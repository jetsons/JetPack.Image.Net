# JetPack.Image for .NET

[![Version](https://img.shields.io/nuget/vpre/Jetsons.JetPack.Image.svg)](https://www.nuget.org/packages/Jetsons.JetPack.Image)
[![Downloads](https://img.shields.io/nuget/dt/Jetsons.JetPack.Image.svg)](https://www.nuget.org/packages/Jetsons.JetPack.Image)
[![GitHub contributors](https://img.shields.io/github/contributors/jetsons/JetPack.Image.Net.svg)](https://github.com/jetsons/JetPack.Image.Net/graphs/contributors)
[![License](https://img.shields.io/github/license/jetsons/JetPack.Image.Net.svg)](https://github.com/jetsons/JetPack.Image.Net/blob/master/LICENSE)

To use this simply grab our Nuget package `Jetsons.JetPack.Image` and add this to the top of your class:

    using Jetsons.JetPack;
	
This statement unlocks all the extension methods below. Enjoy!
	
### Extensions

Extension methods for file I/O performed using file path Strings:

- string.**LoadBitmap**
- string.**LoadPNG**
- string.**LoadJPG**
- string.**LoadBMP**
- string.**LoadICO**
- bitmap.**SaveToPNG**
- bitmap.**SaveToJPG**
- bitmap.**SaveToBMP**
- icon.**SaveToICO**

Extension methods for file I/O performed using Bitmaps:

- icon.**EncodeICO**
- bitmap.**EncodePNG**
- bitmap.**EncodeJPG**
- bitmap.**EncodeBMP**

Extension methods for Bitmap objects:

- bitmap.**EncodePNG**
- bitmap.**EncodeJPG**
- bitmap.**EncodeBMP**
- icon.**EncodeICO**
- bytes.**DecodeBitmap**
- bytes.**DecodePNG**
- bytes.**DecodeJPG**
- bytes.**DecodeBMP**
- bytes.**DecodeICO**