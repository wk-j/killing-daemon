## Killing Daemon

- https://stackoverflow.com/questions/38291567/killing-gracefully-a-net-core-daemon-running-on-linux
- https://github.com/dotnet/corefx/issues/10012

## Test

1. Start 

```
dotnet KillingDaemon.dll
```

2. Kill process

```
kill <PID>
```

3. Output ??

```
Hello World from F#!
fish: Job 2, 'dotnet KillingDaemon.dll' terminated by signal SIGTERM (Polite quit request)
```