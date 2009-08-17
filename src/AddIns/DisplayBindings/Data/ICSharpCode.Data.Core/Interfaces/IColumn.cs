﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICSharpCode.Data.Core.Interfaces
{
    public interface IColumn : IDatabaseObjectBase
    {
        string ColumnSummary { get; }
        string DataType { get; set; }
        string SystemType { get; set; }
        int Length { get; set; }       
        int ColumnId { get; set; }
        int FullTextTypeColumn { get; set; }
        bool IsComputed { get; set; }
        bool IsCursorType { get; set; }
        bool IsDeterministic { get; set; }
        bool IsFulltextIndexed { get; set; }
        bool IsIdentity { get; set; }
        bool IsIdNotForRepl { get; set; }
        bool IsIndexable { get; set; }
        bool IsNullable { get; set; }
        bool IsOutParam { get; set; }
        bool IsPrecise { get; set; }
        bool IsPrimaryKey { get; set; }
        bool IsRowGuidCol { get; set; }
        bool IsSystemVerified { get; set; }
        bool IsXmlIndexable { get; set; }
        int Precision { get; set; }
        int Scale { get; set; }
        bool SystemDataAccess { get; set; }
        bool UserDataAccess { get; set; }
        bool UsesAnsiTrim { get; set; }
    }
}