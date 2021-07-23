# About ImageToANSI
This is a tool to convert image files to ANSI art. Please note that unlike other similar programs, the purpose of this one is to make art to be used in <b>DOS</b> (DOSBox), using only 16 colors.

![ImageToANSI](https://user-images.githubusercontent.com/56899074/126808960-201c48e9-30c9-4190-b42d-be382f80a00a.png)

# How to use
Get a small image, preferably 80x50 PNG with low colors. Start the program and press Open to find your image file.<br>There's a preview window at the bottom, so you can see what the end result will look like in console. The number of rows and columns should stay 80x25 but you can change it at the top if you want to. Colors will be reduced to 16 colors by default. Some color options are available on top but I recommend balancing things out in your favorite image editor first.<br>Press the Save button to save your image in ANS format. Navigate to your file in DOS and write "type file.ans" to display your art.

# Known problems
- Window size might not stretch correctly in some cases. Try to avoid window resizing.
- Some image formats load incorrectly. Keep it simple, use Paint and save to PNG or BMP files.
- There are certain color restrictions due to using only 16 colors. For example you can't have white with yellow underneath in even rows.
- Output file is <b>unoptimized</b>. I recommend resaving the file in a program like TheDraw.

# Build info
IDE: Visual Studio 2019<br>
Project type: Windows Forms App (C#)<br>
Target framework: .NET Framework 4.5
