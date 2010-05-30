/*   Copyright 2009 - 2010 Marcus Bratton

     Licensed under the Apache License, Version 2.0 (the "License");
     you may not use this file except in compliance with the License.
     You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

     Unless required by applicable law or agreed to in writing, software
     distributed under the License is distributed on an "AS IS" BASIS,
     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     See the License for the specific language governing permissions and
     limitations under the License.
*/

namespace Siege.DynamicTypeGeneration.Tests
{
	public class Simulator
	{
		public string Simulate(string stringArg, SampleClass sample)
		{
			var del = new DelegateWithArguments();
			var args = new MethodArgument[2];
            
			var arg = new MethodArgument();
            
			arg.Index = 0;
			arg.Name = "stringArg";
			arg.Value = stringArg;
			args[0] = arg;

			var arg1 = new MethodArgument();

			arg1.Index = 1;
			arg1.Name = "sample";
			arg1.Value = sample;
            
			args[1] = arg1;

			return del.Process(() => "lol", args);
		}
	}
}