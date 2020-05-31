using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Loader
{
    class Json
    {
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000069DF File Offset: 0x00004BDF
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000069E7 File Offset: 0x00004BE7
		[JsonProperty("code")]
		public string exchangecode { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000069F0 File Offset: 0x00004BF0
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000069F8 File Offset: 0x00004BF8
		[JsonProperty("access_token")]
		public string access_token { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00006A01 File Offset: 0x00004C01
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00006A09 File Offset: 0x00004C09
		[JsonProperty("account_id")]
		public string account_id { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00006A12 File Offset: 0x00004C12
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00006A1A File Offset: 0x00004C1A
		[JsonProperty("id")]
		public string id { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00006A23 File Offset: 0x00004C23
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00006A2B File Offset: 0x00004C2B
		[JsonProperty("displayName")]
		public string displayName { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00006A34 File Offset: 0x00004C34
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00006A3C File Offset: 0x00004C3C
		[JsonProperty("name")]
		public string first_name { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00006A45 File Offset: 0x00004C45
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00006A4D File Offset: 0x00004C4D
		[JsonProperty("email")]
		public string email { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00006A56 File Offset: 0x00004C56
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00006A5E File Offset: 0x00004C5E
		[JsonProperty("lastLogin")]
		public string lastLogin { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00006A67 File Offset: 0x00004C67
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00006A6F File Offset: 0x00004C6F
		[JsonProperty("numberOfDisplayNameChanges")]
		public string numberOfDisplayNameChanges { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00006A78 File Offset: 0x00004C78
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00006A80 File Offset: 0x00004C80
		[JsonProperty("emailVerified")]
		public string emailVerified { get; set; }
		
		[JsonProperty("country")]
		public string country { get; set; }
		
		[JsonProperty("phoneNumber")]
		public string phoneNumber { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00006A89 File Offset: 0x00004C89
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00006A91 File Offset: 0x00004C91
		[JsonProperty("lastName")]
		public string lastName { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00006A9A File Offset: 0x00004C9A
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00006AA2 File Offset: 0x00004CA2
		[JsonProperty("type")]
		public string type { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00006AAB File Offset: 0x00004CAB
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00006AB3 File Offset: 0x00004CB3
		[JsonProperty("profile")]
		public string profile { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00006ABC File Offset: 0x00004CBC
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00006AC4 File Offset: 0x00004CC4
		[JsonProperty("created")]
		public string created { get; set; }
	}
}
