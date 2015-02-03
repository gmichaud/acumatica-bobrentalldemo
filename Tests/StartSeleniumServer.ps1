Write-Output "Selenium Server Is Running"

$seleniumDir = "..\TestSDK51\Selenium"
$selenium = (Get-Item $seleniumDir\*.jar).Name

$javaFolder = "C:\Program Files\Java"
if (Test-Path "C:\Program Files\Java") {
	$javaFolder = "C:\Program Files\Java"
}

$javaVersion = (Get-Item "$javaFolder\jre*").Name
&"$javaFolder\$javaVersion\bin\java.exe" -jar $seleniumDir\$selenium -port 4444 -avoidProxy -userExtensions $seleniumDir\user-extensions.js | Out-Null