dotnet publish -c Release
$url = ".\Lib\bin\Release\net8.0-browser\publish\wwwroot\_framework\"
ls $url | % { cp ($url + $_.Name) (".\Web\_framework\" + $_.Name)  }