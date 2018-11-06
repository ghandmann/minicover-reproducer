# Minimal Reproducer for Minicover not picking up ASP.net Core Integration Tests

## Steps to reproduce

1) Clone this repository
2) Run `./test-and-cover.sh`
3) Check the Coverage-Report of `WebAPI/Controllers/ValuesController.cs`

## Expected

The `ValuesController.cs` should be covered by 100%.

## Actual

The `ValuesController.cs` should is covered by 0%.