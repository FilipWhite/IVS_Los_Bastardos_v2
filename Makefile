.PHONY: all clean pack run stddev help

all: 
	@echo "Project successfully loaded. Build it manually in Visual Studio (e.g., Ctrl+Shift+B)."

run:
	@echo "Running the calculator"
	cmd /c start "" bin\Debug\IVS_proj2.exe


stddev:
	@echo "Running standard deviation calculation" #potrebujem udelat ten profiling 

clean:
	@echo "Cleaning project files"
	del /Q /F bin\Debug\*.exe bin\Debug\*.pdb bin\Debug\*.config

pack:
	@echo "Packing project into zip"
	@if exist IVS_proj2.zip del IVS_proj2.zip
	@powershell -Command "Compress-Archive -Path * -DestinationPath IVS_proj2.zip"
	@echo "Project successfully packed into IVS_proj2.zip"


help:
	@echo "Help:"
	@echo "  make all      - reminds you to build the project in Visual Studio"
	@echo "  make run      - runs the main application"
	@echo "  make stddev   - runs the standard deviation calculation"
	@echo "  make clean    - deletes bin/ and obj/ folders"
	@echo "  make pack     - compresses the project into a ZIP archive"
	@echo "  make help     - displays this help message"
