﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meraki {
    internal class UrlFormatProvider : IFormatProvider {
        private readonly UrlFormatter _formatter = new UrlFormatter();

        public object GetFormat(Type formatType) {
            if(formatType == typeof(ICustomFormatter)) {
                return _formatter;
            }

            return null;
        }

        private class UrlFormatter : ICustomFormatter {
            public string Format(string format, object arg, IFormatProvider formatProvider) {
                if(arg == null) {
                    return string.Empty;
                }
                if(format == "r") {
                    return arg.ToString();
                }

                return Uri.EscapeDataString(arg.ToString());
            }
        }
    }
}