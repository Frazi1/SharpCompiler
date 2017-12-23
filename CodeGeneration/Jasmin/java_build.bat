@echo off
javac JavaTestBuild.java > java_build_log.txt 2>&1
javap -v *.class > java_decompiled.txt