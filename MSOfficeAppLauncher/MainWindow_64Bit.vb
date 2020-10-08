'Drew's MS Office App Launcher (64-bit) - Launch Office Apps Quickly!
'Copyright (C) 2013-2017, 2020  Drew Naylor
'Microsoft Office is copyright Microsoft Corp.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of Drew's MS Office App Launcher (64-bit)
'(Program is also known as "Drew's App Launcher")
'
'Drew's App Launcher is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'If you modify Drew's App Launcher, you must remove branding materials
'such as the "D" or "DN" logo from your version and replace it with something
'different as well as the actual name of the application to differentiate
'it from my original version. See "Drew's Modification Exception 1.1"
'in the file "LICENSE.txt" for the full text, as well as the GPL v3+.
'
'Drew's App Launcher is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with Drew's App Launcher.  If not, see <http://www.gnu.org/licenses/>.
'If you did not recieve a copy of "Drew's Modification Exception 1.1",
'please visit <https://github.com/DrewNaylor/MSOfficeAppLauncherNext64/blob/master/LICENSE.txt>


Public Class Main

    ' Create a string out of the BuildDate file.
    ' Note: In order for the date and time to be updated, you must tell Visual Studio to build the project BEFORE debugging it. In VS2010, you can right-click
    ' on the toolbar at the top of the window and click "Build" to add the Build Toolbar.
    Dim InsertBuildDate As String = My.Resources.BuildDate

    Friend Shared Sub CheckOfficeDriveLocationSettingLengthForSecurity()
        ' We need to make sure there's only one character in the
        ' officeDriveLocation setting for security purposes.
        If Not My.Settings.officeDriveLocation.Length = 1 Then
            My.Settings.officeDriveLocation = "C"
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Make sure My.Settings.officeDriveLocation has only one character in it.
        ' Moved to its own sub for easy re-use.
        CheckOfficeDriveLocationSettingLengthForSecurity()

        ' Put the text in the About box on launch.
        TextBox1.Text = ("Drew's App Launcher for Microsoft Office 2010 ProPlus" & vbCrLf &
        "Version 2.8.1 - Codename ""Last Huzzah""" & vbCrLf &
        "Compiled for 64-bit systems with a 32-bit installation of Office 2010" & vbCrLf &
        "" & vbCrLf &
        "Copyright (C) 2013-2017, 2020 Drew Naylor" & vbCrLf &
        "This app is designed to quickly and easily launch Office 2010 ProPlus software." & vbCrLf &
        "It can also clear up space on your desktop." & vbCrLf &
        "I am not intending on infringing on Microsoft's copyrights, so this is only a shortcut application." & vbCrLf &
        "" & vbCrLf &
        "App compiled at UTC " + InsertBuildDate.ToString &
        "" & vbCrLf &
        "Copyright notice: Office, Microsoft Office, Word, Excel, PowerPoint, and all related words (by MSFT) are Copyright Microsoft Corp. All Rights Reserved for Microsoft's copyrights." & vbCrLf &
        "" & vbCrLf &
        "This application is licensed under the Gnu GPL v3+ and Drew's Modification Exception 1.1." & vbCrLf &
        "" & vbCrLf &
        "------------------------------------------------------" & vbCrLf &
        "" & vbCrLf &
        My.Resources.applauncher_icons_info_TXT.Replace(vbLf, vbCrLf))

        ' Put the text in the Notes box on launch.
        TextBox2.Text = ("--> This app was made for launching the default apps in Microsoft Office 2010 ProPlus. Not all Office 2010 app shortcuts are included." & Environment.NewLine)
        TextBox2.AppendText("" & Environment.NewLine)
        TextBox2.AppendText("--> Unless there are major issues in the future, 2.8.1 is the last official update to the 2.x branch. Please use UXL Launcher (3.x) instead if you can. UXL Launcher page: https://github.com/DrewNaylor/UXL-Launcher" & Environment.NewLine)
        TextBox2.AppendText("" & Environment.NewLine)
        TextBox2.AppendText("--> If you didn't get a copy of the GPL v3 and Drew's Modification Exception 1.1 in the download, you can grab a copy of it from the link below which says, ""Visit the GitHub Repo..."" Scroll down on that page and open the file that's called LICENSE.")
    End Sub

#Region "Applications to launch."

    ' Catch-all error handler and launcher.
    Private Sub LaunchApp(ExeToLaunch As String, ExeFriendlyName As String)
        ' Make sure the saved setting isn't something other than a drive letter.
        ' We have to do this here as it's possible to modify the config file while
        ' the Options window is open and close it with the Cancel button.
        ' What happens then is the modified config file is loaded, which
        ' could have something other than a drive letter in it.
        CheckOfficeDriveLocationSettingLengthForSecurity()

        ' Do a try...catch like 3.x so there's a nice error message if it goes wrong.
        Try
            Process.Start(My.Settings.officeDriveLocation.ToString & ":\Program Files (x86)\Microsoft Office\Office14\" & ExeToLaunch.ToString)
        Catch ex As Exception
            ' If we can't find the program, let the user know.
            MessageBox.Show("We couldn't find " & ExeFriendlyName.ToString & " in " & """" & My.Settings.officeDriveLocation.ToString & ":\Program Files (x86)\Microsoft Office\Office14\""." &
                            " Please change your drive letter in the Options window, use Drew's App Launcher 32-bit Edition, or upgrade to UXL Launcher (if you can) instead.", "Couldn't find " & ExeFriendlyName,
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Microsoft Access
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        LaunchApp("MSACCESS.EXE", Button1.Text.ToString)
    End Sub

    ' Excel
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        LaunchApp("EXCEL.EXE", Button2.Text.ToString)
    End Sub

    ' Infopath
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        LaunchApp("INFOPATH.EXE", Button3.Text.ToString)
    End Sub

    ' OneNote
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        LaunchApp("ONENOTE.EXE", Button4.Text.ToString)
    End Sub

    ' Outlook
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        LaunchApp("OUTLOOK.EXE", Button5.Text.ToString)
    End Sub

    ' Powerpoint
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        LaunchApp("POWERPNT.EXE", Button6.Text.ToString)
    End Sub

    ' SharePoint
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        LaunchApp("GROOVE.EXE", Button8.Text.ToString)
    End Sub

    ' Microsoft Publisher
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        LaunchApp("MSPUB.EXE", Button7.Text.ToString)
    End Sub

    ' Microsoft Word
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        LaunchApp("WINWORD.EXE", Button9.Text.ToString)
    End Sub

    ' Microsoft Query
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        LaunchApp("MSQRY32.EXE", Button10.Text.ToString)
    End Sub

    ' Clip Organizer
    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        LaunchApp("MSTORE.EXE", Button11.Text.ToString)
    End Sub

    ' Office Picture Manager
    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        LaunchApp("OIS.EXE", Button12.Text.ToString)
    End Sub

    ' OneNote Quick Launch
    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        LaunchApp("ONENOTEM.EXE", Button13.Text.ToString)
    End Sub

    ' Open the Language Settings.
    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        LaunchApp("SETLANG.EXE", Button14.Text.ToString)
    End Sub
#End Region

    ' Open the version history - 32-bit
    Private Sub ThreeTwoBitHist_Click(sender As System.Object, e As System.EventArgs) Handles ThreeTwoBitHist.Click
        If My.Settings.deprecatedChangelogDisplayMode = False Then
            Process.Start("https://github.com/DrewNaylor/MSOfficeAppLauncherNext32/releases")
        Else
            HTML32BitVerHist.ShowDialog()
        End If

    End Sub

    ' Open the version history - 64-bit
    Private Sub SixFourVerHistButton_Click(sender As System.Object, e As System.EventArgs) Handles SixFourVerHistButton.Click
        If My.Settings.deprecatedChangelogDisplayMode = False Then
            Process.Start("https://github.com/DrewNaylor/MSOfficeAppLauncherNext64/releases")
        Else
            HTML64BitVerHist.ShowDialog()
        End If
    End Sub

    ' Open the Options window.
    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        OptionsWindow64.ShowDialog()
    End Sub

    ' Open my main website.
    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://drew-naylor.com/")
    End Sub

    ' Open my application website.
    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://www.github.com/DrewNaylor")
    End Sub

    ' This button takes the user to my wiki page with the old 64-bit changelog.
    Private Sub buttonReadOld64bitChangelogs_Click(sender As System.Object, e As System.EventArgs) Handles buttonReadOld64bitChangelogs.Click
        Process.Start("https://github.com/DrewNaylor/MSOfficeAppLauncherNext64/wiki/Old-64-Bit-Changelog")
    End Sub

    ' Open the GitHub repository for this application.
    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://github.com/DrewNaylor/MSOfficeAppLauncherNext64/")
    End Sub


End Class
