﻿using Xunarmand.Domain.Common.Queries;

namespace Xunarmand.Application.Orders.Models;

public class OrderFilter:FilterPagination
{
    /// <summary>
    /// Overrides base GetHashCode method
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        var hashCode = new HashCode();

        hashCode.Add(PageSize);
        hashCode.Add(PageToken);

        return hashCode.ToHashCode();
    }

    /// <summary>
    /// Overrides base Equals method
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj) =>
        obj is OrderFilter clientFilter
        && clientFilter.GetHashCode() == GetHashCode();
}