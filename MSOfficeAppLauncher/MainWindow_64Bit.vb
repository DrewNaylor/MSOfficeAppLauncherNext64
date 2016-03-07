'Drew's MS Office App Launcher (64-bit) - Launch Office Apps Quickly!
'Copyright (C) 2013-2016  Drew Naylor
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
'it from my original version. See "Drew's Modification Exception" for
'the full text, as well as the GPL v3+.
'
'Drew's App Launcher is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with Drew's App Launcher.  If not, see <http://www.gnu.org/licenses/>.
'If you did not recieve a copy of "Drew's Modification Exception,"
'please visit <http://drews-apps.weebly.com/about>


Public Class Main

    'Open the Options window using the secret button.
    'Private Sub zSecretOptionsButton_Click(sender As System.Object, e As System.EventArgs) Handles zSecretOptionsButton.Click
    '   OptionsWindow64.ShowDialog()
    'End Sub

    'This code is used to work around label text being copied to the clipboard when the user double-clicks on the zSecretOptionsButton label.
    'Comment out "zSecretOptionsButton.Hide()" code below and uncomment the code block above to use the secret button located below the "General Options" button.

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        zSecretOptionsButton.Hide()
    End Sub

#Region "Applications to launch."


    'Microsoft Access
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\MSACCESS.EXE")
    End Sub

    'Excel
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\EXCEL.EXE")
    End Sub

    'Infopath
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\INFOPATH.EXE")
    End Sub

    'OneNote
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\ONENOTE.EXE")
    End Sub

    'Outlook
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\OUTLOOK.EXE")
    End Sub

    'Powerpoint
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\POWERPNT.EXE")
    End Sub

    'SharePoint
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\GROOVE.EXE")
    End Sub

    'Microsoft Publisher
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\MSPUB.EXE")
    End Sub

    'Microsoft Word
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\WINWORD.EXE")
    End Sub

    'Microsoft Query
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\MSQRY32.EXE")
    End Sub

    'Clip Organizer
    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\MSTORE.EXE")
    End Sub

    'Office Picture Manager
    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\OIS.EXE")
    End Sub

    'OneNote Quick Launch
    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\ONENOTEM.EXE")
    End Sub

    'Open the Language Settings.
    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Shell(My.Settings.officeDriveLocation + ":\Program Files (x86)\Microsoft Office\Office14\SETLANG.EXE")
    End Sub
#End Region


    'Open the version history - 32-bit
    Private Sub ThreeTwoBitHist_Click(sender As System.Object, e As System.EventArgs) Handles ThreeTwoBitHist.Click
        If My.Settings.changelogDisplayMode = True Then
            Process.Start("http://drews-apps.weebly.com/3/feed")
        Else
            HTML32BitVerHist.ShowDialog()
        End If

    End Sub

    'Open the version history - 64-bit
    Private Sub SixFourVerHistButton_Click(sender As System.Object, e As System.EventArgs) Handles SixFourVerHistButton.Click
        If My.Settings.changelogDisplayMode = True Then
            Process.Start("http://drews-apps.weebly.com/2/feed")
        Else
            HTML64BitVerHist.ShowDialog()
        End If
    End Sub

    'Open the Options window.
    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        OptionsWindow64.ShowDialog()
    End Sub

    'Open my main website.
    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.drewnayloremulation.weebly.com/")
    End Sub

    'Open my application website.
    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://www.drews-apps.weebly.com")
    End Sub


End Class
