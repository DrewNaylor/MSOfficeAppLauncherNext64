'Drew's MS Office App Launcher (64-bit) - Launch Office Apps Quickly!
'Copyright (C) 2013-2017, 2020  Drew Naylor
'Microsoft Office is copyright Microsoft Corp.
'Microsoft is not associated with and does not condone this project.
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


Imports System.Windows.Forms

Public Class HTML64BitVerHist

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
