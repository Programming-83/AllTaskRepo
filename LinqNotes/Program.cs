
// Q.1  What are the different things required to write a LINQ Query 
// Ans. 1. Data Source(In-memory objects, SQL Server, XML Document, etc)
//     2. Query
//     3. Execution of the Query
//--------------------------------------------------------------------------------------------------
// Each query is a combination of three things. They are as follows:
//     1.Initialization(to work with a particular data source)
//     2.Condition(Where, filter, sorting condition)
//     3.Selection(single selection, group selection.or joining)
// We can write the LINQ query in three different ways. They are as follows
//     1. Query Syntax
//     2. Method Syntax
//     3. Mixed Syntax
//   >> The LINQ queries written using query syntax are translated into their lambda expressions
//      before they are compiled.

//                                 :LINQ Query Syntax:
//       1.from object in database <------- Initialization
//          where condition <--------------- Condition
//          select database
//       2. Method Chaining
//          DataSource.ConditionMethod().SelectionMethod()
//              |               |                  |
//        Initialization  Condition           Selection 

//       3. LINQ Mixed Syntax:
//           (from object in DataSource
//            where condition
//            select object).Method()

