Git-History-AddIn
=================

Visual Studio Add-In that pulls version history from GitHub and displays it in GitHub-style (contribution graph). Graph gets updated whenever you open a source code file.

As of today, you can bind GitHub project only.

# Install

1. Build project, close Visual Studio
2. Copy files from bin/Debug to c:\Users\YourUsername\Documents\Visual Studio 2012\Addins\ folder
3. Start Visual Studio
4. Tools - Add-in Manager ... -> check "Git History Add-In" (check "Startup" as well)
5. Restart Visual Studio
6. If "Git History" window is not visible, you can right-click on any source file and select "Git History" menu item.

![Contribution Graph](https://raw.githubusercontent.com/akos-sereg/Git-History-AddIn/master/GitHistoryAddIn/Docs/Screenshot.png "Screenshot")
