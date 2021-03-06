using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillsMatrix.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SkillsMatrixContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Employees.Any())
            {
                var employees = new List<Employee>
                {
                    new Employee { Name = "Adele" },
                    new Employee { Name = "Lily Allen" },
                    new Employee { Name = "Lauren Aquilina" },
                    new Employee { Name = "Joan Armatrading" },
                    new Employee { Name = "Kevin Ayers" },
                    new Employee { Name = "Gary Barlow" },
                    new Employee { Name = "Rich Batsford" },
                    new Employee { Name = "James Bay" },
                    new Employee { Name = "Matt Bigland" },
                    new Employee { Name = "James Blunt" },
                    new Employee { Name = "David Bowie" },
                    new Employee { Name = "Andy Brown" },
                    new Employee { Name = "Melanie Brown" },
                    new Employee { Name = "Kate Bush" },
                    new Employee { Name = "Gary Clark" },
                    new Employee { Name = "Lloyd Cole" },
                    new Employee { Name = "Elvis Costello" },
                    new Employee { Name = "Gareth Davies" },
                    new Employee { Name = "Paul Stuart Davies" },
                    new Employee { Name = "Alex Day" },
                    new Employee { Name = "Chris de Burgh" },
                    new Employee { Name = "Marina Diamandis" },
                    new Employee { Name = "Siobhán Donaghy" },
                    new Employee { Name = "Donovan" },
                    new Employee { Name = "Josh Doyle" },
                    new Employee { Name = "Duffy" },
                    new Employee { Name = "Ella Eyre" },
                    new Employee { Name = "Newton Faulkner" },
                    new Employee { Name = "Kat Flint" },
                    new Employee { Name = "Andi Fraggs" },
                    new Employee { Name = "Barry Gibb" },
                    new Employee { Name = "Maurice Gibb" },
                    new Employee { Name = "Ellie Goulding" },
                    new Employee { Name = "David Gray" },
                    new Employee { Name = "Malcolm Guite" },
                    new Employee { Name = "Nick Harper" },
                    new Employee { Name = "George Harrison" },
                    new Employee { Name = "PJ Harvey" },
                    new Employee { Name = "Justin Hayward" },
                    new Employee { Name = "Imogen Heap" },
                    new Employee { Name = "Paul Heaton" },
                    new Employee { Name = "Ella Henderson" },
                    new Employee { Name = "Ant Henson" },
                    new Employee { Name = "Boo Hewerdine" },
                    new Employee { Name = "Robyn Hitchcock" },
                    new Employee { Name = "Trevor Horn" },
                    new Employee { Name = "Ben Howard" },
                    new Employee { Name = "Jamelia" },
                    new Employee { Name = "Bert Jansch" },
                    new Employee { Name = "Elton John" },
                    new Employee { Name = "Tom Jones" },
                    new Employee { Name = "Wizz Jones" },
                    new Employee { Name = "Martyn Joseph" },
                    new Employee { Name = "Nik Kershaw" },
                    new Employee { Name = "Hani King" },
                    new Employee { Name = "Beverley Knight" },
                    new Employee { Name = "Steve Knightley" },
                    new Employee { Name = "Charlie Landsborough" },
                    new Employee { Name = "John Lennon" },
                    new Employee { Name = "Adam Leonard" },
                    new Employee { Name = "Al Lewis" },
                    new Employee { Name = "Leona Lewis" },
                    new Employee { Name = "Dua Lipa" },
                    new Employee { Name = "Cher Lloyd" },
                    new Employee { Name = "Jez Lowe" },
                    new Employee { Name = "Nick Lowe" },
                    new Employee { Name = "M–Z[edit]" },
                    new Employee { Name = "Ewan MacColl" },
                    new Employee { Name = "Kirsty MacColl" },
                    new Employee { Name = "Amy Macdonald" },
                    new Employee { Name = "Emily Maguire" },
                    new Employee { Name = "Zayn Malik" },
                    new Employee { Name = "Laura Marling" },
                    new Employee { Name = "Johnny Marr" },
                    new Employee { Name = "Michael Marra" },
                    new Employee { Name = "John Martyn" },
                    new Employee { Name = "Brian May" },
                    new Employee { Name = "Conor Maynard" },
                    new Employee { Name = "Paul McCartney" },
                    new Employee { Name = "Shelagh McDonald" },
                    new Employee { Name = "Charlie McDonnell" },
                    new Employee { Name = "Mika" },
                    new Employee { Name = "Gary Moore" },
                    new Employee { Name = "James Morrison" },
                    new Employee { Name = "Graham Nash" },
                    new Employee { Name = "John Newman" },
                    new Employee { Name = "Tom Odell" },
                    new Employee { Name = "Ozzy Osbourne" },
                    new Employee { Name = "Passenger" },
                    new Employee { Name = "Liam Payne" },
                    new Employee { Name = "Karen Poole" },
                    new Employee { Name = "Mal Pope" },
                    new Employee { Name = "Paul Poulton" },
                    new Employee { Name = "Ricky Ross" },
                    new Employee { Name = "Emeli Sandé" },
                    new Employee { Name = "Ed Sheeran" },
                    new Employee { Name = "Lucie Silvas" },
                    new Employee { Name = "Sam Smith" },
                    new Employee { Name = "Cat Stevens" },
                    new Employee { Name = "Harry Styles" }
                };
                foreach (Employee e in employees)
                {
                    context.Employees.Add(e);
                }
                context.SaveChanges();
            }

            if (!context.Skills.Any())
            {
                var skills = new List<Skill>
                {
                    new Skill { Name = "Angelscript" },
                    new Skill { Name = "Apex" },
                    new Skill { Name = "Applescript" },
                    new Skill { Name = "AutoLISP" },
                    new Skill { Name = "Automator" },
                    new Skill { Name = "Bash" },
                    new Skill { Name = "Boo" },
                    new Skill { Name = "C++" },
                    new Skill { Name = "Caml" },
                    new Skill { Name = "COBOL" },
                    new Skill { Name = "CoffeeScript" },
                    new Skill { Name = "COMAL" },
                    new Skill { Name = "Common Lisp" },
                    new Skill { Name = "Curl" },
                    new Skill { Name = "ECMAScript" },
                    new Skill { Name = "Eiffel" },
                    new Skill { Name = "Elm" },
                    new Skill { Name = "Erlang" },
                    new Skill { Name = "Etoys" },
                    new Skill { Name = "EXEC" },
                    new Skill { Name = "Fantom" },
                    new Skill { Name = "Fortran" },
                    new Skill { Name = "Fortress" },
                    new Skill { Name = "Gambas" },
                    new Skill { Name = "GNU Octave" },
                    new Skill { Name = "Hack" },
                    new Skill { Name = "Haskell" },
                    new Skill { Name = "Haxe" },
                    new Skill { Name = "Heron" },
                    new Skill { Name = "HyperTalk" },
                    new Skill { Name = "Inform" },
                    new Skill { Name = "INTERCAL" },
                    new Skill { Name = "JADE" },
                    new Skill { Name = "Java" },
                    new Skill { Name = "JavaFX Script" },
                    new Skill { Name = "JScript" },
                    new Skill { Name = "JScript.NET" },
                    new Skill { Name = "Kotlin" },
                    new Skill { Name = "LabVIEW" },
                    new Skill { Name = "Ladder Logic" },
                    new Skill { Name = "Lasso" },
                    new Skill { Name = "Limbo" },
                    new Skill { Name = "Lingo" },
                    new Skill { Name = "Lisp" },
                    new Skill { Name = "LotusScript" },
                    new Skill { Name = "LPC" },
                    new Skill { Name = "Lustre" },
                    new Skill { Name = "Magik" },
                    new Skill { Name = "Malbolge" },
                    new Skill { Name = "MANTIS" },
                    new Skill { Name = "Maple" },
                    new Skill { Name = "MATLAB" },
                    new Skill { Name = "Max/MSP" },
                    new Skill { Name = "MAXScript" },
                    new Skill { Name = "MDX" },
                    new Skill { Name = "MEL" },
                    new Skill { Name = "Mercury" },
                    new Skill { Name = "Miva" },
                    new Skill { Name = "Modula-2" },
                    new Skill { Name = "Modula-3" },
                    new Skill { Name = "Monkey" },
                    new Skill { Name = "MOO" },
                    new Skill { Name = "Moto" },
                    new Skill { Name = "MS-DOS batch" },
                    new Skill { Name = "MUMPS" },
                    new Skill { Name = "NATURAL" },
                    new Skill { Name = "Nemerle" },
                    new Skill { Name = "NQC" },
                    new Skill { Name = "NSIS" },
                    new Skill { Name = "NXT-G" },
                    new Skill { Name = "Oberon" },
                    new Skill { Name = "Object Rexx" },
                    new Skill { Name = "Occam" },
                    new Skill { Name = "OpenCL" },
                    new Skill { Name = "Perl" },
                    new Skill { Name = "PHP" },
                    new Skill { Name = "PL/SQL" },
                    new Skill { Name = "PowerShell" },
                    new Skill { Name = "Prolog" },
                    new Skill { Name = "Python" },
                    new Skill { Name = "Q" },
                    new Skill { Name = "Ruby" },
                    new Skill { Name = "SAS" },
                    new Skill { Name = "Scala" },
                    new Skill { Name = "Scratch" },
                    new Skill { Name = "Smalltalk" },
                    new Skill { Name = "SPARK" },
                    new Skill { Name = "Squeak" },
                    new Skill { Name = "Squirrel" },
                    new Skill { Name = "Swift" },
                    new Skill { Name = "TypeScript" },
                    new Skill { Name = "VBScript" },
                    new Skill { Name = "Verilog" },
                    new Skill { Name = "VHDL" },
                    new Skill { Name = "Whitespace" },
                    new Skill { Name = "Wolfram" },
                    new Skill { Name = "X10" },
                    new Skill { Name = "xBase" },
                    new Skill { Name = "XQuery" }

                };
                foreach (Skill s in skills)
                {
                    context.Skills.Add(s);
                }
                context.SaveChanges();
            }
        }
    }
}