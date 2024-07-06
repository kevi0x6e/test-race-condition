<p align="center">
  <h3 align="center"><b>Test Race Condition</b></h3>
  <p align="center">Test project on how to avoid race conditions</p>
</p>

### Summary
A race condition occurs when two or more threads or processes attempt to modify a variable or resource simultaneously, potentially causing unpredictable behavior in the application. To mitigate this issue, I created this test example to prevent it from happening. Can you find more about this solution at [Microsoft article](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/lock).

---

### Download and install

```bash
# Download
$ git clone LINK-GITHUB-PROJECT && cd test-race-condition

# Install libs and dependencies
$ dotnet restore

# Build application
$ dotnet build
```

---

### How to use

```bash
# Start
dotnet run api/api.csproj
```

Run on: [localhost](http://localhost:5000/index.html)

### How to test

To test, you need to make two simultaneous requests in debug

---
### License

This work is licensed under [MIT License.](/LICENSE.md)