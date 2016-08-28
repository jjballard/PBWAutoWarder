Imports System.Net
Imports System.Data.SQLite
Imports System.Security.Cryptography

Public Class Form1

    Private PBWID As String
    Private Chars As New Dictionary(Of String, String)
    Private Boards As New Dictionary(Of String, String)
    Private Posts As New Dictionary(Of String, String)

    Private Sub butWard_Click(sender As Object, e As EventArgs) Handles butWard.Click

        Dim postData As String = String.Empty
        Dim postID As String = String.Empty

        If lstPostIDs.SelectedItems.Count = 1 Then
            postID = lstPostIDs.SelectedItem.ToString()
            postData = replacePostData(postID)
            SubmitForm(postData)

        ElseIf lstPostIDs.SelectedItems.Count = 0 Then
            For i = 0 To lstPostIDs.Items.Count - 1
                postID = lstPostIDs.Items(i).ToString()
                postData = replacePostData(postID)
                SubmitForm(postData)
            Next

        ElseIf lstPostIDs.SelectedItems.Count > 1 Then
            For i = 0 To lstPostIDs.SelectedItems.Count - 1
                postID = lstPostIDs.SelectedItems(i).ToString()
                postData = replacePostData(postID)
                SubmitForm(postData)
            Next

        End If
        RefreshPostIDs()

    End Sub

    Private Function replacePostData(postID As String) As String
        Dim boardID As String = txtBoardID.Text
        Dim charID As String = txtCharID.Text
        Dim titleText As String = txtTitle.Text
        Dim bodyText As String = txtBody.Text
        Dim postData As String = String.Empty

        Dim postDataGeneric As String =
            "_b=BOARDID&_h=generic2.php&_p=POSTID&_n=99&_i=80&_g=44149&_e=er&_php=postreply.php&_title=TITLETEXT&_c=CHARID&_text=BODYTEXT&edit2request=" +
            "Array%0D%0A%28%0D%0A++++%5B_b%5D+%3D%3E+BOARDID%0D%0A++++%5B_h%5D+%3D%3E+generic2.php%0D%0A++++%5B_p%5D+%3D%3E+POSTID%0D%0A++++%5B_n%5D+%3D%3E+" +
            "99%0D%0A++++%5B_i%5D+%3D%3E+80%0D%0A++++%5B_g%5D+%3D%3E+44149%0D%0A++++%5B_e%5D+%3D%3E+er%0D%0A++++%5B_php%5D+%3D%3E+postreply.php%0D%0A++++%5B" +
            "edit1request%5D+%3D%3E+Array%28++++%5B_b%5D+%3D%3E+BOARDID++++%5B_h%5D+%3D%3E+generic2.php++++%5B_p%5D+%3D%3E+113086++++%5B_n%5D+%3D%3E+99++++%5B_i%5D" +
            "+%3D%3E+80++++%5B_g%5D+%3D%3E+44149++++%5B_e%5D+%3D%3E+er++++%5B_php%5D+%3D%3E+postreply.php++++%5BAC%5D+%3D%3E+3798559++++%5Barp_scroll_position%5D+" +
            "%3D%3E+6607%29%0D%0A++++%5Bedit1url%5D+%3D%3E+%3CTD+NOWRAP%3E%3CA+TARGET%3D_blank+HREF%3Ddice1.php%3F_b%3DBOARDID%26_h%3Dgeneric2.php%26_p%3D113086%26_n%3D99%26" +
            "_i%3D80%26_g%3D44149%26_e%3Der%26_php%3Dpostreply.php%3E%3CBIG%3EDice%3C%2FBIG%3E%3C%2FA%3E%3CBR%3E%3CBR%3E%3CBIG%3EPlayers%3C%2FBIG%3E%3CBR%3E%A0%A0%A0%A0%3C" +
            "INPUT+TYPE%3DRADIO+NAME%3D_c+VALUE%3D133861+%3E%3CA+TARGET%3D_blank+HREF%3Dchar_ed1.php%3F_b%3DBOARDID%26_h%3Dgeneric2.php%26_p%3D113086%26_n%3D99%26_i%3D80%26_g" +
            "%3D44149%26_e%3Der%26_php%3Dpostreply.php%26_c%3D133861%26_u%3D559%3ETalisman%3C%2FA%3E+%3CBR%3E%3CBIG%3ETogether%3C%2FBIG%3E%3CBR%3E%A0%A0%A0%A0%3CINPUT+TYPE%3DRADIO" +
            "+NAME%3D_c+VALUE%3D133861+%3E%3CA+TARGET%3D_blank+HREF%3Dchar_ed1.php%3F_b%3DBOARDID%26_h%3Dgeneric2.php%26_p%3D113086%26_n%3D99%26_i%3D80%26_g%3D44149%26" +
            "_e%3Der%26_php%3Dpostreply.php%26_c%3D133861%26_u%3D559%3ETalisman%3C%2FA%3E+%3CBR%3E%3CBIG%3EPlayers%3C%2FBIG%3E%3CBR%3E%A0%A0%A0%A0%3C" +
            "INPUT+TYPE%3DRADIO+NAME%3D_c+VALUE%3DCHARID+%3E%3CA+TARGET%3D_blank+HREF%3Dchar_ed1.php%3F_b%3DBOARDID%26_h%3Dgeneric2.php%26_p%3D113086%26_n%3D99%26_i%3D80%26" +
            "_g%3D44149%26_e%3Der%26_php%3Dpostreply.php%26_c%3DCHARID%26_u%3D559%3EJer+Stanton%3C%2FA%3E+%3CBR%3E%3CBIG%3EPrivate%3C%2FBIG%3E%3CBR%3E%A0%A0%A0%A0%3C" +
            "INPUT+TYPE%3DRADIO+NAME%3D_c+VALUE%3DCHARID+%3E%3CA+TARGET%3D_blank+HREF%3Dchar_ed1.php%3F_b%3DBOARDID%26_h%3Dgeneric2.php%26_p%3D113086%26_n%3D99%26_i%3D80%26" +
            "_g%3D44149%26_e%3Der%26_php%3Dpostreply.php%26_c%3DCHARID%26_u%3D559%3EJer+Stanton%3C%2FA%3E+%3CBR%3E%3CBIG%3ETogether%3C%2FBIG%3E%3CBR%3E%A0%A0%A0%A0%3C" +
            "INPUT+TYPE%3DRADIO+NAME%3D_c+VALUE%3DCHARID+%3E%3CA+TARGET%3D_blank+HREF%3Dchar_ed1.php%3F_b%3DBOARDID%26_h%3Dgeneric2.php%26_p%3D113086%26_n%3D99%26_i%3D80%26" +
            "_g%3D44149%26_e%3Der%26_php%3Dpostreply.php%26_c%3DCHARID%26_u%3D559%3EJer+Stanton%3C%2FA%3E+%3CBR%3E%3C%2FTD%3E%0D%0A++++%5B_title%5D+%3D%3E+TITLETEXT" +
            "%0D%0A++++%5Bbutton%5D+%3D%3E+Preview+%3E%0D%0A++++%5B_c%5D+%3D%3E+CHARID%0D%0A++++%5B_text%5D+%3D%3E+BODYTEXT%0D%0A++++%5BAC%5D+%3D%3E+3798559%0D%0A" +
            "++++%5Barp_scroll_position%5D+%3D%3E+1200%0D%0A%29%0D%0A&button=Post+%3E"

        postData = postDataGeneric
        postData = postData.Replace("BOARDID", boardID)
        postData = postData.Replace("CHARID", charID)
        postData = postData.Replace("TITLETEXT", titleText)
        postData = postData.Replace("BODYTEXT", bodyText)
        postData = postData.Replace("POSTID", postID)
        Return postData
    End Function

    Private Sub SubmitForm(postData As String)
        Dim request As WebRequest = WebRequest.Create("http://www.playbyweb.com/postreply.php")

        If Not PBWID = String.Empty Then
            request.Headers.Add(HttpRequestHeader.Cookie, String.Format("AC={0}", PBWID))
        Else
            request.Headers.Add(HttpRequestHeader.Cookie, String.Format("AC=3798559"))
        End If

        request.Method = "POST"

        Dim byteArray As Byte()
        byteArray = System.Text.Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Dim dataStream As System.IO.Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

    End Sub

    Private Sub btnGetPosts_Click(sender As Object, e As EventArgs) Handles btnGetPosts.Click
        RefreshPostIDs()

    End Sub

    Private Sub RefreshPostIDs()
        If Not txtBoardID.Text = "" Then
            Dim boardURL As String = String.Format("http://www.playbyweb.com/generic2.php?_b={0}", txtBoardID.Text)
            Dim request As WebRequest = WebRequest.Create(boardURL)
            request.Method = "GET"
            Dim dataStream As System.IO.Stream ' = request.GetRequestStream
            Dim response As WebResponse
            response = request.GetResponse()
            Dim strPostId As String = ""


            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            dataStream = response.GetResponseStream()

            Dim reader As New System.IO.StreamReader(dataStream)
            Dim responseFromServer As String = ""
            lstPostIDs.Items.Clear()

            While Not reader.EndOfStream
                responseFromServer = reader.ReadLine()
                If responseFromServer.Contains(" i (Reap in") Then
                    strPostId = responseFromServer.Substring(responseFromServer.IndexOf("_p="), 9).Substring(3, 6)
                    'Console.WriteLine(strPostId)
                    lstPostIDs.Items.Add(strPostId)

                End If
            End While

            'Console.WriteLine(responseFromServer)
            reader.Close()
            response.Close()

        End If
    End Sub

    Private Sub pbwAutoWarder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PBWID = ""
        PBWID = getCookie_Chrome()
        If PBWID = "" Then PBWID = getCookie_Firefox()
        If Not PBWID = "" Then
            ' getChars(PBWID)
            getBoards(PBWID)
        End If
        If txtBoardID.TextLength > 0 Then RefreshPostIDs()

    End Sub

    Private Sub getBoards(PBWID As String)
        Boards.Clear()
        ' ignore board 12518 (Staff Room)
        Dim URL As String = "http://www.playbyweb.com/index.php"
        Dim request As WebRequest = WebRequest.Create(URL)
        request.Method = "GET"
        Dim dataStream As System.IO.Stream ' = request.GetRequestStream
        Dim response As WebResponse = request.GetResponse()
        Dim strBoardID As String = ""
        Dim strBoardName As String = ""

        If Not PBWID = String.Empty Then
            request.Headers.Add(HttpRequestHeader.Cookie, String.Format("AC={0}", PBWID))
        Else
            request.Headers.Add(HttpRequestHeader.Cookie, String.Format("AC="))
        End If

        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        dataStream = response.GetResponseStream()

        Dim reader As New System.IO.StreamReader(dataStream)
        Dim responseFromServer As String = ""
        lstPostIDs.Items.Clear()

        While Not reader.EndOfStream
            responseFromServer = reader.ReadLine()
            If responseFromServer.Contains("_b=") Then
                strBoardID = responseFromServer.Substring(responseFromServer.IndexOf("_b="), 9).Substring(3, 5)



            End If
        End While

        'Console.WriteLine(responseFromServer)
        reader.Close()


    End Sub

    Private Sub getChars(pBWID As String)
        Chars.Clear()
    End Sub

    Private Function getCookie_Firefox() As String
        Dim strPath As String = String.Empty
        Dim strDb As String = String.Empty
        Dim strTemp As String = String.Empty
        strPath = GetFirefoxCookiePath()
        Dim strReturn As String = String.Empty

        If strPath = String.Empty Then
            Return String.Empty
        End If
        Try
            strTemp = strPath + ".temp"
            strDb = "Data Source=" + strTemp + ";pooling=false"
            System.IO.File.Copy(strPath, strTemp, True)

            Dim sqlcon As New SQLiteConnection(strDb)
            Dim cmd As SQLiteCommand = sqlcon.CreateCommand()
            cmd.CommandText = "SELECT value FROM moz_cookies WHERE host LIKE '%playbyweb.com%' AND name LIKE '%AC%';"
            sqlcon.Open()
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()
            While reader.Read()
                strReturn = reader.GetString(0)
                If Not strReturn.Equals(String.Empty) Then
                    Exit While
                End If
            End While
            Return strReturn

        Catch ex As Exception
            Return String.Empty
        End Try

        Return strReturn
    End Function

    Private Function GetFirefoxCookiePath() As String
        Dim path As String = ""
        path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        path += "\Mozilla\Firefox\Profiles\"
        Try
            Dim dinfo As New System.IO.DirectoryInfo(path)
            Dim dir As System.IO.DirectoryInfo() = dinfo.GetDirectories("*.default*")

            If Not dir.Length = 1 Then
                Return String.Empty
            End If

            path += dir(0).Name + "\cookies.sqlite"
        Catch ex As Exception
            Return String.Empty
        End Try

        If Not System.IO.File.Exists(path) Then
            Return String.Empty
        Else
            Return path
        End If

    End Function

    Private Function getCookie_Chrome() As String
        Dim strPath As String = ""
        Dim strDb As String = ""
        strPath = GetChromeCookiePath()
        Dim strReturn As String = ""

        If strPath = String.Empty Then
            Return ""
        End If

        Dim strTemp As String = strPath + ".temp"
        If System.IO.File.Exists(strTemp) Then System.IO.File.Delete(strTemp)
        System.IO.File.Copy(strPath, strTemp)
        Try

            strDb = String.Format("Data source={0};Version\=3;Pooling=true", strTemp)
            'strDb = "Data source=:memory:;Version=3;Pooling=true;"
            Dim sqlcon As New SQLiteConnection(strDb)
            Dim cmd As SQLiteCommand = sqlcon.CreateCommand()
            cmd.CommandText = "SELECT name,encrypted_value FROM cookies WHERE host_key LIKE '%playbyweb.com%';"
            sqlcon.Open()
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()
            While reader.Read()
                strReturn = reader.GetString(1)
                If Not strReturn.Equals(String.Empty) Then
                    Dim encryptedvalue() As Byte = System.Text.Encoding.ASCII.GetBytes(strReturn)

                    Dim decryptedValue() As Byte = ProtectedData.Unprotect(encryptedvalue, Nothing, DataProtectionScope.CurrentUser)
                    strReturn = System.Text.Encoding.ASCII.GetString(decryptedValue)
                End If
            End While
            sqlcon.Close()
            If System.IO.File.Exists(strTemp) Then System.IO.File.Delete(strTemp)
            Return strReturn

        Catch ex As Exception
            Return String.Empty
        End Try


    End Function

    Private Function GetChromeCookiePath() As String
        Dim path As String = ""
        path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        path += "\Google\Chrome\User Data\Default\cookies"

        If Not System.IO.File.Exists(path) Then
            Return String.Empty
        Else
            Return path
        End If
    End Function
End Class
