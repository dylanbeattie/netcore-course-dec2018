# Exercise: Working with data APIs

In this exercise, we're going to write an app to pull data from a public data API, convert the API responses into .NET objects, and then use LINQ to filter and sort those objects.

## Connecting to a remote API

Take a look at Todd Motto’s list of free public APIs: https://github.com/toddmotto/public-apis

Pick one that gives you an endpoint that will return one random thing - a random joke or a random fact or a random piece of data.

Write some .NET code that uses the HttpClient class (https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netcore-2.1) to retrieve one random data point from the remote URL and display it on the screen.

## Exposing an IEnumerable of API responses

Create a .NET object that models the responses you're getting from your remote API.

Create a .NET method that exposes an IEnumerable of these objects. Each time it's called it should call the remote API, retrieves a single random response, translates it into one of your .NET objects, and then 
return the .NET object containing that response.

## Filtering the response

Use LINQ to filter your list of responses to the top 20 responses matching some particular criteria, and display these on the console in a defined order.

## Error Handling

What happens to your program if the remote API is unavailable? Try switching off your wifi, run the program again and see what happens. Can you make it fail more gracefully?
