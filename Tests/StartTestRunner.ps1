Write-Output "Copying Test Assembly to Runner Path"
$runnerDir = "..\TestSDK51\Test Runner"
Copy-Item "bin\Debug\TestToolRental.dll" $runnerDir

Write-Output "Starting Test Runner"
&"$runnerDir\TestProject.exe" /run "$pwd\ToolRentalTests.xml"