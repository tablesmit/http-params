http-param
==========

Convienience class wrapping access to an HTTP friendly `System.Collections.Specialized.NameValueCollection` with a fluent interface.

### Usage:

    var parameters = new HttpParams().Add("key", "value")
                                     .Add("otherKey", "otherValue")

	var url = "http://domain.com/controller/action?" + parameters.ToString();

Since the `HttpParams` wraps `System.Collections.Specialized.NameValueCollection` the values are automatically URL encoded when _ToString()_ is called..


### [Nuget](https://www.nuget.org/packages/HttpParamsUtility/1.0.0)

To install HTTP Params Utility, run the following command in the Package Manager Console

    PM> Install-Package HttpParamsUtility
