using SQLite;
using System;
using CookingBuddy.Models;

namespace CookingBuddy.Services
{
    public class RecipeService
    {
        string _dbPath;
        public string StatusMessage { get; set; }
        private SQLiteAsyncConnection conn;
        public RecipeService(string dbPath)
        {
            _dbPath = dbPath;
        }
        private async Task InitAsync()
        {
            // Don't Create database if it exists
            if (conn != null)
                return;
            // Create database and Recipe Table
            conn = new SQLiteAsyncConnection(_dbPath);
            await conn.CreateTableAsync<RecipeModel>();
        }
        public async Task<List<RecipeModel>> GetRecipeAsync()
        {
            await InitAsync();
            return await conn.Table<RecipeModel>().ToListAsync();
        }
        public async Task<RecipeModel> CreateRecipeAsync(
            RecipeModel paramRecipe)
        {
            // insert
            await conn.InsertAsync(paramRecipe);
            // return the object with the auto incremented Id populated
            return paramRecipe;
        }
        public async Task<RecipeModel> UpdateRecipeAsync(
            RecipeModel paramRecipe)
        {
            // update
            await conn.UpdateAsync(paramRecipe);
            return paramRecipe;
        }
        public async Task<RecipeModel> DeleteRecipeAsync(
            RecipeModel paramRecipe)
        {
            // delete
            await conn.DeleteAsync(paramRecipe);
            return paramRecipe;
        }
    }
}

