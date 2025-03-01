using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;

namespace RoutingASPDotNetCoreMVC.Models;

public class AlphaNumericConstraint : IRouteConstraint
{
    public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        if (httpContext == null)
        {
            throw new ArgumentNullException(nameof(httpContext));
        }

        if (route == null)
        {
            throw new ArgumentNullException(nameof(route));
        }

        if (routeKey == null)
        {
            throw new ArgumentNullException(nameof(routeKey));
        }

        if (values == null)
        {
            throw new ArgumentNullException(nameof(values));
        }
        if (values.TryGetValue(routeKey, out var parameterValueObject) && parameterValueObject != null)
        {
            var parameterValueString = Convert.ToString(routeKey);

            if (Regex.IsMatch(parameterValueString ?? string.Empty, @"^(?=.*[a-zA-Z])(?=.*[0-9])[A-Za-z0-9]+$"))
            {
                return true;
            }
            else return false;
        }
        return false;



    }




}
