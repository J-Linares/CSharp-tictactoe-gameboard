echo "we will be creating both the dll file and .exe file"
mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -out:mytictactoeframe.dll mytictactoeframe.cs
echo "dll file has no been created"
mcs -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:mytictactoeframe.dll -out:mytictactoe.exe mytictactoemain.cs
echo "the .exe file for the has now been created"
echo "we will now run the file, if an error occurs you will be notified"
./mytictactoe.exe
