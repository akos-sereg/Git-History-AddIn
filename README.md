Git-History-AddIn
=================

Visual Studio Add-In that pulls version history from GitHub and displays it in GitHub-style (contribution graph). Graph gets updated whenever you open a source code file.

As of today, you can bind GitHub project only.

# Install

1. Restore NuGet packages: right click on solution, "Manage NuGet Packages ...", then click Restore on the top of the window
2. Build project, close Visual Studio
3. Copy files from bin/Debug to c:\Users\YourUsername\Documents\Visual Studio 2012\Addins\ folder
4. Start Visual Studio
5. Tools - Add-in Manager ... -> check "Git History Add-In" (check "Startup" as well)
6. Restart Visual Studio
7. If "Git History" window is not visible, you can right-click on any source file and select "Git History" menu item.

![Contribution Graph](https://raw.githubusercontent.com/akos-sereg/Git-History-AddIn/master/GitHistoryAddIn/Docs/Screenshot.png "Screenshot")

# Usage

If you have installed the Add-In successfully, you should see "Git History" menu item at the bottom of the context menu when right clicking on a Project, Folder, or any file in your solution. After clicking on this menu item, Git History window should pop up.
