using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman {
    class Player {

        //Constructors is called when an object gets created. to ensure props have valid values.  always have the same name as thier containing class.
        // constructors are always void 
        public Player(string name) {
            if(name == null) {
                throw new ArgumentNullException(nameof(name));
            }

            this.Name = name;

        }

        public Player() 
            : this("Anonymous") { }

        public string Name { get; set; }
    }
}


