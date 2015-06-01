Imports System.Security.Cryptography
Imports Mindscape.LightSpeed.Querying
Imports Mindscape.LightSpeed
Imports Mindscape.LightSpeed.Linq
Imports dvdresources
Imports LDModels.LDModels

Public Class RNG

    Private LSConnRNG As New LightSpeedContext

    Private Sub LoadConnectionRNG()
        With LSConnRNG
            .ConnectionString = "Server=localhost;User Id=rdmsdb;database=DBDat;password=rdms123;Persist Security Info=True"
            .IdentityMethod = IdentityMethod.IdentityColumn
            .DataProvider = DataProvider.SqlServer2008
            .QuoteIdentifiers = True
        End With
    End Sub

    Private myNum
    Private myOutput
    Private TripleDes As New TripleDESCryptoServiceProvider

    Sub New(ByVal key)
        ' Initialize the crypto provider.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        myNum = key
    End Sub

    Public Function GenerateRNG()
        Try
            myOutput = Math.Sqrt(myNum)
            Return myOutput
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GeneratePKMFromList(ByVal hashname As Integer, ByVal counter As Integer) As IList(Of StrucMonsters)
        Using uow = LSConnRNG.CreateUnitOfWork
            Try
                LoadConnectionRNG()
                Dim ilistMon As New List(Of StrucMonsters)

                Dim q As New Query
                q.QueryExpression = Entity.Attribute(TblMon.PkmClassField) < 6
                'q.Order = Order.By(Entity.Attribute(TblMon.PkmClassField)).Descending
                listPkm = uow.Find(Of TblMon)(q).Take(counter).ToList

                If listPkm.Count > 0 Then
                    For i = 0 To listPkm.Count - 1
                        Dim objMon As New StrucMonsters
                        objMon.monName = listPkm(i).PkmName
                        objMon.monType = listPkm(i).PkmType
                        objMon.monClass = listPkm(i).PkmClass

                        ilistMon.Add(objMon)
                    Next
                    Return ilistMon
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                MsgBox(Err.Description)
                Return Nothing
            End Try
        End Using
    End Function

    Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key. 
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash. 
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Public Function EncryptData(
    ByVal plaintext As String) As String

        ' Convert the plaintext string to a byte array. 
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream. 
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string. 
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function DecryptData(
    ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array. 
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream. 
        Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string. 
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function

    Property listPkm As List(Of TblMon)


End Class

Public Class StrucMonsters
    Property monName As String
    Property monType As String
    Property monClass As Integer
End Class
