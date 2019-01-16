  // Nullable types
            // Allows you to store data and null values
            Nullable<int> i = null;
            // same at int ?i = null;

            // to set a nullable to another variable | these are reference types
            int ?v = i;

            i.HasValue(); // if has value

            i.Value() // returns the value


