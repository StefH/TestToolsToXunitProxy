# TestToolsToXunitProxy
Microsoft.VisualStudio.TestTools.UnitTesting to Xunit proxy

This project makes it possible to keep your existing tests written in Microsoft.VisualStudio.TestTools.UnitTesting but use XUnit assertions.
This can be usefull when upgrading a .net 4.x project to the new .netcore (netstandard / netcoreapp)  projects and you don't want to modify all tests yet to xunit (because Microsoft.VisualStudio.TestTools.UnitTesting does not yet support .netcore).
