﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Pizza.Application.Common.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
            : base("The request is invalid or incomplete.")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(List<ValidationFailure> failures)
            : this()
        {
            var propertyNames = failures
                .Select(e => e.PropertyName)
                .Distinct();

            foreach (var propertyName in propertyNames)
            {
                var propertyFailures = failures
                    .Where(e => e.PropertyName == propertyName)
                    .Select(e => e.ErrorMessage)
                    .ToArray();

                Errors.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Errors { get; }
    }
}
