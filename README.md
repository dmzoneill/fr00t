# Fr00t

<p align="center">
  <img src=".github/logo.png" alt="fr00t logo" width="128" />
</p>

A Windows Forms tool that watches for programs that are not on an
allowed list.

## What it does

It checks the running processes against a list of allowed process names
(Windows services, Explorer, antivirus and driver helpers). When it
finds a new program it lists it and asks whether it should continue.

## Tech

- Visual Basic .NET (Windows Forms)

## Building

Open the `.sln` file in Visual Studio and build it. Windows only.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
