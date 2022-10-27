<Query Kind="Statements" />

var query = new[] { "a", "bc", "d" }.AsQueryable();

Expression<Func<string, bool>> expr = x => x.Length > 1;
Func<string, bool> del = x => x.Length > 1;
var valid = query.Where(expr);
var invalid = query.Where(del);