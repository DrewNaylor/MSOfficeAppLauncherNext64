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



Imports Microsoft.VisualBasic
Public Class OptionsWindow64

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles textboxOfficeDrive.KeyPress

        'Only allow user to type capital letters, not lowercase ones or numbers.
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 Then

            'Display a message box when the user presses characters that aren't allowed.
            e.Handled = True
            MessageBox.Show("You can only type capital letters such as A, B, C etc. Click the Clear button to empty the textbox.")

            'Change the textbox for choosing the drive Office is installed on back to drive C.
            textboxOfficeDrive.Text = "C"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles textboxOfficeDrive.TextChanged

    End Sub

    Private Sub buttonResetToDefaults_Click(sender As System.Object, e As System.EventArgs) Handles buttonResetToDefaults.Click

        'Reset the "Drive Selector" textbox to drive C.
        textboxOfficeDrive.Text = "C"
        'Reset the checkboxChangelog to the checked position.
        checkboxChangelog.Checked = True
        'Show a message box informing the user that they need to click the Save button for the changes to take effect.
        MessageBox.Show("Values reset to default. Click the Save button to save changes.")

    End Sub

    Private Sub buttonSaveSettings_Click(sender As System.Object, e As System.EventArgs) Handles buttonSaveSettings.Click

        'Look at the length of the text in the "Drive Selector" textbox and if there is no text in it then kindly tell the
        'user they need to type in one drive letter.
        If textboxOfficeDrive.Text.Length = 0 Then
            MessageBox.Show("You must type in one drive letter.")

            'After telling them that, reset the "Drive Selector" textbox to default.
            textboxOfficeDrive.Text = "C"

        Else

            'This is where to look up the drive for launching the programs.
            My.Settings.officeDriveLocation = textboxOfficeDrive.Text

            'Choose how to display the changelogs.
            If checkboxChangelog.Checked = True Then
                My.Settings.changelogDisplayMode = True
            Else
                My.Settings.changelogDisplayMode = False
            End If

            'Save settings.
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("Settings saved.")
            Me.Close()

        End If
    End Sub

    Private Sub buttonCancel_Click(sender As System.Object, e As System.EventArgs) Handles buttonCancel.Click

        'Cancel out of the Options window and reload the user's settings
        My.Settings.Reload()
        Me.Close()

    End Sub

    'When the Options window loads, pull up the user's settings.
    Private Sub OptionsWindow64_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        textboxOfficeDrive.Text = My.Settings.officeDriveLocation

        checkboxChangelog.Checked = My.Settings.changelogDisplayMode
    End Sub

    Private Sub buttonClearDrive_Click(sender As System.Object, e As System.EventArgs) Handles buttonClearDrive.Click

        'Clear the OfficeDrive textbox.
        textboxOfficeDrive.Text = ""
        textboxOfficeDrive.Select()
    End Sub

    Private Sub checkboxChangelog_Click(sender As Object, e As System.EventArgs) Handles checkboxChangelog.Click
        
    End Sub
End Class