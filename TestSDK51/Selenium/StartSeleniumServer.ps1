Write-Output "Selenium Server Is Running"

$seleniumDir = "C:\SDK\Selenium"
$selenium = (Get-Item $seleniumDir\*.jar).Name

$javaFolder = "C:\Program Files (x86)\Java"
if (Test-Path "C:\Program Files (x86)\Java") {
	$javaFolder = "C:\Program Files (x86)\Java"
}

$javaVersion = (Get-Item "$javaFolder\jre*").Name
&"$javaFolder\$javaVersion\bin\java.exe" -jar $seleniumDir\$selenium -port 4444 -avoidProxy -userExtensions $seleniumDir\user-extensions.js | Out-Null