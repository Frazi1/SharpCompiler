@echo off
java -jar %JASMIN_PATH% *.j >jasmin_buildlog.txt 2>&1
type jasmin_buildlog.txt

