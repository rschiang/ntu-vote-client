ntu-vote-client
===============

The .NET client of NTU Vote [authentication server](https://github.com/rschiang/ntu-vote-auth-server), used in 106-1 NTUSA election.

Prerequisites
-------------

* .NET Framework 3.5 or higher (this project targets v4.0)
* JSON.NET
* Native [card reader library](http://www.shdeka.com/Upfiles/Attachment/D8%E6%84%9F%E5%BA%94IC%E5%8D%A1%E8%AF%BB%E5%86%99%E5%99%A8%E5%BC%80%E5%8F%91%E5%8C%85.rar) provided by manufacturer.

To build
--------

* Extract and put `dcrf32.dll` under `Vendor/`.
* Put your own loading animation under `NTUVoteClient/Resources/`.
* Fill in `targetSector`, `apiPath`, and `apiFormat` variable value in `ApiClient` and `CardReader`.
* Build and run the project.

License
-------

This project is licensed under Apache 2.0 license.
