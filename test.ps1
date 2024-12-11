dotnet publish -c Release
$url = ".\Lib\bin\Release\net8.0-browser\publish\wwwroot\_framework\"
ls $url | ? { $_.Name.EndsWith(".wasm") } | % { cp ($url + $_.Name) (".\Web\" + $_.Name)  }
ls $url | ? { $_.Name.EndsWith(".js") } | % { cp ($url + $_.Name) (".\Web\" + $_.Name)  }
ls $url | ? { $_.Name.EndsWith(".json") } | % { cp ($url + $_.Name) (".\Web\" + $_.Name)  }
ls $url | ? { $_.Name.EndsWith(".dat") } | % { cp ($url + $_.Name) (".\Web\" + $_.Name)  }