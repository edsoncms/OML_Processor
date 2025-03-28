using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssOMLProcessor {

	/// <summary>
	/// Structure <code>RCEntityInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEntityInfoRecord: ISerializable, ITypedRecord<RCEntityInfoRecord> {
		internal static readonly GlobalObjectKey IdEntityInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8V6zAVUJiiKs2Hg6R28Fng");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EntityInfo")]
		public STEntityInfoStructure ssSTEntityInfo;


		public static implicit operator STEntityInfoStructure(RCEntityInfoRecord r) {
			return r.ssSTEntityInfo;
		}

		public static implicit operator RCEntityInfoRecord(STEntityInfoStructure r) {
			RCEntityInfoRecord res = new RCEntityInfoRecord(null);
			res.ssSTEntityInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEntityInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEntityInfo = new STEntityInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEntityInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEntityInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEntityInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCEntityInfoRecord a, RCEntityInfoRecord b) {
			if (a.ssSTEntityInfo != b.ssSTEntityInfo) return false;
			return true;
		}

		public static bool operator != (RCEntityInfoRecord a, RCEntityInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEntityInfoRecord)) return false;
			return (this == (RCEntityInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEntityInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEntityInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEntityInfo = new STEntityInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEntityInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEntityInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEntityInfo = (STEntityInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEntityInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEntityInfo.InternalRecursiveSave();
		}


		public RCEntityInfoRecord Duplicate() {
			RCEntityInfoRecord t;
			t.ssSTEntityInfo = (STEntityInfoStructure) this.ssSTEntityInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEntityInfo.ToXml(this, recordElem, "EntityInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "entityinfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EntityInfo")) variable.Value = ssSTEntityInfo; else variable.Optimized = true;
				variable.SetFieldName("entityinfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEntityInfo) {
				return ssSTEntityInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEntityInfo.FillFromOther((IRecord) other.AttributeGet(IdEntityInfo));
		}
		public bool IsDefault() {
			RCEntityInfoRecord defaultStruct = new RCEntityInfoRecord(null);
			if (this.ssSTEntityInfo != defaultStruct.ssSTEntityInfo) return false;
			return true;
		}
	} // RCEntityInfoRecord

	/// <summary>
	/// Structure <code>RCExtensionInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCExtensionInfoRecord: ISerializable, ITypedRecord<RCExtensionInfoRecord> {
		internal static readonly GlobalObjectKey IdExtensionInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9Eq4sZCwKDBm_6R9IdWOeA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ExtensionInfo")]
		public STExtensionInfoStructure ssSTExtensionInfo;


		public static implicit operator STExtensionInfoStructure(RCExtensionInfoRecord r) {
			return r.ssSTExtensionInfo;
		}

		public static implicit operator RCExtensionInfoRecord(STExtensionInfoStructure r) {
			RCExtensionInfoRecord res = new RCExtensionInfoRecord(null);
			res.ssSTExtensionInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCExtensionInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTExtensionInfo = new STExtensionInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTExtensionInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTExtensionInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCExtensionInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCExtensionInfoRecord a, RCExtensionInfoRecord b) {
			if (a.ssSTExtensionInfo != b.ssSTExtensionInfo) return false;
			return true;
		}

		public static bool operator != (RCExtensionInfoRecord a, RCExtensionInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCExtensionInfoRecord)) return false;
			return (this == (RCExtensionInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTExtensionInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCExtensionInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTExtensionInfo = new STExtensionInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTExtensionInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTExtensionInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTExtensionInfo = (STExtensionInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTExtensionInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTExtensionInfo.InternalRecursiveSave();
		}


		public RCExtensionInfoRecord Duplicate() {
			RCExtensionInfoRecord t;
			t.ssSTExtensionInfo = (STExtensionInfoStructure) this.ssSTExtensionInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTExtensionInfo.ToXml(this, recordElem, "ExtensionInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "extensioninfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtensionInfo")) variable.Value = ssSTExtensionInfo; else variable.Optimized = true;
				variable.SetFieldName("extensioninfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdExtensionInfo) {
				return ssSTExtensionInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTExtensionInfo.FillFromOther((IRecord) other.AttributeGet(IdExtensionInfo));
		}
		public bool IsDefault() {
			RCExtensionInfoRecord defaultStruct = new RCExtensionInfoRecord(null);
			if (this.ssSTExtensionInfo != defaultStruct.ssSTExtensionInfo) return false;
			return true;
		}
	} // RCExtensionInfoRecord

	/// <summary>
	/// Structure <code>RCHEMessageRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCHEMessageRecord: ISerializable, ITypedRecord<RCHEMessageRecord> {
		internal static readonly GlobalObjectKey IdHEMessage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SVzy0SdgwfJLrS63SrIFKw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("HEMessage")]
		public STHEMessageStructure ssSTHEMessage;


		public static implicit operator STHEMessageStructure(RCHEMessageRecord r) {
			return r.ssSTHEMessage;
		}

		public static implicit operator RCHEMessageRecord(STHEMessageStructure r) {
			RCHEMessageRecord res = new RCHEMessageRecord(null);
			res.ssSTHEMessage = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCHEMessageRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTHEMessage = new STHEMessageStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTHEMessage.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTHEMessage.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCHEMessageRecord r) {
			this = r;
		}


		public static bool operator == (RCHEMessageRecord a, RCHEMessageRecord b) {
			if (a.ssSTHEMessage != b.ssSTHEMessage) return false;
			return true;
		}

		public static bool operator != (RCHEMessageRecord a, RCHEMessageRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCHEMessageRecord)) return false;
			return (this == (RCHEMessageRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTHEMessage.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCHEMessageRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTHEMessage = new STHEMessageStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTHEMessage", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTHEMessage' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTHEMessage = (STHEMessageStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTHEMessage.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTHEMessage.InternalRecursiveSave();
		}


		public RCHEMessageRecord Duplicate() {
			RCHEMessageRecord t;
			t.ssSTHEMessage = (STHEMessageStructure) this.ssSTHEMessage.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTHEMessage.ToXml(this, recordElem, "HEMessage", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "hemessage") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".HEMessage")) variable.Value = ssSTHEMessage; else variable.Optimized = true;
				variable.SetFieldName("hemessage");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdHEMessage) {
				return ssSTHEMessage;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTHEMessage.FillFromOther((IRecord) other.AttributeGet(IdHEMessage));
		}
		public bool IsDefault() {
			RCHEMessageRecord defaultStruct = new RCHEMessageRecord(null);
			if (this.ssSTHEMessage != defaultStruct.ssSTHEMessage) return false;
			return true;
		}
	} // RCHEMessageRecord

	/// <summary>
	/// Structure <code>RCHubNodeStatusRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCHubNodeStatusRecord: ISerializable, ITypedRecord<RCHubNodeStatusRecord> {
		internal static readonly GlobalObjectKey IdHubNodeStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TFloGFvLlFazLrrD06X9Mw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("HubNodeStatus")]
		public STHubNodeStatusStructure ssSTHubNodeStatus;


		public static implicit operator STHubNodeStatusStructure(RCHubNodeStatusRecord r) {
			return r.ssSTHubNodeStatus;
		}

		public static implicit operator RCHubNodeStatusRecord(STHubNodeStatusStructure r) {
			RCHubNodeStatusRecord res = new RCHubNodeStatusRecord(null);
			res.ssSTHubNodeStatus = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCHubNodeStatusRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTHubNodeStatus = new STHubNodeStatusStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTHubNodeStatus.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTHubNodeStatus.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCHubNodeStatusRecord r) {
			this = r;
		}


		public static bool operator == (RCHubNodeStatusRecord a, RCHubNodeStatusRecord b) {
			if (a.ssSTHubNodeStatus != b.ssSTHubNodeStatus) return false;
			return true;
		}

		public static bool operator != (RCHubNodeStatusRecord a, RCHubNodeStatusRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCHubNodeStatusRecord)) return false;
			return (this == (RCHubNodeStatusRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTHubNodeStatus.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCHubNodeStatusRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTHubNodeStatus = new STHubNodeStatusStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTHubNodeStatus", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTHubNodeStatus' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTHubNodeStatus = (STHubNodeStatusStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTHubNodeStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTHubNodeStatus.InternalRecursiveSave();
		}


		public RCHubNodeStatusRecord Duplicate() {
			RCHubNodeStatusRecord t;
			t.ssSTHubNodeStatus = (STHubNodeStatusStructure) this.ssSTHubNodeStatus.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTHubNodeStatus.ToXml(this, recordElem, "HubNodeStatus", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "hubnodestatus") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".HubNodeStatus")) variable.Value = ssSTHubNodeStatus; else variable.Optimized = true;
				variable.SetFieldName("hubnodestatus");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdHubNodeStatus) {
				return ssSTHubNodeStatus;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTHubNodeStatus.FillFromOther((IRecord) other.AttributeGet(IdHubNodeStatus));
		}
		public bool IsDefault() {
			RCHubNodeStatusRecord defaultStruct = new RCHubNodeStatusRecord(null);
			if (this.ssSTHubNodeStatus != defaultStruct.ssSTHubNodeStatus) return false;
			return true;
		}
	} // RCHubNodeStatusRecord

	/// <summary>
	/// Structure <code>RCOmlReportRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCOmlReportRecord: ISerializable, ITypedRecord<RCOmlReportRecord> {
		internal static readonly GlobalObjectKey IdOmlReport = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ziv+TXANeC+yVCXMTdKEyQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("OmlReport")]
		public STOmlReportStructure ssSTOmlReport;


		public static implicit operator STOmlReportStructure(RCOmlReportRecord r) {
			return r.ssSTOmlReport;
		}

		public static implicit operator RCOmlReportRecord(STOmlReportStructure r) {
			RCOmlReportRecord res = new RCOmlReportRecord(null);
			res.ssSTOmlReport = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCOmlReportRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTOmlReport = new STOmlReportStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTOmlReport.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTOmlReport.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCOmlReportRecord r) {
			this = r;
		}


		public static bool operator == (RCOmlReportRecord a, RCOmlReportRecord b) {
			if (a.ssSTOmlReport != b.ssSTOmlReport) return false;
			return true;
		}

		public static bool operator != (RCOmlReportRecord a, RCOmlReportRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCOmlReportRecord)) return false;
			return (this == (RCOmlReportRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTOmlReport.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCOmlReportRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTOmlReport = new STOmlReportStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTOmlReport", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTOmlReport' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTOmlReport = (STOmlReportStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTOmlReport.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTOmlReport.InternalRecursiveSave();
		}


		public RCOmlReportRecord Duplicate() {
			RCOmlReportRecord t;
			t.ssSTOmlReport = (STOmlReportStructure) this.ssSTOmlReport.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTOmlReport.ToXml(this, recordElem, "OmlReport", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "omlreport") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".OmlReport")) variable.Value = ssSTOmlReport; else variable.Optimized = true;
				variable.SetFieldName("omlreport");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdOmlReport) {
				return ssSTOmlReport;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTOmlReport.FillFromOther((IRecord) other.AttributeGet(IdOmlReport));
		}
		public bool IsDefault() {
			RCOmlReportRecord defaultStruct = new RCOmlReportRecord(null);
			if (this.ssSTOmlReport != defaultStruct.ssSTOmlReport) return false;
			return true;
		}
	} // RCOmlReportRecord

	/// <summary>
	/// Structure <code>RCQueueStatusRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCQueueStatusRecord: ISerializable, ITypedRecord<RCQueueStatusRecord> {
		internal static readonly GlobalObjectKey IdQueueStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nIa7lV6H8UbnpYO5hfZ7Ww");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("QueueStatus")]
		public STQueueStatusStructure ssSTQueueStatus;


		public static implicit operator STQueueStatusStructure(RCQueueStatusRecord r) {
			return r.ssSTQueueStatus;
		}

		public static implicit operator RCQueueStatusRecord(STQueueStatusStructure r) {
			RCQueueStatusRecord res = new RCQueueStatusRecord(null);
			res.ssSTQueueStatus = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCQueueStatusRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTQueueStatus = new STQueueStatusStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTQueueStatus.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTQueueStatus.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCQueueStatusRecord r) {
			this = r;
		}


		public static bool operator == (RCQueueStatusRecord a, RCQueueStatusRecord b) {
			if (a.ssSTQueueStatus != b.ssSTQueueStatus) return false;
			return true;
		}

		public static bool operator != (RCQueueStatusRecord a, RCQueueStatusRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCQueueStatusRecord)) return false;
			return (this == (RCQueueStatusRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTQueueStatus.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCQueueStatusRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTQueueStatus = new STQueueStatusStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTQueueStatus", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTQueueStatus' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTQueueStatus = (STQueueStatusStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTQueueStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTQueueStatus.InternalRecursiveSave();
		}


		public RCQueueStatusRecord Duplicate() {
			RCQueueStatusRecord t;
			t.ssSTQueueStatus = (STQueueStatusStructure) this.ssSTQueueStatus.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTQueueStatus.ToXml(this, recordElem, "QueueStatus", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "queuestatus") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".QueueStatus")) variable.Value = ssSTQueueStatus; else variable.Optimized = true;
				variable.SetFieldName("queuestatus");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdQueueStatus) {
				return ssSTQueueStatus;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTQueueStatus.FillFromOther((IRecord) other.AttributeGet(IdQueueStatus));
		}
		public bool IsDefault() {
			RCQueueStatusRecord defaultStruct = new RCQueueStatusRecord(null);
			if (this.ssSTQueueStatus != defaultStruct.ssSTQueueStatus) return false;
			return true;
		}
	} // RCQueueStatusRecord

	/// <summary>
	/// Structure <code>RCThreadStatusRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCThreadStatusRecord: ISerializable, ITypedRecord<RCThreadStatusRecord> {
		internal static readonly GlobalObjectKey IdThreadStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WYGsmaBTIdJoUxz0VyQo9A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ThreadStatus")]
		public STThreadStatusStructure ssSTThreadStatus;


		public static implicit operator STThreadStatusStructure(RCThreadStatusRecord r) {
			return r.ssSTThreadStatus;
		}

		public static implicit operator RCThreadStatusRecord(STThreadStatusStructure r) {
			RCThreadStatusRecord res = new RCThreadStatusRecord(null);
			res.ssSTThreadStatus = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCThreadStatusRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTThreadStatus = new STThreadStatusStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTThreadStatus.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTThreadStatus.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCThreadStatusRecord r) {
			this = r;
		}


		public static bool operator == (RCThreadStatusRecord a, RCThreadStatusRecord b) {
			if (a.ssSTThreadStatus != b.ssSTThreadStatus) return false;
			return true;
		}

		public static bool operator != (RCThreadStatusRecord a, RCThreadStatusRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCThreadStatusRecord)) return false;
			return (this == (RCThreadStatusRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTThreadStatus.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCThreadStatusRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTThreadStatus = new STThreadStatusStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTThreadStatus", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTThreadStatus' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTThreadStatus = (STThreadStatusStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTThreadStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTThreadStatus.InternalRecursiveSave();
		}


		public RCThreadStatusRecord Duplicate() {
			RCThreadStatusRecord t;
			t.ssSTThreadStatus = (STThreadStatusStructure) this.ssSTThreadStatus.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTThreadStatus.ToXml(this, recordElem, "ThreadStatus", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "threadstatus") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ThreadStatus")) variable.Value = ssSTThreadStatus; else variable.Optimized = true;
				variable.SetFieldName("threadstatus");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdThreadStatus) {
				return ssSTThreadStatus;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTThreadStatus.FillFromOther((IRecord) other.AttributeGet(IdThreadStatus));
		}
		public bool IsDefault() {
			RCThreadStatusRecord defaultStruct = new RCThreadStatusRecord(null);
			if (this.ssSTThreadStatus != defaultStruct.ssSTThreadStatus) return false;
			return true;
		}
	} // RCThreadStatusRecord

	/// <summary>
	/// Structure <code>RCActionInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCActionInfoRecord: ISerializable, ITypedRecord<RCActionInfoRecord> {
		internal static readonly GlobalObjectKey IdActionInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vmSyBcq3R033fwBrwe_JiQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ActionInfo")]
		public STActionInfoStructure ssSTActionInfo;


		public static implicit operator STActionInfoStructure(RCActionInfoRecord r) {
			return r.ssSTActionInfo;
		}

		public static implicit operator RCActionInfoRecord(STActionInfoStructure r) {
			RCActionInfoRecord res = new RCActionInfoRecord(null);
			res.ssSTActionInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCActionInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTActionInfo = new STActionInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTActionInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTActionInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCActionInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCActionInfoRecord a, RCActionInfoRecord b) {
			if (a.ssSTActionInfo != b.ssSTActionInfo) return false;
			return true;
		}

		public static bool operator != (RCActionInfoRecord a, RCActionInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCActionInfoRecord)) return false;
			return (this == (RCActionInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTActionInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCActionInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTActionInfo = new STActionInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTActionInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTActionInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTActionInfo = (STActionInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTActionInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTActionInfo.InternalRecursiveSave();
		}


		public RCActionInfoRecord Duplicate() {
			RCActionInfoRecord t;
			t.ssSTActionInfo = (STActionInfoStructure) this.ssSTActionInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTActionInfo.ToXml(this, recordElem, "ActionInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "actioninfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ActionInfo")) variable.Value = ssSTActionInfo; else variable.Optimized = true;
				variable.SetFieldName("actioninfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdActionInfo) {
				return ssSTActionInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTActionInfo.FillFromOther((IRecord) other.AttributeGet(IdActionInfo));
		}
		public bool IsDefault() {
			RCActionInfoRecord defaultStruct = new RCActionInfoRecord(null);
			if (this.ssSTActionInfo != defaultStruct.ssSTActionInfo) return false;
			return true;
		}
	} // RCActionInfoRecord

	/// <summary>
	/// Structure <code>RCStructureInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCStructureInfoRecord: ISerializable, ITypedRecord<RCStructureInfoRecord> {
		internal static readonly GlobalObjectKey IdStructureInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9wd07R02i9Ff6MFJPitkow");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("StructureInfo")]
		public STStructureInfoStructure ssSTStructureInfo;


		public static implicit operator STStructureInfoStructure(RCStructureInfoRecord r) {
			return r.ssSTStructureInfo;
		}

		public static implicit operator RCStructureInfoRecord(STStructureInfoStructure r) {
			RCStructureInfoRecord res = new RCStructureInfoRecord(null);
			res.ssSTStructureInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCStructureInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTStructureInfo = new STStructureInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTStructureInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTStructureInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCStructureInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCStructureInfoRecord a, RCStructureInfoRecord b) {
			if (a.ssSTStructureInfo != b.ssSTStructureInfo) return false;
			return true;
		}

		public static bool operator != (RCStructureInfoRecord a, RCStructureInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCStructureInfoRecord)) return false;
			return (this == (RCStructureInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTStructureInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCStructureInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTStructureInfo = new STStructureInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTStructureInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTStructureInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTStructureInfo = (STStructureInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTStructureInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTStructureInfo.InternalRecursiveSave();
		}


		public RCStructureInfoRecord Duplicate() {
			RCStructureInfoRecord t;
			t.ssSTStructureInfo = (STStructureInfoStructure) this.ssSTStructureInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTStructureInfo.ToXml(this, recordElem, "StructureInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "structureinfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".StructureInfo")) variable.Value = ssSTStructureInfo; else variable.Optimized = true;
				variable.SetFieldName("structureinfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdStructureInfo) {
				return ssSTStructureInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTStructureInfo.FillFromOther((IRecord) other.AttributeGet(IdStructureInfo));
		}
		public bool IsDefault() {
			RCStructureInfoRecord defaultStruct = new RCStructureInfoRecord(null);
			if (this.ssSTStructureInfo != defaultStruct.ssSTStructureInfo) return false;
			return true;
		}
	} // RCStructureInfoRecord

	/// <summary>
	/// Structure <code>RCReferenceImageRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCReferenceImageRecord: ISerializable, ITypedRecord<RCReferenceImageRecord> {
		internal static readonly GlobalObjectKey IdReferenceImage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xZHBIkQXrOR7P9uirdjltQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ReferenceImage")]
		public STReferenceImageStructure ssSTReferenceImage;


		public static implicit operator STReferenceImageStructure(RCReferenceImageRecord r) {
			return r.ssSTReferenceImage;
		}

		public static implicit operator RCReferenceImageRecord(STReferenceImageStructure r) {
			RCReferenceImageRecord res = new RCReferenceImageRecord(null);
			res.ssSTReferenceImage = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCReferenceImageRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTReferenceImage = new STReferenceImageStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTReferenceImage.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTReferenceImage.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCReferenceImageRecord r) {
			this = r;
		}


		public static bool operator == (RCReferenceImageRecord a, RCReferenceImageRecord b) {
			if (a.ssSTReferenceImage != b.ssSTReferenceImage) return false;
			return true;
		}

		public static bool operator != (RCReferenceImageRecord a, RCReferenceImageRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCReferenceImageRecord)) return false;
			return (this == (RCReferenceImageRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTReferenceImage.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCReferenceImageRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTReferenceImage = new STReferenceImageStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTReferenceImage", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTReferenceImage' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTReferenceImage = (STReferenceImageStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTReferenceImage.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTReferenceImage.InternalRecursiveSave();
		}


		public RCReferenceImageRecord Duplicate() {
			RCReferenceImageRecord t;
			t.ssSTReferenceImage = (STReferenceImageStructure) this.ssSTReferenceImage.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTReferenceImage.ToXml(this, recordElem, "ReferenceImage", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "referenceimage") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ReferenceImage")) variable.Value = ssSTReferenceImage; else variable.Optimized = true;
				variable.SetFieldName("referenceimage");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdReferenceImage) {
				return ssSTReferenceImage;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTReferenceImage.FillFromOther((IRecord) other.AttributeGet(IdReferenceImage));
		}
		public bool IsDefault() {
			RCReferenceImageRecord defaultStruct = new RCReferenceImageRecord(null);
			if (this.ssSTReferenceImage != defaultStruct.ssSTReferenceImage) return false;
			return true;
		}
	} // RCReferenceImageRecord

	/// <summary>
	/// Structure <code>RCProcessConfigRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCProcessConfigRecord: ISerializable, ITypedRecord<RCProcessConfigRecord> {
		internal static readonly GlobalObjectKey IdProcessConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zjW2iikGXM3DLR34sO76RA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ProcessConfig")]
		public STProcessConfigStructure ssSTProcessConfig;


		public static implicit operator STProcessConfigStructure(RCProcessConfigRecord r) {
			return r.ssSTProcessConfig;
		}

		public static implicit operator RCProcessConfigRecord(STProcessConfigStructure r) {
			RCProcessConfigRecord res = new RCProcessConfigRecord(null);
			res.ssSTProcessConfig = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCProcessConfigRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTProcessConfig = new STProcessConfigStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTProcessConfig.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTProcessConfig.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCProcessConfigRecord r) {
			this = r;
		}


		public static bool operator == (RCProcessConfigRecord a, RCProcessConfigRecord b) {
			if (a.ssSTProcessConfig != b.ssSTProcessConfig) return false;
			return true;
		}

		public static bool operator != (RCProcessConfigRecord a, RCProcessConfigRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCProcessConfigRecord)) return false;
			return (this == (RCProcessConfigRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTProcessConfig.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCProcessConfigRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTProcessConfig = new STProcessConfigStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTProcessConfig", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTProcessConfig' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTProcessConfig = (STProcessConfigStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTProcessConfig.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTProcessConfig.InternalRecursiveSave();
		}


		public RCProcessConfigRecord Duplicate() {
			RCProcessConfigRecord t;
			t.ssSTProcessConfig = (STProcessConfigStructure) this.ssSTProcessConfig.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTProcessConfig.ToXml(this, recordElem, "ProcessConfig", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "processconfig") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessConfig")) variable.Value = ssSTProcessConfig; else variable.Optimized = true;
				variable.SetFieldName("processconfig");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdProcessConfig) {
				return ssSTProcessConfig;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTProcessConfig.FillFromOther((IRecord) other.AttributeGet(IdProcessConfig));
		}
		public bool IsDefault() {
			RCProcessConfigRecord defaultStruct = new RCProcessConfigRecord(null);
			if (this.ssSTProcessConfig != defaultStruct.ssSTProcessConfig) return false;
			return true;
		}
	} // RCProcessConfigRecord

	/// <summary>
	/// Structure <code>RCProcessMemDataRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCProcessMemDataRecord: ISerializable, ITypedRecord<RCProcessMemDataRecord> {
		internal static readonly GlobalObjectKey IdProcessMemData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MDwAPM1XFzEFxBltcznn2A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ProcessMemData")]
		public STProcessMemDataStructure ssSTProcessMemData;


		public static implicit operator STProcessMemDataStructure(RCProcessMemDataRecord r) {
			return r.ssSTProcessMemData;
		}

		public static implicit operator RCProcessMemDataRecord(STProcessMemDataStructure r) {
			RCProcessMemDataRecord res = new RCProcessMemDataRecord(null);
			res.ssSTProcessMemData = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCProcessMemDataRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTProcessMemData = new STProcessMemDataStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTProcessMemData.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTProcessMemData.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCProcessMemDataRecord r) {
			this = r;
		}


		public static bool operator == (RCProcessMemDataRecord a, RCProcessMemDataRecord b) {
			if (a.ssSTProcessMemData != b.ssSTProcessMemData) return false;
			return true;
		}

		public static bool operator != (RCProcessMemDataRecord a, RCProcessMemDataRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCProcessMemDataRecord)) return false;
			return (this == (RCProcessMemDataRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTProcessMemData.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCProcessMemDataRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTProcessMemData = new STProcessMemDataStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTProcessMemData", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTProcessMemData' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTProcessMemData = (STProcessMemDataStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTProcessMemData.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTProcessMemData.InternalRecursiveSave();
		}


		public RCProcessMemDataRecord Duplicate() {
			RCProcessMemDataRecord t;
			t.ssSTProcessMemData = (STProcessMemDataStructure) this.ssSTProcessMemData.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTProcessMemData.ToXml(this, recordElem, "ProcessMemData", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "processmemdata") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessMemData")) variable.Value = ssSTProcessMemData; else variable.Optimized = true;
				variable.SetFieldName("processmemdata");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdProcessMemData) {
				return ssSTProcessMemData;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTProcessMemData.FillFromOther((IRecord) other.AttributeGet(IdProcessMemData));
		}
		public bool IsDefault() {
			RCProcessMemDataRecord defaultStruct = new RCProcessMemDataRecord(null);
			if (this.ssSTProcessMemData != defaultStruct.ssSTProcessMemData) return false;
			return true;
		}
	} // RCProcessMemDataRecord

	/// <summary>
	/// Structure <code>RCActivationResponseRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCActivationResponseRecord: ISerializable, ITypedRecord<RCActivationResponseRecord> {
		internal static readonly GlobalObjectKey IdActivationResponse = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TjqNbB5JtaMQ9RBddqmqPA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ActivationResponse")]
		public STActivationResponseStructure ssSTActivationResponse;


		public static implicit operator STActivationResponseStructure(RCActivationResponseRecord r) {
			return r.ssSTActivationResponse;
		}

		public static implicit operator RCActivationResponseRecord(STActivationResponseStructure r) {
			RCActivationResponseRecord res = new RCActivationResponseRecord(null);
			res.ssSTActivationResponse = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCActivationResponseRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTActivationResponse = new STActivationResponseStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTActivationResponse.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTActivationResponse.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCActivationResponseRecord r) {
			this = r;
		}


		public static bool operator == (RCActivationResponseRecord a, RCActivationResponseRecord b) {
			if (a.ssSTActivationResponse != b.ssSTActivationResponse) return false;
			return true;
		}

		public static bool operator != (RCActivationResponseRecord a, RCActivationResponseRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCActivationResponseRecord)) return false;
			return (this == (RCActivationResponseRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTActivationResponse.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCActivationResponseRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTActivationResponse = new STActivationResponseStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTActivationResponse", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTActivationResponse' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTActivationResponse = (STActivationResponseStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTActivationResponse.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTActivationResponse.InternalRecursiveSave();
		}


		public RCActivationResponseRecord Duplicate() {
			RCActivationResponseRecord t;
			t.ssSTActivationResponse = (STActivationResponseStructure) this.ssSTActivationResponse.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTActivationResponse.ToXml(this, recordElem, "ActivationResponse", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "activationresponse") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivationResponse")) variable.Value = ssSTActivationResponse; else variable.Optimized = true;
				variable.SetFieldName("activationresponse");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdActivationResponse) {
				return ssSTActivationResponse;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTActivationResponse.FillFromOther((IRecord) other.AttributeGet(IdActivationResponse));
		}
		public bool IsDefault() {
			RCActivationResponseRecord defaultStruct = new RCActivationResponseRecord(null);
			if (this.ssSTActivationResponse != defaultStruct.ssSTActivationResponse) return false;
			return true;
		}
	} // RCActivationResponseRecord

	/// <summary>
	/// Structure <code>RCActivationLicenseInformationRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCActivationLicenseInformationRecord: ISerializable, ITypedRecord<RCActivationLicenseInformationRecord> {
		internal static readonly GlobalObjectKey IdActivationLicenseInformation = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*V2xmVI9TqK4wnO+CmTR3qQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ActivationLicenseInformation")]
		public STActivationLicenseInformationStructure ssSTActivationLicenseInformation;


		public static implicit operator STActivationLicenseInformationStructure(RCActivationLicenseInformationRecord r) {
			return r.ssSTActivationLicenseInformation;
		}

		public static implicit operator RCActivationLicenseInformationRecord(STActivationLicenseInformationStructure r) {
			RCActivationLicenseInformationRecord res = new RCActivationLicenseInformationRecord(null);
			res.ssSTActivationLicenseInformation = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCActivationLicenseInformationRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTActivationLicenseInformation = new STActivationLicenseInformationStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTActivationLicenseInformation.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTActivationLicenseInformation.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCActivationLicenseInformationRecord r) {
			this = r;
		}


		public static bool operator == (RCActivationLicenseInformationRecord a, RCActivationLicenseInformationRecord b) {
			if (a.ssSTActivationLicenseInformation != b.ssSTActivationLicenseInformation) return false;
			return true;
		}

		public static bool operator != (RCActivationLicenseInformationRecord a, RCActivationLicenseInformationRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCActivationLicenseInformationRecord)) return false;
			return (this == (RCActivationLicenseInformationRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTActivationLicenseInformation.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCActivationLicenseInformationRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTActivationLicenseInformation = new STActivationLicenseInformationStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTActivationLicenseInformation", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTActivationLicenseInformation' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTActivationLicenseInformation = (STActivationLicenseInformationStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTActivationLicenseInformation.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTActivationLicenseInformation.InternalRecursiveSave();
		}


		public RCActivationLicenseInformationRecord Duplicate() {
			RCActivationLicenseInformationRecord t;
			t.ssSTActivationLicenseInformation = (STActivationLicenseInformationStructure) this.ssSTActivationLicenseInformation.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTActivationLicenseInformation.ToXml(this, recordElem, "ActivationLicenseInformation", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "activationlicenseinformation") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ActivationLicenseInformation")) variable.Value = ssSTActivationLicenseInformation; else variable.Optimized = true;
				variable.SetFieldName("activationlicenseinformation");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdActivationLicenseInformation) {
				return ssSTActivationLicenseInformation;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTActivationLicenseInformation.FillFromOther((IRecord) other.AttributeGet(IdActivationLicenseInformation));
		}
		public bool IsDefault() {
			RCActivationLicenseInformationRecord defaultStruct = new RCActivationLicenseInformationRecord(null);
			if (this.ssSTActivationLicenseInformation != defaultStruct.ssSTActivationLicenseInformation) return false;
			return true;
		}
	} // RCActivationLicenseInformationRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_SolutionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_SolutionRecord: ISerializable, ITypedRecord<RCSolutionPack_SolutionRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_Solution = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*JW4X9aQr+cFW5mSjZh2e6A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_Solution")]
		public STSolutionPack_SolutionStructure ssSTSolutionPack_Solution;


		public static implicit operator STSolutionPack_SolutionStructure(RCSolutionPack_SolutionRecord r) {
			return r.ssSTSolutionPack_Solution;
		}

		public static implicit operator RCSolutionPack_SolutionRecord(STSolutionPack_SolutionStructure r) {
			RCSolutionPack_SolutionRecord res = new RCSolutionPack_SolutionRecord(null);
			res.ssSTSolutionPack_Solution = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_SolutionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_Solution = new STSolutionPack_SolutionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_Solution.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_Solution.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_SolutionRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_SolutionRecord a, RCSolutionPack_SolutionRecord b) {
			if (a.ssSTSolutionPack_Solution != b.ssSTSolutionPack_Solution) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_SolutionRecord a, RCSolutionPack_SolutionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_SolutionRecord)) return false;
			return (this == (RCSolutionPack_SolutionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_Solution.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_SolutionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_Solution = new STSolutionPack_SolutionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_Solution", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_Solution' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_Solution = (STSolutionPack_SolutionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_Solution.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_Solution.InternalRecursiveSave();
		}


		public RCSolutionPack_SolutionRecord Duplicate() {
			RCSolutionPack_SolutionRecord t;
			t.ssSTSolutionPack_Solution = (STSolutionPack_SolutionStructure) this.ssSTSolutionPack_Solution.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_Solution.ToXml(this, recordElem, "SolutionPack_Solution", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_solution") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_Solution")) variable.Value = ssSTSolutionPack_Solution; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_solution");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_Solution) {
				return ssSTSolutionPack_Solution;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_Solution.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_Solution));
		}
		public bool IsDefault() {
			RCSolutionPack_SolutionRecord defaultStruct = new RCSolutionPack_SolutionRecord(null);
			if (this.ssSTSolutionPack_Solution != defaultStruct.ssSTSolutionPack_Solution) return false;
			return true;
		}
	} // RCSolutionPack_SolutionRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_SolutionReferenceRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_SolutionReferenceRecord: ISerializable, ITypedRecord<RCSolutionPack_SolutionReferenceRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_SolutionReference = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4UAFLS1U2yaCMDWEJVBa2g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_SolutionReference")]
		public STSolutionPack_SolutionReferenceStructure ssSTSolutionPack_SolutionReference;


		public static implicit operator STSolutionPack_SolutionReferenceStructure(RCSolutionPack_SolutionReferenceRecord r) {
			return r.ssSTSolutionPack_SolutionReference;
		}

		public static implicit operator RCSolutionPack_SolutionReferenceRecord(STSolutionPack_SolutionReferenceStructure r) {
			RCSolutionPack_SolutionReferenceRecord res = new RCSolutionPack_SolutionReferenceRecord(null);
			res.ssSTSolutionPack_SolutionReference = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_SolutionReferenceRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionReference = new STSolutionPack_SolutionReferenceStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_SolutionReference.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_SolutionReference.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_SolutionReferenceRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_SolutionReferenceRecord a, RCSolutionPack_SolutionReferenceRecord b) {
			if (a.ssSTSolutionPack_SolutionReference != b.ssSTSolutionPack_SolutionReference) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_SolutionReferenceRecord a, RCSolutionPack_SolutionReferenceRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_SolutionReferenceRecord)) return false;
			return (this == (RCSolutionPack_SolutionReferenceRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_SolutionReference.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_SolutionReferenceRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionReference = new STSolutionPack_SolutionReferenceStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_SolutionReference", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_SolutionReference' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_SolutionReference = (STSolutionPack_SolutionReferenceStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_SolutionReference.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_SolutionReference.InternalRecursiveSave();
		}


		public RCSolutionPack_SolutionReferenceRecord Duplicate() {
			RCSolutionPack_SolutionReferenceRecord t;
			t.ssSTSolutionPack_SolutionReference = (STSolutionPack_SolutionReferenceStructure) this.ssSTSolutionPack_SolutionReference.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_SolutionReference.ToXml(this, recordElem, "SolutionPack_SolutionReference", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_solutionreference") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_SolutionReference")) variable.Value = ssSTSolutionPack_SolutionReference; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_solutionreference");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_SolutionReference) {
				return ssSTSolutionPack_SolutionReference;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_SolutionReference.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_SolutionReference));
		}
		public bool IsDefault() {
			RCSolutionPack_SolutionReferenceRecord defaultStruct = new RCSolutionPack_SolutionReferenceRecord(null);
			if (this.ssSTSolutionPack_SolutionReference != defaultStruct.ssSTSolutionPack_SolutionReference) return false;
			return true;
		}
	} // RCSolutionPack_SolutionReferenceRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_SolutionVersionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_SolutionVersionRecord: ISerializable, ITypedRecord<RCSolutionPack_SolutionVersionRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_SolutionVersion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ugq_87Ace_1ZDeZbHoWRTQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_SolutionVersion")]
		public STSolutionPack_SolutionVersionStructure ssSTSolutionPack_SolutionVersion;


		public static implicit operator STSolutionPack_SolutionVersionStructure(RCSolutionPack_SolutionVersionRecord r) {
			return r.ssSTSolutionPack_SolutionVersion;
		}

		public static implicit operator RCSolutionPack_SolutionVersionRecord(STSolutionPack_SolutionVersionStructure r) {
			RCSolutionPack_SolutionVersionRecord res = new RCSolutionPack_SolutionVersionRecord(null);
			res.ssSTSolutionPack_SolutionVersion = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_SolutionVersionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionVersion = new STSolutionPack_SolutionVersionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_SolutionVersion.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_SolutionVersion.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_SolutionVersionRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_SolutionVersionRecord a, RCSolutionPack_SolutionVersionRecord b) {
			if (a.ssSTSolutionPack_SolutionVersion != b.ssSTSolutionPack_SolutionVersion) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_SolutionVersionRecord a, RCSolutionPack_SolutionVersionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_SolutionVersionRecord)) return false;
			return (this == (RCSolutionPack_SolutionVersionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_SolutionVersion.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_SolutionVersionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionVersion = new STSolutionPack_SolutionVersionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_SolutionVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_SolutionVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_SolutionVersion = (STSolutionPack_SolutionVersionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_SolutionVersion.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_SolutionVersion.InternalRecursiveSave();
		}


		public RCSolutionPack_SolutionVersionRecord Duplicate() {
			RCSolutionPack_SolutionVersionRecord t;
			t.ssSTSolutionPack_SolutionVersion = (STSolutionPack_SolutionVersionStructure) this.ssSTSolutionPack_SolutionVersion.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_SolutionVersion.ToXml(this, recordElem, "SolutionPack_SolutionVersion", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_solutionversion") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_SolutionVersion")) variable.Value = ssSTSolutionPack_SolutionVersion; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_solutionversion");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_SolutionVersion) {
				return ssSTSolutionPack_SolutionVersion;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_SolutionVersion.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_SolutionVersion));
		}
		public bool IsDefault() {
			RCSolutionPack_SolutionVersionRecord defaultStruct = new RCSolutionPack_SolutionVersionRecord(null);
			if (this.ssSTSolutionPack_SolutionVersion != defaultStruct.ssSTSolutionPack_SolutionVersion) return false;
			return true;
		}
	} // RCSolutionPack_SolutionVersionRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_SolutionVersionReferenceRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_SolutionVersionReferenceRecord: ISerializable, ITypedRecord<RCSolutionPack_SolutionVersionReferenceRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_SolutionVersionReference = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fH1b4Ze4i0UgCKw+URKZ1w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_SolutionVersionReference")]
		public STSolutionPack_SolutionVersionReferenceStructure ssSTSolutionPack_SolutionVersionReference;


		public static implicit operator STSolutionPack_SolutionVersionReferenceStructure(RCSolutionPack_SolutionVersionReferenceRecord r) {
			return r.ssSTSolutionPack_SolutionVersionReference;
		}

		public static implicit operator RCSolutionPack_SolutionVersionReferenceRecord(STSolutionPack_SolutionVersionReferenceStructure r) {
			RCSolutionPack_SolutionVersionReferenceRecord res = new RCSolutionPack_SolutionVersionReferenceRecord(null);
			res.ssSTSolutionPack_SolutionVersionReference = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_SolutionVersionReferenceRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionVersionReference = new STSolutionPack_SolutionVersionReferenceStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_SolutionVersionReference.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_SolutionVersionReference.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_SolutionVersionReferenceRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_SolutionVersionReferenceRecord a, RCSolutionPack_SolutionVersionReferenceRecord b) {
			if (a.ssSTSolutionPack_SolutionVersionReference != b.ssSTSolutionPack_SolutionVersionReference) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_SolutionVersionReferenceRecord a, RCSolutionPack_SolutionVersionReferenceRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_SolutionVersionReferenceRecord)) return false;
			return (this == (RCSolutionPack_SolutionVersionReferenceRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_SolutionVersionReference.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_SolutionVersionReferenceRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionVersionReference = new STSolutionPack_SolutionVersionReferenceStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_SolutionVersionReference", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_SolutionVersionReference' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_SolutionVersionReference = (STSolutionPack_SolutionVersionReferenceStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_SolutionVersionReference.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_SolutionVersionReference.InternalRecursiveSave();
		}


		public RCSolutionPack_SolutionVersionReferenceRecord Duplicate() {
			RCSolutionPack_SolutionVersionReferenceRecord t;
			t.ssSTSolutionPack_SolutionVersionReference = (STSolutionPack_SolutionVersionReferenceStructure) this.ssSTSolutionPack_SolutionVersionReference.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_SolutionVersionReference.ToXml(this, recordElem, "SolutionPack_SolutionVersionReference", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_solutionversionreference") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_SolutionVersionReference")) variable.Value = ssSTSolutionPack_SolutionVersionReference; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_solutionversionreference");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_SolutionVersionReference) {
				return ssSTSolutionPack_SolutionVersionReference;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_SolutionVersionReference.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_SolutionVersionReference));
		}
		public bool IsDefault() {
			RCSolutionPack_SolutionVersionReferenceRecord defaultStruct = new RCSolutionPack_SolutionVersionReferenceRecord(null);
			if (this.ssSTSolutionPack_SolutionVersionReference != defaultStruct.ssSTSolutionPack_SolutionVersionReference) return false;
			return true;
		}
	} // RCSolutionPack_SolutionVersionReferenceRecord

	/// <summary>
	/// Structure <code>RCSolutionPackRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPackRecord: ISerializable, ITypedRecord<RCSolutionPackRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K0yVaOZxHHj8B22vY3gmCw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack")]
		public STSolutionPackStructure ssSTSolutionPack;


		public static implicit operator STSolutionPackStructure(RCSolutionPackRecord r) {
			return r.ssSTSolutionPack;
		}

		public static implicit operator RCSolutionPackRecord(STSolutionPackStructure r) {
			RCSolutionPackRecord res = new RCSolutionPackRecord(null);
			res.ssSTSolutionPack = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPackRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack = new STSolutionPackStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPackRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPackRecord a, RCSolutionPackRecord b) {
			if (a.ssSTSolutionPack != b.ssSTSolutionPack) return false;
			return true;
		}

		public static bool operator != (RCSolutionPackRecord a, RCSolutionPackRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPackRecord)) return false;
			return (this == (RCSolutionPackRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPackRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack = new STSolutionPackStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack = (STSolutionPackStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack.InternalRecursiveSave();
		}


		public RCSolutionPackRecord Duplicate() {
			RCSolutionPackRecord t;
			t.ssSTSolutionPack = (STSolutionPackStructure) this.ssSTSolutionPack.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack.ToXml(this, recordElem, "SolutionPack", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack")) variable.Value = ssSTSolutionPack; else variable.Optimized = true;
				variable.SetFieldName("solutionpack");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack) {
				return ssSTSolutionPack;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack));
		}
		public bool IsDefault() {
			RCSolutionPackRecord defaultStruct = new RCSolutionPackRecord(null);
			if (this.ssSTSolutionPack != defaultStruct.ssSTSolutionPack) return false;
			return true;
		}
	} // RCSolutionPackRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_FileRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_FileRecord: ISerializable, ITypedRecord<RCSolutionPack_FileRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_File = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*EdbgcWBmumHQoHqhzCdP_A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_File")]
		public STSolutionPack_FileStructure ssSTSolutionPack_File;


		public static implicit operator STSolutionPack_FileStructure(RCSolutionPack_FileRecord r) {
			return r.ssSTSolutionPack_File;
		}

		public static implicit operator RCSolutionPack_FileRecord(STSolutionPack_FileStructure r) {
			RCSolutionPack_FileRecord res = new RCSolutionPack_FileRecord(null);
			res.ssSTSolutionPack_File = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_FileRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_File = new STSolutionPack_FileStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_File.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_File.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_FileRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_FileRecord a, RCSolutionPack_FileRecord b) {
			if (a.ssSTSolutionPack_File != b.ssSTSolutionPack_File) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_FileRecord a, RCSolutionPack_FileRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_FileRecord)) return false;
			return (this == (RCSolutionPack_FileRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_File.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_FileRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_File = new STSolutionPack_FileStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_File", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_File' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_File = (STSolutionPack_FileStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_File.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_File.InternalRecursiveSave();
		}


		public RCSolutionPack_FileRecord Duplicate() {
			RCSolutionPack_FileRecord t;
			t.ssSTSolutionPack_File = (STSolutionPack_FileStructure) this.ssSTSolutionPack_File.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_File.ToXml(this, recordElem, "SolutionPack_File", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_file") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_File")) variable.Value = ssSTSolutionPack_File; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_file");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_File) {
				return ssSTSolutionPack_File;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_File.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_File));
		}
		public bool IsDefault() {
			RCSolutionPack_FileRecord defaultStruct = new RCSolutionPack_FileRecord(null);
			if (this.ssSTSolutionPack_File != defaultStruct.ssSTSolutionPack_File) return false;
			return true;
		}
	} // RCSolutionPack_FileRecord

	/// <summary>
	/// Structure <code>RCEspaceInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEspaceInfoRecord: ISerializable, ITypedRecord<RCEspaceInfoRecord> {
		internal static readonly GlobalObjectKey IdEspaceInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FmNR0F+rdFsKVoozrAviEw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EspaceInfo")]
		public STEspaceInfoStructure ssSTEspaceInfo;


		public static implicit operator STEspaceInfoStructure(RCEspaceInfoRecord r) {
			return r.ssSTEspaceInfo;
		}

		public static implicit operator RCEspaceInfoRecord(STEspaceInfoStructure r) {
			RCEspaceInfoRecord res = new RCEspaceInfoRecord(null);
			res.ssSTEspaceInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEspaceInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEspaceInfo = new STEspaceInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEspaceInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEspaceInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEspaceInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCEspaceInfoRecord a, RCEspaceInfoRecord b) {
			if (a.ssSTEspaceInfo != b.ssSTEspaceInfo) return false;
			return true;
		}

		public static bool operator != (RCEspaceInfoRecord a, RCEspaceInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEspaceInfoRecord)) return false;
			return (this == (RCEspaceInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEspaceInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEspaceInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEspaceInfo = new STEspaceInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEspaceInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEspaceInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEspaceInfo = (STEspaceInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEspaceInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEspaceInfo.InternalRecursiveSave();
		}


		public RCEspaceInfoRecord Duplicate() {
			RCEspaceInfoRecord t;
			t.ssSTEspaceInfo = (STEspaceInfoStructure) this.ssSTEspaceInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEspaceInfo.ToXml(this, recordElem, "EspaceInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "espaceinfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EspaceInfo")) variable.Value = ssSTEspaceInfo; else variable.Optimized = true;
				variable.SetFieldName("espaceinfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEspaceInfo) {
				return ssSTEspaceInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEspaceInfo.FillFromOther((IRecord) other.AttributeGet(IdEspaceInfo));
		}
		public bool IsDefault() {
			RCEspaceInfoRecord defaultStruct = new RCEspaceInfoRecord(null);
			if (this.ssSTEspaceInfo != defaultStruct.ssSTEspaceInfo) return false;
			return true;
		}
	} // RCEspaceInfoRecord

	/// <summary>
	/// Structure <code>RCReferenceRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCReferenceRecord: ISerializable, ITypedRecord<RCReferenceRecord> {
		internal static readonly GlobalObjectKey IdReference = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CQrpjEDvVm8QqmERwCb8IQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Reference")]
		public STReferenceStructure ssSTReference;


		public static implicit operator STReferenceStructure(RCReferenceRecord r) {
			return r.ssSTReference;
		}

		public static implicit operator RCReferenceRecord(STReferenceStructure r) {
			RCReferenceRecord res = new RCReferenceRecord(null);
			res.ssSTReference = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCReferenceRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTReference = new STReferenceStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTReference.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTReference.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCReferenceRecord r) {
			this = r;
		}


		public static bool operator == (RCReferenceRecord a, RCReferenceRecord b) {
			if (a.ssSTReference != b.ssSTReference) return false;
			return true;
		}

		public static bool operator != (RCReferenceRecord a, RCReferenceRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCReferenceRecord)) return false;
			return (this == (RCReferenceRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTReference.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCReferenceRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTReference = new STReferenceStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTReference", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTReference' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTReference = (STReferenceStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTReference.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTReference.InternalRecursiveSave();
		}


		public RCReferenceRecord Duplicate() {
			RCReferenceRecord t;
			t.ssSTReference = (STReferenceStructure) this.ssSTReference.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTReference.ToXml(this, recordElem, "Reference", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "reference") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Reference")) variable.Value = ssSTReference; else variable.Optimized = true;
				variable.SetFieldName("reference");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdReference) {
				return ssSTReference;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTReference.FillFromOther((IRecord) other.AttributeGet(IdReference));
		}
		public bool IsDefault() {
			RCReferenceRecord defaultStruct = new RCReferenceRecord(null);
			if (this.ssSTReference != defaultStruct.ssSTReference) return false;
			return true;
		}
	} // RCReferenceRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_SolutionLogicalDatabaseRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_SolutionLogicalDatabaseRecord: ISerializable, ITypedRecord<RCSolutionPack_SolutionLogicalDatabaseRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_SolutionLogicalDatabase = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ls6IafvhKQ7RNY809Xq42Q");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_SolutionLogicalDatabase")]
		public STSolutionPack_SolutionLogicalDatabaseStructure ssSTSolutionPack_SolutionLogicalDatabase;


		public static implicit operator STSolutionPack_SolutionLogicalDatabaseStructure(RCSolutionPack_SolutionLogicalDatabaseRecord r) {
			return r.ssSTSolutionPack_SolutionLogicalDatabase;
		}

		public static implicit operator RCSolutionPack_SolutionLogicalDatabaseRecord(STSolutionPack_SolutionLogicalDatabaseStructure r) {
			RCSolutionPack_SolutionLogicalDatabaseRecord res = new RCSolutionPack_SolutionLogicalDatabaseRecord(null);
			res.ssSTSolutionPack_SolutionLogicalDatabase = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_SolutionLogicalDatabaseRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionLogicalDatabase = new STSolutionPack_SolutionLogicalDatabaseStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_SolutionLogicalDatabase.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_SolutionLogicalDatabase.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_SolutionLogicalDatabaseRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_SolutionLogicalDatabaseRecord a, RCSolutionPack_SolutionLogicalDatabaseRecord b) {
			if (a.ssSTSolutionPack_SolutionLogicalDatabase != b.ssSTSolutionPack_SolutionLogicalDatabase) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_SolutionLogicalDatabaseRecord a, RCSolutionPack_SolutionLogicalDatabaseRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_SolutionLogicalDatabaseRecord)) return false;
			return (this == (RCSolutionPack_SolutionLogicalDatabaseRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_SolutionLogicalDatabase.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_SolutionLogicalDatabaseRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionLogicalDatabase = new STSolutionPack_SolutionLogicalDatabaseStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_SolutionLogicalDatabase", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_SolutionLogicalDatabase' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_SolutionLogicalDatabase = (STSolutionPack_SolutionLogicalDatabaseStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_SolutionLogicalDatabase.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_SolutionLogicalDatabase.InternalRecursiveSave();
		}


		public RCSolutionPack_SolutionLogicalDatabaseRecord Duplicate() {
			RCSolutionPack_SolutionLogicalDatabaseRecord t;
			t.ssSTSolutionPack_SolutionLogicalDatabase = (STSolutionPack_SolutionLogicalDatabaseStructure) this.ssSTSolutionPack_SolutionLogicalDatabase.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_SolutionLogicalDatabase.ToXml(this, recordElem, "SolutionPack_SolutionLogicalDatabase", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_solutionlogicaldatabase") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_SolutionLogicalDatabase")) variable.Value = ssSTSolutionPack_SolutionLogicalDatabase; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_solutionlogicaldatabase");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_SolutionLogicalDatabase) {
				return ssSTSolutionPack_SolutionLogicalDatabase;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_SolutionLogicalDatabase.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_SolutionLogicalDatabase));
		}
		public bool IsDefault() {
			RCSolutionPack_SolutionLogicalDatabaseRecord defaultStruct = new RCSolutionPack_SolutionLogicalDatabaseRecord(null);
			if (this.ssSTSolutionPack_SolutionLogicalDatabase != defaultStruct.ssSTSolutionPack_SolutionLogicalDatabase) return false;
			return true;
		}
	} // RCSolutionPack_SolutionLogicalDatabaseRecord

	/// <summary>
	/// Structure <code>RCLinkRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCLinkRecord: ISerializable, ITypedRecord<RCLinkRecord> {
		internal static readonly GlobalObjectKey IdLink = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*I2szAbjeqpHRDzwh47rpgg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Link")]
		public STLinkStructure ssSTLink;


		public static implicit operator STLinkStructure(RCLinkRecord r) {
			return r.ssSTLink;
		}

		public static implicit operator RCLinkRecord(STLinkStructure r) {
			RCLinkRecord res = new RCLinkRecord(null);
			res.ssSTLink = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCLinkRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTLink = new STLinkStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTLink.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTLink.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCLinkRecord r) {
			this = r;
		}


		public static bool operator == (RCLinkRecord a, RCLinkRecord b) {
			if (a.ssSTLink != b.ssSTLink) return false;
			return true;
		}

		public static bool operator != (RCLinkRecord a, RCLinkRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCLinkRecord)) return false;
			return (this == (RCLinkRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTLink.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCLinkRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTLink = new STLinkStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTLink", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTLink' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTLink = (STLinkStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTLink.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTLink.InternalRecursiveSave();
		}


		public RCLinkRecord Duplicate() {
			RCLinkRecord t;
			t.ssSTLink = (STLinkStructure) this.ssSTLink.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTLink.ToXml(this, recordElem, "Link", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "link") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Link")) variable.Value = ssSTLink; else variable.Optimized = true;
				variable.SetFieldName("link");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdLink) {
				return ssSTLink;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTLink.FillFromOther((IRecord) other.AttributeGet(IdLink));
		}
		public bool IsDefault() {
			RCLinkRecord defaultStruct = new RCLinkRecord(null);
			if (this.ssSTLink != defaultStruct.ssSTLink) return false;
			return true;
		}
	} // RCLinkRecord

	/// <summary>
	/// Structure <code>RCAbstractRecordRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAbstractRecordRecord: ISerializable, ITypedRecord<RCAbstractRecordRecord> {
		internal static readonly GlobalObjectKey IdAbstractRecord = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*68ENka70xVNe1SJ+ENUznQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("AbstractRecord")]
		public STAbstractRecordStructure ssSTAbstractRecord;


		public static implicit operator STAbstractRecordStructure(RCAbstractRecordRecord r) {
			return r.ssSTAbstractRecord;
		}

		public static implicit operator RCAbstractRecordRecord(STAbstractRecordStructure r) {
			RCAbstractRecordRecord res = new RCAbstractRecordRecord(null);
			res.ssSTAbstractRecord = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAbstractRecordRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAbstractRecord = new STAbstractRecordStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAbstractRecord.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAbstractRecord.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAbstractRecordRecord r) {
			this = r;
		}


		public static bool operator == (RCAbstractRecordRecord a, RCAbstractRecordRecord b) {
			if (a.ssSTAbstractRecord != b.ssSTAbstractRecord) return false;
			return true;
		}

		public static bool operator != (RCAbstractRecordRecord a, RCAbstractRecordRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAbstractRecordRecord)) return false;
			return (this == (RCAbstractRecordRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAbstractRecord.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAbstractRecordRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAbstractRecord = new STAbstractRecordStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAbstractRecord", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAbstractRecord' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAbstractRecord = (STAbstractRecordStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAbstractRecord.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAbstractRecord.InternalRecursiveSave();
		}


		public RCAbstractRecordRecord Duplicate() {
			RCAbstractRecordRecord t;
			t.ssSTAbstractRecord = (STAbstractRecordStructure) this.ssSTAbstractRecord.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAbstractRecord.ToXml(this, recordElem, "AbstractRecord", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "abstractrecord") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AbstractRecord")) variable.Value = ssSTAbstractRecord; else variable.Optimized = true;
				variable.SetFieldName("abstractrecord");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAbstractRecord) {
				return ssSTAbstractRecord;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAbstractRecord.FillFromOther((IRecord) other.AttributeGet(IdAbstractRecord));
		}
		public bool IsDefault() {
			RCAbstractRecordRecord defaultStruct = new RCAbstractRecordRecord(null);
			if (this.ssSTAbstractRecord != defaultStruct.ssSTAbstractRecord) return false;
			return true;
		}
	} // RCAbstractRecordRecord

	/// <summary>
	/// Structure <code>RCAbstractFieldRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAbstractFieldRecord: ISerializable, ITypedRecord<RCAbstractFieldRecord> {
		internal static readonly GlobalObjectKey IdAbstractField = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LddL+uZ5HO1VjGe4I66dwA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("AbstractField")]
		public STAbstractFieldStructure ssSTAbstractField;


		public static implicit operator STAbstractFieldStructure(RCAbstractFieldRecord r) {
			return r.ssSTAbstractField;
		}

		public static implicit operator RCAbstractFieldRecord(STAbstractFieldStructure r) {
			RCAbstractFieldRecord res = new RCAbstractFieldRecord(null);
			res.ssSTAbstractField = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAbstractFieldRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAbstractField = new STAbstractFieldStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAbstractField.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAbstractField.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAbstractFieldRecord r) {
			this = r;
		}


		public static bool operator == (RCAbstractFieldRecord a, RCAbstractFieldRecord b) {
			if (a.ssSTAbstractField != b.ssSTAbstractField) return false;
			return true;
		}

		public static bool operator != (RCAbstractFieldRecord a, RCAbstractFieldRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAbstractFieldRecord)) return false;
			return (this == (RCAbstractFieldRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAbstractField.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAbstractFieldRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAbstractField = new STAbstractFieldStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAbstractField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAbstractField' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAbstractField = (STAbstractFieldStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAbstractField.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAbstractField.InternalRecursiveSave();
		}


		public RCAbstractFieldRecord Duplicate() {
			RCAbstractFieldRecord t;
			t.ssSTAbstractField = (STAbstractFieldStructure) this.ssSTAbstractField.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAbstractField.ToXml(this, recordElem, "AbstractField", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "abstractfield") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AbstractField")) variable.Value = ssSTAbstractField; else variable.Optimized = true;
				variable.SetFieldName("abstractfield");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAbstractField) {
				return ssSTAbstractField;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAbstractField.FillFromOther((IRecord) other.AttributeGet(IdAbstractField));
		}
		public bool IsDefault() {
			RCAbstractFieldRecord defaultStruct = new RCAbstractFieldRecord(null);
			if (this.ssSTAbstractField != defaultStruct.ssSTAbstractField) return false;
			return true;
		}
	} // RCAbstractFieldRecord

	/// <summary>
	/// Structure <code>RCFeatureRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCFeatureRecord: ISerializable, ITypedRecord<RCFeatureRecord> {
		internal static readonly GlobalObjectKey IdFeature = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*z_F4dCcb0gQ2brMJy8z76Q");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Feature")]
		public STFeatureStructure ssSTFeature;


		public static implicit operator STFeatureStructure(RCFeatureRecord r) {
			return r.ssSTFeature;
		}

		public static implicit operator RCFeatureRecord(STFeatureStructure r) {
			RCFeatureRecord res = new RCFeatureRecord(null);
			res.ssSTFeature = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCFeatureRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTFeature = new STFeatureStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTFeature.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTFeature.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCFeatureRecord r) {
			this = r;
		}


		public static bool operator == (RCFeatureRecord a, RCFeatureRecord b) {
			if (a.ssSTFeature != b.ssSTFeature) return false;
			return true;
		}

		public static bool operator != (RCFeatureRecord a, RCFeatureRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCFeatureRecord)) return false;
			return (this == (RCFeatureRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTFeature.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCFeatureRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTFeature = new STFeatureStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTFeature", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTFeature' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTFeature = (STFeatureStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTFeature.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTFeature.InternalRecursiveSave();
		}


		public RCFeatureRecord Duplicate() {
			RCFeatureRecord t;
			t.ssSTFeature = (STFeatureStructure) this.ssSTFeature.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTFeature.ToXml(this, recordElem, "Feature", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "feature") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Feature")) variable.Value = ssSTFeature; else variable.Optimized = true;
				variable.SetFieldName("feature");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdFeature) {
				return ssSTFeature;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTFeature.FillFromOther((IRecord) other.AttributeGet(IdFeature));
		}
		public bool IsDefault() {
			RCFeatureRecord defaultStruct = new RCFeatureRecord(null);
			if (this.ssSTFeature != defaultStruct.ssSTFeature) return false;
			return true;
		}
	} // RCFeatureRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_SolutionDBCatalogRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_SolutionDBCatalogRecord: ISerializable, ITypedRecord<RCSolutionPack_SolutionDBCatalogRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_SolutionDBCatalog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YZsEu8yDeyWPVUwHdiSA_w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_SolutionDBCatalog")]
		public STSolutionPack_SolutionDBCatalogStructure ssSTSolutionPack_SolutionDBCatalog;


		public static implicit operator STSolutionPack_SolutionDBCatalogStructure(RCSolutionPack_SolutionDBCatalogRecord r) {
			return r.ssSTSolutionPack_SolutionDBCatalog;
		}

		public static implicit operator RCSolutionPack_SolutionDBCatalogRecord(STSolutionPack_SolutionDBCatalogStructure r) {
			RCSolutionPack_SolutionDBCatalogRecord res = new RCSolutionPack_SolutionDBCatalogRecord(null);
			res.ssSTSolutionPack_SolutionDBCatalog = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_SolutionDBCatalogRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionDBCatalog = new STSolutionPack_SolutionDBCatalogStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_SolutionDBCatalog.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_SolutionDBCatalog.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_SolutionDBCatalogRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_SolutionDBCatalogRecord a, RCSolutionPack_SolutionDBCatalogRecord b) {
			if (a.ssSTSolutionPack_SolutionDBCatalog != b.ssSTSolutionPack_SolutionDBCatalog) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_SolutionDBCatalogRecord a, RCSolutionPack_SolutionDBCatalogRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_SolutionDBCatalogRecord)) return false;
			return (this == (RCSolutionPack_SolutionDBCatalogRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_SolutionDBCatalog.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_SolutionDBCatalogRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SolutionDBCatalog = new STSolutionPack_SolutionDBCatalogStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_SolutionDBCatalog", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_SolutionDBCatalog' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_SolutionDBCatalog = (STSolutionPack_SolutionDBCatalogStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_SolutionDBCatalog.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_SolutionDBCatalog.InternalRecursiveSave();
		}


		public RCSolutionPack_SolutionDBCatalogRecord Duplicate() {
			RCSolutionPack_SolutionDBCatalogRecord t;
			t.ssSTSolutionPack_SolutionDBCatalog = (STSolutionPack_SolutionDBCatalogStructure) this.ssSTSolutionPack_SolutionDBCatalog.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_SolutionDBCatalog.ToXml(this, recordElem, "SolutionPack_SolutionDBCatalog", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_solutiondbcatalog") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_SolutionDBCatalog")) variable.Value = ssSTSolutionPack_SolutionDBCatalog; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_solutiondbcatalog");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_SolutionDBCatalog) {
				return ssSTSolutionPack_SolutionDBCatalog;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_SolutionDBCatalog.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_SolutionDBCatalog));
		}
		public bool IsDefault() {
			RCSolutionPack_SolutionDBCatalogRecord defaultStruct = new RCSolutionPack_SolutionDBCatalogRecord(null);
			if (this.ssSTSolutionPack_SolutionDBCatalog != defaultStruct.ssSTSolutionPack_SolutionDBCatalog) return false;
			return true;
		}
	} // RCSolutionPack_SolutionDBCatalogRecord

	/// <summary>
	/// Structure <code>RCIntegerRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCIntegerRecord: ISerializable, ITypedRecord<RCIntegerRecord> {
		internal static readonly GlobalObjectKey IdInteger = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8iHnAE6KBscgJn03y7gnFw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Integer")]
		public STIntegerStructure ssSTInteger;


		public static implicit operator STIntegerStructure(RCIntegerRecord r) {
			return r.ssSTInteger;
		}

		public static implicit operator RCIntegerRecord(STIntegerStructure r) {
			RCIntegerRecord res = new RCIntegerRecord(null);
			res.ssSTInteger = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCIntegerRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTInteger = new STIntegerStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTInteger.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTInteger.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCIntegerRecord r) {
			this = r;
		}


		public static bool operator == (RCIntegerRecord a, RCIntegerRecord b) {
			if (a.ssSTInteger != b.ssSTInteger) return false;
			return true;
		}

		public static bool operator != (RCIntegerRecord a, RCIntegerRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCIntegerRecord)) return false;
			return (this == (RCIntegerRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTInteger.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCIntegerRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTInteger = new STIntegerStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTInteger", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTInteger' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTInteger = (STIntegerStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTInteger.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTInteger.InternalRecursiveSave();
		}


		public RCIntegerRecord Duplicate() {
			RCIntegerRecord t;
			t.ssSTInteger = (STIntegerStructure) this.ssSTInteger.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTInteger.ToXml(this, recordElem, "Integer", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "integer") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Integer")) variable.Value = ssSTInteger; else variable.Optimized = true;
				variable.SetFieldName("integer");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdInteger) {
				return ssSTInteger;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTInteger.FillFromOther((IRecord) other.AttributeGet(IdInteger));
		}
		public bool IsDefault() {
			RCIntegerRecord defaultStruct = new RCIntegerRecord(null);
			if (this.ssSTInteger != defaultStruct.ssSTInteger) return false;
			return true;
		}
	} // RCIntegerRecord

	/// <summary>
	/// Structure <code>RCTextRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTextRecord: ISerializable, ITypedRecord<RCTextRecord> {
		internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qzXJFbaDHLlYZ3r9+JkJHg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Text")]
		public STTextStructure ssSTText;


		public static implicit operator STTextStructure(RCTextRecord r) {
			return r.ssSTText;
		}

		public static implicit operator RCTextRecord(STTextStructure r) {
			RCTextRecord res = new RCTextRecord(null);
			res.ssSTText = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCTextRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTText = new STTextStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTText.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTText.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCTextRecord r) {
			this = r;
		}


		public static bool operator == (RCTextRecord a, RCTextRecord b) {
			if (a.ssSTText != b.ssSTText) return false;
			return true;
		}

		public static bool operator != (RCTextRecord a, RCTextRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTextRecord)) return false;
			return (this == (RCTextRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTText.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCTextRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTText = new STTextStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTText", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTText' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTText = (STTextStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTText.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTText.InternalRecursiveSave();
		}


		public RCTextRecord Duplicate() {
			RCTextRecord t;
			t.ssSTText = (STTextStructure) this.ssSTText.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTText.ToXml(this, recordElem, "Text", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "text") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssSTText; else variable.Optimized = true;
				variable.SetFieldName("text");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdText) {
				return ssSTText;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTText.FillFromOther((IRecord) other.AttributeGet(IdText));
		}
		public bool IsDefault() {
			RCTextRecord defaultStruct = new RCTextRecord(null);
			if (this.ssSTText != defaultStruct.ssSTText) return false;
			return true;
		}
	} // RCTextRecord

	/// <summary>
	/// Structure <code>RCBooleanRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCBooleanRecord: ISerializable, ITypedRecord<RCBooleanRecord> {
		internal static readonly GlobalObjectKey IdBoolean = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rgHw2eU9n0yUYH4r2nHCBw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Boolean")]
		public STBooleanStructure ssSTBoolean;


		public static implicit operator STBooleanStructure(RCBooleanRecord r) {
			return r.ssSTBoolean;
		}

		public static implicit operator RCBooleanRecord(STBooleanStructure r) {
			RCBooleanRecord res = new RCBooleanRecord(null);
			res.ssSTBoolean = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCBooleanRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTBoolean = new STBooleanStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTBoolean.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTBoolean.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCBooleanRecord r) {
			this = r;
		}


		public static bool operator == (RCBooleanRecord a, RCBooleanRecord b) {
			if (a.ssSTBoolean != b.ssSTBoolean) return false;
			return true;
		}

		public static bool operator != (RCBooleanRecord a, RCBooleanRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCBooleanRecord)) return false;
			return (this == (RCBooleanRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTBoolean.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCBooleanRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTBoolean = new STBooleanStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTBoolean", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTBoolean' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTBoolean = (STBooleanStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTBoolean.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTBoolean.InternalRecursiveSave();
		}


		public RCBooleanRecord Duplicate() {
			RCBooleanRecord t;
			t.ssSTBoolean = (STBooleanStructure) this.ssSTBoolean.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTBoolean.ToXml(this, recordElem, "Boolean", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "boolean") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Boolean")) variable.Value = ssSTBoolean; else variable.Optimized = true;
				variable.SetFieldName("boolean");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdBoolean) {
				return ssSTBoolean;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTBoolean.FillFromOther((IRecord) other.AttributeGet(IdBoolean));
		}
		public bool IsDefault() {
			RCBooleanRecord defaultStruct = new RCBooleanRecord(null);
			if (this.ssSTBoolean != defaultStruct.ssSTBoolean) return false;
			return true;
		}
	} // RCBooleanRecord

	/// <summary>
	/// Structure <code>RCDecimalRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDecimalRecord: ISerializable, ITypedRecord<RCDecimalRecord> {
		internal static readonly GlobalObjectKey IdDecimal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DJtzAJuMzuKS0lLGMfZELg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Decimal")]
		public STDecimalStructure ssSTDecimal;


		public static implicit operator STDecimalStructure(RCDecimalRecord r) {
			return r.ssSTDecimal;
		}

		public static implicit operator RCDecimalRecord(STDecimalStructure r) {
			RCDecimalRecord res = new RCDecimalRecord(null);
			res.ssSTDecimal = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDecimalRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDecimal = new STDecimalStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDecimal.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDecimal.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDecimalRecord r) {
			this = r;
		}


		public static bool operator == (RCDecimalRecord a, RCDecimalRecord b) {
			if (a.ssSTDecimal != b.ssSTDecimal) return false;
			return true;
		}

		public static bool operator != (RCDecimalRecord a, RCDecimalRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDecimalRecord)) return false;
			return (this == (RCDecimalRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDecimal.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDecimalRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDecimal = new STDecimalStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDecimal", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDecimal' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDecimal = (STDecimalStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDecimal.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDecimal.InternalRecursiveSave();
		}


		public RCDecimalRecord Duplicate() {
			RCDecimalRecord t;
			t.ssSTDecimal = (STDecimalStructure) this.ssSTDecimal.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDecimal.ToXml(this, recordElem, "Decimal", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "decimal") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Decimal")) variable.Value = ssSTDecimal; else variable.Optimized = true;
				variable.SetFieldName("decimal");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDecimal) {
				return ssSTDecimal;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDecimal.FillFromOther((IRecord) other.AttributeGet(IdDecimal));
		}
		public bool IsDefault() {
			RCDecimalRecord defaultStruct = new RCDecimalRecord(null);
			if (this.ssSTDecimal != defaultStruct.ssSTDecimal) return false;
			return true;
		}
	} // RCDecimalRecord

	/// <summary>
	/// Structure <code>RCDateTimeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDateTimeRecord: ISerializable, ITypedRecord<RCDateTimeRecord> {
		internal static readonly GlobalObjectKey IdDateTime = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S7XSL_VqTf_F2vFbnWznfA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DateTime")]
		public STDateTimeStructure ssSTDateTime;


		public static implicit operator STDateTimeStructure(RCDateTimeRecord r) {
			return r.ssSTDateTime;
		}

		public static implicit operator RCDateTimeRecord(STDateTimeStructure r) {
			RCDateTimeRecord res = new RCDateTimeRecord(null);
			res.ssSTDateTime = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDateTimeRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDateTime = new STDateTimeStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDateTime.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDateTime.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDateTimeRecord r) {
			this = r;
		}


		public static bool operator == (RCDateTimeRecord a, RCDateTimeRecord b) {
			if (a.ssSTDateTime != b.ssSTDateTime) return false;
			return true;
		}

		public static bool operator != (RCDateTimeRecord a, RCDateTimeRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDateTimeRecord)) return false;
			return (this == (RCDateTimeRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDateTime.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDateTimeRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDateTime = new STDateTimeStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDateTime", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDateTime' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDateTime = (STDateTimeStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDateTime.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDateTime.InternalRecursiveSave();
		}


		public RCDateTimeRecord Duplicate() {
			RCDateTimeRecord t;
			t.ssSTDateTime = (STDateTimeStructure) this.ssSTDateTime.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDateTime.ToXml(this, recordElem, "DateTime", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "datetime") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DateTime")) variable.Value = ssSTDateTime; else variable.Optimized = true;
				variable.SetFieldName("datetime");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDateTime) {
				return ssSTDateTime;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDateTime.FillFromOther((IRecord) other.AttributeGet(IdDateTime));
		}
		public bool IsDefault() {
			RCDateTimeRecord defaultStruct = new RCDateTimeRecord(null);
			if (this.ssSTDateTime != defaultStruct.ssSTDateTime) return false;
			return true;
		}
	} // RCDateTimeRecord

	/// <summary>
	/// Structure <code>RCBinaryDataRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCBinaryDataRecord: ISerializable, ITypedRecord<RCBinaryDataRecord> {
		internal static readonly GlobalObjectKey IdBinaryData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2EulqBn1Egbjl3n9NOgnEw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("BinaryData")]
		public STBinaryDataStructure ssSTBinaryData;


		public static implicit operator STBinaryDataStructure(RCBinaryDataRecord r) {
			return r.ssSTBinaryData;
		}

		public static implicit operator RCBinaryDataRecord(STBinaryDataStructure r) {
			RCBinaryDataRecord res = new RCBinaryDataRecord(null);
			res.ssSTBinaryData = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCBinaryDataRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTBinaryData = new STBinaryDataStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTBinaryData.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTBinaryData.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCBinaryDataRecord r) {
			this = r;
		}


		public static bool operator == (RCBinaryDataRecord a, RCBinaryDataRecord b) {
			if (a.ssSTBinaryData != b.ssSTBinaryData) return false;
			return true;
		}

		public static bool operator != (RCBinaryDataRecord a, RCBinaryDataRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCBinaryDataRecord)) return false;
			return (this == (RCBinaryDataRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTBinaryData.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCBinaryDataRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTBinaryData = new STBinaryDataStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTBinaryData", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTBinaryData' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTBinaryData = (STBinaryDataStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTBinaryData.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTBinaryData.InternalRecursiveSave();
		}


		public RCBinaryDataRecord Duplicate() {
			RCBinaryDataRecord t;
			t.ssSTBinaryData = (STBinaryDataStructure) this.ssSTBinaryData.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTBinaryData.ToXml(this, recordElem, "BinaryData", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "binarydata") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".BinaryData")) variable.Value = ssSTBinaryData; else variable.Optimized = true;
				variable.SetFieldName("binarydata");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdBinaryData) {
				return ssSTBinaryData;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTBinaryData.FillFromOther((IRecord) other.AttributeGet(IdBinaryData));
		}
		public bool IsDefault() {
			RCBinaryDataRecord defaultStruct = new RCBinaryDataRecord(null);
			if (this.ssSTBinaryData != defaultStruct.ssSTBinaryData) return false;
			return true;
		}
	} // RCBinaryDataRecord

	/// <summary>
	/// Structure <code>RCKeyValuePairRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCKeyValuePairRecord: ISerializable, ITypedRecord<RCKeyValuePairRecord> {
		internal static readonly GlobalObjectKey IdKeyValuePair = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XtlsZimhTlpLPldyW3hbdw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("KeyValuePair")]
		public STKeyValuePairStructure ssSTKeyValuePair;


		public static implicit operator STKeyValuePairStructure(RCKeyValuePairRecord r) {
			return r.ssSTKeyValuePair;
		}

		public static implicit operator RCKeyValuePairRecord(STKeyValuePairStructure r) {
			RCKeyValuePairRecord res = new RCKeyValuePairRecord(null);
			res.ssSTKeyValuePair = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCKeyValuePairRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTKeyValuePair = new STKeyValuePairStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTKeyValuePair.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTKeyValuePair.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCKeyValuePairRecord r) {
			this = r;
		}


		public static bool operator == (RCKeyValuePairRecord a, RCKeyValuePairRecord b) {
			if (a.ssSTKeyValuePair != b.ssSTKeyValuePair) return false;
			return true;
		}

		public static bool operator != (RCKeyValuePairRecord a, RCKeyValuePairRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCKeyValuePairRecord)) return false;
			return (this == (RCKeyValuePairRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTKeyValuePair.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCKeyValuePairRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTKeyValuePair = new STKeyValuePairStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTKeyValuePair", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTKeyValuePair' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTKeyValuePair = (STKeyValuePairStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTKeyValuePair.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTKeyValuePair.InternalRecursiveSave();
		}


		public RCKeyValuePairRecord Duplicate() {
			RCKeyValuePairRecord t;
			t.ssSTKeyValuePair = (STKeyValuePairStructure) this.ssSTKeyValuePair.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTKeyValuePair.ToXml(this, recordElem, "KeyValuePair", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "keyvaluepair") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".KeyValuePair")) variable.Value = ssSTKeyValuePair; else variable.Optimized = true;
				variable.SetFieldName("keyvaluepair");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdKeyValuePair) {
				return ssSTKeyValuePair;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTKeyValuePair.FillFromOther((IRecord) other.AttributeGet(IdKeyValuePair));
		}
		public bool IsDefault() {
			RCKeyValuePairRecord defaultStruct = new RCKeyValuePairRecord(null);
			if (this.ssSTKeyValuePair != defaultStruct.ssSTKeyValuePair) return false;
			return true;
		}
	} // RCKeyValuePairRecord

	/// <summary>
	/// Structure <code>RCEntityEventRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEntityEventRecord: ISerializable, ITypedRecord<RCEntityEventRecord> {
		internal static readonly GlobalObjectKey IdEntityEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*hHtU6hR2_nBi5xSD2ym+Vg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EntityEvent")]
		public STEntityEventStructure ssSTEntityEvent;


		public static implicit operator STEntityEventStructure(RCEntityEventRecord r) {
			return r.ssSTEntityEvent;
		}

		public static implicit operator RCEntityEventRecord(STEntityEventStructure r) {
			RCEntityEventRecord res = new RCEntityEventRecord(null);
			res.ssSTEntityEvent = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEntityEventRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEntityEvent = new STEntityEventStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEntityEvent.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEntityEvent.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEntityEventRecord r) {
			this = r;
		}


		public static bool operator == (RCEntityEventRecord a, RCEntityEventRecord b) {
			if (a.ssSTEntityEvent != b.ssSTEntityEvent) return false;
			return true;
		}

		public static bool operator != (RCEntityEventRecord a, RCEntityEventRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEntityEventRecord)) return false;
			return (this == (RCEntityEventRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEntityEvent.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEntityEventRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEntityEvent = new STEntityEventStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEntityEvent", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEntityEvent' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEntityEvent = (STEntityEventStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEntityEvent.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEntityEvent.InternalRecursiveSave();
		}


		public RCEntityEventRecord Duplicate() {
			RCEntityEventRecord t;
			t.ssSTEntityEvent = (STEntityEventStructure) this.ssSTEntityEvent.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEntityEvent.ToXml(this, recordElem, "EntityEvent", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "entityevent") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EntityEvent")) variable.Value = ssSTEntityEvent; else variable.Optimized = true;
				variable.SetFieldName("entityevent");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEntityEvent) {
				return ssSTEntityEvent;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEntityEvent.FillFromOther((IRecord) other.AttributeGet(IdEntityEvent));
		}
		public bool IsDefault() {
			RCEntityEventRecord defaultStruct = new RCEntityEventRecord(null);
			if (this.ssSTEntityEvent != defaultStruct.ssSTEntityEvent) return false;
			return true;
		}
	} // RCEntityEventRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_ApplicationRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_ApplicationRecord: ISerializable, ITypedRecord<RCSolutionPack_ApplicationRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_Application = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gDAVDQSrLxnc0PKlIkS3eQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_Application")]
		public STSolutionPack_ApplicationStructure ssSTSolutionPack_Application;


		public static implicit operator STSolutionPack_ApplicationStructure(RCSolutionPack_ApplicationRecord r) {
			return r.ssSTSolutionPack_Application;
		}

		public static implicit operator RCSolutionPack_ApplicationRecord(STSolutionPack_ApplicationStructure r) {
			RCSolutionPack_ApplicationRecord res = new RCSolutionPack_ApplicationRecord(null);
			res.ssSTSolutionPack_Application = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_ApplicationRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_Application = new STSolutionPack_ApplicationStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_Application.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_Application.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_ApplicationRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_ApplicationRecord a, RCSolutionPack_ApplicationRecord b) {
			if (a.ssSTSolutionPack_Application != b.ssSTSolutionPack_Application) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_ApplicationRecord a, RCSolutionPack_ApplicationRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_ApplicationRecord)) return false;
			return (this == (RCSolutionPack_ApplicationRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_Application.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_ApplicationRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_Application = new STSolutionPack_ApplicationStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_Application", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_Application' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_Application = (STSolutionPack_ApplicationStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_Application.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_Application.InternalRecursiveSave();
		}


		public RCSolutionPack_ApplicationRecord Duplicate() {
			RCSolutionPack_ApplicationRecord t;
			t.ssSTSolutionPack_Application = (STSolutionPack_ApplicationStructure) this.ssSTSolutionPack_Application.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_Application.ToXml(this, recordElem, "SolutionPack_Application", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_application") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_Application")) variable.Value = ssSTSolutionPack_Application; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_application");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_Application) {
				return ssSTSolutionPack_Application;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_Application.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_Application));
		}
		public bool IsDefault() {
			RCSolutionPack_ApplicationRecord defaultStruct = new RCSolutionPack_ApplicationRecord(null);
			if (this.ssSTSolutionPack_Application != defaultStruct.ssSTSolutionPack_Application) return false;
			return true;
		}
	} // RCSolutionPack_ApplicationRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_ApplicationModuleRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_ApplicationModuleRecord: ISerializable, ITypedRecord<RCSolutionPack_ApplicationModuleRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_ApplicationModule = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zFkWDeg+JWu2wMHuiahziQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_ApplicationModule")]
		public STSolutionPack_ApplicationModuleStructure ssSTSolutionPack_ApplicationModule;


		public static implicit operator STSolutionPack_ApplicationModuleStructure(RCSolutionPack_ApplicationModuleRecord r) {
			return r.ssSTSolutionPack_ApplicationModule;
		}

		public static implicit operator RCSolutionPack_ApplicationModuleRecord(STSolutionPack_ApplicationModuleStructure r) {
			RCSolutionPack_ApplicationModuleRecord res = new RCSolutionPack_ApplicationModuleRecord(null);
			res.ssSTSolutionPack_ApplicationModule = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_ApplicationModuleRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_ApplicationModule = new STSolutionPack_ApplicationModuleStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_ApplicationModule.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_ApplicationModule.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_ApplicationModuleRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_ApplicationModuleRecord a, RCSolutionPack_ApplicationModuleRecord b) {
			if (a.ssSTSolutionPack_ApplicationModule != b.ssSTSolutionPack_ApplicationModule) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_ApplicationModuleRecord a, RCSolutionPack_ApplicationModuleRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_ApplicationModuleRecord)) return false;
			return (this == (RCSolutionPack_ApplicationModuleRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_ApplicationModule.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_ApplicationModuleRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_ApplicationModule = new STSolutionPack_ApplicationModuleStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_ApplicationModule", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_ApplicationModule' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_ApplicationModule = (STSolutionPack_ApplicationModuleStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_ApplicationModule.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_ApplicationModule.InternalRecursiveSave();
		}


		public RCSolutionPack_ApplicationModuleRecord Duplicate() {
			RCSolutionPack_ApplicationModuleRecord t;
			t.ssSTSolutionPack_ApplicationModule = (STSolutionPack_ApplicationModuleStructure) this.ssSTSolutionPack_ApplicationModule.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_ApplicationModule.ToXml(this, recordElem, "SolutionPack_ApplicationModule", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_applicationmodule") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_ApplicationModule")) variable.Value = ssSTSolutionPack_ApplicationModule; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_applicationmodule");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_ApplicationModule) {
				return ssSTSolutionPack_ApplicationModule;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_ApplicationModule.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_ApplicationModule));
		}
		public bool IsDefault() {
			RCSolutionPack_ApplicationModuleRecord defaultStruct = new RCSolutionPack_ApplicationModuleRecord(null);
			if (this.ssSTSolutionPack_ApplicationModule != defaultStruct.ssSTSolutionPack_ApplicationModule) return false;
			return true;
		}
	} // RCSolutionPack_ApplicationModuleRecord

	/// <summary>
	/// Structure <code>RCExtensionEntityInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCExtensionEntityInfoRecord: ISerializable, ITypedRecord<RCExtensionEntityInfoRecord> {
		internal static readonly GlobalObjectKey IdExtensionEntityInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UuoyFr5iXims9N4ysNNOGw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ExtensionEntityInfo")]
		public STExtensionEntityInfoStructure ssSTExtensionEntityInfo;


		public static implicit operator STExtensionEntityInfoStructure(RCExtensionEntityInfoRecord r) {
			return r.ssSTExtensionEntityInfo;
		}

		public static implicit operator RCExtensionEntityInfoRecord(STExtensionEntityInfoStructure r) {
			RCExtensionEntityInfoRecord res = new RCExtensionEntityInfoRecord(null);
			res.ssSTExtensionEntityInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCExtensionEntityInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTExtensionEntityInfo = new STExtensionEntityInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTExtensionEntityInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTExtensionEntityInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCExtensionEntityInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCExtensionEntityInfoRecord a, RCExtensionEntityInfoRecord b) {
			if (a.ssSTExtensionEntityInfo != b.ssSTExtensionEntityInfo) return false;
			return true;
		}

		public static bool operator != (RCExtensionEntityInfoRecord a, RCExtensionEntityInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCExtensionEntityInfoRecord)) return false;
			return (this == (RCExtensionEntityInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTExtensionEntityInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCExtensionEntityInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTExtensionEntityInfo = new STExtensionEntityInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTExtensionEntityInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTExtensionEntityInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTExtensionEntityInfo = (STExtensionEntityInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTExtensionEntityInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTExtensionEntityInfo.InternalRecursiveSave();
		}


		public RCExtensionEntityInfoRecord Duplicate() {
			RCExtensionEntityInfoRecord t;
			t.ssSTExtensionEntityInfo = (STExtensionEntityInfoStructure) this.ssSTExtensionEntityInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTExtensionEntityInfo.ToXml(this, recordElem, "ExtensionEntityInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "extensionentityinfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtensionEntityInfo")) variable.Value = ssSTExtensionEntityInfo; else variable.Optimized = true;
				variable.SetFieldName("extensionentityinfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdExtensionEntityInfo) {
				return ssSTExtensionEntityInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTExtensionEntityInfo.FillFromOther((IRecord) other.AttributeGet(IdExtensionEntityInfo));
		}
		public bool IsDefault() {
			RCExtensionEntityInfoRecord defaultStruct = new RCExtensionEntityInfoRecord(null);
			if (this.ssSTExtensionEntityInfo != defaultStruct.ssSTExtensionEntityInfo) return false;
			return true;
		}
	} // RCExtensionEntityInfoRecord

	/// <summary>
	/// Structure <code>RCDALDBConfigParamRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDALDBConfigParamRecord: ISerializable, ITypedRecord<RCDALDBConfigParamRecord> {
		internal static readonly GlobalObjectKey IdDALDBConfigParam = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nBJhO4FzJtM5ZmJxgn9wnA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DALDBConfigParam")]
		public STDALDBConfigParamStructure ssSTDALDBConfigParam;


		public static implicit operator STDALDBConfigParamStructure(RCDALDBConfigParamRecord r) {
			return r.ssSTDALDBConfigParam;
		}

		public static implicit operator RCDALDBConfigParamRecord(STDALDBConfigParamStructure r) {
			RCDALDBConfigParamRecord res = new RCDALDBConfigParamRecord(null);
			res.ssSTDALDBConfigParam = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDALDBConfigParamRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDALDBConfigParam = new STDALDBConfigParamStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDALDBConfigParam.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDALDBConfigParam.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDALDBConfigParamRecord r) {
			this = r;
		}


		public static bool operator == (RCDALDBConfigParamRecord a, RCDALDBConfigParamRecord b) {
			if (a.ssSTDALDBConfigParam != b.ssSTDALDBConfigParam) return false;
			return true;
		}

		public static bool operator != (RCDALDBConfigParamRecord a, RCDALDBConfigParamRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDALDBConfigParamRecord)) return false;
			return (this == (RCDALDBConfigParamRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDALDBConfigParam.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDALDBConfigParamRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDALDBConfigParam = new STDALDBConfigParamStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDALDBConfigParam", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDALDBConfigParam' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDALDBConfigParam = (STDALDBConfigParamStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDALDBConfigParam.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDALDBConfigParam.InternalRecursiveSave();
		}


		public RCDALDBConfigParamRecord Duplicate() {
			RCDALDBConfigParamRecord t;
			t.ssSTDALDBConfigParam = (STDALDBConfigParamStructure) this.ssSTDALDBConfigParam.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDALDBConfigParam.ToXml(this, recordElem, "DALDBConfigParam", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "daldbconfigparam") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DALDBConfigParam")) variable.Value = ssSTDALDBConfigParam; else variable.Optimized = true;
				variable.SetFieldName("daldbconfigparam");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDALDBConfigParam) {
				return ssSTDALDBConfigParam;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDALDBConfigParam.FillFromOther((IRecord) other.AttributeGet(IdDALDBConfigParam));
		}
		public bool IsDefault() {
			RCDALDBConfigParamRecord defaultStruct = new RCDALDBConfigParamRecord(null);
			if (this.ssSTDALDBConfigParam != defaultStruct.ssSTDALDBConfigParam) return false;
			return true;
		}
	} // RCDALDBConfigParamRecord

	/// <summary>
	/// Structure <code>RCDALDBConfigProviderRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDALDBConfigProviderRecord: ISerializable, ITypedRecord<RCDALDBConfigProviderRecord> {
		internal static readonly GlobalObjectKey IdDALDBConfigProvider = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*v6l10YZj0jc2HbJqf9fqXg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DALDBConfigProvider")]
		public STDALDBConfigProviderStructure ssSTDALDBConfigProvider;


		public static implicit operator STDALDBConfigProviderStructure(RCDALDBConfigProviderRecord r) {
			return r.ssSTDALDBConfigProvider;
		}

		public static implicit operator RCDALDBConfigProviderRecord(STDALDBConfigProviderStructure r) {
			RCDALDBConfigProviderRecord res = new RCDALDBConfigProviderRecord(null);
			res.ssSTDALDBConfigProvider = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDALDBConfigProviderRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDALDBConfigProvider = new STDALDBConfigProviderStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDALDBConfigProvider.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDALDBConfigProvider.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDALDBConfigProviderRecord r) {
			this = r;
		}


		public static bool operator == (RCDALDBConfigProviderRecord a, RCDALDBConfigProviderRecord b) {
			if (a.ssSTDALDBConfigProvider != b.ssSTDALDBConfigProvider) return false;
			return true;
		}

		public static bool operator != (RCDALDBConfigProviderRecord a, RCDALDBConfigProviderRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDALDBConfigProviderRecord)) return false;
			return (this == (RCDALDBConfigProviderRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDALDBConfigProvider.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDALDBConfigProviderRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDALDBConfigProvider = new STDALDBConfigProviderStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDALDBConfigProvider", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDALDBConfigProvider' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDALDBConfigProvider = (STDALDBConfigProviderStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDALDBConfigProvider.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDALDBConfigProvider.InternalRecursiveSave();
		}


		public RCDALDBConfigProviderRecord Duplicate() {
			RCDALDBConfigProviderRecord t;
			t.ssSTDALDBConfigProvider = (STDALDBConfigProviderStructure) this.ssSTDALDBConfigProvider.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDALDBConfigProvider.ToXml(this, recordElem, "DALDBConfigProvider", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "daldbconfigprovider") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DALDBConfigProvider")) variable.Value = ssSTDALDBConfigProvider; else variable.Optimized = true;
				variable.SetFieldName("daldbconfigprovider");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDALDBConfigProvider) {
				return ssSTDALDBConfigProvider;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDALDBConfigProvider.FillFromOther((IRecord) other.AttributeGet(IdDALDBConfigProvider));
		}
		public bool IsDefault() {
			RCDALDBConfigProviderRecord defaultStruct = new RCDALDBConfigProviderRecord(null);
			if (this.ssSTDALDBConfigProvider != defaultStruct.ssSTDALDBConfigProvider) return false;
			return true;
		}
	} // RCDALDBConfigProviderRecord

	/// <summary>
	/// Structure <code>RCDALDBConfigEnumValueRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDALDBConfigEnumValueRecord: ISerializable, ITypedRecord<RCDALDBConfigEnumValueRecord> {
		internal static readonly GlobalObjectKey IdDALDBConfigEnumValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tKmD829LMWu9GKfbzIKLOQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DALDBConfigEnumValue")]
		public STDALDBConfigEnumValueStructure ssSTDALDBConfigEnumValue;


		public static implicit operator STDALDBConfigEnumValueStructure(RCDALDBConfigEnumValueRecord r) {
			return r.ssSTDALDBConfigEnumValue;
		}

		public static implicit operator RCDALDBConfigEnumValueRecord(STDALDBConfigEnumValueStructure r) {
			RCDALDBConfigEnumValueRecord res = new RCDALDBConfigEnumValueRecord(null);
			res.ssSTDALDBConfigEnumValue = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDALDBConfigEnumValueRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDALDBConfigEnumValue = new STDALDBConfigEnumValueStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDALDBConfigEnumValue.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDALDBConfigEnumValue.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDALDBConfigEnumValueRecord r) {
			this = r;
		}


		public static bool operator == (RCDALDBConfigEnumValueRecord a, RCDALDBConfigEnumValueRecord b) {
			if (a.ssSTDALDBConfigEnumValue != b.ssSTDALDBConfigEnumValue) return false;
			return true;
		}

		public static bool operator != (RCDALDBConfigEnumValueRecord a, RCDALDBConfigEnumValueRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDALDBConfigEnumValueRecord)) return false;
			return (this == (RCDALDBConfigEnumValueRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDALDBConfigEnumValue.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDALDBConfigEnumValueRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDALDBConfigEnumValue = new STDALDBConfigEnumValueStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDALDBConfigEnumValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDALDBConfigEnumValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDALDBConfigEnumValue = (STDALDBConfigEnumValueStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDALDBConfigEnumValue.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDALDBConfigEnumValue.InternalRecursiveSave();
		}


		public RCDALDBConfigEnumValueRecord Duplicate() {
			RCDALDBConfigEnumValueRecord t;
			t.ssSTDALDBConfigEnumValue = (STDALDBConfigEnumValueStructure) this.ssSTDALDBConfigEnumValue.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDALDBConfigEnumValue.ToXml(this, recordElem, "DALDBConfigEnumValue", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "daldbconfigenumvalue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DALDBConfigEnumValue")) variable.Value = ssSTDALDBConfigEnumValue; else variable.Optimized = true;
				variable.SetFieldName("daldbconfigenumvalue");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDALDBConfigEnumValue) {
				return ssSTDALDBConfigEnumValue;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDALDBConfigEnumValue.FillFromOther((IRecord) other.AttributeGet(IdDALDBConfigEnumValue));
		}
		public bool IsDefault() {
			RCDALDBConfigEnumValueRecord defaultStruct = new RCDALDBConfigEnumValueRecord(null);
			if (this.ssSTDALDBConfigEnumValue != defaultStruct.ssSTDALDBConfigEnumValue) return false;
			return true;
		}
	} // RCDALDBConfigEnumValueRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_ApplicationModulePublicElementRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_ApplicationModulePublicElementRecord: ISerializable, ITypedRecord<RCSolutionPack_ApplicationModulePublicElementRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_ApplicationModulePublicElement = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OowN5yfHWwGpDdzNU8M+BQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_ApplicationModulePublicElement")]
		public STSolutionPack_ApplicationModulePublicElementStructure ssSTSolutionPack_ApplicationModulePublicElement;


		public static implicit operator STSolutionPack_ApplicationModulePublicElementStructure(RCSolutionPack_ApplicationModulePublicElementRecord r) {
			return r.ssSTSolutionPack_ApplicationModulePublicElement;
		}

		public static implicit operator RCSolutionPack_ApplicationModulePublicElementRecord(STSolutionPack_ApplicationModulePublicElementStructure r) {
			RCSolutionPack_ApplicationModulePublicElementRecord res = new RCSolutionPack_ApplicationModulePublicElementRecord(null);
			res.ssSTSolutionPack_ApplicationModulePublicElement = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_ApplicationModulePublicElementRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_ApplicationModulePublicElement = new STSolutionPack_ApplicationModulePublicElementStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_ApplicationModulePublicElement.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_ApplicationModulePublicElement.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_ApplicationModulePublicElementRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_ApplicationModulePublicElementRecord a, RCSolutionPack_ApplicationModulePublicElementRecord b) {
			if (a.ssSTSolutionPack_ApplicationModulePublicElement != b.ssSTSolutionPack_ApplicationModulePublicElement) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_ApplicationModulePublicElementRecord a, RCSolutionPack_ApplicationModulePublicElementRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_ApplicationModulePublicElementRecord)) return false;
			return (this == (RCSolutionPack_ApplicationModulePublicElementRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_ApplicationModulePublicElement.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_ApplicationModulePublicElementRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_ApplicationModulePublicElement = new STSolutionPack_ApplicationModulePublicElementStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_ApplicationModulePublicElement", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_ApplicationModulePublicElement' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_ApplicationModulePublicElement = (STSolutionPack_ApplicationModulePublicElementStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_ApplicationModulePublicElement.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_ApplicationModulePublicElement.InternalRecursiveSave();
		}


		public RCSolutionPack_ApplicationModulePublicElementRecord Duplicate() {
			RCSolutionPack_ApplicationModulePublicElementRecord t;
			t.ssSTSolutionPack_ApplicationModulePublicElement = (STSolutionPack_ApplicationModulePublicElementStructure) this.ssSTSolutionPack_ApplicationModulePublicElement.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_ApplicationModulePublicElement.ToXml(this, recordElem, "SolutionPack_ApplicationModulePublicElement", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_applicationmodulepublicelement") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_ApplicationModulePublicElement")) variable.Value = ssSTSolutionPack_ApplicationModulePublicElement; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_applicationmodulepublicelement");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_ApplicationModulePublicElement) {
				return ssSTSolutionPack_ApplicationModulePublicElement;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_ApplicationModulePublicElement.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_ApplicationModulePublicElement));
		}
		public bool IsDefault() {
			RCSolutionPack_ApplicationModulePublicElementRecord defaultStruct = new RCSolutionPack_ApplicationModulePublicElementRecord(null);
			if (this.ssSTSolutionPack_ApplicationModulePublicElement != defaultStruct.ssSTSolutionPack_ApplicationModulePublicElement) return false;
			return true;
		}
	} // RCSolutionPack_ApplicationModulePublicElementRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_ApplicationDependencyRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_ApplicationDependencyRecord: ISerializable, ITypedRecord<RCSolutionPack_ApplicationDependencyRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_ApplicationDependency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wX0xk9aBHVaeGyC7dxz8Qw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_ApplicationDependency")]
		public STSolutionPack_ApplicationDependencyStructure ssSTSolutionPack_ApplicationDependency;


		public static implicit operator STSolutionPack_ApplicationDependencyStructure(RCSolutionPack_ApplicationDependencyRecord r) {
			return r.ssSTSolutionPack_ApplicationDependency;
		}

		public static implicit operator RCSolutionPack_ApplicationDependencyRecord(STSolutionPack_ApplicationDependencyStructure r) {
			RCSolutionPack_ApplicationDependencyRecord res = new RCSolutionPack_ApplicationDependencyRecord(null);
			res.ssSTSolutionPack_ApplicationDependency = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_ApplicationDependencyRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_ApplicationDependency = new STSolutionPack_ApplicationDependencyStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_ApplicationDependency.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_ApplicationDependency.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_ApplicationDependencyRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_ApplicationDependencyRecord a, RCSolutionPack_ApplicationDependencyRecord b) {
			if (a.ssSTSolutionPack_ApplicationDependency != b.ssSTSolutionPack_ApplicationDependency) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_ApplicationDependencyRecord a, RCSolutionPack_ApplicationDependencyRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_ApplicationDependencyRecord)) return false;
			return (this == (RCSolutionPack_ApplicationDependencyRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_ApplicationDependency.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_ApplicationDependencyRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_ApplicationDependency = new STSolutionPack_ApplicationDependencyStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_ApplicationDependency", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_ApplicationDependency' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_ApplicationDependency = (STSolutionPack_ApplicationDependencyStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_ApplicationDependency.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_ApplicationDependency.InternalRecursiveSave();
		}


		public RCSolutionPack_ApplicationDependencyRecord Duplicate() {
			RCSolutionPack_ApplicationDependencyRecord t;
			t.ssSTSolutionPack_ApplicationDependency = (STSolutionPack_ApplicationDependencyStructure) this.ssSTSolutionPack_ApplicationDependency.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_ApplicationDependency.ToXml(this, recordElem, "SolutionPack_ApplicationDependency", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_applicationdependency") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_ApplicationDependency")) variable.Value = ssSTSolutionPack_ApplicationDependency; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_applicationdependency");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_ApplicationDependency) {
				return ssSTSolutionPack_ApplicationDependency;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_ApplicationDependency.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_ApplicationDependency));
		}
		public bool IsDefault() {
			RCSolutionPack_ApplicationDependencyRecord defaultStruct = new RCSolutionPack_ApplicationDependencyRecord(null);
			if (this.ssSTSolutionPack_ApplicationDependency != defaultStruct.ssSTSolutionPack_ApplicationDependency) return false;
			return true;
		}
	} // RCSolutionPack_ApplicationDependencyRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_ApplicationReferencedModuleRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_ApplicationReferencedModuleRecord: ISerializable, ITypedRecord<RCSolutionPack_ApplicationReferencedModuleRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_ApplicationReferencedModule = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*droZ1koAR06P1ub4sxTjIg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_ApplicationReferencedModule")]
		public STSolutionPack_ApplicationReferencedModuleStructure ssSTSolutionPack_ApplicationReferencedModule;


		public static implicit operator STSolutionPack_ApplicationReferencedModuleStructure(RCSolutionPack_ApplicationReferencedModuleRecord r) {
			return r.ssSTSolutionPack_ApplicationReferencedModule;
		}

		public static implicit operator RCSolutionPack_ApplicationReferencedModuleRecord(STSolutionPack_ApplicationReferencedModuleStructure r) {
			RCSolutionPack_ApplicationReferencedModuleRecord res = new RCSolutionPack_ApplicationReferencedModuleRecord(null);
			res.ssSTSolutionPack_ApplicationReferencedModule = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_ApplicationReferencedModuleRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_ApplicationReferencedModule = new STSolutionPack_ApplicationReferencedModuleStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_ApplicationReferencedModule.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_ApplicationReferencedModule.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_ApplicationReferencedModuleRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_ApplicationReferencedModuleRecord a, RCSolutionPack_ApplicationReferencedModuleRecord b) {
			if (a.ssSTSolutionPack_ApplicationReferencedModule != b.ssSTSolutionPack_ApplicationReferencedModule) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_ApplicationReferencedModuleRecord a, RCSolutionPack_ApplicationReferencedModuleRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_ApplicationReferencedModuleRecord)) return false;
			return (this == (RCSolutionPack_ApplicationReferencedModuleRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_ApplicationReferencedModule.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_ApplicationReferencedModuleRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_ApplicationReferencedModule = new STSolutionPack_ApplicationReferencedModuleStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_ApplicationReferencedModule", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_ApplicationReferencedModule' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_ApplicationReferencedModule = (STSolutionPack_ApplicationReferencedModuleStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_ApplicationReferencedModule.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_ApplicationReferencedModule.InternalRecursiveSave();
		}


		public RCSolutionPack_ApplicationReferencedModuleRecord Duplicate() {
			RCSolutionPack_ApplicationReferencedModuleRecord t;
			t.ssSTSolutionPack_ApplicationReferencedModule = (STSolutionPack_ApplicationReferencedModuleStructure) this.ssSTSolutionPack_ApplicationReferencedModule.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_ApplicationReferencedModule.ToXml(this, recordElem, "SolutionPack_ApplicationReferencedModule", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_applicationreferencedmodule") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_ApplicationReferencedModule")) variable.Value = ssSTSolutionPack_ApplicationReferencedModule; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_applicationreferencedmodule");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_ApplicationReferencedModule) {
				return ssSTSolutionPack_ApplicationReferencedModule;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_ApplicationReferencedModule.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_ApplicationReferencedModule));
		}
		public bool IsDefault() {
			RCSolutionPack_ApplicationReferencedModuleRecord defaultStruct = new RCSolutionPack_ApplicationReferencedModuleRecord(null);
			if (this.ssSTSolutionPack_ApplicationReferencedModule != defaultStruct.ssSTSolutionPack_ApplicationReferencedModule) return false;
			return true;
		}
	} // RCSolutionPack_ApplicationReferencedModuleRecord

	/// <summary>
	/// Structure <code>RCEntityDBProviderKeyRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEntityDBProviderKeyRecord: ISerializable, ITypedRecord<RCEntityDBProviderKeyRecord> {
		internal static readonly GlobalObjectKey IdEntityDBProviderKey = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rLjj9aFcMxFFH3FXiyn+JA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EntityDBProviderKey")]
		public STEntityDBProviderKeyStructure ssSTEntityDBProviderKey;


		public static implicit operator STEntityDBProviderKeyStructure(RCEntityDBProviderKeyRecord r) {
			return r.ssSTEntityDBProviderKey;
		}

		public static implicit operator RCEntityDBProviderKeyRecord(STEntityDBProviderKeyStructure r) {
			RCEntityDBProviderKeyRecord res = new RCEntityDBProviderKeyRecord(null);
			res.ssSTEntityDBProviderKey = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEntityDBProviderKeyRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEntityDBProviderKey = new STEntityDBProviderKeyStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEntityDBProviderKey.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEntityDBProviderKey.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEntityDBProviderKeyRecord r) {
			this = r;
		}


		public static bool operator == (RCEntityDBProviderKeyRecord a, RCEntityDBProviderKeyRecord b) {
			if (a.ssSTEntityDBProviderKey != b.ssSTEntityDBProviderKey) return false;
			return true;
		}

		public static bool operator != (RCEntityDBProviderKeyRecord a, RCEntityDBProviderKeyRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEntityDBProviderKeyRecord)) return false;
			return (this == (RCEntityDBProviderKeyRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEntityDBProviderKey.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEntityDBProviderKeyRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEntityDBProviderKey = new STEntityDBProviderKeyStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEntityDBProviderKey", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEntityDBProviderKey' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEntityDBProviderKey = (STEntityDBProviderKeyStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEntityDBProviderKey.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEntityDBProviderKey.InternalRecursiveSave();
		}


		public RCEntityDBProviderKeyRecord Duplicate() {
			RCEntityDBProviderKeyRecord t;
			t.ssSTEntityDBProviderKey = (STEntityDBProviderKeyStructure) this.ssSTEntityDBProviderKey.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEntityDBProviderKey.ToXml(this, recordElem, "EntityDBProviderKey", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "entitydbproviderkey") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EntityDBProviderKey")) variable.Value = ssSTEntityDBProviderKey; else variable.Optimized = true;
				variable.SetFieldName("entitydbproviderkey");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEntityDBProviderKey) {
				return ssSTEntityDBProviderKey;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEntityDBProviderKey.FillFromOther((IRecord) other.AttributeGet(IdEntityDBProviderKey));
		}
		public bool IsDefault() {
			RCEntityDBProviderKeyRecord defaultStruct = new RCEntityDBProviderKeyRecord(null);
			if (this.ssSTEntityDBProviderKey != defaultStruct.ssSTEntityDBProviderKey) return false;
			return true;
		}
	} // RCEntityDBProviderKeyRecord

	/// <summary>
	/// Structure <code>RCDALEntityHighlightingHashRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDALEntityHighlightingHashRecord: ISerializable, ITypedRecord<RCDALEntityHighlightingHashRecord> {
		internal static readonly GlobalObjectKey IdDALEntityHighlightingHash = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Z9W8xnTQJkeRxhvWdUx6Qg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DALEntityHighlightingHash")]
		public STDALEntityHighlightingHashStructure ssSTDALEntityHighlightingHash;


		public static implicit operator STDALEntityHighlightingHashStructure(RCDALEntityHighlightingHashRecord r) {
			return r.ssSTDALEntityHighlightingHash;
		}

		public static implicit operator RCDALEntityHighlightingHashRecord(STDALEntityHighlightingHashStructure r) {
			RCDALEntityHighlightingHashRecord res = new RCDALEntityHighlightingHashRecord(null);
			res.ssSTDALEntityHighlightingHash = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDALEntityHighlightingHashRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDALEntityHighlightingHash = new STDALEntityHighlightingHashStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDALEntityHighlightingHash.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDALEntityHighlightingHash.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDALEntityHighlightingHashRecord r) {
			this = r;
		}


		public static bool operator == (RCDALEntityHighlightingHashRecord a, RCDALEntityHighlightingHashRecord b) {
			if (a.ssSTDALEntityHighlightingHash != b.ssSTDALEntityHighlightingHash) return false;
			return true;
		}

		public static bool operator != (RCDALEntityHighlightingHashRecord a, RCDALEntityHighlightingHashRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDALEntityHighlightingHashRecord)) return false;
			return (this == (RCDALEntityHighlightingHashRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDALEntityHighlightingHash.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDALEntityHighlightingHashRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDALEntityHighlightingHash = new STDALEntityHighlightingHashStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDALEntityHighlightingHash", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDALEntityHighlightingHash' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDALEntityHighlightingHash = (STDALEntityHighlightingHashStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDALEntityHighlightingHash.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDALEntityHighlightingHash.InternalRecursiveSave();
		}


		public RCDALEntityHighlightingHashRecord Duplicate() {
			RCDALEntityHighlightingHashRecord t;
			t.ssSTDALEntityHighlightingHash = (STDALEntityHighlightingHashStructure) this.ssSTDALEntityHighlightingHash.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDALEntityHighlightingHash.ToXml(this, recordElem, "DALEntityHighlightingHash", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "dalentityhighlightinghash") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DALEntityHighlightingHash")) variable.Value = ssSTDALEntityHighlightingHash; else variable.Optimized = true;
				variable.SetFieldName("dalentityhighlightinghash");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDALEntityHighlightingHash) {
				return ssSTDALEntityHighlightingHash;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDALEntityHighlightingHash.FillFromOther((IRecord) other.AttributeGet(IdDALEntityHighlightingHash));
		}
		public bool IsDefault() {
			RCDALEntityHighlightingHashRecord defaultStruct = new RCDALEntityHighlightingHashRecord(null);
			if (this.ssSTDALEntityHighlightingHash != defaultStruct.ssSTDALEntityHighlightingHash) return false;
			return true;
		}
	} // RCDALEntityHighlightingHashRecord

	/// <summary>
	/// Structure <code>RCDALHighlightingDefinitionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDALHighlightingDefinitionRecord: ISerializable, ITypedRecord<RCDALHighlightingDefinitionRecord> {
		internal static readonly GlobalObjectKey IdDALHighlightingDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bRqvf7f780htHucmM4pg4w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DALHighlightingDefinition")]
		public STDALHighlightingDefinitionStructure ssSTDALHighlightingDefinition;


		public static implicit operator STDALHighlightingDefinitionStructure(RCDALHighlightingDefinitionRecord r) {
			return r.ssSTDALHighlightingDefinition;
		}

		public static implicit operator RCDALHighlightingDefinitionRecord(STDALHighlightingDefinitionStructure r) {
			RCDALHighlightingDefinitionRecord res = new RCDALHighlightingDefinitionRecord(null);
			res.ssSTDALHighlightingDefinition = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDALHighlightingDefinitionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDALHighlightingDefinition = new STDALHighlightingDefinitionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDALHighlightingDefinition.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDALHighlightingDefinition.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDALHighlightingDefinitionRecord r) {
			this = r;
		}


		public static bool operator == (RCDALHighlightingDefinitionRecord a, RCDALHighlightingDefinitionRecord b) {
			if (a.ssSTDALHighlightingDefinition != b.ssSTDALHighlightingDefinition) return false;
			return true;
		}

		public static bool operator != (RCDALHighlightingDefinitionRecord a, RCDALHighlightingDefinitionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDALHighlightingDefinitionRecord)) return false;
			return (this == (RCDALHighlightingDefinitionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDALHighlightingDefinition.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDALHighlightingDefinitionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDALHighlightingDefinition = new STDALHighlightingDefinitionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDALHighlightingDefinition", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDALHighlightingDefinition' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDALHighlightingDefinition = (STDALHighlightingDefinitionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDALHighlightingDefinition.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDALHighlightingDefinition.InternalRecursiveSave();
		}


		public RCDALHighlightingDefinitionRecord Duplicate() {
			RCDALHighlightingDefinitionRecord t;
			t.ssSTDALHighlightingDefinition = (STDALHighlightingDefinitionStructure) this.ssSTDALHighlightingDefinition.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDALHighlightingDefinition.ToXml(this, recordElem, "DALHighlightingDefinition", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "dalhighlightingdefinition") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DALHighlightingDefinition")) variable.Value = ssSTDALHighlightingDefinition; else variable.Optimized = true;
				variable.SetFieldName("dalhighlightingdefinition");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDALHighlightingDefinition) {
				return ssSTDALHighlightingDefinition;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDALHighlightingDefinition.FillFromOther((IRecord) other.AttributeGet(IdDALHighlightingDefinition));
		}
		public bool IsDefault() {
			RCDALHighlightingDefinitionRecord defaultStruct = new RCDALHighlightingDefinitionRecord(null);
			if (this.ssSTDALHighlightingDefinition != defaultStruct.ssSTDALHighlightingDefinition) return false;
			return true;
		}
	} // RCDALHighlightingDefinitionRecord

	/// <summary>
	/// Structure <code>RCModuleDefinitionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCModuleDefinitionRecord: ISerializable, ITypedRecord<RCModuleDefinitionRecord> {
		internal static readonly GlobalObjectKey IdModuleDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iSFWvUoynfK_O51WDdBzig");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ModuleDefinition")]
		public STModuleDefinitionStructure ssSTModuleDefinition;


		public static implicit operator STModuleDefinitionStructure(RCModuleDefinitionRecord r) {
			return r.ssSTModuleDefinition;
		}

		public static implicit operator RCModuleDefinitionRecord(STModuleDefinitionStructure r) {
			RCModuleDefinitionRecord res = new RCModuleDefinitionRecord(null);
			res.ssSTModuleDefinition = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCModuleDefinitionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTModuleDefinition = new STModuleDefinitionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTModuleDefinition.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTModuleDefinition.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCModuleDefinitionRecord r) {
			this = r;
		}


		public static bool operator == (RCModuleDefinitionRecord a, RCModuleDefinitionRecord b) {
			if (a.ssSTModuleDefinition != b.ssSTModuleDefinition) return false;
			return true;
		}

		public static bool operator != (RCModuleDefinitionRecord a, RCModuleDefinitionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCModuleDefinitionRecord)) return false;
			return (this == (RCModuleDefinitionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTModuleDefinition.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCModuleDefinitionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTModuleDefinition = new STModuleDefinitionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTModuleDefinition", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTModuleDefinition' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTModuleDefinition = (STModuleDefinitionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTModuleDefinition.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTModuleDefinition.InternalRecursiveSave();
		}


		public RCModuleDefinitionRecord Duplicate() {
			RCModuleDefinitionRecord t;
			t.ssSTModuleDefinition = (STModuleDefinitionStructure) this.ssSTModuleDefinition.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTModuleDefinition.ToXml(this, recordElem, "ModuleDefinition", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "moduledefinition") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ModuleDefinition")) variable.Value = ssSTModuleDefinition; else variable.Optimized = true;
				variable.SetFieldName("moduledefinition");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdModuleDefinition) {
				return ssSTModuleDefinition;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTModuleDefinition.FillFromOther((IRecord) other.AttributeGet(IdModuleDefinition));
		}
		public bool IsDefault() {
			RCModuleDefinitionRecord defaultStruct = new RCModuleDefinitionRecord(null);
			if (this.ssSTModuleDefinition != defaultStruct.ssSTModuleDefinition) return false;
			return true;
		}
	} // RCModuleDefinitionRecord

	/// <summary>
	/// Structure <code>RCEntityDefinitionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEntityDefinitionRecord: ISerializable, ITypedRecord<RCEntityDefinitionRecord> {
		internal static readonly GlobalObjectKey IdEntityDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Jl1NVd4Lp6XE9tyvW9e22Q");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EntityDefinition")]
		public STEntityDefinitionStructure ssSTEntityDefinition;


		public static implicit operator STEntityDefinitionStructure(RCEntityDefinitionRecord r) {
			return r.ssSTEntityDefinition;
		}

		public static implicit operator RCEntityDefinitionRecord(STEntityDefinitionStructure r) {
			RCEntityDefinitionRecord res = new RCEntityDefinitionRecord(null);
			res.ssSTEntityDefinition = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEntityDefinitionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEntityDefinition = new STEntityDefinitionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEntityDefinition.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEntityDefinition.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEntityDefinitionRecord r) {
			this = r;
		}


		public static bool operator == (RCEntityDefinitionRecord a, RCEntityDefinitionRecord b) {
			if (a.ssSTEntityDefinition != b.ssSTEntityDefinition) return false;
			return true;
		}

		public static bool operator != (RCEntityDefinitionRecord a, RCEntityDefinitionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEntityDefinitionRecord)) return false;
			return (this == (RCEntityDefinitionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEntityDefinition.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEntityDefinitionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEntityDefinition = new STEntityDefinitionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEntityDefinition", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEntityDefinition' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEntityDefinition = (STEntityDefinitionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEntityDefinition.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEntityDefinition.InternalRecursiveSave();
		}


		public RCEntityDefinitionRecord Duplicate() {
			RCEntityDefinitionRecord t;
			t.ssSTEntityDefinition = (STEntityDefinitionStructure) this.ssSTEntityDefinition.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEntityDefinition.ToXml(this, recordElem, "EntityDefinition", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "entitydefinition") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EntityDefinition")) variable.Value = ssSTEntityDefinition; else variable.Optimized = true;
				variable.SetFieldName("entitydefinition");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEntityDefinition) {
				return ssSTEntityDefinition;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEntityDefinition.FillFromOther((IRecord) other.AttributeGet(IdEntityDefinition));
		}
		public bool IsDefault() {
			RCEntityDefinitionRecord defaultStruct = new RCEntityDefinitionRecord(null);
			if (this.ssSTEntityDefinition != defaultStruct.ssSTEntityDefinition) return false;
			return true;
		}
	} // RCEntityDefinitionRecord

	/// <summary>
	/// Structure <code>RCAttributeDefinitionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAttributeDefinitionRecord: ISerializable, ITypedRecord<RCAttributeDefinitionRecord> {
		internal static readonly GlobalObjectKey IdAttributeDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*aafbEXR_PRwOH3OaBZP1PQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("AttributeDefinition")]
		public STAttributeDefinitionStructure ssSTAttributeDefinition;


		public static implicit operator STAttributeDefinitionStructure(RCAttributeDefinitionRecord r) {
			return r.ssSTAttributeDefinition;
		}

		public static implicit operator RCAttributeDefinitionRecord(STAttributeDefinitionStructure r) {
			RCAttributeDefinitionRecord res = new RCAttributeDefinitionRecord(null);
			res.ssSTAttributeDefinition = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAttributeDefinitionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAttributeDefinition = new STAttributeDefinitionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAttributeDefinition.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAttributeDefinition.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAttributeDefinitionRecord r) {
			this = r;
		}


		public static bool operator == (RCAttributeDefinitionRecord a, RCAttributeDefinitionRecord b) {
			if (a.ssSTAttributeDefinition != b.ssSTAttributeDefinition) return false;
			return true;
		}

		public static bool operator != (RCAttributeDefinitionRecord a, RCAttributeDefinitionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAttributeDefinitionRecord)) return false;
			return (this == (RCAttributeDefinitionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAttributeDefinition.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAttributeDefinitionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAttributeDefinition = new STAttributeDefinitionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAttributeDefinition", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAttributeDefinition' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAttributeDefinition = (STAttributeDefinitionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAttributeDefinition.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAttributeDefinition.InternalRecursiveSave();
		}


		public RCAttributeDefinitionRecord Duplicate() {
			RCAttributeDefinitionRecord t;
			t.ssSTAttributeDefinition = (STAttributeDefinitionStructure) this.ssSTAttributeDefinition.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAttributeDefinition.ToXml(this, recordElem, "AttributeDefinition", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "attributedefinition") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AttributeDefinition")) variable.Value = ssSTAttributeDefinition; else variable.Optimized = true;
				variable.SetFieldName("attributedefinition");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAttributeDefinition) {
				return ssSTAttributeDefinition;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAttributeDefinition.FillFromOther((IRecord) other.AttributeGet(IdAttributeDefinition));
		}
		public bool IsDefault() {
			RCAttributeDefinitionRecord defaultStruct = new RCAttributeDefinitionRecord(null);
			if (this.ssSTAttributeDefinition != defaultStruct.ssSTAttributeDefinition) return false;
			return true;
		}
	} // RCAttributeDefinitionRecord

	/// <summary>
	/// Structure <code>RCModuleVersionDefinitionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCModuleVersionDefinitionRecord: ISerializable, ITypedRecord<RCModuleVersionDefinitionRecord> {
		internal static readonly GlobalObjectKey IdModuleVersionDefinition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*INPTvEZkWl+0YYiqa6RkGw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ModuleVersionDefinition")]
		public STModuleVersionDefinitionStructure ssSTModuleVersionDefinition;


		public static implicit operator STModuleVersionDefinitionStructure(RCModuleVersionDefinitionRecord r) {
			return r.ssSTModuleVersionDefinition;
		}

		public static implicit operator RCModuleVersionDefinitionRecord(STModuleVersionDefinitionStructure r) {
			RCModuleVersionDefinitionRecord res = new RCModuleVersionDefinitionRecord(null);
			res.ssSTModuleVersionDefinition = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCModuleVersionDefinitionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTModuleVersionDefinition = new STModuleVersionDefinitionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTModuleVersionDefinition.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTModuleVersionDefinition.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCModuleVersionDefinitionRecord r) {
			this = r;
		}


		public static bool operator == (RCModuleVersionDefinitionRecord a, RCModuleVersionDefinitionRecord b) {
			if (a.ssSTModuleVersionDefinition != b.ssSTModuleVersionDefinition) return false;
			return true;
		}

		public static bool operator != (RCModuleVersionDefinitionRecord a, RCModuleVersionDefinitionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCModuleVersionDefinitionRecord)) return false;
			return (this == (RCModuleVersionDefinitionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTModuleVersionDefinition.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCModuleVersionDefinitionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTModuleVersionDefinition = new STModuleVersionDefinitionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTModuleVersionDefinition", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTModuleVersionDefinition' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTModuleVersionDefinition = (STModuleVersionDefinitionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTModuleVersionDefinition.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTModuleVersionDefinition.InternalRecursiveSave();
		}


		public RCModuleVersionDefinitionRecord Duplicate() {
			RCModuleVersionDefinitionRecord t;
			t.ssSTModuleVersionDefinition = (STModuleVersionDefinitionStructure) this.ssSTModuleVersionDefinition.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTModuleVersionDefinition.ToXml(this, recordElem, "ModuleVersionDefinition", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "moduleversiondefinition") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ModuleVersionDefinition")) variable.Value = ssSTModuleVersionDefinition; else variable.Optimized = true;
				variable.SetFieldName("moduleversiondefinition");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdModuleVersionDefinition) {
				return ssSTModuleVersionDefinition;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTModuleVersionDefinition.FillFromOther((IRecord) other.AttributeGet(IdModuleVersionDefinition));
		}
		public bool IsDefault() {
			RCModuleVersionDefinitionRecord defaultStruct = new RCModuleVersionDefinitionRecord(null);
			if (this.ssSTModuleVersionDefinition != defaultStruct.ssSTModuleVersionDefinition) return false;
			return true;
		}
	} // RCModuleVersionDefinitionRecord

	/// <summary>
	/// Structure <code>RCExternalAuthentication_PluginAPIStatusRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCExternalAuthentication_PluginAPIStatusRecord: ISerializable, ITypedRecord<RCExternalAuthentication_PluginAPIStatusRecord> {
		internal static readonly GlobalObjectKey IdExternalAuthentication_PluginAPIStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*R3AvyZjRCtrl22T3tPRD1g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ExternalAuthentication_PluginAPIStatus")]
		public STExternalAuthentication_PluginAPIStatusStructure ssSTExternalAuthentication_PluginAPIStatus;


		public static implicit operator STExternalAuthentication_PluginAPIStatusStructure(RCExternalAuthentication_PluginAPIStatusRecord r) {
			return r.ssSTExternalAuthentication_PluginAPIStatus;
		}

		public static implicit operator RCExternalAuthentication_PluginAPIStatusRecord(STExternalAuthentication_PluginAPIStatusStructure r) {
			RCExternalAuthentication_PluginAPIStatusRecord res = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			res.ssSTExternalAuthentication_PluginAPIStatus = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCExternalAuthentication_PluginAPIStatusRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTExternalAuthentication_PluginAPIStatus = new STExternalAuthentication_PluginAPIStatusStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTExternalAuthentication_PluginAPIStatus.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTExternalAuthentication_PluginAPIStatus.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCExternalAuthentication_PluginAPIStatusRecord r) {
			this = r;
		}


		public static bool operator == (RCExternalAuthentication_PluginAPIStatusRecord a, RCExternalAuthentication_PluginAPIStatusRecord b) {
			if (a.ssSTExternalAuthentication_PluginAPIStatus != b.ssSTExternalAuthentication_PluginAPIStatus) return false;
			return true;
		}

		public static bool operator != (RCExternalAuthentication_PluginAPIStatusRecord a, RCExternalAuthentication_PluginAPIStatusRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCExternalAuthentication_PluginAPIStatusRecord)) return false;
			return (this == (RCExternalAuthentication_PluginAPIStatusRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTExternalAuthentication_PluginAPIStatus.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCExternalAuthentication_PluginAPIStatusRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTExternalAuthentication_PluginAPIStatus = new STExternalAuthentication_PluginAPIStatusStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTExternalAuthentication_PluginAPIStatus", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTExternalAuthentication_PluginAPIStatus' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTExternalAuthentication_PluginAPIStatus = (STExternalAuthentication_PluginAPIStatusStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTExternalAuthentication_PluginAPIStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTExternalAuthentication_PluginAPIStatus.InternalRecursiveSave();
		}


		public RCExternalAuthentication_PluginAPIStatusRecord Duplicate() {
			RCExternalAuthentication_PluginAPIStatusRecord t;
			t.ssSTExternalAuthentication_PluginAPIStatus = (STExternalAuthentication_PluginAPIStatusStructure) this.ssSTExternalAuthentication_PluginAPIStatus.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTExternalAuthentication_PluginAPIStatus.ToXml(this, recordElem, "ExternalAuthentication_PluginAPIStatus", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "externalauthentication_pluginapistatus") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ExternalAuthentication_PluginAPIStatus")) variable.Value = ssSTExternalAuthentication_PluginAPIStatus; else variable.Optimized = true;
				variable.SetFieldName("externalauthentication_pluginapistatus");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdExternalAuthentication_PluginAPIStatus) {
				return ssSTExternalAuthentication_PluginAPIStatus;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTExternalAuthentication_PluginAPIStatus.FillFromOther((IRecord) other.AttributeGet(IdExternalAuthentication_PluginAPIStatus));
		}
		public bool IsDefault() {
			RCExternalAuthentication_PluginAPIStatusRecord defaultStruct = new RCExternalAuthentication_PluginAPIStatusRecord(null);
			if (this.ssSTExternalAuthentication_PluginAPIStatus != defaultStruct.ssSTExternalAuthentication_PluginAPIStatus) return false;
			return true;
		}
	} // RCExternalAuthentication_PluginAPIStatusRecord

	/// <summary>
	/// Structure <code>RCIntegrationPluginInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCIntegrationPluginInfoRecord: ISerializable, ITypedRecord<RCIntegrationPluginInfoRecord> {
		internal static readonly GlobalObjectKey IdIntegrationPluginInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*j1og5X1em26SvlVIC73xXA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("IntegrationPluginInfo")]
		public STIntegrationPluginInfoStructure ssSTIntegrationPluginInfo;


		public static implicit operator STIntegrationPluginInfoStructure(RCIntegrationPluginInfoRecord r) {
			return r.ssSTIntegrationPluginInfo;
		}

		public static implicit operator RCIntegrationPluginInfoRecord(STIntegrationPluginInfoStructure r) {
			RCIntegrationPluginInfoRecord res = new RCIntegrationPluginInfoRecord(null);
			res.ssSTIntegrationPluginInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCIntegrationPluginInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTIntegrationPluginInfo = new STIntegrationPluginInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTIntegrationPluginInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTIntegrationPluginInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCIntegrationPluginInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCIntegrationPluginInfoRecord a, RCIntegrationPluginInfoRecord b) {
			if (a.ssSTIntegrationPluginInfo != b.ssSTIntegrationPluginInfo) return false;
			return true;
		}

		public static bool operator != (RCIntegrationPluginInfoRecord a, RCIntegrationPluginInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCIntegrationPluginInfoRecord)) return false;
			return (this == (RCIntegrationPluginInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTIntegrationPluginInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCIntegrationPluginInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTIntegrationPluginInfo = new STIntegrationPluginInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTIntegrationPluginInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTIntegrationPluginInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTIntegrationPluginInfo = (STIntegrationPluginInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTIntegrationPluginInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTIntegrationPluginInfo.InternalRecursiveSave();
		}


		public RCIntegrationPluginInfoRecord Duplicate() {
			RCIntegrationPluginInfoRecord t;
			t.ssSTIntegrationPluginInfo = (STIntegrationPluginInfoStructure) this.ssSTIntegrationPluginInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTIntegrationPluginInfo.ToXml(this, recordElem, "IntegrationPluginInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "integrationplugininfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IntegrationPluginInfo")) variable.Value = ssSTIntegrationPluginInfo; else variable.Optimized = true;
				variable.SetFieldName("integrationplugininfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdIntegrationPluginInfo) {
				return ssSTIntegrationPluginInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTIntegrationPluginInfo.FillFromOther((IRecord) other.AttributeGet(IdIntegrationPluginInfo));
		}
		public bool IsDefault() {
			RCIntegrationPluginInfoRecord defaultStruct = new RCIntegrationPluginInfoRecord(null);
			if (this.ssSTIntegrationPluginInfo != defaultStruct.ssSTIntegrationPluginInfo) return false;
			return true;
		}
	} // RCIntegrationPluginInfoRecord

	/// <summary>
	/// Structure <code>RCFileRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCFileRecord: ISerializable, ITypedRecord<RCFileRecord> {
		internal static readonly GlobalObjectKey IdFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NQkt9hwEGaMVwTnEtpLSjg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("File")]
		public STFileStructure ssSTFile;


		public static implicit operator STFileStructure(RCFileRecord r) {
			return r.ssSTFile;
		}

		public static implicit operator RCFileRecord(STFileStructure r) {
			RCFileRecord res = new RCFileRecord(null);
			res.ssSTFile = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCFileRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTFile = new STFileStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTFile.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTFile.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCFileRecord r) {
			this = r;
		}


		public static bool operator == (RCFileRecord a, RCFileRecord b) {
			if (a.ssSTFile != b.ssSTFile) return false;
			return true;
		}

		public static bool operator != (RCFileRecord a, RCFileRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCFileRecord)) return false;
			return (this == (RCFileRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTFile.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCFileRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTFile = new STFileStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTFile", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTFile' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTFile = (STFileStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTFile.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTFile.InternalRecursiveSave();
		}


		public RCFileRecord Duplicate() {
			RCFileRecord t;
			t.ssSTFile = (STFileStructure) this.ssSTFile.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTFile.ToXml(this, recordElem, "File", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "file") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".File")) variable.Value = ssSTFile; else variable.Optimized = true;
				variable.SetFieldName("file");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdFile) {
				return ssSTFile;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTFile.FillFromOther((IRecord) other.AttributeGet(IdFile));
		}
		public bool IsDefault() {
			RCFileRecord defaultStruct = new RCFileRecord(null);
			if (this.ssSTFile != defaultStruct.ssSTFile) return false;
			return true;
		}
	} // RCFileRecord

	/// <summary>
	/// Structure <code>RCLoginAttemptRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCLoginAttemptRecord: ISerializable, ITypedRecord<RCLoginAttemptRecord> {
		internal static readonly GlobalObjectKey IdLoginAttempt = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZNyMexvNKedcwH8wd8YNGQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("LoginAttempt")]
		public STLoginAttemptStructure ssSTLoginAttempt;


		public static implicit operator STLoginAttemptStructure(RCLoginAttemptRecord r) {
			return r.ssSTLoginAttempt;
		}

		public static implicit operator RCLoginAttemptRecord(STLoginAttemptStructure r) {
			RCLoginAttemptRecord res = new RCLoginAttemptRecord(null);
			res.ssSTLoginAttempt = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCLoginAttemptRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTLoginAttempt = new STLoginAttemptStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTLoginAttempt.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTLoginAttempt.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCLoginAttemptRecord r) {
			this = r;
		}


		public static bool operator == (RCLoginAttemptRecord a, RCLoginAttemptRecord b) {
			if (a.ssSTLoginAttempt != b.ssSTLoginAttempt) return false;
			return true;
		}

		public static bool operator != (RCLoginAttemptRecord a, RCLoginAttemptRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCLoginAttemptRecord)) return false;
			return (this == (RCLoginAttemptRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTLoginAttempt.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCLoginAttemptRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTLoginAttempt = new STLoginAttemptStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTLoginAttempt", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTLoginAttempt' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTLoginAttempt = (STLoginAttemptStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTLoginAttempt.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTLoginAttempt.InternalRecursiveSave();
		}


		public RCLoginAttemptRecord Duplicate() {
			RCLoginAttemptRecord t;
			t.ssSTLoginAttempt = (STLoginAttemptStructure) this.ssSTLoginAttempt.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTLoginAttempt.ToXml(this, recordElem, "LoginAttempt", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "loginattempt") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".LoginAttempt")) variable.Value = ssSTLoginAttempt; else variable.Optimized = true;
				variable.SetFieldName("loginattempt");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdLoginAttempt) {
				return ssSTLoginAttempt;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTLoginAttempt.FillFromOther((IRecord) other.AttributeGet(IdLoginAttempt));
		}
		public bool IsDefault() {
			RCLoginAttemptRecord defaultStruct = new RCLoginAttemptRecord(null);
			if (this.ssSTLoginAttempt != defaultStruct.ssSTLoginAttempt) return false;
			return true;
		}
	} // RCLoginAttemptRecord

	/// <summary>
	/// Structure <code>RCJWTClaimsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCJWTClaimsRecord: ISerializable, ITypedRecord<RCJWTClaimsRecord> {
		internal static readonly GlobalObjectKey IdJWTClaims = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OSA6XK1h2sdQicPOQo8AXQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("JWTClaims")]
		public STJWTClaimsStructure ssSTJWTClaims;


		public static implicit operator STJWTClaimsStructure(RCJWTClaimsRecord r) {
			return r.ssSTJWTClaims;
		}

		public static implicit operator RCJWTClaimsRecord(STJWTClaimsStructure r) {
			RCJWTClaimsRecord res = new RCJWTClaimsRecord(null);
			res.ssSTJWTClaims = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCJWTClaimsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTJWTClaims = new STJWTClaimsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTJWTClaims.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTJWTClaims.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCJWTClaimsRecord r) {
			this = r;
		}


		public static bool operator == (RCJWTClaimsRecord a, RCJWTClaimsRecord b) {
			if (a.ssSTJWTClaims != b.ssSTJWTClaims) return false;
			return true;
		}

		public static bool operator != (RCJWTClaimsRecord a, RCJWTClaimsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCJWTClaimsRecord)) return false;
			return (this == (RCJWTClaimsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTJWTClaims.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCJWTClaimsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTJWTClaims = new STJWTClaimsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTJWTClaims", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTJWTClaims' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTJWTClaims = (STJWTClaimsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTJWTClaims.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTJWTClaims.InternalRecursiveSave();
		}


		public RCJWTClaimsRecord Duplicate() {
			RCJWTClaimsRecord t;
			t.ssSTJWTClaims = (STJWTClaimsStructure) this.ssSTJWTClaims.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTJWTClaims.ToXml(this, recordElem, "JWTClaims", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "jwtclaims") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".JWTClaims")) variable.Value = ssSTJWTClaims; else variable.Optimized = true;
				variable.SetFieldName("jwtclaims");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdJWTClaims) {
				return ssSTJWTClaims;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTJWTClaims.FillFromOther((IRecord) other.AttributeGet(IdJWTClaims));
		}
		public bool IsDefault() {
			RCJWTClaimsRecord defaultStruct = new RCJWTClaimsRecord(null);
			if (this.ssSTJWTClaims != defaultStruct.ssSTJWTClaims) return false;
			return true;
		}
	} // RCJWTClaimsRecord

	/// <summary>
	/// Structure <code>RCQueuedNativeBuildResultRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCQueuedNativeBuildResultRecord: ISerializable, ITypedRecord<RCQueuedNativeBuildResultRecord> {
		internal static readonly GlobalObjectKey IdQueuedNativeBuildResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ETB6b0O1djke6fmSYR13XQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("QueuedNativeBuildResult")]
		public STQueuedNativeBuildResultStructure ssSTQueuedNativeBuildResult;


		public static implicit operator STQueuedNativeBuildResultStructure(RCQueuedNativeBuildResultRecord r) {
			return r.ssSTQueuedNativeBuildResult;
		}

		public static implicit operator RCQueuedNativeBuildResultRecord(STQueuedNativeBuildResultStructure r) {
			RCQueuedNativeBuildResultRecord res = new RCQueuedNativeBuildResultRecord(null);
			res.ssSTQueuedNativeBuildResult = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCQueuedNativeBuildResultRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTQueuedNativeBuildResult = new STQueuedNativeBuildResultStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTQueuedNativeBuildResult.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTQueuedNativeBuildResult.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCQueuedNativeBuildResultRecord r) {
			this = r;
		}


		public static bool operator == (RCQueuedNativeBuildResultRecord a, RCQueuedNativeBuildResultRecord b) {
			if (a.ssSTQueuedNativeBuildResult != b.ssSTQueuedNativeBuildResult) return false;
			return true;
		}

		public static bool operator != (RCQueuedNativeBuildResultRecord a, RCQueuedNativeBuildResultRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCQueuedNativeBuildResultRecord)) return false;
			return (this == (RCQueuedNativeBuildResultRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTQueuedNativeBuildResult.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCQueuedNativeBuildResultRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTQueuedNativeBuildResult = new STQueuedNativeBuildResultStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTQueuedNativeBuildResult", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTQueuedNativeBuildResult' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTQueuedNativeBuildResult = (STQueuedNativeBuildResultStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTQueuedNativeBuildResult.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTQueuedNativeBuildResult.InternalRecursiveSave();
		}


		public RCQueuedNativeBuildResultRecord Duplicate() {
			RCQueuedNativeBuildResultRecord t;
			t.ssSTQueuedNativeBuildResult = (STQueuedNativeBuildResultStructure) this.ssSTQueuedNativeBuildResult.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTQueuedNativeBuildResult.ToXml(this, recordElem, "QueuedNativeBuildResult", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "queuednativebuildresult") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".QueuedNativeBuildResult")) variable.Value = ssSTQueuedNativeBuildResult; else variable.Optimized = true;
				variable.SetFieldName("queuednativebuildresult");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdQueuedNativeBuildResult) {
				return ssSTQueuedNativeBuildResult;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTQueuedNativeBuildResult.FillFromOther((IRecord) other.AttributeGet(IdQueuedNativeBuildResult));
		}
		public bool IsDefault() {
			RCQueuedNativeBuildResultRecord defaultStruct = new RCQueuedNativeBuildResultRecord(null);
			if (this.ssSTQueuedNativeBuildResult != defaultStruct.ssSTQueuedNativeBuildResult) return false;
			return true;
		}
	} // RCQueuedNativeBuildResultRecord

	/// <summary>
	/// Structure <code>RCNativePluginConfigurationRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCNativePluginConfigurationRecord: ISerializable, ITypedRecord<RCNativePluginConfigurationRecord> {
		internal static readonly GlobalObjectKey IdNativePluginConfiguration = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2k7OZmKfhyg2zUSu0Eg0Ow");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("NativePluginConfiguration")]
		public STNativePluginConfigurationStructure ssSTNativePluginConfiguration;


		public static implicit operator STNativePluginConfigurationStructure(RCNativePluginConfigurationRecord r) {
			return r.ssSTNativePluginConfiguration;
		}

		public static implicit operator RCNativePluginConfigurationRecord(STNativePluginConfigurationStructure r) {
			RCNativePluginConfigurationRecord res = new RCNativePluginConfigurationRecord(null);
			res.ssSTNativePluginConfiguration = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCNativePluginConfigurationRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTNativePluginConfiguration = new STNativePluginConfigurationStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTNativePluginConfiguration.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTNativePluginConfiguration.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCNativePluginConfigurationRecord r) {
			this = r;
		}


		public static bool operator == (RCNativePluginConfigurationRecord a, RCNativePluginConfigurationRecord b) {
			if (a.ssSTNativePluginConfiguration != b.ssSTNativePluginConfiguration) return false;
			return true;
		}

		public static bool operator != (RCNativePluginConfigurationRecord a, RCNativePluginConfigurationRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCNativePluginConfigurationRecord)) return false;
			return (this == (RCNativePluginConfigurationRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTNativePluginConfiguration.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCNativePluginConfigurationRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTNativePluginConfiguration = new STNativePluginConfigurationStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTNativePluginConfiguration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTNativePluginConfiguration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTNativePluginConfiguration = (STNativePluginConfigurationStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTNativePluginConfiguration.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTNativePluginConfiguration.InternalRecursiveSave();
		}


		public RCNativePluginConfigurationRecord Duplicate() {
			RCNativePluginConfigurationRecord t;
			t.ssSTNativePluginConfiguration = (STNativePluginConfigurationStructure) this.ssSTNativePluginConfiguration.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTNativePluginConfiguration.ToXml(this, recordElem, "NativePluginConfiguration", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "nativepluginconfiguration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".NativePluginConfiguration")) variable.Value = ssSTNativePluginConfiguration; else variable.Optimized = true;
				variable.SetFieldName("nativepluginconfiguration");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdNativePluginConfiguration) {
				return ssSTNativePluginConfiguration;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTNativePluginConfiguration.FillFromOther((IRecord) other.AttributeGet(IdNativePluginConfiguration));
		}
		public bool IsDefault() {
			RCNativePluginConfigurationRecord defaultStruct = new RCNativePluginConfigurationRecord(null);
			if (this.ssSTNativePluginConfiguration != defaultStruct.ssSTNativePluginConfiguration) return false;
			return true;
		}
	} // RCNativePluginConfigurationRecord

	/// <summary>
	/// Structure <code>RCUserWithUserPoolRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCUserWithUserPoolRecord: ISerializable, ITypedRecord<RCUserWithUserPoolRecord> {
		internal static readonly GlobalObjectKey IdUserWithUserPool = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*uIb9SN5Y9dXFu8wMD_BGEw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("UserWithUserPool")]
		public STUserWithUserPoolStructure ssSTUserWithUserPool;


		public static implicit operator STUserWithUserPoolStructure(RCUserWithUserPoolRecord r) {
			return r.ssSTUserWithUserPool;
		}

		public static implicit operator RCUserWithUserPoolRecord(STUserWithUserPoolStructure r) {
			RCUserWithUserPoolRecord res = new RCUserWithUserPoolRecord(null);
			res.ssSTUserWithUserPool = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCUserWithUserPoolRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTUserWithUserPool = new STUserWithUserPoolStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTUserWithUserPool.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTUserWithUserPool.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCUserWithUserPoolRecord r) {
			this = r;
		}


		public static bool operator == (RCUserWithUserPoolRecord a, RCUserWithUserPoolRecord b) {
			if (a.ssSTUserWithUserPool != b.ssSTUserWithUserPool) return false;
			return true;
		}

		public static bool operator != (RCUserWithUserPoolRecord a, RCUserWithUserPoolRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCUserWithUserPoolRecord)) return false;
			return (this == (RCUserWithUserPoolRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTUserWithUserPool.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCUserWithUserPoolRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTUserWithUserPool = new STUserWithUserPoolStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTUserWithUserPool", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTUserWithUserPool' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTUserWithUserPool = (STUserWithUserPoolStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTUserWithUserPool.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTUserWithUserPool.InternalRecursiveSave();
		}


		public RCUserWithUserPoolRecord Duplicate() {
			RCUserWithUserPoolRecord t;
			t.ssSTUserWithUserPool = (STUserWithUserPoolStructure) this.ssSTUserWithUserPool.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTUserWithUserPool.ToXml(this, recordElem, "UserWithUserPool", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "userwithuserpool") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UserWithUserPool")) variable.Value = ssSTUserWithUserPool; else variable.Optimized = true;
				variable.SetFieldName("userwithuserpool");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdUserWithUserPool) {
				return ssSTUserWithUserPool;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTUserWithUserPool.FillFromOther((IRecord) other.AttributeGet(IdUserWithUserPool));
		}
		public bool IsDefault() {
			RCUserWithUserPoolRecord defaultStruct = new RCUserWithUserPoolRecord(null);
			if (this.ssSTUserWithUserPool != defaultStruct.ssSTUserWithUserPool) return false;
			return true;
		}
	} // RCUserWithUserPoolRecord

	/// <summary>
	/// Structure <code>RCDeploymentDetailsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentDetailsRecord: ISerializable, ITypedRecord<RCDeploymentDetailsRecord> {
		internal static readonly GlobalObjectKey IdDeploymentDetails = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5YzuXBsvTXz_g+gFu8p5w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentDetails")]
		public STDeploymentDetailsStructure ssSTDeploymentDetails;


		public static implicit operator STDeploymentDetailsStructure(RCDeploymentDetailsRecord r) {
			return r.ssSTDeploymentDetails;
		}

		public static implicit operator RCDeploymentDetailsRecord(STDeploymentDetailsStructure r) {
			RCDeploymentDetailsRecord res = new RCDeploymentDetailsRecord(null);
			res.ssSTDeploymentDetails = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentDetailsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentDetails = new STDeploymentDetailsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentDetails.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentDetails.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentDetailsRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentDetailsRecord a, RCDeploymentDetailsRecord b) {
			if (a.ssSTDeploymentDetails != b.ssSTDeploymentDetails) return false;
			return true;
		}

		public static bool operator != (RCDeploymentDetailsRecord a, RCDeploymentDetailsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentDetailsRecord)) return false;
			return (this == (RCDeploymentDetailsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentDetails.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentDetailsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentDetails = new STDeploymentDetailsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentDetails", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentDetails' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentDetails = (STDeploymentDetailsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentDetails.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentDetails.InternalRecursiveSave();
		}


		public RCDeploymentDetailsRecord Duplicate() {
			RCDeploymentDetailsRecord t;
			t.ssSTDeploymentDetails = (STDeploymentDetailsStructure) this.ssSTDeploymentDetails.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentDetails.ToXml(this, recordElem, "DeploymentDetails", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymentdetails") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentDetails")) variable.Value = ssSTDeploymentDetails; else variable.Optimized = true;
				variable.SetFieldName("deploymentdetails");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentDetails) {
				return ssSTDeploymentDetails;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentDetails.FillFromOther((IRecord) other.AttributeGet(IdDeploymentDetails));
		}
		public bool IsDefault() {
			RCDeploymentDetailsRecord defaultStruct = new RCDeploymentDetailsRecord(null);
			if (this.ssSTDeploymentDetails != defaultStruct.ssSTDeploymentDetails) return false;
			return true;
		}
	} // RCDeploymentDetailsRecord

	/// <summary>
	/// Structure <code>RCEntityRecordRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEntityRecordRecord: ISerializable, ITypedRecord<RCEntityRecordRecord> {
		internal static readonly GlobalObjectKey IdEntityRecord = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bLTttptX+RhfaSN8sMV3mw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EntityRecord")]
		public STEntityRecordStructure ssSTEntityRecord;


		public static implicit operator STEntityRecordStructure(RCEntityRecordRecord r) {
			return r.ssSTEntityRecord;
		}

		public static implicit operator RCEntityRecordRecord(STEntityRecordStructure r) {
			RCEntityRecordRecord res = new RCEntityRecordRecord(null);
			res.ssSTEntityRecord = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEntityRecordRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEntityRecord = new STEntityRecordStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEntityRecord.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEntityRecord.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEntityRecordRecord r) {
			this = r;
		}


		public static bool operator == (RCEntityRecordRecord a, RCEntityRecordRecord b) {
			if (a.ssSTEntityRecord != b.ssSTEntityRecord) return false;
			return true;
		}

		public static bool operator != (RCEntityRecordRecord a, RCEntityRecordRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEntityRecordRecord)) return false;
			return (this == (RCEntityRecordRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEntityRecord.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEntityRecordRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEntityRecord = new STEntityRecordStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEntityRecord", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEntityRecord' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEntityRecord = (STEntityRecordStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEntityRecord.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEntityRecord.InternalRecursiveSave();
		}


		public RCEntityRecordRecord Duplicate() {
			RCEntityRecordRecord t;
			t.ssSTEntityRecord = (STEntityRecordStructure) this.ssSTEntityRecord.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEntityRecord.ToXml(this, recordElem, "EntityRecord", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "entityrecord") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EntityRecord")) variable.Value = ssSTEntityRecord; else variable.Optimized = true;
				variable.SetFieldName("entityrecord");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEntityRecord) {
				return ssSTEntityRecord;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEntityRecord.FillFromOther((IRecord) other.AttributeGet(IdEntityRecord));
		}
		public bool IsDefault() {
			RCEntityRecordRecord defaultStruct = new RCEntityRecordRecord(null);
			if (this.ssSTEntityRecord != defaultStruct.ssSTEntityRecord) return false;
			return true;
		}
	} // RCEntityRecordRecord

	/// <summary>
	/// Structure <code>RCDeploymentTechnologyRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentTechnologyRecord: ISerializable, ITypedRecord<RCDeploymentTechnologyRecord> {
		internal static readonly GlobalObjectKey IdDeploymentTechnology = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8a1MsRuP3Z+KX+jgIdeiMQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentTechnology")]
		public STDeploymentTechnologyStructure ssSTDeploymentTechnology;


		public static implicit operator STDeploymentTechnologyStructure(RCDeploymentTechnologyRecord r) {
			return r.ssSTDeploymentTechnology;
		}

		public static implicit operator RCDeploymentTechnologyRecord(STDeploymentTechnologyStructure r) {
			RCDeploymentTechnologyRecord res = new RCDeploymentTechnologyRecord(null);
			res.ssSTDeploymentTechnology = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentTechnologyRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentTechnology = new STDeploymentTechnologyStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentTechnology.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentTechnology.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentTechnologyRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentTechnologyRecord a, RCDeploymentTechnologyRecord b) {
			if (a.ssSTDeploymentTechnology != b.ssSTDeploymentTechnology) return false;
			return true;
		}

		public static bool operator != (RCDeploymentTechnologyRecord a, RCDeploymentTechnologyRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentTechnologyRecord)) return false;
			return (this == (RCDeploymentTechnologyRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentTechnology.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentTechnologyRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentTechnology = new STDeploymentTechnologyStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentTechnology", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentTechnology' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentTechnology = (STDeploymentTechnologyStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentTechnology.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentTechnology.InternalRecursiveSave();
		}


		public RCDeploymentTechnologyRecord Duplicate() {
			RCDeploymentTechnologyRecord t;
			t.ssSTDeploymentTechnology = (STDeploymentTechnologyStructure) this.ssSTDeploymentTechnology.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentTechnology.ToXml(this, recordElem, "DeploymentTechnology", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymenttechnology") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentTechnology")) variable.Value = ssSTDeploymentTechnology; else variable.Optimized = true;
				variable.SetFieldName("deploymenttechnology");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentTechnology) {
				return ssSTDeploymentTechnology;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentTechnology.FillFromOther((IRecord) other.AttributeGet(IdDeploymentTechnology));
		}
		public bool IsDefault() {
			RCDeploymentTechnologyRecord defaultStruct = new RCDeploymentTechnologyRecord(null);
			if (this.ssSTDeploymentTechnology != defaultStruct.ssSTDeploymentTechnology) return false;
			return true;
		}
	} // RCDeploymentTechnologyRecord

	/// <summary>
	/// Structure <code>RCDeploymentZone_VMRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentZone_VMRecord: ISerializable, ITypedRecord<RCDeploymentZone_VMRecord> {
		internal static readonly GlobalObjectKey IdDeploymentZone_VM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tyfi7s3i_ASP_ysMbo6oag");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentZone_VM")]
		public STDeploymentZone_VMStructure ssSTDeploymentZone_VM;


		public static implicit operator STDeploymentZone_VMStructure(RCDeploymentZone_VMRecord r) {
			return r.ssSTDeploymentZone_VM;
		}

		public static implicit operator RCDeploymentZone_VMRecord(STDeploymentZone_VMStructure r) {
			RCDeploymentZone_VMRecord res = new RCDeploymentZone_VMRecord(null);
			res.ssSTDeploymentZone_VM = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentZone_VMRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_VM = new STDeploymentZone_VMStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentZone_VM.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentZone_VM.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentZone_VMRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentZone_VMRecord a, RCDeploymentZone_VMRecord b) {
			if (a.ssSTDeploymentZone_VM != b.ssSTDeploymentZone_VM) return false;
			return true;
		}

		public static bool operator != (RCDeploymentZone_VMRecord a, RCDeploymentZone_VMRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentZone_VMRecord)) return false;
			return (this == (RCDeploymentZone_VMRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentZone_VM.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentZone_VMRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_VM = new STDeploymentZone_VMStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentZone_VM", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentZone_VM' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentZone_VM = (STDeploymentZone_VMStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentZone_VM.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentZone_VM.InternalRecursiveSave();
		}


		public RCDeploymentZone_VMRecord Duplicate() {
			RCDeploymentZone_VMRecord t;
			t.ssSTDeploymentZone_VM = (STDeploymentZone_VMStructure) this.ssSTDeploymentZone_VM.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentZone_VM.ToXml(this, recordElem, "DeploymentZone_VM", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymentzone_vm") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentZone_VM")) variable.Value = ssSTDeploymentZone_VM; else variable.Optimized = true;
				variable.SetFieldName("deploymentzone_vm");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentZone_VM) {
				return ssSTDeploymentZone_VM;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentZone_VM.FillFromOther((IRecord) other.AttributeGet(IdDeploymentZone_VM));
		}
		public bool IsDefault() {
			RCDeploymentZone_VMRecord defaultStruct = new RCDeploymentZone_VMRecord(null);
			if (this.ssSTDeploymentZone_VM != defaultStruct.ssSTDeploymentZone_VM) return false;
			return true;
		}
	} // RCDeploymentZone_VMRecord

	/// <summary>
	/// Structure <code>RCDeploymentZone_DockerRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentZone_DockerRecord: ISerializable, ITypedRecord<RCDeploymentZone_DockerRecord> {
		internal static readonly GlobalObjectKey IdDeploymentZone_Docker = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pzBN1mdft+NLxQkttd8n5w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentZone_Docker")]
		public STDeploymentZone_DockerStructure ssSTDeploymentZone_Docker;


		public static implicit operator STDeploymentZone_DockerStructure(RCDeploymentZone_DockerRecord r) {
			return r.ssSTDeploymentZone_Docker;
		}

		public static implicit operator RCDeploymentZone_DockerRecord(STDeploymentZone_DockerStructure r) {
			RCDeploymentZone_DockerRecord res = new RCDeploymentZone_DockerRecord(null);
			res.ssSTDeploymentZone_Docker = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentZone_DockerRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_Docker = new STDeploymentZone_DockerStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentZone_Docker.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentZone_Docker.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentZone_DockerRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentZone_DockerRecord a, RCDeploymentZone_DockerRecord b) {
			if (a.ssSTDeploymentZone_Docker != b.ssSTDeploymentZone_Docker) return false;
			return true;
		}

		public static bool operator != (RCDeploymentZone_DockerRecord a, RCDeploymentZone_DockerRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentZone_DockerRecord)) return false;
			return (this == (RCDeploymentZone_DockerRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentZone_Docker.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentZone_DockerRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_Docker = new STDeploymentZone_DockerStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentZone_Docker", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentZone_Docker' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentZone_Docker = (STDeploymentZone_DockerStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentZone_Docker.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentZone_Docker.InternalRecursiveSave();
		}


		public RCDeploymentZone_DockerRecord Duplicate() {
			RCDeploymentZone_DockerRecord t;
			t.ssSTDeploymentZone_Docker = (STDeploymentZone_DockerStructure) this.ssSTDeploymentZone_Docker.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentZone_Docker.ToXml(this, recordElem, "DeploymentZone_Docker", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymentzone_docker") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentZone_Docker")) variable.Value = ssSTDeploymentZone_Docker; else variable.Optimized = true;
				variable.SetFieldName("deploymentzone_docker");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentZone_Docker) {
				return ssSTDeploymentZone_Docker;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentZone_Docker.FillFromOther((IRecord) other.AttributeGet(IdDeploymentZone_Docker));
		}
		public bool IsDefault() {
			RCDeploymentZone_DockerRecord defaultStruct = new RCDeploymentZone_DockerRecord(null);
			if (this.ssSTDeploymentZone_Docker != defaultStruct.ssSTDeploymentZone_Docker) return false;
			return true;
		}
	} // RCDeploymentZone_DockerRecord

	/// <summary>
	/// Structure <code>RCDeploymentZoneRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentZoneRecord: ISerializable, ITypedRecord<RCDeploymentZoneRecord> {
		internal static readonly GlobalObjectKey IdDeploymentZone = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CkKJpM6g1T73zU_dgqiPQA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentZone")]
		public STDeploymentZoneStructure ssSTDeploymentZone;


		public static implicit operator STDeploymentZoneStructure(RCDeploymentZoneRecord r) {
			return r.ssSTDeploymentZone;
		}

		public static implicit operator RCDeploymentZoneRecord(STDeploymentZoneStructure r) {
			RCDeploymentZoneRecord res = new RCDeploymentZoneRecord(null);
			res.ssSTDeploymentZone = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentZoneRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentZone = new STDeploymentZoneStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentZone.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentZone.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentZoneRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentZoneRecord a, RCDeploymentZoneRecord b) {
			if (a.ssSTDeploymentZone != b.ssSTDeploymentZone) return false;
			return true;
		}

		public static bool operator != (RCDeploymentZoneRecord a, RCDeploymentZoneRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentZoneRecord)) return false;
			return (this == (RCDeploymentZoneRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentZone.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentZoneRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentZone = new STDeploymentZoneStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentZone", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentZone' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentZone = (STDeploymentZoneStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentZone.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentZone.InternalRecursiveSave();
		}


		public RCDeploymentZoneRecord Duplicate() {
			RCDeploymentZoneRecord t;
			t.ssSTDeploymentZone = (STDeploymentZoneStructure) this.ssSTDeploymentZone.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentZone.ToXml(this, recordElem, "DeploymentZone", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymentzone") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentZone")) variable.Value = ssSTDeploymentZone; else variable.Optimized = true;
				variable.SetFieldName("deploymentzone");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentZone) {
				return ssSTDeploymentZone;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentZone.FillFromOther((IRecord) other.AttributeGet(IdDeploymentZone));
		}
		public bool IsDefault() {
			RCDeploymentZoneRecord defaultStruct = new RCDeploymentZoneRecord(null);
			if (this.ssSTDeploymentZone != defaultStruct.ssSTDeploymentZone) return false;
			return true;
		}
	} // RCDeploymentZoneRecord

	/// <summary>
	/// Structure <code>RCApplicationModuleDetailsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCApplicationModuleDetailsRecord: ISerializable, ITypedRecord<RCApplicationModuleDetailsRecord> {
		internal static readonly GlobalObjectKey IdApplicationModuleDetails = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NexUTMstL4gFRMZ0mZ_dNQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ApplicationModuleDetails")]
		public STApplicationModuleDetailsStructure ssSTApplicationModuleDetails;


		public static implicit operator STApplicationModuleDetailsStructure(RCApplicationModuleDetailsRecord r) {
			return r.ssSTApplicationModuleDetails;
		}

		public static implicit operator RCApplicationModuleDetailsRecord(STApplicationModuleDetailsStructure r) {
			RCApplicationModuleDetailsRecord res = new RCApplicationModuleDetailsRecord(null);
			res.ssSTApplicationModuleDetails = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCApplicationModuleDetailsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTApplicationModuleDetails = new STApplicationModuleDetailsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTApplicationModuleDetails.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTApplicationModuleDetails.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCApplicationModuleDetailsRecord r) {
			this = r;
		}


		public static bool operator == (RCApplicationModuleDetailsRecord a, RCApplicationModuleDetailsRecord b) {
			if (a.ssSTApplicationModuleDetails != b.ssSTApplicationModuleDetails) return false;
			return true;
		}

		public static bool operator != (RCApplicationModuleDetailsRecord a, RCApplicationModuleDetailsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCApplicationModuleDetailsRecord)) return false;
			return (this == (RCApplicationModuleDetailsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTApplicationModuleDetails.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCApplicationModuleDetailsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTApplicationModuleDetails = new STApplicationModuleDetailsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTApplicationModuleDetails", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTApplicationModuleDetails' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTApplicationModuleDetails = (STApplicationModuleDetailsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTApplicationModuleDetails.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTApplicationModuleDetails.InternalRecursiveSave();
		}


		public RCApplicationModuleDetailsRecord Duplicate() {
			RCApplicationModuleDetailsRecord t;
			t.ssSTApplicationModuleDetails = (STApplicationModuleDetailsStructure) this.ssSTApplicationModuleDetails.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTApplicationModuleDetails.ToXml(this, recordElem, "ApplicationModuleDetails", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "applicationmoduledetails") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationModuleDetails")) variable.Value = ssSTApplicationModuleDetails; else variable.Optimized = true;
				variable.SetFieldName("applicationmoduledetails");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdApplicationModuleDetails) {
				return ssSTApplicationModuleDetails;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTApplicationModuleDetails.FillFromOther((IRecord) other.AttributeGet(IdApplicationModuleDetails));
		}
		public bool IsDefault() {
			RCApplicationModuleDetailsRecord defaultStruct = new RCApplicationModuleDetailsRecord(null);
			if (this.ssSTApplicationModuleDetails != defaultStruct.ssSTApplicationModuleDetails) return false;
			return true;
		}
	} // RCApplicationModuleDetailsRecord

	/// <summary>
	/// Structure <code>RCGenericRecordDescriptionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCGenericRecordDescriptionRecord: ISerializable, ITypedRecord<RCGenericRecordDescriptionRecord> {
		internal static readonly GlobalObjectKey IdGenericRecordDescription = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T+fpgID8BYeiNNzFqN0vCw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("GenericRecordDescription")]
		public STGenericRecordDescriptionStructure ssSTGenericRecordDescription;


		public static implicit operator STGenericRecordDescriptionStructure(RCGenericRecordDescriptionRecord r) {
			return r.ssSTGenericRecordDescription;
		}

		public static implicit operator RCGenericRecordDescriptionRecord(STGenericRecordDescriptionStructure r) {
			RCGenericRecordDescriptionRecord res = new RCGenericRecordDescriptionRecord(null);
			res.ssSTGenericRecordDescription = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCGenericRecordDescriptionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTGenericRecordDescription = new STGenericRecordDescriptionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTGenericRecordDescription.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTGenericRecordDescription.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCGenericRecordDescriptionRecord r) {
			this = r;
		}


		public static bool operator == (RCGenericRecordDescriptionRecord a, RCGenericRecordDescriptionRecord b) {
			if (a.ssSTGenericRecordDescription != b.ssSTGenericRecordDescription) return false;
			return true;
		}

		public static bool operator != (RCGenericRecordDescriptionRecord a, RCGenericRecordDescriptionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCGenericRecordDescriptionRecord)) return false;
			return (this == (RCGenericRecordDescriptionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTGenericRecordDescription.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCGenericRecordDescriptionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTGenericRecordDescription = new STGenericRecordDescriptionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTGenericRecordDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTGenericRecordDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTGenericRecordDescription = (STGenericRecordDescriptionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTGenericRecordDescription.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTGenericRecordDescription.InternalRecursiveSave();
		}


		public RCGenericRecordDescriptionRecord Duplicate() {
			RCGenericRecordDescriptionRecord t;
			t.ssSTGenericRecordDescription = (STGenericRecordDescriptionStructure) this.ssSTGenericRecordDescription.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTGenericRecordDescription.ToXml(this, recordElem, "GenericRecordDescription", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "genericrecorddescription") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".GenericRecordDescription")) variable.Value = ssSTGenericRecordDescription; else variable.Optimized = true;
				variable.SetFieldName("genericrecorddescription");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdGenericRecordDescription) {
				return ssSTGenericRecordDescription;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTGenericRecordDescription.FillFromOther((IRecord) other.AttributeGet(IdGenericRecordDescription));
		}
		public bool IsDefault() {
			RCGenericRecordDescriptionRecord defaultStruct = new RCGenericRecordDescriptionRecord(null);
			if (this.ssSTGenericRecordDescription != defaultStruct.ssSTGenericRecordDescription) return false;
			return true;
		}
	} // RCGenericRecordDescriptionRecord

	/// <summary>
	/// Structure <code>RCESpaceDetailedInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCESpaceDetailedInfoRecord: ISerializable, ITypedRecord<RCESpaceDetailedInfoRecord> {
		internal static readonly GlobalObjectKey IdESpaceDetailedInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tSiiF0CkQvdf2qoti3DEJA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ESpaceDetailedInfo")]
		public STESpaceDetailedInfoStructure ssSTESpaceDetailedInfo;


		public static implicit operator STESpaceDetailedInfoStructure(RCESpaceDetailedInfoRecord r) {
			return r.ssSTESpaceDetailedInfo;
		}

		public static implicit operator RCESpaceDetailedInfoRecord(STESpaceDetailedInfoStructure r) {
			RCESpaceDetailedInfoRecord res = new RCESpaceDetailedInfoRecord(null);
			res.ssSTESpaceDetailedInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCESpaceDetailedInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTESpaceDetailedInfo = new STESpaceDetailedInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTESpaceDetailedInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTESpaceDetailedInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCESpaceDetailedInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCESpaceDetailedInfoRecord a, RCESpaceDetailedInfoRecord b) {
			if (a.ssSTESpaceDetailedInfo != b.ssSTESpaceDetailedInfo) return false;
			return true;
		}

		public static bool operator != (RCESpaceDetailedInfoRecord a, RCESpaceDetailedInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCESpaceDetailedInfoRecord)) return false;
			return (this == (RCESpaceDetailedInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTESpaceDetailedInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCESpaceDetailedInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTESpaceDetailedInfo = new STESpaceDetailedInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTESpaceDetailedInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTESpaceDetailedInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTESpaceDetailedInfo = (STESpaceDetailedInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTESpaceDetailedInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTESpaceDetailedInfo.InternalRecursiveSave();
		}


		public RCESpaceDetailedInfoRecord Duplicate() {
			RCESpaceDetailedInfoRecord t;
			t.ssSTESpaceDetailedInfo = (STESpaceDetailedInfoStructure) this.ssSTESpaceDetailedInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTESpaceDetailedInfo.ToXml(this, recordElem, "ESpaceDetailedInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "espacedetailedinfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ESpaceDetailedInfo")) variable.Value = ssSTESpaceDetailedInfo; else variable.Optimized = true;
				variable.SetFieldName("espacedetailedinfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdESpaceDetailedInfo) {
				return ssSTESpaceDetailedInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTESpaceDetailedInfo.FillFromOther((IRecord) other.AttributeGet(IdESpaceDetailedInfo));
		}
		public bool IsDefault() {
			RCESpaceDetailedInfoRecord defaultStruct = new RCESpaceDetailedInfoRecord(null);
			if (this.ssSTESpaceDetailedInfo != defaultStruct.ssSTESpaceDetailedInfo) return false;
			return true;
		}
	} // RCESpaceDetailedInfoRecord

	/// <summary>
	/// Structure <code>RCDeploymentZone_PivotalRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentZone_PivotalRecord: ISerializable, ITypedRecord<RCDeploymentZone_PivotalRecord> {
		internal static readonly GlobalObjectKey IdDeploymentZone_Pivotal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lAymoibEHvcrkCME10s1jw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentZone_Pivotal")]
		public STDeploymentZone_PivotalStructure ssSTDeploymentZone_Pivotal;


		public static implicit operator STDeploymentZone_PivotalStructure(RCDeploymentZone_PivotalRecord r) {
			return r.ssSTDeploymentZone_Pivotal;
		}

		public static implicit operator RCDeploymentZone_PivotalRecord(STDeploymentZone_PivotalStructure r) {
			RCDeploymentZone_PivotalRecord res = new RCDeploymentZone_PivotalRecord(null);
			res.ssSTDeploymentZone_Pivotal = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentZone_PivotalRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_Pivotal = new STDeploymentZone_PivotalStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentZone_Pivotal.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentZone_Pivotal.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentZone_PivotalRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentZone_PivotalRecord a, RCDeploymentZone_PivotalRecord b) {
			if (a.ssSTDeploymentZone_Pivotal != b.ssSTDeploymentZone_Pivotal) return false;
			return true;
		}

		public static bool operator != (RCDeploymentZone_PivotalRecord a, RCDeploymentZone_PivotalRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentZone_PivotalRecord)) return false;
			return (this == (RCDeploymentZone_PivotalRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentZone_Pivotal.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentZone_PivotalRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_Pivotal = new STDeploymentZone_PivotalStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentZone_Pivotal", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentZone_Pivotal' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentZone_Pivotal = (STDeploymentZone_PivotalStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentZone_Pivotal.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentZone_Pivotal.InternalRecursiveSave();
		}


		public RCDeploymentZone_PivotalRecord Duplicate() {
			RCDeploymentZone_PivotalRecord t;
			t.ssSTDeploymentZone_Pivotal = (STDeploymentZone_PivotalStructure) this.ssSTDeploymentZone_Pivotal.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentZone_Pivotal.ToXml(this, recordElem, "DeploymentZone_Pivotal", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymentzone_pivotal") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentZone_Pivotal")) variable.Value = ssSTDeploymentZone_Pivotal; else variable.Optimized = true;
				variable.SetFieldName("deploymentzone_pivotal");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentZone_Pivotal) {
				return ssSTDeploymentZone_Pivotal;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentZone_Pivotal.FillFromOther((IRecord) other.AttributeGet(IdDeploymentZone_Pivotal));
		}
		public bool IsDefault() {
			RCDeploymentZone_PivotalRecord defaultStruct = new RCDeploymentZone_PivotalRecord(null);
			if (this.ssSTDeploymentZone_Pivotal != defaultStruct.ssSTDeploymentZone_Pivotal) return false;
			return true;
		}
	} // RCDeploymentZone_PivotalRecord

	/// <summary>
	/// Structure <code>RCCacheInvalidationServiceStatusRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCCacheInvalidationServiceStatusRecord: ISerializable, ITypedRecord<RCCacheInvalidationServiceStatusRecord> {
		internal static readonly GlobalObjectKey IdCacheInvalidationServiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5ROi7VHBNV6soXk1CYv1aA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("CacheInvalidationServiceStatus")]
		public STCacheInvalidationServiceStatusStructure ssSTCacheInvalidationServiceStatus;


		public static implicit operator STCacheInvalidationServiceStatusStructure(RCCacheInvalidationServiceStatusRecord r) {
			return r.ssSTCacheInvalidationServiceStatus;
		}

		public static implicit operator RCCacheInvalidationServiceStatusRecord(STCacheInvalidationServiceStatusStructure r) {
			RCCacheInvalidationServiceStatusRecord res = new RCCacheInvalidationServiceStatusRecord(null);
			res.ssSTCacheInvalidationServiceStatus = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCCacheInvalidationServiceStatusRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTCacheInvalidationServiceStatus = new STCacheInvalidationServiceStatusStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTCacheInvalidationServiceStatus.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTCacheInvalidationServiceStatus.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCCacheInvalidationServiceStatusRecord r) {
			this = r;
		}


		public static bool operator == (RCCacheInvalidationServiceStatusRecord a, RCCacheInvalidationServiceStatusRecord b) {
			if (a.ssSTCacheInvalidationServiceStatus != b.ssSTCacheInvalidationServiceStatus) return false;
			return true;
		}

		public static bool operator != (RCCacheInvalidationServiceStatusRecord a, RCCacheInvalidationServiceStatusRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCCacheInvalidationServiceStatusRecord)) return false;
			return (this == (RCCacheInvalidationServiceStatusRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTCacheInvalidationServiceStatus.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCCacheInvalidationServiceStatusRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTCacheInvalidationServiceStatus = new STCacheInvalidationServiceStatusStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTCacheInvalidationServiceStatus", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTCacheInvalidationServiceStatus' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTCacheInvalidationServiceStatus = (STCacheInvalidationServiceStatusStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTCacheInvalidationServiceStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTCacheInvalidationServiceStatus.InternalRecursiveSave();
		}


		public RCCacheInvalidationServiceStatusRecord Duplicate() {
			RCCacheInvalidationServiceStatusRecord t;
			t.ssSTCacheInvalidationServiceStatus = (STCacheInvalidationServiceStatusStructure) this.ssSTCacheInvalidationServiceStatus.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTCacheInvalidationServiceStatus.ToXml(this, recordElem, "CacheInvalidationServiceStatus", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "cacheinvalidationservicestatus") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CacheInvalidationServiceStatus")) variable.Value = ssSTCacheInvalidationServiceStatus; else variable.Optimized = true;
				variable.SetFieldName("cacheinvalidationservicestatus");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdCacheInvalidationServiceStatus) {
				return ssSTCacheInvalidationServiceStatus;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTCacheInvalidationServiceStatus.FillFromOther((IRecord) other.AttributeGet(IdCacheInvalidationServiceStatus));
		}
		public bool IsDefault() {
			RCCacheInvalidationServiceStatusRecord defaultStruct = new RCCacheInvalidationServiceStatusRecord(null);
			if (this.ssSTCacheInvalidationServiceStatus != defaultStruct.ssSTCacheInvalidationServiceStatus) return false;
			return true;
		}
	} // RCCacheInvalidationServiceStatusRecord

	/// <summary>
	/// Structure <code>RCDeploymentZone_AzureContainerServiceRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentZone_AzureContainerServiceRecord: ISerializable, ITypedRecord<RCDeploymentZone_AzureContainerServiceRecord> {
		internal static readonly GlobalObjectKey IdDeploymentZone_AzureContainerService = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BIJEJYmjd2d3JnE2DJpK2Q");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentZone_AzureContainerService")]
		public STDeploymentZone_AzureContainerServiceStructure ssSTDeploymentZone_AzureContainerService;


		public static implicit operator STDeploymentZone_AzureContainerServiceStructure(RCDeploymentZone_AzureContainerServiceRecord r) {
			return r.ssSTDeploymentZone_AzureContainerService;
		}

		public static implicit operator RCDeploymentZone_AzureContainerServiceRecord(STDeploymentZone_AzureContainerServiceStructure r) {
			RCDeploymentZone_AzureContainerServiceRecord res = new RCDeploymentZone_AzureContainerServiceRecord(null);
			res.ssSTDeploymentZone_AzureContainerService = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentZone_AzureContainerServiceRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_AzureContainerService = new STDeploymentZone_AzureContainerServiceStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentZone_AzureContainerService.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentZone_AzureContainerService.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentZone_AzureContainerServiceRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentZone_AzureContainerServiceRecord a, RCDeploymentZone_AzureContainerServiceRecord b) {
			if (a.ssSTDeploymentZone_AzureContainerService != b.ssSTDeploymentZone_AzureContainerService) return false;
			return true;
		}

		public static bool operator != (RCDeploymentZone_AzureContainerServiceRecord a, RCDeploymentZone_AzureContainerServiceRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentZone_AzureContainerServiceRecord)) return false;
			return (this == (RCDeploymentZone_AzureContainerServiceRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentZone_AzureContainerService.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentZone_AzureContainerServiceRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_AzureContainerService = new STDeploymentZone_AzureContainerServiceStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentZone_AzureContainerService", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentZone_AzureContainerService' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentZone_AzureContainerService = (STDeploymentZone_AzureContainerServiceStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentZone_AzureContainerService.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentZone_AzureContainerService.InternalRecursiveSave();
		}


		public RCDeploymentZone_AzureContainerServiceRecord Duplicate() {
			RCDeploymentZone_AzureContainerServiceRecord t;
			t.ssSTDeploymentZone_AzureContainerService = (STDeploymentZone_AzureContainerServiceStructure) this.ssSTDeploymentZone_AzureContainerService.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentZone_AzureContainerService.ToXml(this, recordElem, "DeploymentZone_AzureContainerService", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymentzone_azurecontainerservice") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentZone_AzureContainerService")) variable.Value = ssSTDeploymentZone_AzureContainerService; else variable.Optimized = true;
				variable.SetFieldName("deploymentzone_azurecontainerservice");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentZone_AzureContainerService) {
				return ssSTDeploymentZone_AzureContainerService;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentZone_AzureContainerService.FillFromOther((IRecord) other.AttributeGet(IdDeploymentZone_AzureContainerService));
		}
		public bool IsDefault() {
			RCDeploymentZone_AzureContainerServiceRecord defaultStruct = new RCDeploymentZone_AzureContainerServiceRecord(null);
			if (this.ssSTDeploymentZone_AzureContainerService != defaultStruct.ssSTDeploymentZone_AzureContainerService) return false;
			return true;
		}
	} // RCDeploymentZone_AzureContainerServiceRecord

	/// <summary>
	/// Structure <code>RCDeploymentZone_AmazonECSRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentZone_AmazonECSRecord: ISerializable, ITypedRecord<RCDeploymentZone_AmazonECSRecord> {
		internal static readonly GlobalObjectKey IdDeploymentZone_AmazonECS = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6ExYmC0Ws6vimITWPa8EyA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentZone_AmazonECS")]
		public STDeploymentZone_AmazonECSStructure ssSTDeploymentZone_AmazonECS;


		public static implicit operator STDeploymentZone_AmazonECSStructure(RCDeploymentZone_AmazonECSRecord r) {
			return r.ssSTDeploymentZone_AmazonECS;
		}

		public static implicit operator RCDeploymentZone_AmazonECSRecord(STDeploymentZone_AmazonECSStructure r) {
			RCDeploymentZone_AmazonECSRecord res = new RCDeploymentZone_AmazonECSRecord(null);
			res.ssSTDeploymentZone_AmazonECS = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentZone_AmazonECSRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_AmazonECS = new STDeploymentZone_AmazonECSStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentZone_AmazonECS.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentZone_AmazonECS.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentZone_AmazonECSRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentZone_AmazonECSRecord a, RCDeploymentZone_AmazonECSRecord b) {
			if (a.ssSTDeploymentZone_AmazonECS != b.ssSTDeploymentZone_AmazonECS) return false;
			return true;
		}

		public static bool operator != (RCDeploymentZone_AmazonECSRecord a, RCDeploymentZone_AmazonECSRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentZone_AmazonECSRecord)) return false;
			return (this == (RCDeploymentZone_AmazonECSRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentZone_AmazonECS.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentZone_AmazonECSRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_AmazonECS = new STDeploymentZone_AmazonECSStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentZone_AmazonECS", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentZone_AmazonECS' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentZone_AmazonECS = (STDeploymentZone_AmazonECSStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentZone_AmazonECS.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentZone_AmazonECS.InternalRecursiveSave();
		}


		public RCDeploymentZone_AmazonECSRecord Duplicate() {
			RCDeploymentZone_AmazonECSRecord t;
			t.ssSTDeploymentZone_AmazonECS = (STDeploymentZone_AmazonECSStructure) this.ssSTDeploymentZone_AmazonECS.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentZone_AmazonECS.ToXml(this, recordElem, "DeploymentZone_AmazonECS", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymentzone_amazonecs") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentZone_AmazonECS")) variable.Value = ssSTDeploymentZone_AmazonECS; else variable.Optimized = true;
				variable.SetFieldName("deploymentzone_amazonecs");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentZone_AmazonECS) {
				return ssSTDeploymentZone_AmazonECS;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentZone_AmazonECS.FillFromOther((IRecord) other.AttributeGet(IdDeploymentZone_AmazonECS));
		}
		public bool IsDefault() {
			RCDeploymentZone_AmazonECSRecord defaultStruct = new RCDeploymentZone_AmazonECSRecord(null);
			if (this.ssSTDeploymentZone_AmazonECS != defaultStruct.ssSTDeploymentZone_AmazonECS) return false;
			return true;
		}
	} // RCDeploymentZone_AmazonECSRecord

	/// <summary>
	/// Structure <code>RCUserSecurityGrantsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCUserSecurityGrantsRecord: ISerializable, ITypedRecord<RCUserSecurityGrantsRecord> {
		internal static readonly GlobalObjectKey IdUserSecurityGrants = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*d8eO8xAJ+SBlbDSa9PMjwQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("UserSecurityGrants")]
		public STUserSecurityGrantsStructure ssSTUserSecurityGrants;


		public static implicit operator STUserSecurityGrantsStructure(RCUserSecurityGrantsRecord r) {
			return r.ssSTUserSecurityGrants;
		}

		public static implicit operator RCUserSecurityGrantsRecord(STUserSecurityGrantsStructure r) {
			RCUserSecurityGrantsRecord res = new RCUserSecurityGrantsRecord(null);
			res.ssSTUserSecurityGrants = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCUserSecurityGrantsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTUserSecurityGrants = new STUserSecurityGrantsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTUserSecurityGrants.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTUserSecurityGrants.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCUserSecurityGrantsRecord r) {
			this = r;
		}


		public static bool operator == (RCUserSecurityGrantsRecord a, RCUserSecurityGrantsRecord b) {
			if (a.ssSTUserSecurityGrants != b.ssSTUserSecurityGrants) return false;
			return true;
		}

		public static bool operator != (RCUserSecurityGrantsRecord a, RCUserSecurityGrantsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCUserSecurityGrantsRecord)) return false;
			return (this == (RCUserSecurityGrantsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTUserSecurityGrants.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCUserSecurityGrantsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTUserSecurityGrants = new STUserSecurityGrantsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTUserSecurityGrants", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTUserSecurityGrants' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTUserSecurityGrants = (STUserSecurityGrantsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTUserSecurityGrants.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTUserSecurityGrants.InternalRecursiveSave();
		}


		public RCUserSecurityGrantsRecord Duplicate() {
			RCUserSecurityGrantsRecord t;
			t.ssSTUserSecurityGrants = (STUserSecurityGrantsStructure) this.ssSTUserSecurityGrants.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTUserSecurityGrants.ToXml(this, recordElem, "UserSecurityGrants", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "usersecuritygrants") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UserSecurityGrants")) variable.Value = ssSTUserSecurityGrants; else variable.Optimized = true;
				variable.SetFieldName("usersecuritygrants");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdUserSecurityGrants) {
				return ssSTUserSecurityGrants;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTUserSecurityGrants.FillFromOther((IRecord) other.AttributeGet(IdUserSecurityGrants));
		}
		public bool IsDefault() {
			RCUserSecurityGrantsRecord defaultStruct = new RCUserSecurityGrantsRecord(null);
			if (this.ssSTUserSecurityGrants != defaultStruct.ssSTUserSecurityGrants) return false;
			return true;
		}
	} // RCUserSecurityGrantsRecord

	/// <summary>
	/// Structure <code>RCVersionComparisonRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCVersionComparisonRecord: ISerializable, ITypedRecord<RCVersionComparisonRecord> {
		internal static readonly GlobalObjectKey IdVersionComparison = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*id5dr59QqMh5Wyyqb8NgdA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("VersionComparison")]
		public STVersionComparisonStructure ssSTVersionComparison;


		public static implicit operator STVersionComparisonStructure(RCVersionComparisonRecord r) {
			return r.ssSTVersionComparison;
		}

		public static implicit operator RCVersionComparisonRecord(STVersionComparisonStructure r) {
			RCVersionComparisonRecord res = new RCVersionComparisonRecord(null);
			res.ssSTVersionComparison = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCVersionComparisonRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTVersionComparison = new STVersionComparisonStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTVersionComparison.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTVersionComparison.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCVersionComparisonRecord r) {
			this = r;
		}


		public static bool operator == (RCVersionComparisonRecord a, RCVersionComparisonRecord b) {
			if (a.ssSTVersionComparison != b.ssSTVersionComparison) return false;
			return true;
		}

		public static bool operator != (RCVersionComparisonRecord a, RCVersionComparisonRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCVersionComparisonRecord)) return false;
			return (this == (RCVersionComparisonRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTVersionComparison.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCVersionComparisonRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTVersionComparison = new STVersionComparisonStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTVersionComparison", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTVersionComparison' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTVersionComparison = (STVersionComparisonStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTVersionComparison.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTVersionComparison.InternalRecursiveSave();
		}


		public RCVersionComparisonRecord Duplicate() {
			RCVersionComparisonRecord t;
			t.ssSTVersionComparison = (STVersionComparisonStructure) this.ssSTVersionComparison.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTVersionComparison.ToXml(this, recordElem, "VersionComparison", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "versioncomparison") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".VersionComparison")) variable.Value = ssSTVersionComparison; else variable.Optimized = true;
				variable.SetFieldName("versioncomparison");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdVersionComparison) {
				return ssSTVersionComparison;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTVersionComparison.FillFromOther((IRecord) other.AttributeGet(IdVersionComparison));
		}
		public bool IsDefault() {
			RCVersionComparisonRecord defaultStruct = new RCVersionComparisonRecord(null);
			if (this.ssSTVersionComparison != defaultStruct.ssSTVersionComparison) return false;
			return true;
		}
	} // RCVersionComparisonRecord

	/// <summary>
	/// Structure <code>RCDBCatalogRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDBCatalogRecord: ISerializable, ITypedRecord<RCDBCatalogRecord> {
		internal static readonly GlobalObjectKey IdDBCatalog = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4paGZD+8guigFDrAQ+bz+A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DBCatalog")]
		public STDBCatalogStructure ssSTDBCatalog;


		public static implicit operator STDBCatalogStructure(RCDBCatalogRecord r) {
			return r.ssSTDBCatalog;
		}

		public static implicit operator RCDBCatalogRecord(STDBCatalogStructure r) {
			RCDBCatalogRecord res = new RCDBCatalogRecord(null);
			res.ssSTDBCatalog = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDBCatalogRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDBCatalog = new STDBCatalogStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDBCatalog.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDBCatalog.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDBCatalogRecord r) {
			this = r;
		}


		public static bool operator == (RCDBCatalogRecord a, RCDBCatalogRecord b) {
			if (a.ssSTDBCatalog != b.ssSTDBCatalog) return false;
			return true;
		}

		public static bool operator != (RCDBCatalogRecord a, RCDBCatalogRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDBCatalogRecord)) return false;
			return (this == (RCDBCatalogRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDBCatalog.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDBCatalogRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDBCatalog = new STDBCatalogStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDBCatalog", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDBCatalog' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDBCatalog = (STDBCatalogStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDBCatalog.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDBCatalog.InternalRecursiveSave();
		}


		public RCDBCatalogRecord Duplicate() {
			RCDBCatalogRecord t;
			t.ssSTDBCatalog = (STDBCatalogStructure) this.ssSTDBCatalog.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDBCatalog.ToXml(this, recordElem, "DBCatalog", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "dbcatalog") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DBCatalog")) variable.Value = ssSTDBCatalog; else variable.Optimized = true;
				variable.SetFieldName("dbcatalog");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDBCatalog) {
				return ssSTDBCatalog;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDBCatalog.FillFromOther((IRecord) other.AttributeGet(IdDBCatalog));
		}
		public bool IsDefault() {
			RCDBCatalogRecord defaultStruct = new RCDBCatalogRecord(null);
			if (this.ssSTDBCatalog != defaultStruct.ssSTDBCatalog) return false;
			return true;
		}
	} // RCDBCatalogRecord

	/// <summary>
	/// Structure <code>RCReferenceableModuleRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCReferenceableModuleRecord: ISerializable, ITypedRecord<RCReferenceableModuleRecord> {
		internal static readonly GlobalObjectKey IdReferenceableModule = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D3LXwtf0WkozXp6dhZWSag");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ReferenceableModule")]
		public STReferenceableModuleStructure ssSTReferenceableModule;


		public static implicit operator STReferenceableModuleStructure(RCReferenceableModuleRecord r) {
			return r.ssSTReferenceableModule;
		}

		public static implicit operator RCReferenceableModuleRecord(STReferenceableModuleStructure r) {
			RCReferenceableModuleRecord res = new RCReferenceableModuleRecord(null);
			res.ssSTReferenceableModule = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCReferenceableModuleRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTReferenceableModule = new STReferenceableModuleStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTReferenceableModule.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTReferenceableModule.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCReferenceableModuleRecord r) {
			this = r;
		}


		public static bool operator == (RCReferenceableModuleRecord a, RCReferenceableModuleRecord b) {
			if (a.ssSTReferenceableModule != b.ssSTReferenceableModule) return false;
			return true;
		}

		public static bool operator != (RCReferenceableModuleRecord a, RCReferenceableModuleRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCReferenceableModuleRecord)) return false;
			return (this == (RCReferenceableModuleRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTReferenceableModule.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCReferenceableModuleRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTReferenceableModule = new STReferenceableModuleStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTReferenceableModule", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTReferenceableModule' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTReferenceableModule = (STReferenceableModuleStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTReferenceableModule.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTReferenceableModule.InternalRecursiveSave();
		}


		public RCReferenceableModuleRecord Duplicate() {
			RCReferenceableModuleRecord t;
			t.ssSTReferenceableModule = (STReferenceableModuleStructure) this.ssSTReferenceableModule.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTReferenceableModule.ToXml(this, recordElem, "ReferenceableModule", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "referenceablemodule") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ReferenceableModule")) variable.Value = ssSTReferenceableModule; else variable.Optimized = true;
				variable.SetFieldName("referenceablemodule");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdReferenceableModule) {
				return ssSTReferenceableModule;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTReferenceableModule.FillFromOther((IRecord) other.AttributeGet(IdReferenceableModule));
		}
		public bool IsDefault() {
			RCReferenceableModuleRecord defaultStruct = new RCReferenceableModuleRecord(null);
			if (this.ssSTReferenceableModule != defaultStruct.ssSTReferenceableModule) return false;
			return true;
		}
	} // RCReferenceableModuleRecord

	/// <summary>
	/// Structure <code>RCEspaceToPublishRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEspaceToPublishRecord: ISerializable, ITypedRecord<RCEspaceToPublishRecord> {
		internal static readonly GlobalObjectKey IdEspaceToPublish = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xJ1MCnd4oUmDLuHWZaps+g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EspaceToPublish")]
		public STEspaceToPublishStructure ssSTEspaceToPublish;


		public static implicit operator STEspaceToPublishStructure(RCEspaceToPublishRecord r) {
			return r.ssSTEspaceToPublish;
		}

		public static implicit operator RCEspaceToPublishRecord(STEspaceToPublishStructure r) {
			RCEspaceToPublishRecord res = new RCEspaceToPublishRecord(null);
			res.ssSTEspaceToPublish = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEspaceToPublishRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEspaceToPublish = new STEspaceToPublishStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEspaceToPublish.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEspaceToPublish.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEspaceToPublishRecord r) {
			this = r;
		}


		public static bool operator == (RCEspaceToPublishRecord a, RCEspaceToPublishRecord b) {
			if (a.ssSTEspaceToPublish != b.ssSTEspaceToPublish) return false;
			return true;
		}

		public static bool operator != (RCEspaceToPublishRecord a, RCEspaceToPublishRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEspaceToPublishRecord)) return false;
			return (this == (RCEspaceToPublishRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEspaceToPublish.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEspaceToPublishRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEspaceToPublish = new STEspaceToPublishStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEspaceToPublish", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEspaceToPublish' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEspaceToPublish = (STEspaceToPublishStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEspaceToPublish.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEspaceToPublish.InternalRecursiveSave();
		}


		public RCEspaceToPublishRecord Duplicate() {
			RCEspaceToPublishRecord t;
			t.ssSTEspaceToPublish = (STEspaceToPublishStructure) this.ssSTEspaceToPublish.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEspaceToPublish.ToXml(this, recordElem, "EspaceToPublish", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "espacetopublish") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EspaceToPublish")) variable.Value = ssSTEspaceToPublish; else variable.Optimized = true;
				variable.SetFieldName("espacetopublish");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEspaceToPublish) {
				return ssSTEspaceToPublish;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEspaceToPublish.FillFromOther((IRecord) other.AttributeGet(IdEspaceToPublish));
		}
		public bool IsDefault() {
			RCEspaceToPublishRecord defaultStruct = new RCEspaceToPublishRecord(null);
			if (this.ssSTEspaceToPublish != defaultStruct.ssSTEspaceToPublish) return false;
			return true;
		}
	} // RCEspaceToPublishRecord

	/// <summary>
	/// Structure <code>RCEspacePublishOptionsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEspacePublishOptionsRecord: ISerializable, ITypedRecord<RCEspacePublishOptionsRecord> {
		internal static readonly GlobalObjectKey IdEspacePublishOptions = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XR57SB3hL1ybD6GIao6Jpg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EspacePublishOptions")]
		public STEspacePublishOptionsStructure ssSTEspacePublishOptions;


		public static implicit operator STEspacePublishOptionsStructure(RCEspacePublishOptionsRecord r) {
			return r.ssSTEspacePublishOptions;
		}

		public static implicit operator RCEspacePublishOptionsRecord(STEspacePublishOptionsStructure r) {
			RCEspacePublishOptionsRecord res = new RCEspacePublishOptionsRecord(null);
			res.ssSTEspacePublishOptions = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEspacePublishOptionsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEspacePublishOptions = new STEspacePublishOptionsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEspacePublishOptions.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEspacePublishOptions.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEspacePublishOptionsRecord r) {
			this = r;
		}


		public static bool operator == (RCEspacePublishOptionsRecord a, RCEspacePublishOptionsRecord b) {
			if (a.ssSTEspacePublishOptions != b.ssSTEspacePublishOptions) return false;
			return true;
		}

		public static bool operator != (RCEspacePublishOptionsRecord a, RCEspacePublishOptionsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEspacePublishOptionsRecord)) return false;
			return (this == (RCEspacePublishOptionsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEspacePublishOptions.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEspacePublishOptionsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEspacePublishOptions = new STEspacePublishOptionsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEspacePublishOptions", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEspacePublishOptions' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEspacePublishOptions = (STEspacePublishOptionsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEspacePublishOptions.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEspacePublishOptions.InternalRecursiveSave();
		}


		public RCEspacePublishOptionsRecord Duplicate() {
			RCEspacePublishOptionsRecord t;
			t.ssSTEspacePublishOptions = (STEspacePublishOptionsStructure) this.ssSTEspacePublishOptions.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEspacePublishOptions.ToXml(this, recordElem, "EspacePublishOptions", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "espacepublishoptions") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EspacePublishOptions")) variable.Value = ssSTEspacePublishOptions; else variable.Optimized = true;
				variable.SetFieldName("espacepublishoptions");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEspacePublishOptions) {
				return ssSTEspacePublishOptions;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEspacePublishOptions.FillFromOther((IRecord) other.AttributeGet(IdEspacePublishOptions));
		}
		public bool IsDefault() {
			RCEspacePublishOptionsRecord defaultStruct = new RCEspacePublishOptionsRecord(null);
			if (this.ssSTEspacePublishOptions != defaultStruct.ssSTEspacePublishOptions) return false;
			return true;
		}
	} // RCEspacePublishOptionsRecord

	/// <summary>
	/// Structure <code>RCEspacePublishAsyncResultRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEspacePublishAsyncResultRecord: ISerializable, ITypedRecord<RCEspacePublishAsyncResultRecord> {
		internal static readonly GlobalObjectKey IdEspacePublishAsyncResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o18PvW+Y0jZvZMlrD4HBZw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EspacePublishAsyncResult")]
		public STEspacePublishAsyncResultStructure ssSTEspacePublishAsyncResult;


		public static implicit operator STEspacePublishAsyncResultStructure(RCEspacePublishAsyncResultRecord r) {
			return r.ssSTEspacePublishAsyncResult;
		}

		public static implicit operator RCEspacePublishAsyncResultRecord(STEspacePublishAsyncResultStructure r) {
			RCEspacePublishAsyncResultRecord res = new RCEspacePublishAsyncResultRecord(null);
			res.ssSTEspacePublishAsyncResult = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEspacePublishAsyncResultRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEspacePublishAsyncResult = new STEspacePublishAsyncResultStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEspacePublishAsyncResult.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEspacePublishAsyncResult.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEspacePublishAsyncResultRecord r) {
			this = r;
		}


		public static bool operator == (RCEspacePublishAsyncResultRecord a, RCEspacePublishAsyncResultRecord b) {
			if (a.ssSTEspacePublishAsyncResult != b.ssSTEspacePublishAsyncResult) return false;
			return true;
		}

		public static bool operator != (RCEspacePublishAsyncResultRecord a, RCEspacePublishAsyncResultRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEspacePublishAsyncResultRecord)) return false;
			return (this == (RCEspacePublishAsyncResultRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEspacePublishAsyncResult.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEspacePublishAsyncResultRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEspacePublishAsyncResult = new STEspacePublishAsyncResultStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEspacePublishAsyncResult", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEspacePublishAsyncResult' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEspacePublishAsyncResult = (STEspacePublishAsyncResultStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEspacePublishAsyncResult.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEspacePublishAsyncResult.InternalRecursiveSave();
		}


		public RCEspacePublishAsyncResultRecord Duplicate() {
			RCEspacePublishAsyncResultRecord t;
			t.ssSTEspacePublishAsyncResult = (STEspacePublishAsyncResultStructure) this.ssSTEspacePublishAsyncResult.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEspacePublishAsyncResult.ToXml(this, recordElem, "EspacePublishAsyncResult", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "espacepublishasyncresult") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EspacePublishAsyncResult")) variable.Value = ssSTEspacePublishAsyncResult; else variable.Optimized = true;
				variable.SetFieldName("espacepublishasyncresult");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEspacePublishAsyncResult) {
				return ssSTEspacePublishAsyncResult;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEspacePublishAsyncResult.FillFromOther((IRecord) other.AttributeGet(IdEspacePublishAsyncResult));
		}
		public bool IsDefault() {
			RCEspacePublishAsyncResultRecord defaultStruct = new RCEspacePublishAsyncResultRecord(null);
			if (this.ssSTEspacePublishAsyncResult != defaultStruct.ssSTEspacePublishAsyncResult) return false;
			return true;
		}
	} // RCEspacePublishAsyncResultRecord

	/// <summary>
	/// Structure <code>RCEnvironmentInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEnvironmentInfoRecord: ISerializable, ITypedRecord<RCEnvironmentInfoRecord> {
		internal static readonly GlobalObjectKey IdEnvironmentInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jOyp5sH1Cmh_7v7rjdldqQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EnvironmentInfo")]
		public STEnvironmentInfoStructure ssSTEnvironmentInfo;


		public static implicit operator STEnvironmentInfoStructure(RCEnvironmentInfoRecord r) {
			return r.ssSTEnvironmentInfo;
		}

		public static implicit operator RCEnvironmentInfoRecord(STEnvironmentInfoStructure r) {
			RCEnvironmentInfoRecord res = new RCEnvironmentInfoRecord(null);
			res.ssSTEnvironmentInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEnvironmentInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEnvironmentInfo = new STEnvironmentInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEnvironmentInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEnvironmentInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEnvironmentInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCEnvironmentInfoRecord a, RCEnvironmentInfoRecord b) {
			if (a.ssSTEnvironmentInfo != b.ssSTEnvironmentInfo) return false;
			return true;
		}

		public static bool operator != (RCEnvironmentInfoRecord a, RCEnvironmentInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEnvironmentInfoRecord)) return false;
			return (this == (RCEnvironmentInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEnvironmentInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEnvironmentInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEnvironmentInfo = new STEnvironmentInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEnvironmentInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEnvironmentInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEnvironmentInfo = (STEnvironmentInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEnvironmentInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEnvironmentInfo.InternalRecursiveSave();
		}


		public RCEnvironmentInfoRecord Duplicate() {
			RCEnvironmentInfoRecord t;
			t.ssSTEnvironmentInfo = (STEnvironmentInfoStructure) this.ssSTEnvironmentInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEnvironmentInfo.ToXml(this, recordElem, "EnvironmentInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "environmentinfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EnvironmentInfo")) variable.Value = ssSTEnvironmentInfo; else variable.Optimized = true;
				variable.SetFieldName("environmentinfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEnvironmentInfo) {
				return ssSTEnvironmentInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEnvironmentInfo.FillFromOther((IRecord) other.AttributeGet(IdEnvironmentInfo));
		}
		public bool IsDefault() {
			RCEnvironmentInfoRecord defaultStruct = new RCEnvironmentInfoRecord(null);
			if (this.ssSTEnvironmentInfo != defaultStruct.ssSTEnvironmentInfo) return false;
			return true;
		}
	} // RCEnvironmentInfoRecord

	/// <summary>
	/// Structure <code>RCFeatureInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCFeatureInfoRecord: ISerializable, ITypedRecord<RCFeatureInfoRecord> {
		internal static readonly GlobalObjectKey IdFeatureInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dwkHFDZfcQ3TN5BY2J0VQw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("FeatureInfo")]
		public STFeatureInfoStructure ssSTFeatureInfo;


		public static implicit operator STFeatureInfoStructure(RCFeatureInfoRecord r) {
			return r.ssSTFeatureInfo;
		}

		public static implicit operator RCFeatureInfoRecord(STFeatureInfoStructure r) {
			RCFeatureInfoRecord res = new RCFeatureInfoRecord(null);
			res.ssSTFeatureInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCFeatureInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTFeatureInfo = new STFeatureInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTFeatureInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTFeatureInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCFeatureInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCFeatureInfoRecord a, RCFeatureInfoRecord b) {
			if (a.ssSTFeatureInfo != b.ssSTFeatureInfo) return false;
			return true;
		}

		public static bool operator != (RCFeatureInfoRecord a, RCFeatureInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCFeatureInfoRecord)) return false;
			return (this == (RCFeatureInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTFeatureInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCFeatureInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTFeatureInfo = new STFeatureInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTFeatureInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTFeatureInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTFeatureInfo = (STFeatureInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTFeatureInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTFeatureInfo.InternalRecursiveSave();
		}


		public RCFeatureInfoRecord Duplicate() {
			RCFeatureInfoRecord t;
			t.ssSTFeatureInfo = (STFeatureInfoStructure) this.ssSTFeatureInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTFeatureInfo.ToXml(this, recordElem, "FeatureInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "featureinfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FeatureInfo")) variable.Value = ssSTFeatureInfo; else variable.Optimized = true;
				variable.SetFieldName("featureinfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdFeatureInfo) {
				return ssSTFeatureInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTFeatureInfo.FillFromOther((IRecord) other.AttributeGet(IdFeatureInfo));
		}
		public bool IsDefault() {
			RCFeatureInfoRecord defaultStruct = new RCFeatureInfoRecord(null);
			if (this.ssSTFeatureInfo != defaultStruct.ssSTFeatureInfo) return false;
			return true;
		}
	} // RCFeatureInfoRecord

	/// <summary>
	/// Structure <code>RCPublicElementRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCPublicElementRecord: ISerializable, ITypedRecord<RCPublicElementRecord> {
		internal static readonly GlobalObjectKey IdPublicElement = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*273xEYxBaqMQP9zqp6kE5w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("PublicElement")]
		public STPublicElementStructure ssSTPublicElement;


		public static implicit operator STPublicElementStructure(RCPublicElementRecord r) {
			return r.ssSTPublicElement;
		}

		public static implicit operator RCPublicElementRecord(STPublicElementStructure r) {
			RCPublicElementRecord res = new RCPublicElementRecord(null);
			res.ssSTPublicElement = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCPublicElementRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTPublicElement = new STPublicElementStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTPublicElement.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTPublicElement.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCPublicElementRecord r) {
			this = r;
		}


		public static bool operator == (RCPublicElementRecord a, RCPublicElementRecord b) {
			if (a.ssSTPublicElement != b.ssSTPublicElement) return false;
			return true;
		}

		public static bool operator != (RCPublicElementRecord a, RCPublicElementRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCPublicElementRecord)) return false;
			return (this == (RCPublicElementRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTPublicElement.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCPublicElementRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTPublicElement = new STPublicElementStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTPublicElement", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTPublicElement' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTPublicElement = (STPublicElementStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTPublicElement.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTPublicElement.InternalRecursiveSave();
		}


		public RCPublicElementRecord Duplicate() {
			RCPublicElementRecord t;
			t.ssSTPublicElement = (STPublicElementStructure) this.ssSTPublicElement.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTPublicElement.ToXml(this, recordElem, "PublicElement", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "publicelement") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PublicElement")) variable.Value = ssSTPublicElement; else variable.Optimized = true;
				variable.SetFieldName("publicelement");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdPublicElement) {
				return ssSTPublicElement;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTPublicElement.FillFromOther((IRecord) other.AttributeGet(IdPublicElement));
		}
		public bool IsDefault() {
			RCPublicElementRecord defaultStruct = new RCPublicElementRecord(null);
			if (this.ssSTPublicElement != defaultStruct.ssSTPublicElement) return false;
			return true;
		}
	} // RCPublicElementRecord

	/// <summary>
	/// Structure <code>RCModuleVersionFeatureRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCModuleVersionFeatureRecord: ISerializable, ITypedRecord<RCModuleVersionFeatureRecord> {
		internal static readonly GlobalObjectKey IdModuleVersionFeature = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wajLGXOWNFctn_iOtTrQow");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ModuleVersionFeature")]
		public STModuleVersionFeatureStructure ssSTModuleVersionFeature;


		public static implicit operator STModuleVersionFeatureStructure(RCModuleVersionFeatureRecord r) {
			return r.ssSTModuleVersionFeature;
		}

		public static implicit operator RCModuleVersionFeatureRecord(STModuleVersionFeatureStructure r) {
			RCModuleVersionFeatureRecord res = new RCModuleVersionFeatureRecord(null);
			res.ssSTModuleVersionFeature = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCModuleVersionFeatureRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTModuleVersionFeature = new STModuleVersionFeatureStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTModuleVersionFeature.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTModuleVersionFeature.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCModuleVersionFeatureRecord r) {
			this = r;
		}


		public static bool operator == (RCModuleVersionFeatureRecord a, RCModuleVersionFeatureRecord b) {
			if (a.ssSTModuleVersionFeature != b.ssSTModuleVersionFeature) return false;
			return true;
		}

		public static bool operator != (RCModuleVersionFeatureRecord a, RCModuleVersionFeatureRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCModuleVersionFeatureRecord)) return false;
			return (this == (RCModuleVersionFeatureRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTModuleVersionFeature.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCModuleVersionFeatureRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTModuleVersionFeature = new STModuleVersionFeatureStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTModuleVersionFeature", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTModuleVersionFeature' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTModuleVersionFeature = (STModuleVersionFeatureStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTModuleVersionFeature.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTModuleVersionFeature.InternalRecursiveSave();
		}


		public RCModuleVersionFeatureRecord Duplicate() {
			RCModuleVersionFeatureRecord t;
			t.ssSTModuleVersionFeature = (STModuleVersionFeatureStructure) this.ssSTModuleVersionFeature.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTModuleVersionFeature.ToXml(this, recordElem, "ModuleVersionFeature", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "moduleversionfeature") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ModuleVersionFeature")) variable.Value = ssSTModuleVersionFeature; else variable.Optimized = true;
				variable.SetFieldName("moduleversionfeature");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdModuleVersionFeature) {
				return ssSTModuleVersionFeature;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTModuleVersionFeature.FillFromOther((IRecord) other.AttributeGet(IdModuleVersionFeature));
		}
		public bool IsDefault() {
			RCModuleVersionFeatureRecord defaultStruct = new RCModuleVersionFeatureRecord(null);
			if (this.ssSTModuleVersionFeature != defaultStruct.ssSTModuleVersionFeature) return false;
			return true;
		}
	} // RCModuleVersionFeatureRecord

	/// <summary>
	/// Structure <code>RCExtensionEntityConfigRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCExtensionEntityConfigRecord: ISerializable, ITypedRecord<RCExtensionEntityConfigRecord> {
		internal static readonly GlobalObjectKey IdExtensionEntityConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BpWd1uhazt4fHBq_72LWSQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ExtensionEntityConfig")]
		public STExtensionEntityConfigStructure ssSTExtensionEntityConfig;


		public static implicit operator STExtensionEntityConfigStructure(RCExtensionEntityConfigRecord r) {
			return r.ssSTExtensionEntityConfig;
		}

		public static implicit operator RCExtensionEntityConfigRecord(STExtensionEntityConfigStructure r) {
			RCExtensionEntityConfigRecord res = new RCExtensionEntityConfigRecord(null);
			res.ssSTExtensionEntityConfig = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCExtensionEntityConfigRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTExtensionEntityConfig = new STExtensionEntityConfigStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTExtensionEntityConfig.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTExtensionEntityConfig.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCExtensionEntityConfigRecord r) {
			this = r;
		}


		public static bool operator == (RCExtensionEntityConfigRecord a, RCExtensionEntityConfigRecord b) {
			if (a.ssSTExtensionEntityConfig != b.ssSTExtensionEntityConfig) return false;
			return true;
		}

		public static bool operator != (RCExtensionEntityConfigRecord a, RCExtensionEntityConfigRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCExtensionEntityConfigRecord)) return false;
			return (this == (RCExtensionEntityConfigRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTExtensionEntityConfig.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCExtensionEntityConfigRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTExtensionEntityConfig = new STExtensionEntityConfigStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTExtensionEntityConfig", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTExtensionEntityConfig' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTExtensionEntityConfig = (STExtensionEntityConfigStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTExtensionEntityConfig.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTExtensionEntityConfig.InternalRecursiveSave();
		}


		public RCExtensionEntityConfigRecord Duplicate() {
			RCExtensionEntityConfigRecord t;
			t.ssSTExtensionEntityConfig = (STExtensionEntityConfigStructure) this.ssSTExtensionEntityConfig.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTExtensionEntityConfig.ToXml(this, recordElem, "ExtensionEntityConfig", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "extensionentityconfig") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtensionEntityConfig")) variable.Value = ssSTExtensionEntityConfig; else variable.Optimized = true;
				variable.SetFieldName("extensionentityconfig");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdExtensionEntityConfig) {
				return ssSTExtensionEntityConfig;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTExtensionEntityConfig.FillFromOther((IRecord) other.AttributeGet(IdExtensionEntityConfig));
		}
		public bool IsDefault() {
			RCExtensionEntityConfigRecord defaultStruct = new RCExtensionEntityConfigRecord(null);
			if (this.ssSTExtensionEntityConfig != defaultStruct.ssSTExtensionEntityConfig) return false;
			return true;
		}
	} // RCExtensionEntityConfigRecord

	/// <summary>
	/// Structure <code>RCDeploymentZone_AmazonEKSRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCDeploymentZone_AmazonEKSRecord: ISerializable, ITypedRecord<RCDeploymentZone_AmazonEKSRecord> {
		internal static readonly GlobalObjectKey IdDeploymentZone_AmazonEKS = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xlVerxLF7lZ2zxmXWuW3BA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DeploymentZone_AmazonEKS")]
		public STDeploymentZone_AmazonEKSStructure ssSTDeploymentZone_AmazonEKS;


		public static implicit operator STDeploymentZone_AmazonEKSStructure(RCDeploymentZone_AmazonEKSRecord r) {
			return r.ssSTDeploymentZone_AmazonEKS;
		}

		public static implicit operator RCDeploymentZone_AmazonEKSRecord(STDeploymentZone_AmazonEKSStructure r) {
			RCDeploymentZone_AmazonEKSRecord res = new RCDeploymentZone_AmazonEKSRecord(null);
			res.ssSTDeploymentZone_AmazonEKS = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCDeploymentZone_AmazonEKSRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_AmazonEKS = new STDeploymentZone_AmazonEKSStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTDeploymentZone_AmazonEKS.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTDeploymentZone_AmazonEKS.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCDeploymentZone_AmazonEKSRecord r) {
			this = r;
		}


		public static bool operator == (RCDeploymentZone_AmazonEKSRecord a, RCDeploymentZone_AmazonEKSRecord b) {
			if (a.ssSTDeploymentZone_AmazonEKS != b.ssSTDeploymentZone_AmazonEKS) return false;
			return true;
		}

		public static bool operator != (RCDeploymentZone_AmazonEKSRecord a, RCDeploymentZone_AmazonEKSRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCDeploymentZone_AmazonEKSRecord)) return false;
			return (this == (RCDeploymentZone_AmazonEKSRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTDeploymentZone_AmazonEKS.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCDeploymentZone_AmazonEKSRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTDeploymentZone_AmazonEKS = new STDeploymentZone_AmazonEKSStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTDeploymentZone_AmazonEKS", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTDeploymentZone_AmazonEKS' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTDeploymentZone_AmazonEKS = (STDeploymentZone_AmazonEKSStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTDeploymentZone_AmazonEKS.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTDeploymentZone_AmazonEKS.InternalRecursiveSave();
		}


		public RCDeploymentZone_AmazonEKSRecord Duplicate() {
			RCDeploymentZone_AmazonEKSRecord t;
			t.ssSTDeploymentZone_AmazonEKS = (STDeploymentZone_AmazonEKSStructure) this.ssSTDeploymentZone_AmazonEKS.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTDeploymentZone_AmazonEKS.ToXml(this, recordElem, "DeploymentZone_AmazonEKS", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "deploymentzone_amazoneks") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DeploymentZone_AmazonEKS")) variable.Value = ssSTDeploymentZone_AmazonEKS; else variable.Optimized = true;
				variable.SetFieldName("deploymentzone_amazoneks");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDeploymentZone_AmazonEKS) {
				return ssSTDeploymentZone_AmazonEKS;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTDeploymentZone_AmazonEKS.FillFromOther((IRecord) other.AttributeGet(IdDeploymentZone_AmazonEKS));
		}
		public bool IsDefault() {
			RCDeploymentZone_AmazonEKSRecord defaultStruct = new RCDeploymentZone_AmazonEKSRecord(null);
			if (this.ssSTDeploymentZone_AmazonEKS != defaultStruct.ssSTDeploymentZone_AmazonEKS) return false;
			return true;
		}
	} // RCDeploymentZone_AmazonEKSRecord

	/// <summary>
	/// Structure <code>RCSolutionPack_SCEntityRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCSolutionPack_SCEntityRecord: ISerializable, ITypedRecord<RCSolutionPack_SCEntityRecord> {
		internal static readonly GlobalObjectKey IdSolutionPack_SCEntity = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*33lyHFEO0h5yHxE7bzq8VA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("SolutionPack_SCEntity")]
		public STSolutionPack_SCEntityStructure ssSTSolutionPack_SCEntity;


		public static implicit operator STSolutionPack_SCEntityStructure(RCSolutionPack_SCEntityRecord r) {
			return r.ssSTSolutionPack_SCEntity;
		}

		public static implicit operator RCSolutionPack_SCEntityRecord(STSolutionPack_SCEntityStructure r) {
			RCSolutionPack_SCEntityRecord res = new RCSolutionPack_SCEntityRecord(null);
			res.ssSTSolutionPack_SCEntity = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCSolutionPack_SCEntityRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SCEntity = new STSolutionPack_SCEntityStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTSolutionPack_SCEntity.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTSolutionPack_SCEntity.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCSolutionPack_SCEntityRecord r) {
			this = r;
		}


		public static bool operator == (RCSolutionPack_SCEntityRecord a, RCSolutionPack_SCEntityRecord b) {
			if (a.ssSTSolutionPack_SCEntity != b.ssSTSolutionPack_SCEntity) return false;
			return true;
		}

		public static bool operator != (RCSolutionPack_SCEntityRecord a, RCSolutionPack_SCEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCSolutionPack_SCEntityRecord)) return false;
			return (this == (RCSolutionPack_SCEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTSolutionPack_SCEntity.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCSolutionPack_SCEntityRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTSolutionPack_SCEntity = new STSolutionPack_SCEntityStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTSolutionPack_SCEntity", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTSolutionPack_SCEntity' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTSolutionPack_SCEntity = (STSolutionPack_SCEntityStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTSolutionPack_SCEntity.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTSolutionPack_SCEntity.InternalRecursiveSave();
		}


		public RCSolutionPack_SCEntityRecord Duplicate() {
			RCSolutionPack_SCEntityRecord t;
			t.ssSTSolutionPack_SCEntity = (STSolutionPack_SCEntityStructure) this.ssSTSolutionPack_SCEntity.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTSolutionPack_SCEntity.ToXml(this, recordElem, "SolutionPack_SCEntity", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "solutionpack_scentity") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SolutionPack_SCEntity")) variable.Value = ssSTSolutionPack_SCEntity; else variable.Optimized = true;
				variable.SetFieldName("solutionpack_scentity");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSolutionPack_SCEntity) {
				return ssSTSolutionPack_SCEntity;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTSolutionPack_SCEntity.FillFromOther((IRecord) other.AttributeGet(IdSolutionPack_SCEntity));
		}
		public bool IsDefault() {
			RCSolutionPack_SCEntityRecord defaultStruct = new RCSolutionPack_SCEntityRecord(null);
			if (this.ssSTSolutionPack_SCEntity != defaultStruct.ssSTSolutionPack_SCEntity) return false;
			return true;
		}
	} // RCSolutionPack_SCEntityRecord

	/// <summary>
	/// Structure <code>RCProducerModuleSignatureRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCProducerModuleSignatureRecord: ISerializable, ITypedRecord<RCProducerModuleSignatureRecord> {
		internal static readonly GlobalObjectKey IdProducerModuleSignature = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DWVWcPtPEWHDhJ2sBVTr2w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ProducerModuleSignature")]
		public STProducerModuleSignatureStructure ssSTProducerModuleSignature;


		public static implicit operator STProducerModuleSignatureStructure(RCProducerModuleSignatureRecord r) {
			return r.ssSTProducerModuleSignature;
		}

		public static implicit operator RCProducerModuleSignatureRecord(STProducerModuleSignatureStructure r) {
			RCProducerModuleSignatureRecord res = new RCProducerModuleSignatureRecord(null);
			res.ssSTProducerModuleSignature = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCProducerModuleSignatureRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTProducerModuleSignature = new STProducerModuleSignatureStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTProducerModuleSignature.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTProducerModuleSignature.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCProducerModuleSignatureRecord r) {
			this = r;
		}


		public static bool operator == (RCProducerModuleSignatureRecord a, RCProducerModuleSignatureRecord b) {
			if (a.ssSTProducerModuleSignature != b.ssSTProducerModuleSignature) return false;
			return true;
		}

		public static bool operator != (RCProducerModuleSignatureRecord a, RCProducerModuleSignatureRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCProducerModuleSignatureRecord)) return false;
			return (this == (RCProducerModuleSignatureRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTProducerModuleSignature.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCProducerModuleSignatureRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTProducerModuleSignature = new STProducerModuleSignatureStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTProducerModuleSignature", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTProducerModuleSignature' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTProducerModuleSignature = (STProducerModuleSignatureStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTProducerModuleSignature.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTProducerModuleSignature.InternalRecursiveSave();
		}


		public RCProducerModuleSignatureRecord Duplicate() {
			RCProducerModuleSignatureRecord t;
			t.ssSTProducerModuleSignature = (STProducerModuleSignatureStructure) this.ssSTProducerModuleSignature.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTProducerModuleSignature.ToXml(this, recordElem, "ProducerModuleSignature", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "producermodulesignature") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ProducerModuleSignature")) variable.Value = ssSTProducerModuleSignature; else variable.Optimized = true;
				variable.SetFieldName("producermodulesignature");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdProducerModuleSignature) {
				return ssSTProducerModuleSignature;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTProducerModuleSignature.FillFromOther((IRecord) other.AttributeGet(IdProducerModuleSignature));
		}
		public bool IsDefault() {
			RCProducerModuleSignatureRecord defaultStruct = new RCProducerModuleSignatureRecord(null);
			if (this.ssSTProducerModuleSignature != defaultStruct.ssSTProducerModuleSignature) return false;
			return true;
		}
	} // RCProducerModuleSignatureRecord

	/// <summary>
	/// Structure <code>RCCheckReferenceStatusResultRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCCheckReferenceStatusResultRecord: ISerializable, ITypedRecord<RCCheckReferenceStatusResultRecord> {
		internal static readonly GlobalObjectKey IdCheckReferenceStatusResult = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3ourltgP0WlrFyYdfXNESg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("CheckReferenceStatusResult")]
		public STCheckReferenceStatusResultStructure ssSTCheckReferenceStatusResult;


		public static implicit operator STCheckReferenceStatusResultStructure(RCCheckReferenceStatusResultRecord r) {
			return r.ssSTCheckReferenceStatusResult;
		}

		public static implicit operator RCCheckReferenceStatusResultRecord(STCheckReferenceStatusResultStructure r) {
			RCCheckReferenceStatusResultRecord res = new RCCheckReferenceStatusResultRecord(null);
			res.ssSTCheckReferenceStatusResult = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCCheckReferenceStatusResultRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTCheckReferenceStatusResult = new STCheckReferenceStatusResultStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTCheckReferenceStatusResult.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTCheckReferenceStatusResult.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCCheckReferenceStatusResultRecord r) {
			this = r;
		}


		public static bool operator == (RCCheckReferenceStatusResultRecord a, RCCheckReferenceStatusResultRecord b) {
			if (a.ssSTCheckReferenceStatusResult != b.ssSTCheckReferenceStatusResult) return false;
			return true;
		}

		public static bool operator != (RCCheckReferenceStatusResultRecord a, RCCheckReferenceStatusResultRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCCheckReferenceStatusResultRecord)) return false;
			return (this == (RCCheckReferenceStatusResultRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTCheckReferenceStatusResult.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCCheckReferenceStatusResultRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTCheckReferenceStatusResult = new STCheckReferenceStatusResultStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTCheckReferenceStatusResult", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTCheckReferenceStatusResult' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTCheckReferenceStatusResult = (STCheckReferenceStatusResultStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTCheckReferenceStatusResult.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTCheckReferenceStatusResult.InternalRecursiveSave();
		}


		public RCCheckReferenceStatusResultRecord Duplicate() {
			RCCheckReferenceStatusResultRecord t;
			t.ssSTCheckReferenceStatusResult = (STCheckReferenceStatusResultStructure) this.ssSTCheckReferenceStatusResult.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTCheckReferenceStatusResult.ToXml(this, recordElem, "CheckReferenceStatusResult", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "checkreferencestatusresult") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CheckReferenceStatusResult")) variable.Value = ssSTCheckReferenceStatusResult; else variable.Optimized = true;
				variable.SetFieldName("checkreferencestatusresult");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdCheckReferenceStatusResult) {
				return ssSTCheckReferenceStatusResult;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTCheckReferenceStatusResult.FillFromOther((IRecord) other.AttributeGet(IdCheckReferenceStatusResult));
		}
		public bool IsDefault() {
			RCCheckReferenceStatusResultRecord defaultStruct = new RCCheckReferenceStatusResultRecord(null);
			if (this.ssSTCheckReferenceStatusResult != defaultStruct.ssSTCheckReferenceStatusResult) return false;
			return true;
		}
	} // RCCheckReferenceStatusResultRecord

	/// <summary>
	/// Structure <code>RCIncompatibleModuleRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCIncompatibleModuleRecord: ISerializable, ITypedRecord<RCIncompatibleModuleRecord> {
		internal static readonly GlobalObjectKey IdIncompatibleModule = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+nd7P8mo5NxSuB0X0Ax9ZQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("IncompatibleModule")]
		public STIncompatibleModuleStructure ssSTIncompatibleModule;


		public static implicit operator STIncompatibleModuleStructure(RCIncompatibleModuleRecord r) {
			return r.ssSTIncompatibleModule;
		}

		public static implicit operator RCIncompatibleModuleRecord(STIncompatibleModuleStructure r) {
			RCIncompatibleModuleRecord res = new RCIncompatibleModuleRecord(null);
			res.ssSTIncompatibleModule = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCIncompatibleModuleRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTIncompatibleModule = new STIncompatibleModuleStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTIncompatibleModule.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTIncompatibleModule.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCIncompatibleModuleRecord r) {
			this = r;
		}


		public static bool operator == (RCIncompatibleModuleRecord a, RCIncompatibleModuleRecord b) {
			if (a.ssSTIncompatibleModule != b.ssSTIncompatibleModule) return false;
			return true;
		}

		public static bool operator != (RCIncompatibleModuleRecord a, RCIncompatibleModuleRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCIncompatibleModuleRecord)) return false;
			return (this == (RCIncompatibleModuleRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTIncompatibleModule.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCIncompatibleModuleRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTIncompatibleModule = new STIncompatibleModuleStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTIncompatibleModule", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTIncompatibleModule' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTIncompatibleModule = (STIncompatibleModuleStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTIncompatibleModule.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTIncompatibleModule.InternalRecursiveSave();
		}


		public RCIncompatibleModuleRecord Duplicate() {
			RCIncompatibleModuleRecord t;
			t.ssSTIncompatibleModule = (STIncompatibleModuleStructure) this.ssSTIncompatibleModule.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTIncompatibleModule.ToXml(this, recordElem, "IncompatibleModule", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "incompatiblemodule") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IncompatibleModule")) variable.Value = ssSTIncompatibleModule; else variable.Optimized = true;
				variable.SetFieldName("incompatiblemodule");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdIncompatibleModule) {
				return ssSTIncompatibleModule;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTIncompatibleModule.FillFromOther((IRecord) other.AttributeGet(IdIncompatibleModule));
		}
		public bool IsDefault() {
			RCIncompatibleModuleRecord defaultStruct = new RCIncompatibleModuleRecord(null);
			if (this.ssSTIncompatibleModule != defaultStruct.ssSTIncompatibleModule) return false;
			return true;
		}
	} // RCIncompatibleModuleRecord

	/// <summary>
	/// Structure <code>RCIncompatibleElementRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCIncompatibleElementRecord: ISerializable, ITypedRecord<RCIncompatibleElementRecord> {
		internal static readonly GlobalObjectKey IdIncompatibleElement = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DgZH5XqmYTksHoWPy45i0w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("IncompatibleElement")]
		public STIncompatibleElementStructure ssSTIncompatibleElement;


		public static implicit operator STIncompatibleElementStructure(RCIncompatibleElementRecord r) {
			return r.ssSTIncompatibleElement;
		}

		public static implicit operator RCIncompatibleElementRecord(STIncompatibleElementStructure r) {
			RCIncompatibleElementRecord res = new RCIncompatibleElementRecord(null);
			res.ssSTIncompatibleElement = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCIncompatibleElementRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTIncompatibleElement = new STIncompatibleElementStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTIncompatibleElement.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTIncompatibleElement.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCIncompatibleElementRecord r) {
			this = r;
		}


		public static bool operator == (RCIncompatibleElementRecord a, RCIncompatibleElementRecord b) {
			if (a.ssSTIncompatibleElement != b.ssSTIncompatibleElement) return false;
			return true;
		}

		public static bool operator != (RCIncompatibleElementRecord a, RCIncompatibleElementRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCIncompatibleElementRecord)) return false;
			return (this == (RCIncompatibleElementRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTIncompatibleElement.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCIncompatibleElementRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTIncompatibleElement = new STIncompatibleElementStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTIncompatibleElement", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTIncompatibleElement' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTIncompatibleElement = (STIncompatibleElementStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTIncompatibleElement.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTIncompatibleElement.InternalRecursiveSave();
		}


		public RCIncompatibleElementRecord Duplicate() {
			RCIncompatibleElementRecord t;
			t.ssSTIncompatibleElement = (STIncompatibleElementStructure) this.ssSTIncompatibleElement.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTIncompatibleElement.ToXml(this, recordElem, "IncompatibleElement", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "incompatibleelement") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IncompatibleElement")) variable.Value = ssSTIncompatibleElement; else variable.Optimized = true;
				variable.SetFieldName("incompatibleelement");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdIncompatibleElement) {
				return ssSTIncompatibleElement;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTIncompatibleElement.FillFromOther((IRecord) other.AttributeGet(IdIncompatibleElement));
		}
		public bool IsDefault() {
			RCIncompatibleElementRecord defaultStruct = new RCIncompatibleElementRecord(null);
			if (this.ssSTIncompatibleElement != defaultStruct.ssSTIncompatibleElement) return false;
			return true;
		}
	} // RCIncompatibleElementRecord
}
