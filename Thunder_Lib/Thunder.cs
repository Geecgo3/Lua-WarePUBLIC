using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lua_Ware_Testing.Thunder_Loader
{
    internal class Thunder
    {
        public static void Thunder_Load()
        {
            Console.Clear();
            string text = @"
                                                                                                              
                                                                                                              
                                                                                                              
                                                                                          ██▓▓                
                                                                                          ██▓▓                
                                                                                      ██████▓▓                
                                                                                    ▓▓████▓▓                  
                                                                                  ▓▓██████                    
                                                                                ██████████                    
                                                                                ██████████                    
                                                                            ██████████████                    
                                                                            ██████████▓▓▓▓                    
                                                                            ██████████                        
                                                                        ▓▓████████████                        
                                                                        ▓▓████████████                        
                                                                        ▓▓████████████                        
                                                                      ▓▓████████████▓▓                        
                                                                      ████████████▓▓                          
                                                                      ████████████▓▓                          
                                                                      ████████████▓▓                          
                                                                  ████████████████▓▓                          
                                                                  ██████████████▓▓                            
                                                                  ██████████████                              
                                                                  ██████████████                              
                                                                  ██████████████                              
                                                              ▓▓████████████████                              
                                                              ▓▓████████████▓▓▓▓                              
                                                              ▓▓████████████                                  
                                                            ████████████████                                  
                                                            ████████████████                                  
                                                            ████████████▓▓                                    
                                                        ▓▓▓▓████████████▓▓                                    
                                                        ████████████████▓▓                                    
                                                        ████████████████▓▓                                    
                                                        ████████████████▓▓                                    
                                                        ██████████████                                        
                                                      ▓▓██████████████                                        
                                                    ▓▓████████████████                                        
                                                    ▓▓████████████████                                        
                                                    ▓▓████████████████                                        
                                                  ████████████████                                            
                                                  ████████████████                                            
                                                  ████████████████                                            
                                              ████████████████████                                            
                                              ████████████████████                                            
                                              ████████████████▓▓                                              
                                              ████████████████▓▓                                              
                                              ████████████████▓▓                                              
                                          ▓▓██████████████████▓▓                                              
                                          ▓▓██████████████████▓▓                                              
                                          ▓▓████████████████                                                  
                                        ▓▓██████████████████▓▓▓▓▓▓▓▓▓▓▓▓                                      
                                        ████████████████████████████████▓▓                                    
                                        ████████████████████████████████▓▓                                    
                                        ████████████████████████████████▓▓                                    
                                    ████████████████████████████████████▓▓                                    
                                    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████████████▓▓                                      
                                                  ████████████████████                                        
                                              ████████████████████                                            
                                              ████████████████████                                            
                                              ████████████████▓▓                                              
                                            ▓▓████████████████▓▓                                              
                                          ▓▓██████████████████▓▓                                              
                                          ▓▓████████████████                                                  
                                          ▓▓████████████████                                                  
                                        ████████████████                                                      
                                        ████████████████                                                      
                                        ████████████████                                                      
                                    ████████████████▓▓                                                        
                                    ████████████████▓▓                                                        
                                    ██████████████                                                            
                                  ▓▓██████████████                                                            
                                ▓▓████████████████                                                            
                                ▓▓████████████                                                                
                                ▓▓████████████                                                                
                              ████████████▓▓                                                                  
                              ██████████▓▓                                                                    
                              ██████████                                                                      
                          ██████████████                                                                      
                          ██████████████                                                                      
                          ██████████                                                                          
                        ▓▓████████▓▓                                                                          
                      ▓▓████████▓▓                                                                            
                      ▓▓████████▓▓                                                                            
                      ▓▓████████▓▓                                                                            
                    ██████████                                                                                
                    ██████▓▓▓▓                                                                                
                    ██████                                                                                    
                ██████████                                                                                    
                ██████████                                                                                    
                ██████▓▓                                                                                      
              ▓▓████▓▓                                                                                        
            ▓▓██████                                                                                          
            ▓▓██                                                                                              
            ▓▓██                                                                                              
          ██████                                                                                              
          ████▓▓                                                                                              
          ██▓▓                                                                                                
                                                                                                              
                                                                                                              
                                                                                                              ";

            // END
         
            int consoleWidth = Console.WindowWidth;  // Get the width of the console
            int consoleHeight = Console.WindowHeight;  // Get the height of the console

            //Console.WriteLine($"Console Width: {consoleWidth}, Console Height: {consoleHeight}");
            int textLength = text.Length;
            // Set the console's cursor to the start position for centering
            int startPos = (consoleWidth / 2) - (textLength / 2);

            startPos = Math.Max(startPos, 0);  // Clamp to a minimum of 0

            int cursorTop = Math.Min(Console.CursorTop, consoleHeight - 1); // Set a safe top position
            Console.SetCursorPosition(startPos, cursorTop);


            // Rainbow colors array
            ConsoleColor[] rainbowColors = new ConsoleColor[]
            {
            ConsoleColor.White

            };

            /// Loop through the text and print each character with a different color
            for (int i = 0; i < text.Length; i++)
            {
                // Set the color for the character
                Console.ForegroundColor = rainbowColors[i % rainbowColors.Length];

                // Print the character
                Console.Write(text[i]);
            }

            // Reset color after the text
            Console.ResetColor();

            // What ever you want to switch
            Console.Clear();  // Wait for a key press before exiting
        }
    }
}
