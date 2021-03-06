﻿/*   Copyright 2009 - 2010 Marcus Bratton

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

using System;
using Siege.Repository.Finders;

namespace Siege.Repository
{
    public interface IRepository<TPersistenceModel> where TPersistenceModel : IDatabase
    {
        T Get<T>(object id) where T : class;
        void Save<T>(T item) where T : class;
        void Delete<T>(T item) where T : class;
        void Transact(Action<IRepository<TPersistenceModel>>  transactor);
		IQuery<T> Query<T>(Func<System.Linq.IQueryable<T>, System.Linq.IQueryable<T>> expression) where T : class;
		IQuery<T> Query<T>(QuerySpecification<T> querySpecification) where T : class;
		IQuery<T> Query<T>() where T : class;
    }
}