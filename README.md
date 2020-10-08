# Notice of Deprecation
**Important:** Drew's App Launcher is no longer officially supported after version 2.8.x. Visit the [UXL Launcher repository](https://github.com/DrewNaylor/UXL-Launcher) for the new version of the application launcher. Do note that Windows XP and Windows Vista are only officially supported with Drew's App Launcher version 2.8.x and below. UXL Launcher will not work on those operating system versions officially.

# Welcome to the repository for my App Launcher for Microsoft Office 2010!
This is the 64-bit version. Read the file "LICENSE" in a text editor for the entire license. The readme continues after this notice.

Icons are provided by the [applauncher-icons project](https://github.com/DrewNaylor/applauncher-icons).

```vbnet
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
'please visit <https://github.com/DrewNaylor/MSOfficeAppLauncherNext32/blob/master/LICENSE.txt>
```

applauncher-icons info:
```text
applauncher-icons
By Drew Naylor. Licensed under CC BY 4.0.
Version 3.0

The applauncher-icons project provides most of the icons used in Drew's App Launcher,
with the exception of some icons. These include, but are not limited to, the
Drew's App Launcher logo.

Link to applauncher-icons project repository:
https://github.com/DrewNaylor/applauncher-icons

Link to applauncher-icons version 3.0 GitHub Releases page:
https://github.com/DrewNaylor/applauncher-icons/releases/tag/v3.0

No warranty is provided with applauncher-icons. Use at your own risk. Drew Naylor is not responsible
for any problems that use of applauncher-icons may cause.
This work is licensed under the Creative Commons Attribution 4.0 International License.
To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

Microsoft is not associated with either the applauncher-icons project or Drew Naylor and does not
condone this project.
```

**Note that for now I am only getting up-to-speed with GitHub hosting for my applications and will fix bugs and add new features as soon as I get settled in. It may be a while before there is documentation complete on here.**

I am not associated with Microsoft in any way, shape, or form. I just thought this application (my App Launcher for Office) would be useful to people. I have checked online for application launchers for Office to see if anyone else had already made one but I didn't find any except for a general-purpose launcher which looked kinda slow to use. Don't get me wrong, it looks nice, it's just not something I would use.

If you want general information about this project, be sure to check the wiki at the top of this page. It's the button that looks like an open book to the right of the "Pull Requests" tab. Otherwise, keep reading.

---

# Minimum Recommended Specifications
The following specifications are the lowest that I recommended to run this software.

- .Net 4 Client Profile: http://www.microsoft.com/en-us/download/details.aspx?id=24872
Ignore the Windows 10 message on that page, scroll down, and click the orange Download button. May take a while to download.

- Windows versions: Windows XP SP3, Vista SP1 or later, Windows 7 and 7 SP1, 8, 8.1, 10.

- Architectures: x86 (32-bit) and x64 (64-bit.)

- Hardware requirements: At least a 1.2 GHz, Pentium 4 CPU or higher; 1 GB of RAM or more.

- Disk space:

  - 32-bit: 700 MB space free.
  - 64-bit: 2 GB space free.

- To properly view the RSS/Atom release feeds, you'll need Firefox or Internet Explorer.

- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in version 2.8 due to Visual Studio not building properly suddenly. They are enabled in versions 2.7 and 2.6.1.

- Also note that I've never used this software on Vista, although it should work just fine.

---

# Software Required to Edit the Project

- Obviously, you'll need Git. GitHub has GitHub Desktop and Git Shell for Windows. There is one for Mac as well.
- Microsoft Windows. I developed this using Windows 7 but it should work on Windows XP as I originally used XP to develop it. Windows 8/8.1/10 might work but I haven't tested those yet.
- Microsoft Visual Studio 2010 Professional. Again, it should be possible to use the Express edition, but I haven't used that version to develop this in such a long time. I don't know if Visual Studio 2012+ will work. I want it to be able to support XP for as long as possible because Microsoft Office 2010 supports XP. Maybe I will eventually un-support XP. If I do upgrade from VS2010, I would go to VS2013 as it brought back color on some of the icons.
- Microsoft .Net Framework 4.0 (Included with VS 2010.)
- The latest updates for VS 2010.
- Microsoft Office 2010 Professional (or Professional Plus [this app was made for the ProPlus version.]) If you don't have Office or don't want to install Office, you can actually use a collection of dummy files I made called "dummyOffice." They are made up of just a window that says "You have successfully launched the [app] dummy component. Click Ok to continue." I will soon release them but right now I am just getting everything up-to-speed on GitHub. I won't provide an actual installer for the dummy components as I don't want people messing up their installation of Office. Once it's released, only install dummyOffice if you know what you're doing!
- Windows PowerShell. I set up a pre-build event which uses PowerShell to write the current date out to a text document. Note that if you're building from source code available before August 2, 2016, PowerShell is not required.

---

# How to Compile the Project Yourself

In order to compile this project yourself, follow these steps:

1. First, open Explorer and navigate to <code>C:\Windows\Microsoft.NET\Framework\v4.0.30319</code> or <code>C:\Windows\Microsoft.NET\Framework64\v4.0.30319</code> on a 64-bit installation of Windows.
2. Next, open your command prompt and drag the <code>MSBuild.exe</code> file into the prompt. You can also create a shortcut to <code>MSBuild.exe</code> and place it on your desktop for easy access.
3. Third, after dragging <code>MSBuild.exe</code> into the Command Prompt, navigate to where you placed the source code for this project and find the <code>VBProj</code> file. It should be under <code>MSOfficeAppLauncher64-master\MSOfficeAppLauncher\MSOfficeAppLauncher64.vbproj</code>. Note that the filename and location may differ slightly based on which "Edition" of the app launcher code you download.
4. Fourth, insert a space after the <code>MSBuild.exe</code> line inside your Command Prompt, then drag that <code>VBProj</code> file we found earlier into the Command Prompt.
5. And finally, press the <code>Enter</code> or <code>Return</code> key on your keyboard to build the project! After it's complete, you'll find your compiled files in <code>MSOfficeAppLauncher\bin\Debug</code>. Simply double-click the file that says <code>MSOfficeAppLauncher64.exe</code> found within that folder and it will run. If you have trouble, please create a GitHub Issue pertaining to what you're having trouble with and either myself or someone else will assist when they get the chance.

---

# How to get Up and Running with the Files in this Repo


1. First, clone the repository by running:    <code>git clone https://github.com/DrewNaylor/MSOfficeAppLauncherNext64.git</code> and remember where the files are saved.
2. Next, open Visual Studio 2010.
3. When Visual Studio 2010 launches and is ready for input, click <code>File>New Project...</code>.
4. In the left sidebar, navigate to <code>Other Project Types\Visual Studio Solutions</code> and click on <code>Blank Solution</code>. 
5. Name your solution something in the <code>Name:</code> field, browse for the directory if necessary, and click the <code>OK</code> button. For example, I named mine "AppLauncherStudio."
6. After the Solution file is created, click the <code>Save All</code> button to save your project.
7. Click <code>File>Add>Existing Project...</code> and navigate to where you cloned the repo earlier. Dig all the way down to ~~Bedrock~~ <code>MSOfficeAppLauncherNext64\MSOfficeAppLauncher</code> and open the file called "<code>MSOfficeAppLauncher64.vbproj</code>." 
8. If all goes well, the project should appear in the Visual Studio <code>Solution Explorer</code>.
 
You'll be using this Solution file you just made to open the project. See the next paragraph for details.

## Why do I need to create a new Solution file? Why can't I just use the original file?

That's a great question. ~~I don't know why.~~ It's because the original Solution file is looking for a file called "<code>MSOfficeAppLauncher.vbproj</code>." You're probably thinking to yourself, "Isn't that the name of the file that I told Visual Studio to open?" You would be correct, except that there's no "64" at the end of the file it's looking for. That's because I develop both the 32-bit and the 64-bit versions in paralell. Because of that, I had to rename the name of the project file itself by right-clicking the name of the project (not the Solution file!) in the Solution Explorer and hitting "Rename." You can also just single-click on the name of the project and rename it that way. Also the 64-bit version is based on the 32-bit version.
