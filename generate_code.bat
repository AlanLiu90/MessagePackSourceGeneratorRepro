dotnet tool restore

dotnet mpc -i "TestProject1_v2\TestProject1_v2.csproj" -o "TestProject1_v2\MessagePackGenerated.cs"
dotnet mpc -i "TestProject3_v2\TestProject3_v2.csproj" -o "TestProject3_v2\MessagePackGenerated.cs"
dotnet mpc -i "TestProject4_v2\TestProject4_v2.csproj" -o "TestProject4_v2\MessagePackGenerated.cs"
dotnet mpc -i "TestProject5_v2\TestProject5_v2.csproj" -o "TestProject5_v2\MessagePackGenerated.cs"

pause
