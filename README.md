
# NET MAUI SAMPLE ***NOTES*** APP

An *Extremely Simple* implentation of .NET MAUI Sample "Create an .NET MAUI App"

- THIS REPO IS PART OF LEARNING ENVIRONMENT. NO GAURANTEE, OF ANY KIND IS MADE OR IMPLIED. 

- [Microsoft Leaning Tutorial](https://learn.microsoft.com/en-us/training/modules/create-user-interface-xaml/)

- [For Community Toolkit documentation ](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/)

## Release Notes

- Create App Tutorial and Implementation of MVVM complete 

- Styling changes, looks funky on iOS, MAC and Windows, but the demo works =)

- Reaolved Android theme conflict with Navigate Up button not being visible
    - confusion may start with the folliowing 2 basic issues 
        - NotePage.xaml provides custom styling for the Add note button in ContentPage.Toolbar 
        - the Navigate Up button is not actually on a Toolbar, not on the Navigation or Tab pages
    - fix 
        - Navigate Up is provided only at runtime as part of AppShell
        - using Shell section of Resources/Styles.xaml
        - Playing with the styling of Shell items, reveales what color is applied to the Navigate Up button 
        - since Shell.Background Color was Primary (Blue), needed to change foreground color, used for Navigate up from Primary (Blue) to someother color

- Questions, after working with this code for a bit,
    - 1st, Custom navigate up button ?
        - I tried creating my own Navigate Up button, 
        - it's not actually that hard, you still have to bind it to AppShell, to get placed in the desired location
    - 2nd, is there a way to style AppShell's Navigate button directly
        - after making my own, I still had AppShell's Navigate Up button, 
        - whether I wanted it or not
    - 3rd, what's is best practice, in this case?

# Legal Notices

Microsoft and any contributors grant you a license to the Microsoft documentation and other content
in this repository under the [Creative Commons Attribution 4.0 International Public License](https://creativecommons.org/licenses/by/4.0/legalcode),see the [LICENSE](LICENSE) file, and grant you a license to any code in the repository under the [MIT License](https://opensource.org/licenses/MIT), see the
[LICENSE-CODE](LICENSE-CODE) file.

Microsoft, Windows, Microsoft Azure and/or other Microsoft products and services referenced in the documentation may be either trademarks or registered trademarks of Microsoft in the United States and/or other countries. The licenses for this project do not grant you rights to use any Microsoft names, logos, or trademarks. Microsoft's general trademark guidelines can be found at http://go.microsoft.com/fwlink/?LinkID=254653.

Privacy information can be found at https://privacy.microsoft.com/en-us/

Microsoft and any contributors reserve all other rights, whether under their respective copyrights, patents,
or trademarks, whether by implication, estoppel or otherwise.
