
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Encodings;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using AppEndCommon;
using AppEndDynaCode;
using AppEndDbIO;
using AppEndServer;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Routing.Matching;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Collections;
using AngleSharp.Text;
using Microsoft.Extensions.Caching.Memory;
using AngleSharp.Common;
using System.Reflection;
using AppEndDynaCode;



namespace Zzz
{
    public static class AppEndProxy
    {
		public static object? BuildUiForDbObject(string DbConfName, string ObjectName)
		{
			return HostingMethods.BuildUiForDbObject(DbConfName, ObjectName);
		}
		public static object? CreateLogicalFk(string DbConfName, string FkName, string BaseTable, string BaseColumn, string TargetTable, string TargetColumn)
		{
			return HostingMethods.CreateLogicalFk(DbConfName, FkName, BaseTable, BaseColumn, TargetTable, TargetColumn);
		}
		public static object? RemoveLogicalFk(string DbConfName, string BaseTable, string BaseColumn)
		{
			return HostingMethods.RemoveLogicalFk(DbConfName, BaseTable, BaseColumn);
		}
        public static object? RemoveRemovedRelationsFromDbQueries(string DbConfName, string ObjectName)
        {
            return HostingMethods.RemoveRemovedRelationsFromDbQueries(DbConfName, ObjectName);
        }
        public static object? CreateNewNotMappedMethod(string DbConfName, string ObjectName, string MethodName)
        {
            return HostingMethods.CreateNewNotMappedMethod(DbConfName, ObjectName, MethodName);
        }
        public static object? CreateNewMethodQuery(string DbConfName, string ObjectName, string MethodType, string MethodName)
        {
            return HostingMethods.CreateNewMethodQuery(DbConfName, ObjectName, MethodType, MethodName);
        }
        public static object? CreateNewUpdateByKey(string DbConfName, string ObjectName, List<string> ColumnsToUpdate, string MethodName, string? ByColumnName, string? OnColumnName, string? LogTableName)
        {
            return HostingMethods.CreateNewUpdateByKey(DbConfName, ObjectName, ColumnsToUpdate, MethodName, ByColumnName, OnColumnName, LogTableName);
        }
        public static object? DuplicateMethodQuery(string DbConfName, string ObjectName, string MethodName, string MethodCopyName)
        {
            return HostingMethods.DuplicateMethodQuery(DbConfName, ObjectName, MethodName, MethodCopyName);
        }
        public static object? RemoveMethodQuery(string DbConfName, string ObjectName, string MethodName)
        {
            return HostingMethods.RemoveMethodQuery(DbConfName, ObjectName, MethodName);
        }
        public static object? RemoveNotMappedMethod(string DbConfName, string ObjectName, string MethodName)
        {
            return HostingMethods.RemoveNotMappedMethod(DbConfName, ObjectName, MethodName);
        }
		public static object? GetDbObjectsStack(string DbConfName, string ObjectType, string Filter)
		{
			return HostingMethods.GetDbObjectsStack(DbConfName, ObjectType, Filter);
		}
		public static object? GetDbObjectNotMappedMethods(string DbConfName, string ObjectName)
		{
			return HostingMethods.GetDbObjectNotMappedMethods(DbConfName, ObjectName);
		}
		public static object? ReCreateMethodJson(string DbConfName, string ObjectName, string ObjectType, string MethodName)
        {
            return HostingMethods.ReCreateMethodJson(DbConfName, ObjectName, ObjectType, MethodName);
        }
        public static object? RemoveServerObjects(string DbConfName, string ObjectName, string ObjectType)
        {
            return HostingMethods.RemoveServerObjects(DbConfName, ObjectName, ObjectType);
        }
        public static object? CreateServerObjects(string DbConfName, string ObjectName, string ObjectType)
        {
            return HostingMethods.CreateServerObjects(DbConfName, ObjectName, ObjectType);
        }
        public static object? GetCreateOrAlterTable(string DbConfName, string ObjectName)
        {
            return HostingMethods.GetCreateOrAlterObject(DbConfName, ObjectName);
        }
		public static object? SyncDbDialog(string DbConfName, string ObjectName)
		{
			return HostingMethods.SyncDbDialog(DbConfName, ObjectName);
		}
		

		public static object? CreateEmptyDbView(string DbConfName, string ViewName)
		{
			return HostingMethods.CreateEmptyDbView(DbConfName, ViewName);
		}
		public static object? CreateEmptyDbProcedure(string DbConfName, string ProcedureName)
		{
			return HostingMethods.CreateEmptyDbProcedure(DbConfName, ProcedureName);
		}
		public static object? CreateEmptyDbScalarFunction(string DbConfName, string ScalarFunctionName)
		{
			return HostingMethods.CreateEmptyDbScalarFunction(DbConfName, ScalarFunctionName);
		}
		public static object? CreateEmptyDbTableFunction(string DbConfName, string TableFunctionName)
		{
			return HostingMethods.CreateEmptyDbTableFunction(DbConfName, TableFunctionName);
		}
		public static object? AlterObjectScript(string DbConfName, string ObjectScript)
		{
			return HostingMethods.AlterObjectScript(DbConfName, ObjectScript);
		}
		public static object? RenameObject(string DbConfName, string ObjectName_Old, string ObjectName_New, string ObjectType)
		{
			return HostingMethods.RenameObject(DbConfName, ObjectName_Old, ObjectName_New, ObjectType);
		}
		public static object? DeleteObject(string DbConfName, string ObjectName, string ObjectType)
		{
			return HostingMethods.DropObject(DbConfName, ObjectName, ObjectType);
		}
		public static object? DropFk(string DbConfName, string ObjectName, string FkName)
		{
			return HostingMethods.DropFk(DbConfName, ObjectName, FkName);
		}
		public static object? TruncateTable(string DbConfName, string TableName)
		{
			return HostingMethods.TruncateTable(DbConfName, TableName);
		}
		public static object? SaveTableSchema(string DbConfName, JsonElement TableDef)
        {
            return HostingMethods.SaveTableSchema(DbConfName, TableDef);
        }
        public static object? ReadObjectSchema(string DbConfName, string ObjectName)
        {
            return HostingMethods.ReadObjectSchema(DbConfName, ObjectName);
        }
		public static object? GetDbTables(string DbConfName)
		{
			return HostingMethods.GetDbTables(DbConfName);
		}



		public static object? GetMethodSettings(string NamespaceName, string ClassName, string MethodName)
		{
			return HostingMethods.GetMethodSettings(NamespaceName, ClassName, MethodName);
		}
		public static object? WriteMethodSettings(string NamespaceName, string ClassName, string MethodName, JsonElement NewMethodSettings)
		{
			return HostingMethods.WriteMethodSettings(NamespaceName, ClassName, MethodName, NewMethodSettings);
		}



		public static object? GetDataSources()
        {
            return HostingMethods.GetDataSources();
        }
        public static object? GetDataSourcesWithCnn()
        {
            return HostingMethods.GetDataSourcesWithCnn();
        }
        public static object? AddOrUpdateDbServer(JsonElement DataSourceInfo)
        {
            return HostingMethods.AddOrUpdateDbServer(DataSourceInfo);
        }
        public static object? RemoveDbServer(string DbServerName)
        {
            return HostingMethods.RemoveDbServer(DbServerName);
        }



        public static object? GetFolderContent(string PathToRead)
        {
            return HostingMethods.GetFolderContent(PathToRead);
        }
        public static object? GetFileContent(string PathToRead)
        {
            return HostingMethods.GetFileContent(PathToRead);
        }
        public static object? SaveFileContent(string PathToWrite, string FileContent)
        {
            return HostingMethods.SaveFileContent(PathToWrite, FileContent);
        }
		public static object? GetStoredApiCalls()
		{
			return HostingMethods.GetStoredApiCalls();
		}
		public static object? ExtractTranslationKeys(string FolderName)
		{
			return HostingMethods.ExtractTranslationKeys(FolderName);
		}
		public static object? RemoveTheme(string FolderName)
		{
			return HostingMethods.RemoveTheme(FolderName);
		}
		public static object? DuplicateTheme(string OrigFolderName, string CopyFolderName)
		{
			return HostingMethods.DuplicateTheme(OrigFolderName, CopyFolderName);
		}
		public static object? SetThemeProps(string OrigFolderName, string FolderName, string Title, string SubTitle)
		{
			return HostingMethods.SetThemeProps(OrigFolderName, FolderName, Title, SubTitle);
		}
		public static object? GetThemes()
		{
			return HostingMethods.GetThemes();
		}
		public static object? GetUiComponents(string FolderName)
		{
			return HostingMethods.GetUiComponents(FolderName);
		}
		public static object? FolderHasContent(string PathToCheck)
		{
			return HostingMethods.FolderHasContent(PathToCheck);
		}
		public static object? CreateEmptyComponent(string ComponentFullPath)
		{
			return HostingMethods.CreateEmptyComponent(ComponentFullPath);
		}
		public static object? RenameFileItem(string FilePath, string NewFilePath)
		{
			return HostingMethods.RenameFileItem(FilePath, NewFilePath);
		}
		public static object? DuplicateFileItem(string FilePath)
		{
			return HostingMethods.DuplicateFileItem(FilePath);
		}
		public static object? DeleteFileItem(string FilePath)
		{
			return HostingMethods.DeleteFileItem(FilePath);
		}
		public static object? DeleteFolderItem(string PathToDelete, bool Recursive)
		{
			return HostingMethods.DeleteFolderItem(PathToDelete, Recursive);
		}
		public static object? CreateNewFolder(string PathToCreate, string NewFolderName)
		{
			return HostingMethods.CreateNewFolder(PathToCreate, NewFolderName);
		}



		public static object? RemoveAllCacheItems()
		{
			HostingMethods.RemoveAllCacheItems();
			return true;
		}
		public static object? GetCacheItems(string LikeStr)
		{
			return HostingMethods.GetCacheItems(LikeStr);
		}
		public static object? GetCacheItem(string Key)
		{
			return HostingMethods.GetCacheItem(Key);
		}
		public static object? RemoveCacheItem(string Key)
		{
			return HostingMethods.RemoveCacheItem(Key);
		}



		public static void AppEndSuccessLogger(MethodInfo methodInfo, string actor, string methodFullPath, string clientInfo, CodeInvokeResult codeInvokeResult, object[]? inputParams)
        {
            JObject joLogContent = HostingMethods.CreateStandardLogContent(methodInfo, actor, methodFullPath, clientInfo, codeInvokeResult, inputParams);
            AppEndEventLogger.Add(joLogContent);
        }
		public static void AppEndErrorLogger(MethodInfo methodInfo, string actor, string methodFullPath, string clientInfo, CodeInvokeResult codeInvokeResult, object[]? inputParams)
		{
			JObject joLogContent = HostingMethods.CreateStandardLogContent(methodInfo, actor, methodFullPath, clientInfo, codeInvokeResult, inputParams);
			StaticMethods.LogImmed(joLogContent.ToJsonStringByNewtonsoft(), "log", "", $"{methodFullPath}-{actor}-{codeInvokeResult.IsSucceeded}-");
		}
		public static void AppEndStartWritingLogItems()
		{
            List<JObject> logRecords = AppEndEventLogger.GetAndCleanupEvents();
			string cmd = "";
			foreach ( JObject logRecord in logRecords )
            {
                cmd += $"INSERT INTO Common_ActivityLog (Method,IsSucceeded,FromCache,RecordId,EventBy,EventOn,Duration,ClientInfo) VALUES ('{logRecord["Method"]}',{logRecord["IsSucceeded"].ToBooleanSafe().To01Safe()},{logRecord["FromCache"].ToBooleanSafe().To01Safe()},'{logRecord["RecordId"]}','{logRecord["EventBy"]}','{logRecord["EventOn"]}',{logRecord["Duration"]},'{logRecord["ClientInfo"]}');" + SV.NL;
            }
            DbSchemaUtils dbSchemaUtils = new(AppEndSettings.LogDbConfName);
            dbSchemaUtils.DbIOInstance.ToNoneQueryAsync(cmd);
		}


		public static object? SaveUserSettings(AppEndUser? Actor, string Settings)
		{
			if (Actor == null) return false;
			string sqlUpdateUserSettings = "UPDATE AAA_Users SET Settings=N'" + Settings + "' WHERE Id=" + Actor.Id;
			DbIO dbIO = DbIO.Instance(DbConf.FromSettings(AppEndSettings.LoginDbConfName));
			dbIO.ToNoneQuery(sqlUpdateUserSettings);
			return true;
		}
		public static object? Login(string UserName, string Password)
		{
			Dictionary<string, object> kvp = [];
			if (UserName.ToStringEmpty() == "" || Password.ToStringEmpty() == "")
			{
				kvp.Add("Result", false);
			}
			else
			{
				DataRow? drUser = GetUserRow(UserName);
				if (drUser is not null)
				{
					string pass = drUser["Password"].ToStringEmpty();

					if ((pass == Password.GetMD4Hash() || pass == Password.GetMD5Hash()) && drUser["LoginLocked"].ToBooleanSafe() == false && drUser["IsActive"].ToBooleanSafe(true) == true)
					{
						AppEndUser appEndUser = CreateAppEndUserByIdAndUserName(drUser["Id"].ToIntSafe(), drUser["UserName"].ToStringEmpty());
						UpdateLoginTry(drUser["Id"].ToIntSafe(),true, -1);
						kvp.Add("token", appEndUser.CreateToken());
						kvp.Add("Result", true);
					}
					else
					{
						if (drUser["LoginTryFails"].ToIntSafe(0) < 4)
						{
							UpdateLoginTry(drUser["Id"].ToIntSafe(), false, drUser["LoginTryFails"].ToIntSafe(0));
						}
						else
						{
							UpdateLoginLocked(drUser["Id"].ToIntSafe(), true);
						}
						kvp.Add("Result", false);
					}
				}
				else
				{
					kvp.Add("Result", false);
				}
			}

			return kvp;
		}
		public static object? LoginAs(string UserName)
		{
			Dictionary<string, object> kvp = [];
			if (UserName.ToStringEmpty() == "")
			{
				kvp.Add("Result", false);
			}
			else
			{
				DataRow? drUser = GetUserRow(UserName);
				if (drUser != null)
				{
					kvp.Add("token", CreateAppEndUserByIdAndUserName(drUser["Id"].ToIntSafe(), drUser["UserName"].ToStringEmpty()).CreateToken());
					kvp.Add("Result", true);
				}
				else
				{
					kvp.Add("Result", false);
				}
			}
			return kvp;
		}
		public static object? ChangePassword(AppEndUser? Actor, string OldPassword, string NewPassword)
		{
			if (Actor is null) return false;
			DataRow? drUser = GetUserRow(Actor.UserName);
			if (drUser is null) return null;
			if (drUser["Password"].ToStringEmpty() != OldPassword.GetMD4Hash() && drUser["Password"].ToStringEmpty() != OldPassword.GetMD5Hash()) return false;
			string sql = "UPDATE AAA_Users SET PasswordUpdatedBy=" + Actor.ContextInfo?["UserId"] + ",PasswordUpdatedOn=GETDATE(),Password='" + NewPassword.GetMD5Hash() + "' WHERE Id=" + drUser["Id"];
			DbIO dbIO = DbIO.Instance(DbConf.FromSettings(AppEndSettings.LoginDbConfName));
			dbIO.ToNoneQuery(sql);
			return true;
		}
		public static object? Logout(AppEndUser? Actor)
		{
			if (Actor == null) return false;
			SV.SharedMemoryCache.TryRemove(Actor.ContextCacheKey());
			return true;
		}
		public static object? Signup()
		{
			return true;
		}
		public static Dictionary<string, object> CreateUserClientContext(AppEndUser Actor)
		{
			if (Actor is null) return [];

			AppEndUser newActor = CreateAppEndUserByIdAndUserName(Actor.Id, Actor.UserName);

			Dictionary<string, object> r = DynaCode.GetAllAllowdAndDeniedActions(Actor);

			r.Add("IsPublicKey", AppEndSettings.PublicKeyUser.EqualsIgnoreCase(Actor.UserName));
			r.Add("HasPublicKeyRole", newActor.Roles.ContainsIgnoreCase(AppEndSettings.PublicKeyRole.ToLower()));

			string sqlUserRecord = "SELECT Id,UserName,Email,Mobile,Picture_FileBody,Picture_FileBody_xs,Settings FROM AAA_Users WHERE UserName='" + Actor.UserName + "'";
			DbIO dbIO = DbIO.Instance(DbConf.FromSettings(AppEndSettings.LoginDbConfName));
			DataRow drUser = dbIO.ToDataTable(sqlUserRecord)["Master"].Rows[0];
			r.Add("Email", drUser["Email"] is System.DBNull ? "" : drUser["Email"].ToStringEmpty());
			r.Add("Mobile", drUser["Mobile"] is System.DBNull ? "" : drUser["Mobile"].ToStringEmpty());
			r.Add("Picture_FileBody", drUser["Picture_FileBody"] is System.DBNull ? "" : (byte[])drUser["Picture_FileBody"]);
			r.Add("Picture_FileBody_xs", drUser["Picture_FileBody_xs"] is System.DBNull ? "" : (byte[])drUser["Picture_FileBody_xs"]);

			r.Add("Settings", drUser["Settings"] is System.DBNull || drUser["Settings"].ToStringEmpty() == "" ? "{}" : (string)drUser["Settings"]);

			r.Add("NewToken", newActor.CreateToken());

			return r;
		}
		public static Hashtable CreateUserServerContext(AppEndUser? Actor)
		{
			// Dont remove Roles , Just add your own keys if needed
			Hashtable r = new()
			{
				{ "Roles",  GetAppEndUserRoles(Actor?.Id) }
			};
			return r;
		}
		public static object? GetLogedInUserContext(AppEndUser? Actor)
		{
			if (Actor == null) return null;
			Dictionary<string, object> r = CreateUserClientContext(Actor);
			return r;
		}
		private static DataRow? GetUserRow(string UserName)
		{
			string un = UserName.Replace("'", "").Replace(" ", "").Replace("=", "");
			string sqlUserRecord = "SELECT Id,UserName,Email,Mobile,Password,IsActive,LoginLocked,LoginTry,LoginTryFails,LoginTryOn FROM AAA_Users WHERE UserName='" + un + "'";
			DbIO dbIO = DbIO.Instance(DbConf.FromSettings(AppEndSettings.LoginDbConfName));
			DataTable dtUser = dbIO.ToDataTable(sqlUserRecord)["Master"];
			if (dtUser.Rows.Count > 0) return dtUser.Rows[0];
			return null;
		}
		private static AppEndUser CreateAppEndUserByIdAndUserName(int Id, string UserName)
		{
			return new() { Id = Id, UserName = UserName, Roles = [.. GetAppEndUserRoles(Id)] };
		}

		private static List<string> GetAppEndUserRoles(int? userId)
		{
			List<string> roles = [];
			if (userId is null) return roles;
			string sqlRoles = "SELECT RoleName FROM AAA_Users_R_Roles LEFT OUTER JOIN AAA_Roles ON AAA_Users_R_Roles.RoleId=AAA_Roles.Id WHERE UserId=" + userId;
			DbIO dbIO = DbIO.Instance(DbConf.FromSettings(AppEndSettings.LoginDbConfName));
			DataTable dtRoles = dbIO.ToDataTable(sqlRoles)["Master"];
			if (dtRoles.Rows.Count > 0)
			{
				foreach (DataRow dr in dtRoles.Rows)
				{
					roles.Add(dr["RoleName"].ToStringEmpty());
				}
			}
			return roles;
		}

		private static void UpdateLoginTry(int userId, bool res, int count)
		{
			string sql = "UPDATE AAA_Users SET LoginTry=" + (res == true ? "1" : "0") + ",LoginTryOn=GETDATE(),LoginTryFails=" + (count == -1 ? "0" : "ISNULL(LoginTryFails,0)+1") + " WHERE Id=" + userId;
			DbIO dbIO = DbIO.Instance(DbConf.FromSettings(AppEndSettings.LoginDbConfName));
			dbIO.ToNoneQuery(sql);
		}
		private static void UpdateLoginLocked(int userId, bool lockState)
		{
			string sql = "UPDATE AAA_Users SET LoginLockedUpdatedOn=GETDATE(),LoginLocked=" + (lockState == true ? "1" : "0") + " WHERE Id=" + userId;
			DbIO dbIO = DbIO.Instance(DbConf.FromSettings(AppEndSettings.LoginDbConfName));
			dbIO.ToNoneQuery(sql);
		}



		public static object? GetDynaClasses()
		{
			return HostingMethods.GetDynaClasses();
		}
		public static object? RebuildProject()
		{
			return HostingMethods.RebuildProject();
		}
		public static object? GetAppEndSummary()
		{
			return HostingMethods.GetAppEndSummary();
		}
		public static object? PingMe()
		{
			return "I am at your service :)";
		}

		public static object? GetNodes()
		{
			return HostingMethods.GetNodes();
		}
		public static object? RemoveNode(string Ind)
		{
			HostingMethods.RemoveNode(Ind);
			return true;
		}
		public static object? CreateUpdateNode(int Ind, string Ip, string Port, string Name, string UserName, string Password)
		{
			HostingMethods.CreateUpdateNode(Ind, Ip, Port, Name, UserName, Password);
			return true;
		}

	}
}

