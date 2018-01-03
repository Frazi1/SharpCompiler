@echo off
java -jar %~dp0jasmin.jar *.j >jasmin_buildlog.txt 2>&1
type jasmin_buildlog.txt
exit