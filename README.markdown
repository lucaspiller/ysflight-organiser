# YsFlight Organiser

A tool for managing addons for the flight simulator, [YsFlight](http://wwww.ysflight.com/).

## Requirements

### Windows

 * Windows XP or above
 * .NET Framework 3.5

The installer will check for prerequisites, and prompt you to install anything if needed.

### Linux

 * Mono 2.0 or above

## Usage

### Setup

The application will check the default YsFlight installation to see whether an installation is present by default. If there is not, for example if you used a custom directory, or are using a test version, you will be prompted to select the installation directory. Click Browse and select the base directory of the YsFlight installation, containing 'fsmain.exe'. After you have selected the path click 'Save' and the application will load details of your installation.

Under Linux you will need to select the base directory containing the 'ysflight' executable. Under Mono 2.4.2.3 there is a bug which results in the directory selector (pressing Browse) not working. As such, please type in the path into the text box.

### Managing Addons

The tool allows you to manage Aircraft, Ground Objects and Maps by selecting the relavent tab. Two lists are shown, the first listing addons loaded into YsFlight, and the second listing unloaded addons. The lists can be organised by selecting an addon and click the Up and Down buttons to move it up or down. Multiple items can be selected by clicking and dragging, or by holding control while pressing the arrow keys on your keyboard. Items can be moved to the other list by selecting them, and clicking the Load or Unload button.

Items are automatically saved when the program exits, however you can save items manually by clicking the 'Save' button in the settings tab. Unloaded items are stored in a .lst file in the same location as the loaded list, but prefixed with 'unloaded_'. For example, unloaded aircraft are stored in 'aircraft/unloaded_aircraft.lst'.\

## Contributing

The tool and library are open source, so feel free to contribute or use the code within your own application. For further details, please see the project page on [GitHub](http://www.github.com/lucaspiller/ysflight-organiser/).

## Authors

* Luca Spiller <luca@stackednotion.com>

## License

See LICENSE.markdown.