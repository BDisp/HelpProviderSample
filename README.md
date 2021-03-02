# HelpProviderSample

## Introduction
This project basically uses the example made available in [HelpProvider Class](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.helpprovider) for the purpose of demonstrating the use of compiled Help files (.chm) or use the same HTML files to display help in the default browser.
To compile in format (.chm) is necessary the software [HTML Help Workshop](https://docs.microsoft.com/en-us/previous-versions/windows/desktop/htmlhelp/microsoft-html-help-downloads) but as it is considered a very old software and so it is discouraged by Microsoft, I only managed to download it [here]( http://www.helpgenerator.com/exes/htmlhelp.exe).

## Getting Started
It is based on 2 projects:
1. **WindowsFormsApp1** which contains the example "HelpProvider Class" above.
- Pressing F1 in each of the fields will open the help file (.chm) with the corresponding topic.
- Pressing F2 opens the help file (.chm) with the main topic.
- Pressing F3 in each of the fields will open the default browser to help page with the corresponding topic.
- Pressing F4 opens the default browser to help page with the main topic.

2. **HelpProviderChmSample** which contains the configuration files of the [HTML Help Workshop](https://docs.microsoft.com/pt-pt/previous-versions/windows/desktop/htmlhelp/microsoft-html-help-1-4-sdk?redirectedfrom=MSDN) as well as the contents of the pages .htm, .css, .js and images that are common to both help modes, with the exception of [main.htm](HelpProviderChmSample/Contents/main.htm) which is only used in help through the browser.

## License
PROVIDED "AS IS" under the [MIT License](LICENSE).
