# Welcome to the repository for my App Launcher for Microsoft Office 2010!
This is the 64-bit version. Read the file "LICENSE" in a text editor for the entire license. The readme continues after this notice.

<code>Drew's MS Office App Launcher (64-bit) - Launch Office Apps Quickly!
Copyright (C) 2013-2015  Drew Naylor
Microsoft Office is copyright Microsoft Corp.
(Note that the copyright years include the years left out by the hyphen.)</code>

<code>This file is part of Drew's MS Office App Launcher (64-bit)
(Program is also known as "Drew's App Launcher")</code>

<code>Drew's App Launcher is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.</code>

<code>If you modify Drew's App Launcher, you must remove branding materials
such as the "D" or "DN" logo from your version and replace it with something
different as well as the actual name of the application to differentiate
it from my original version. See "Drew's Modification Exception" for
the full text, as well as the GPL v3+.</code>

<code>Drew's App Launcher is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.</code>

<code>You should have received a copy of the GNU General Public License
along with Drew's App Launcher.  If not, see <http://www.gnu.org/licenses/>.
If you did not recieve a copy of "Drew's Modification Exception,"
please visit <http://drews-apps.weebly.com/about> Note that these files should be in one file called LICENSE.</code>

## Note that for now I am only getting up-to-speed with GitHub hosting for my applications and will fix bugs and add new features as soon as I get settled in. It may be a while before there is documentation complete on here.

I am not associated with Microsoft in any way, shape, or form. I just thought this application (my App Launcher for Office) would be useful to people. I have checked online for application launchers for Office to see if anyone else had already made one but I didn't find any except for a general-purpose launcher which looked kinda slow to use. Don't get me wrong, it looks nice, it's just not something I would use.

If you want general information about this project, be sure to check the wiki on the right-hand side. It's the button that looks like an open book. Otherwise, keep reading.

--

# Software Required to Edit the Project

- Obviously, you'll need Git. GitHub has GitHub Desktop and Git Shell for Windows. There is one for Mac as well.
- Microsoft Windows. I developed this using Windows 7 but it should work on Windows XP as I originally used XP to develop it. Windows 8/8.1/10 might work but I haven't tested those yet.
- Microsoft Visual Studio 2010 Professional. Again, it should be possible to use the Express edition, but I haven't used that version to develop this in such a long time. I don't know if Visual Studio 2012+ will work. I want it to be able to support XP for as long as possible because Microsoft Office 2010 supports XP. Maybe I will eventually un-support XP. If I do upgrade from VS2010, I would go to VS2013 as it brought back color on some of the icons.
- Microsoft .Net Framework 4.0 (Included with VS 2010.)
- The latest updates for VS 2010.
- Microsoft Office 2010 Professional (or Professional Plus [this app was made for the ProPlus version.]) If you don't have Office or don't want to install Office, you can actually use a collection of dummy files I made called "dummyOffice." They are made up of just a window that says "You have successfully launched the [app] dummy component. Click Ok to continue." I will soon release them but right now I am just getting everything up-to-speed on GitHub. I won't provide an actual installer for the dummy components as I don't want people messing up their installation of Office. Once it's released, only install dummyOffice if you know what you're doing!


# How to get Up and Running with the Files in this Repo


- First, clone the repository by running:    <code>git clone https://github.com/DrewNaylor/MSOfficeAppLauncherNext64.git</code> and remember where the files are saved.
- Next, open Visual Studio 2010.
- When Visual Studio 2010 launches and is ready for input, click <code>File>New Project...</code>.
- In the left sidebar, navigate to <code>Other Project Types\Visual Studio Solutions</code> and click on <code>Blank Solution</code>. 
- Name your solution something in the <code>Name:</code> field, browse for the directory if necessary, and click the <code>OK</code> button.
- After the Solution file is created, click the <code>Save All</code> to save your project.
- Click <code>File>Add>Existing Project...</code> and navigate to where you cloned the repo earlier. Dig all the way down to ~~Bedrock~~ <code>MSOfficeAppLauncherNext64\MSOfficeAppLauncher</code> and open the file called "<code>MSOfficeAppLauncher64.vbproj</code>." 
- If all goes well, the project should appear in the Visual Studio <code>Solution Explorer</code>.


## Why do I need to create a new Solution file? Why can't I just use the original file?

That's a great question. ~~I don't know why.~~ It's because the original Solution file is looking for a file called "<code>MSOfficeAppLauncher.vbproj</code>." You're probably thinking to yourself, "Isn't that the name of the file that I told Visual Studio to open?" You would be correct, except that there's no "64" at the end of the file it's looking for. That's because I develop both the 32-bit and the 64-bit versions in paralell. Because of that, I had to rename the name of the project file itself by right-clicking the name of the project (not the Solution file!) in the Solution Explorer and hitting "Rename." You can also just single-click on the name of the project and rename it that way. Also the 64-bit version is based on the 32-bit version.
