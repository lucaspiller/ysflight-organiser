# Version History

## Unreleased Changes

### Core Framework

* ToString method of Addon classes no longer returns the name in title case. Use
  the NamePretty property instead.
* Addons throw an InvalidLstEntry exception if the lst entry contains an invalid
  file or is invalid. All exceptions when loading details of addons are caught
  by LstLoader and not rethrown.
* LstLoader and Ysfo classes refactored to make a number of methods public. The 
  Loaders.PathHelper class contains GetFullPath, ConvertToNative and IsPathValid
  methods.
* Refactor DatLoader class.
* Detects the latest version of YSFlight on Windows correctly.

## 0.1.0 (2009-08-26)

Initial release