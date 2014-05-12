Write-Host "OctopusDeploy.QFrameBootcamp.DB - PostDeploy"

try {
	& "$OctopusActionPackageCustomInstallationDirectory\OctopusDeploy.QFrameBootcamp.DB.exe"
}
catch {
	Write-Error $error[0]
	Exit 1
}