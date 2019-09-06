#MakeFile Script For C# Stuff


main: Main.cs
	@mcs Main.cs

edit:
	@vim Main.cs

clean:
	@rm Main.exe

run:
	@mono Main.exe
