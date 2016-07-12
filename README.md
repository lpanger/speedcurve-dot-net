# speedcurve-dot-net

A package to use SpeedCurve (http://www.speedcurve.com) API's. Requires API key. Only implemented part of the API for my needs. Providing code as is for anyone to improve on.

#### Installation

Install via nuget package manager

#### Usage

```
var client = new SpeedCurve.Client("API_KEY_HERE");
var testResult = await client.GetTestResultsAsync("some_test_id_here");
```
