using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssOMLProcessor {

	/// <summary>
	/// RecordList type <code>RLEntityInfoRecordList</code> that represents a record list of
	///  <code>EntityInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLEntityInfoRecordList: GenericRecordList<RCEntityInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEntityInfoRecord GetElementDefaultValue() {
			return new RCEntityInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCEntityInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEntityInfoRecordList recordlist, Func<RCEntityInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEntityInfoRecordList(RCEntityInfoRecord[] array) {
			RLEntityInfoRecordList result = new RLEntityInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEntityInfoRecordList ToList<T>(T[] array, Func <T, RCEntityInfoRecord> converter) {
			RLEntityInfoRecordList result = new RLEntityInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEntityInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEntityInfoRecord> converter) {
			RLEntityInfoRecordList result = new RLEntityInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEntityInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEntityInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEntityInfoRecord> NewList() {
			return new RLEntityInfoRecordList();
		}


	} // RLEntityInfoRecordList

	/// <summary>
	/// RecordList type <code>RLExtensionInfoRecordList</code> that represents a record list of
	///  <code>ExtensionInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLExtensionInfoRecordList: GenericRecordList<RCExtensionInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCExtensionInfoRecord GetElementDefaultValue() {
			return new RCExtensionInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCExtensionInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLExtensionInfoRecordList recordlist, Func<RCExtensionInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLExtensionInfoRecordList(RCExtensionInfoRecord[] array) {
			RLExtensionInfoRecordList result = new RLExtensionInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLExtensionInfoRecordList ToList<T>(T[] array, Func <T, RCExtensionInfoRecord> converter) {
			RLExtensionInfoRecordList result = new RLExtensionInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLExtensionInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCExtensionInfoRecord> converter) {
			RLExtensionInfoRecordList result = new RLExtensionInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLExtensionInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLExtensionInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLExtensionInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLExtensionInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCExtensionInfoRecord> NewList() {
			return new RLExtensionInfoRecordList();
		}


	} // RLExtensionInfoRecordList

	/// <summary>
	/// RecordList type <code>RLHEMessageRecordList</code> that represents a record list of
	///  <code>HEMessage</code>
	/// </summary>
	[Serializable()]
	public partial class RLHEMessageRecordList: GenericRecordList<RCHEMessageRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCHEMessageRecord GetElementDefaultValue() {
			return new RCHEMessageRecord("");
		}

		public T[] ToArray<T>(Func<RCHEMessageRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLHEMessageRecordList recordlist, Func<RCHEMessageRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLHEMessageRecordList(RCHEMessageRecord[] array) {
			RLHEMessageRecordList result = new RLHEMessageRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLHEMessageRecordList ToList<T>(T[] array, Func <T, RCHEMessageRecord> converter) {
			RLHEMessageRecordList result = new RLHEMessageRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLHEMessageRecordList FromRestList<T>(RestList<T> restList, Func <T, RCHEMessageRecord> converter) {
			RLHEMessageRecordList result = new RLHEMessageRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLHEMessageRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLHEMessageRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLHEMessageRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLHEMessageRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCHEMessageRecord> NewList() {
			return new RLHEMessageRecordList();
		}


	} // RLHEMessageRecordList

	/// <summary>
	/// RecordList type <code>RLHubNodeStatusRecordList</code> that represents a record list of
	///  <code>HubNodeStatus</code>
	/// </summary>
	[Serializable()]
	public partial class RLHubNodeStatusRecordList: GenericRecordList<RCHubNodeStatusRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCHubNodeStatusRecord GetElementDefaultValue() {
			return new RCHubNodeStatusRecord("");
		}

		public T[] ToArray<T>(Func<RCHubNodeStatusRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLHubNodeStatusRecordList recordlist, Func<RCHubNodeStatusRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLHubNodeStatusRecordList(RCHubNodeStatusRecord[] array) {
			RLHubNodeStatusRecordList result = new RLHubNodeStatusRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLHubNodeStatusRecordList ToList<T>(T[] array, Func <T, RCHubNodeStatusRecord> converter) {
			RLHubNodeStatusRecordList result = new RLHubNodeStatusRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLHubNodeStatusRecordList FromRestList<T>(RestList<T> restList, Func <T, RCHubNodeStatusRecord> converter) {
			RLHubNodeStatusRecordList result = new RLHubNodeStatusRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLHubNodeStatusRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLHubNodeStatusRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLHubNodeStatusRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLHubNodeStatusRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCHubNodeStatusRecord> NewList() {
			return new RLHubNodeStatusRecordList();
		}


	} // RLHubNodeStatusRecordList

	/// <summary>
	/// RecordList type <code>RLOmlReportRecordList</code> that represents a record list of
	///  <code>OmlReport</code>
	/// </summary>
	[Serializable()]
	public partial class RLOmlReportRecordList: GenericRecordList<RCOmlReportRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCOmlReportRecord GetElementDefaultValue() {
			return new RCOmlReportRecord("");
		}

		public T[] ToArray<T>(Func<RCOmlReportRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLOmlReportRecordList recordlist, Func<RCOmlReportRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLOmlReportRecordList(RCOmlReportRecord[] array) {
			RLOmlReportRecordList result = new RLOmlReportRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLOmlReportRecordList ToList<T>(T[] array, Func <T, RCOmlReportRecord> converter) {
			RLOmlReportRecordList result = new RLOmlReportRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLOmlReportRecordList FromRestList<T>(RestList<T> restList, Func <T, RCOmlReportRecord> converter) {
			RLOmlReportRecordList result = new RLOmlReportRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLOmlReportRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLOmlReportRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLOmlReportRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLOmlReportRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCOmlReportRecord> NewList() {
			return new RLOmlReportRecordList();
		}


	} // RLOmlReportRecordList

	/// <summary>
	/// RecordList type <code>RLQueueStatusRecordList</code> that represents a record list of
	///  <code>QueueStatus</code>
	/// </summary>
	[Serializable()]
	public partial class RLQueueStatusRecordList: GenericRecordList<RCQueueStatusRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCQueueStatusRecord GetElementDefaultValue() {
			return new RCQueueStatusRecord("");
		}

		public T[] ToArray<T>(Func<RCQueueStatusRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLQueueStatusRecordList recordlist, Func<RCQueueStatusRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLQueueStatusRecordList(RCQueueStatusRecord[] array) {
			RLQueueStatusRecordList result = new RLQueueStatusRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLQueueStatusRecordList ToList<T>(T[] array, Func <T, RCQueueStatusRecord> converter) {
			RLQueueStatusRecordList result = new RLQueueStatusRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLQueueStatusRecordList FromRestList<T>(RestList<T> restList, Func <T, RCQueueStatusRecord> converter) {
			RLQueueStatusRecordList result = new RLQueueStatusRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLQueueStatusRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLQueueStatusRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLQueueStatusRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLQueueStatusRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCQueueStatusRecord> NewList() {
			return new RLQueueStatusRecordList();
		}


	} // RLQueueStatusRecordList

	/// <summary>
	/// RecordList type <code>RLThreadStatusRecordList</code> that represents a record list of
	///  <code>ThreadStatus</code>
	/// </summary>
	[Serializable()]
	public partial class RLThreadStatusRecordList: GenericRecordList<RCThreadStatusRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCThreadStatusRecord GetElementDefaultValue() {
			return new RCThreadStatusRecord("");
		}

		public T[] ToArray<T>(Func<RCThreadStatusRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLThreadStatusRecordList recordlist, Func<RCThreadStatusRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLThreadStatusRecordList(RCThreadStatusRecord[] array) {
			RLThreadStatusRecordList result = new RLThreadStatusRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLThreadStatusRecordList ToList<T>(T[] array, Func <T, RCThreadStatusRecord> converter) {
			RLThreadStatusRecordList result = new RLThreadStatusRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLThreadStatusRecordList FromRestList<T>(RestList<T> restList, Func <T, RCThreadStatusRecord> converter) {
			RLThreadStatusRecordList result = new RLThreadStatusRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLThreadStatusRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLThreadStatusRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLThreadStatusRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLThreadStatusRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCThreadStatusRecord> NewList() {
			return new RLThreadStatusRecordList();
		}


	} // RLThreadStatusRecordList

	/// <summary>
	/// RecordList type <code>RLActionInfoRecordList</code> that represents a record list of
	///  <code>ActionInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLActionInfoRecordList: GenericRecordList<RCActionInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCActionInfoRecord GetElementDefaultValue() {
			return new RCActionInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCActionInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLActionInfoRecordList recordlist, Func<RCActionInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLActionInfoRecordList(RCActionInfoRecord[] array) {
			RLActionInfoRecordList result = new RLActionInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLActionInfoRecordList ToList<T>(T[] array, Func <T, RCActionInfoRecord> converter) {
			RLActionInfoRecordList result = new RLActionInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLActionInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCActionInfoRecord> converter) {
			RLActionInfoRecordList result = new RLActionInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLActionInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLActionInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLActionInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLActionInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCActionInfoRecord> NewList() {
			return new RLActionInfoRecordList();
		}


	} // RLActionInfoRecordList

	/// <summary>
	/// RecordList type <code>RLStructureInfoRecordList</code> that represents a record list of
	///  <code>StructureInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLStructureInfoRecordList: GenericRecordList<RCStructureInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCStructureInfoRecord GetElementDefaultValue() {
			return new RCStructureInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCStructureInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLStructureInfoRecordList recordlist, Func<RCStructureInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLStructureInfoRecordList(RCStructureInfoRecord[] array) {
			RLStructureInfoRecordList result = new RLStructureInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLStructureInfoRecordList ToList<T>(T[] array, Func <T, RCStructureInfoRecord> converter) {
			RLStructureInfoRecordList result = new RLStructureInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLStructureInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCStructureInfoRecord> converter) {
			RLStructureInfoRecordList result = new RLStructureInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLStructureInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLStructureInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLStructureInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLStructureInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCStructureInfoRecord> NewList() {
			return new RLStructureInfoRecordList();
		}


	} // RLStructureInfoRecordList

	/// <summary>
	/// RecordList type <code>RLReferenceImageRecordList</code> that represents a record list of
	///  <code>ReferenceImage</code>
	/// </summary>
	[Serializable()]
	public partial class RLReferenceImageRecordList: GenericRecordList<RCReferenceImageRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCReferenceImageRecord GetElementDefaultValue() {
			return new RCReferenceImageRecord("");
		}

		public T[] ToArray<T>(Func<RCReferenceImageRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLReferenceImageRecordList recordlist, Func<RCReferenceImageRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLReferenceImageRecordList(RCReferenceImageRecord[] array) {
			RLReferenceImageRecordList result = new RLReferenceImageRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLReferenceImageRecordList ToList<T>(T[] array, Func <T, RCReferenceImageRecord> converter) {
			RLReferenceImageRecordList result = new RLReferenceImageRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLReferenceImageRecordList FromRestList<T>(RestList<T> restList, Func <T, RCReferenceImageRecord> converter) {
			RLReferenceImageRecordList result = new RLReferenceImageRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLReferenceImageRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReferenceImageRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReferenceImageRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLReferenceImageRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCReferenceImageRecord> NewList() {
			return new RLReferenceImageRecordList();
		}


	} // RLReferenceImageRecordList

	/// <summary>
	/// RecordList type <code>RLProcessConfigRecordList</code> that represents a record list of
	///  <code>ProcessConfig</code>
	/// </summary>
	[Serializable()]
	public partial class RLProcessConfigRecordList: GenericRecordList<RCProcessConfigRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCProcessConfigRecord GetElementDefaultValue() {
			return new RCProcessConfigRecord("");
		}

		public T[] ToArray<T>(Func<RCProcessConfigRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLProcessConfigRecordList recordlist, Func<RCProcessConfigRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLProcessConfigRecordList(RCProcessConfigRecord[] array) {
			RLProcessConfigRecordList result = new RLProcessConfigRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLProcessConfigRecordList ToList<T>(T[] array, Func <T, RCProcessConfigRecord> converter) {
			RLProcessConfigRecordList result = new RLProcessConfigRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLProcessConfigRecordList FromRestList<T>(RestList<T> restList, Func <T, RCProcessConfigRecord> converter) {
			RLProcessConfigRecordList result = new RLProcessConfigRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLProcessConfigRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProcessConfigRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProcessConfigRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLProcessConfigRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCProcessConfigRecord> NewList() {
			return new RLProcessConfigRecordList();
		}


	} // RLProcessConfigRecordList

	/// <summary>
	/// RecordList type <code>RLProcessMemDataRecordList</code> that represents a record list of
	///  <code>ProcessMemData</code>
	/// </summary>
	[Serializable()]
	public partial class RLProcessMemDataRecordList: GenericRecordList<RCProcessMemDataRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCProcessMemDataRecord GetElementDefaultValue() {
			return new RCProcessMemDataRecord("");
		}

		public T[] ToArray<T>(Func<RCProcessMemDataRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLProcessMemDataRecordList recordlist, Func<RCProcessMemDataRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLProcessMemDataRecordList(RCProcessMemDataRecord[] array) {
			RLProcessMemDataRecordList result = new RLProcessMemDataRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLProcessMemDataRecordList ToList<T>(T[] array, Func <T, RCProcessMemDataRecord> converter) {
			RLProcessMemDataRecordList result = new RLProcessMemDataRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLProcessMemDataRecordList FromRestList<T>(RestList<T> restList, Func <T, RCProcessMemDataRecord> converter) {
			RLProcessMemDataRecordList result = new RLProcessMemDataRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLProcessMemDataRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProcessMemDataRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProcessMemDataRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLProcessMemDataRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCProcessMemDataRecord> NewList() {
			return new RLProcessMemDataRecordList();
		}


	} // RLProcessMemDataRecordList

	/// <summary>
	/// RecordList type <code>RLActivationResponseRecordList</code> that represents a record list of
	///  <code>ActivationResponse</code>
	/// </summary>
	[Serializable()]
	public partial class RLActivationResponseRecordList: GenericRecordList<RCActivationResponseRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCActivationResponseRecord GetElementDefaultValue() {
			return new RCActivationResponseRecord("");
		}

		public T[] ToArray<T>(Func<RCActivationResponseRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLActivationResponseRecordList recordlist, Func<RCActivationResponseRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLActivationResponseRecordList(RCActivationResponseRecord[] array) {
			RLActivationResponseRecordList result = new RLActivationResponseRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLActivationResponseRecordList ToList<T>(T[] array, Func <T, RCActivationResponseRecord> converter) {
			RLActivationResponseRecordList result = new RLActivationResponseRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLActivationResponseRecordList FromRestList<T>(RestList<T> restList, Func <T, RCActivationResponseRecord> converter) {
			RLActivationResponseRecordList result = new RLActivationResponseRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLActivationResponseRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLActivationResponseRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLActivationResponseRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLActivationResponseRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCActivationResponseRecord> NewList() {
			return new RLActivationResponseRecordList();
		}


	} // RLActivationResponseRecordList

	/// <summary>
	/// RecordList type <code>RLActivationLicenseInformationRecordList</code> that represents a record list
	///  of <code>ActivationLicenseInformation</code>
	/// </summary>
	[Serializable()]
	public partial class RLActivationLicenseInformationRecordList: GenericRecordList<RCActivationLicenseInformationRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCActivationLicenseInformationRecord GetElementDefaultValue() {
			return new RCActivationLicenseInformationRecord("");
		}

		public T[] ToArray<T>(Func<RCActivationLicenseInformationRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLActivationLicenseInformationRecordList recordlist, Func<RCActivationLicenseInformationRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLActivationLicenseInformationRecordList(RCActivationLicenseInformationRecord[] array) {
			RLActivationLicenseInformationRecordList result = new RLActivationLicenseInformationRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLActivationLicenseInformationRecordList ToList<T>(T[] array, Func <T, RCActivationLicenseInformationRecord> converter) {
			RLActivationLicenseInformationRecordList result = new RLActivationLicenseInformationRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLActivationLicenseInformationRecordList FromRestList<T>(RestList<T> restList, Func <T, RCActivationLicenseInformationRecord> converter) {
			RLActivationLicenseInformationRecordList result = new RLActivationLicenseInformationRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLActivationLicenseInformationRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLActivationLicenseInformationRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLActivationLicenseInformationRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLActivationLicenseInformationRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCActivationLicenseInformationRecord> NewList() {
			return new RLActivationLicenseInformationRecordList();
		}


	} // RLActivationLicenseInformationRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_SolutionRecordList</code> that represents a record list of
	///  <code>SolutionPack_Solution</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_SolutionRecordList: GenericRecordList<RCSolutionPack_SolutionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_SolutionRecord GetElementDefaultValue() {
			return new RCSolutionPack_SolutionRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_SolutionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_SolutionRecordList recordlist, Func<RCSolutionPack_SolutionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_SolutionRecordList(RCSolutionPack_SolutionRecord[] array) {
			RLSolutionPack_SolutionRecordList result = new RLSolutionPack_SolutionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_SolutionRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_SolutionRecord> converter) {
			RLSolutionPack_SolutionRecordList result = new RLSolutionPack_SolutionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_SolutionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_SolutionRecord> converter) {
			RLSolutionPack_SolutionRecordList result = new RLSolutionPack_SolutionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_SolutionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_SolutionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_SolutionRecord> NewList() {
			return new RLSolutionPack_SolutionRecordList();
		}


	} // RLSolutionPack_SolutionRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_SolutionReferenceRecordList</code> that represents a record
	///  list of <code>SolutionPack_SolutionReference</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_SolutionReferenceRecordList: GenericRecordList<RCSolutionPack_SolutionReferenceRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_SolutionReferenceRecord GetElementDefaultValue() {
			return new RCSolutionPack_SolutionReferenceRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_SolutionReferenceRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_SolutionReferenceRecordList recordlist, Func<RCSolutionPack_SolutionReferenceRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_SolutionReferenceRecordList(RCSolutionPack_SolutionReferenceRecord[] array) {
			RLSolutionPack_SolutionReferenceRecordList result = new RLSolutionPack_SolutionReferenceRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_SolutionReferenceRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_SolutionReferenceRecord> converter) {
			RLSolutionPack_SolutionReferenceRecordList result = new RLSolutionPack_SolutionReferenceRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_SolutionReferenceRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_SolutionReferenceRecord> converter) {
			RLSolutionPack_SolutionReferenceRecordList result = new RLSolutionPack_SolutionReferenceRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_SolutionReferenceRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionReferenceRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionReferenceRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_SolutionReferenceRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_SolutionReferenceRecord> NewList() {
			return new RLSolutionPack_SolutionReferenceRecordList();
		}


	} // RLSolutionPack_SolutionReferenceRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_SolutionVersionRecordList</code> that represents a record list
	///  of <code>SolutionPack_SolutionVersion</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_SolutionVersionRecordList: GenericRecordList<RCSolutionPack_SolutionVersionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_SolutionVersionRecord GetElementDefaultValue() {
			return new RCSolutionPack_SolutionVersionRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_SolutionVersionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_SolutionVersionRecordList recordlist, Func<RCSolutionPack_SolutionVersionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_SolutionVersionRecordList(RCSolutionPack_SolutionVersionRecord[] array) {
			RLSolutionPack_SolutionVersionRecordList result = new RLSolutionPack_SolutionVersionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_SolutionVersionRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_SolutionVersionRecord> converter) {
			RLSolutionPack_SolutionVersionRecordList result = new RLSolutionPack_SolutionVersionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_SolutionVersionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_SolutionVersionRecord> converter) {
			RLSolutionPack_SolutionVersionRecordList result = new RLSolutionPack_SolutionVersionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_SolutionVersionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionVersionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionVersionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_SolutionVersionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_SolutionVersionRecord> NewList() {
			return new RLSolutionPack_SolutionVersionRecordList();
		}


	} // RLSolutionPack_SolutionVersionRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_SolutionVersionReferenceRecordList</code> that represents a
	///  record list of <code>SolutionPack_SolutionVersionReference</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_SolutionVersionReferenceRecordList: GenericRecordList<RCSolutionPack_SolutionVersionReferenceRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_SolutionVersionReferenceRecord GetElementDefaultValue() {
			return new RCSolutionPack_SolutionVersionReferenceRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_SolutionVersionReferenceRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_SolutionVersionReferenceRecordList recordlist, Func<RCSolutionPack_SolutionVersionReferenceRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_SolutionVersionReferenceRecordList(RCSolutionPack_SolutionVersionReferenceRecord[] array) {
			RLSolutionPack_SolutionVersionReferenceRecordList result = new RLSolutionPack_SolutionVersionReferenceRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_SolutionVersionReferenceRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_SolutionVersionReferenceRecord> converter) {
			RLSolutionPack_SolutionVersionReferenceRecordList result = new RLSolutionPack_SolutionVersionReferenceRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_SolutionVersionReferenceRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_SolutionVersionReferenceRecord> converter) {
			RLSolutionPack_SolutionVersionReferenceRecordList result = new RLSolutionPack_SolutionVersionReferenceRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_SolutionVersionReferenceRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionVersionReferenceRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionVersionReferenceRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_SolutionVersionReferenceRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_SolutionVersionReferenceRecord> NewList() {
			return new RLSolutionPack_SolutionVersionReferenceRecordList();
		}


	} // RLSolutionPack_SolutionVersionReferenceRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPackRecordList</code> that represents a record list of
	///  <code>SolutionPack</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPackRecordList: GenericRecordList<RCSolutionPackRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPackRecord GetElementDefaultValue() {
			return new RCSolutionPackRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPackRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPackRecordList recordlist, Func<RCSolutionPackRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPackRecordList(RCSolutionPackRecord[] array) {
			RLSolutionPackRecordList result = new RLSolutionPackRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPackRecordList ToList<T>(T[] array, Func <T, RCSolutionPackRecord> converter) {
			RLSolutionPackRecordList result = new RLSolutionPackRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPackRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPackRecord> converter) {
			RLSolutionPackRecordList result = new RLSolutionPackRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPackRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPackRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPackRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPackRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPackRecord> NewList() {
			return new RLSolutionPackRecordList();
		}


	} // RLSolutionPackRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_FileRecordList</code> that represents a record list of
	///  <code>SolutionPack_File</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_FileRecordList: GenericRecordList<RCSolutionPack_FileRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_FileRecord GetElementDefaultValue() {
			return new RCSolutionPack_FileRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_FileRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_FileRecordList recordlist, Func<RCSolutionPack_FileRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_FileRecordList(RCSolutionPack_FileRecord[] array) {
			RLSolutionPack_FileRecordList result = new RLSolutionPack_FileRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_FileRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_FileRecord> converter) {
			RLSolutionPack_FileRecordList result = new RLSolutionPack_FileRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_FileRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_FileRecord> converter) {
			RLSolutionPack_FileRecordList result = new RLSolutionPack_FileRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_FileRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_FileRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_FileRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_FileRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_FileRecord> NewList() {
			return new RLSolutionPack_FileRecordList();
		}


	} // RLSolutionPack_FileRecordList

	/// <summary>
	/// RecordList type <code>RLEspaceInfoRecordList</code> that represents a record list of
	///  <code>EspaceInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLEspaceInfoRecordList: GenericRecordList<RCEspaceInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEspaceInfoRecord GetElementDefaultValue() {
			return new RCEspaceInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCEspaceInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEspaceInfoRecordList recordlist, Func<RCEspaceInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEspaceInfoRecordList(RCEspaceInfoRecord[] array) {
			RLEspaceInfoRecordList result = new RLEspaceInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEspaceInfoRecordList ToList<T>(T[] array, Func <T, RCEspaceInfoRecord> converter) {
			RLEspaceInfoRecordList result = new RLEspaceInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEspaceInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEspaceInfoRecord> converter) {
			RLEspaceInfoRecordList result = new RLEspaceInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEspaceInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEspaceInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEspaceInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEspaceInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEspaceInfoRecord> NewList() {
			return new RLEspaceInfoRecordList();
		}


	} // RLEspaceInfoRecordList

	/// <summary>
	/// RecordList type <code>RLReferenceRecordList</code> that represents a record list of
	///  <code>Reference</code>
	/// </summary>
	[Serializable()]
	public partial class RLReferenceRecordList: GenericRecordList<RCReferenceRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCReferenceRecord GetElementDefaultValue() {
			return new RCReferenceRecord("");
		}

		public T[] ToArray<T>(Func<RCReferenceRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLReferenceRecordList recordlist, Func<RCReferenceRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLReferenceRecordList(RCReferenceRecord[] array) {
			RLReferenceRecordList result = new RLReferenceRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLReferenceRecordList ToList<T>(T[] array, Func <T, RCReferenceRecord> converter) {
			RLReferenceRecordList result = new RLReferenceRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLReferenceRecordList FromRestList<T>(RestList<T> restList, Func <T, RCReferenceRecord> converter) {
			RLReferenceRecordList result = new RLReferenceRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLReferenceRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReferenceRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReferenceRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLReferenceRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCReferenceRecord> NewList() {
			return new RLReferenceRecordList();
		}


	} // RLReferenceRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_SolutionLogicalDatabaseRecordList</code> that represents a
	///  record list of <code>SolutionPack_SolutionLogicalDatabase</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_SolutionLogicalDatabaseRecordList: GenericRecordList<RCSolutionPack_SolutionLogicalDatabaseRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_SolutionLogicalDatabaseRecord GetElementDefaultValue() {
			return new RCSolutionPack_SolutionLogicalDatabaseRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_SolutionLogicalDatabaseRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_SolutionLogicalDatabaseRecordList recordlist, Func<RCSolutionPack_SolutionLogicalDatabaseRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_SolutionLogicalDatabaseRecordList(RCSolutionPack_SolutionLogicalDatabaseRecord[] array) {
			RLSolutionPack_SolutionLogicalDatabaseRecordList result = new RLSolutionPack_SolutionLogicalDatabaseRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_SolutionLogicalDatabaseRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_SolutionLogicalDatabaseRecord> converter) {
			RLSolutionPack_SolutionLogicalDatabaseRecordList result = new RLSolutionPack_SolutionLogicalDatabaseRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_SolutionLogicalDatabaseRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_SolutionLogicalDatabaseRecord> converter) {
			RLSolutionPack_SolutionLogicalDatabaseRecordList result = new RLSolutionPack_SolutionLogicalDatabaseRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_SolutionLogicalDatabaseRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionLogicalDatabaseRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionLogicalDatabaseRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_SolutionLogicalDatabaseRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_SolutionLogicalDatabaseRecord> NewList() {
			return new RLSolutionPack_SolutionLogicalDatabaseRecordList();
		}


	} // RLSolutionPack_SolutionLogicalDatabaseRecordList

	/// <summary>
	/// RecordList type <code>RLLinkRecordList</code> that represents a record list of <code>Link</code>
	/// </summary>
	[Serializable()]
	public partial class RLLinkRecordList: GenericRecordList<RCLinkRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCLinkRecord GetElementDefaultValue() {
			return new RCLinkRecord("");
		}

		public T[] ToArray<T>(Func<RCLinkRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLLinkRecordList recordlist, Func<RCLinkRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLLinkRecordList(RCLinkRecord[] array) {
			RLLinkRecordList result = new RLLinkRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLLinkRecordList ToList<T>(T[] array, Func <T, RCLinkRecord> converter) {
			RLLinkRecordList result = new RLLinkRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLLinkRecordList FromRestList<T>(RestList<T> restList, Func <T, RCLinkRecord> converter) {
			RLLinkRecordList result = new RLLinkRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLLinkRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLinkRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLinkRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLLinkRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCLinkRecord> NewList() {
			return new RLLinkRecordList();
		}


	} // RLLinkRecordList

	/// <summary>
	/// RecordList type <code>RLAbstractRecordRecordList</code> that represents a record list of
	///  <code>AbstractRecord</code>
	/// </summary>
	[Serializable()]
	public partial class RLAbstractRecordRecordList: GenericRecordList<RCAbstractRecordRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAbstractRecordRecord GetElementDefaultValue() {
			return new RCAbstractRecordRecord("");
		}

		public T[] ToArray<T>(Func<RCAbstractRecordRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAbstractRecordRecordList recordlist, Func<RCAbstractRecordRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAbstractRecordRecordList(RCAbstractRecordRecord[] array) {
			RLAbstractRecordRecordList result = new RLAbstractRecordRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAbstractRecordRecordList ToList<T>(T[] array, Func <T, RCAbstractRecordRecord> converter) {
			RLAbstractRecordRecordList result = new RLAbstractRecordRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAbstractRecordRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAbstractRecordRecord> converter) {
			RLAbstractRecordRecordList result = new RLAbstractRecordRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAbstractRecordRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAbstractRecordRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAbstractRecordRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAbstractRecordRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAbstractRecordRecord> NewList() {
			return new RLAbstractRecordRecordList();
		}


	} // RLAbstractRecordRecordList

	/// <summary>
	/// RecordList type <code>RLAbstractFieldRecordList</code> that represents a record list of
	///  <code>AbstractField</code>
	/// </summary>
	[Serializable()]
	public partial class RLAbstractFieldRecordList: GenericRecordList<RCAbstractFieldRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAbstractFieldRecord GetElementDefaultValue() {
			return new RCAbstractFieldRecord("");
		}

		public T[] ToArray<T>(Func<RCAbstractFieldRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAbstractFieldRecordList recordlist, Func<RCAbstractFieldRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAbstractFieldRecordList(RCAbstractFieldRecord[] array) {
			RLAbstractFieldRecordList result = new RLAbstractFieldRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAbstractFieldRecordList ToList<T>(T[] array, Func <T, RCAbstractFieldRecord> converter) {
			RLAbstractFieldRecordList result = new RLAbstractFieldRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAbstractFieldRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAbstractFieldRecord> converter) {
			RLAbstractFieldRecordList result = new RLAbstractFieldRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAbstractFieldRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAbstractFieldRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAbstractFieldRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAbstractFieldRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAbstractFieldRecord> NewList() {
			return new RLAbstractFieldRecordList();
		}


	} // RLAbstractFieldRecordList

	/// <summary>
	/// RecordList type <code>RLFeatureRecordList</code> that represents a record list of
	///  <code>Feature</code>
	/// </summary>
	[Serializable()]
	public partial class RLFeatureRecordList: GenericRecordList<RCFeatureRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCFeatureRecord GetElementDefaultValue() {
			return new RCFeatureRecord("");
		}

		public T[] ToArray<T>(Func<RCFeatureRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLFeatureRecordList recordlist, Func<RCFeatureRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLFeatureRecordList(RCFeatureRecord[] array) {
			RLFeatureRecordList result = new RLFeatureRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLFeatureRecordList ToList<T>(T[] array, Func <T, RCFeatureRecord> converter) {
			RLFeatureRecordList result = new RLFeatureRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLFeatureRecordList FromRestList<T>(RestList<T> restList, Func <T, RCFeatureRecord> converter) {
			RLFeatureRecordList result = new RLFeatureRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLFeatureRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLFeatureRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLFeatureRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLFeatureRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCFeatureRecord> NewList() {
			return new RLFeatureRecordList();
		}


	} // RLFeatureRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_SolutionDBCatalogRecordList</code> that represents a record
	///  list of <code>SolutionPack_SolutionDBCatalog</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_SolutionDBCatalogRecordList: GenericRecordList<RCSolutionPack_SolutionDBCatalogRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_SolutionDBCatalogRecord GetElementDefaultValue() {
			return new RCSolutionPack_SolutionDBCatalogRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_SolutionDBCatalogRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_SolutionDBCatalogRecordList recordlist, Func<RCSolutionPack_SolutionDBCatalogRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_SolutionDBCatalogRecordList(RCSolutionPack_SolutionDBCatalogRecord[] array) {
			RLSolutionPack_SolutionDBCatalogRecordList result = new RLSolutionPack_SolutionDBCatalogRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_SolutionDBCatalogRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_SolutionDBCatalogRecord> converter) {
			RLSolutionPack_SolutionDBCatalogRecordList result = new RLSolutionPack_SolutionDBCatalogRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_SolutionDBCatalogRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_SolutionDBCatalogRecord> converter) {
			RLSolutionPack_SolutionDBCatalogRecordList result = new RLSolutionPack_SolutionDBCatalogRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_SolutionDBCatalogRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionDBCatalogRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SolutionDBCatalogRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_SolutionDBCatalogRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_SolutionDBCatalogRecord> NewList() {
			return new RLSolutionPack_SolutionDBCatalogRecordList();
		}


	} // RLSolutionPack_SolutionDBCatalogRecordList

	/// <summary>
	/// RecordList type <code>RLIntegerRecordList</code> that represents a record list of
	///  <code>Integer</code>
	/// </summary>
	[Serializable()]
	public partial class RLIntegerRecordList: GenericRecordList<RCIntegerRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCIntegerRecord GetElementDefaultValue() {
			return new RCIntegerRecord("");
		}

		public T[] ToArray<T>(Func<RCIntegerRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLIntegerRecordList recordlist, Func<RCIntegerRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLIntegerRecordList(RCIntegerRecord[] array) {
			RLIntegerRecordList result = new RLIntegerRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLIntegerRecordList ToList<T>(T[] array, Func <T, RCIntegerRecord> converter) {
			RLIntegerRecordList result = new RLIntegerRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLIntegerRecordList FromRestList<T>(RestList<T> restList, Func <T, RCIntegerRecord> converter) {
			RLIntegerRecordList result = new RLIntegerRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLIntegerRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIntegerRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIntegerRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLIntegerRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCIntegerRecord> NewList() {
			return new RLIntegerRecordList();
		}


	} // RLIntegerRecordList

	/// <summary>
	/// RecordList type <code>RLTextRecordList</code> that represents a record list of <code>Text</code>
	/// </summary>
	[Serializable()]
	public partial class RLTextRecordList: GenericRecordList<RCTextRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTextRecord GetElementDefaultValue() {
			return new RCTextRecord("");
		}

		public T[] ToArray<T>(Func<RCTextRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTextRecordList recordlist, Func<RCTextRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTextRecordList(RCTextRecord[] array) {
			RLTextRecordList result = new RLTextRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTextRecordList ToList<T>(T[] array, Func <T, RCTextRecord> converter) {
			RLTextRecordList result = new RLTextRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTextRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTextRecord> converter) {
			RLTextRecordList result = new RLTextRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTextRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTextRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTextRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTextRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTextRecord> NewList() {
			return new RLTextRecordList();
		}


	} // RLTextRecordList

	/// <summary>
	/// RecordList type <code>RLBooleanRecordList</code> that represents a record list of
	///  <code>Boolean</code>
	/// </summary>
	[Serializable()]
	public partial class RLBooleanRecordList: GenericRecordList<RCBooleanRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCBooleanRecord GetElementDefaultValue() {
			return new RCBooleanRecord("");
		}

		public T[] ToArray<T>(Func<RCBooleanRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLBooleanRecordList recordlist, Func<RCBooleanRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLBooleanRecordList(RCBooleanRecord[] array) {
			RLBooleanRecordList result = new RLBooleanRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLBooleanRecordList ToList<T>(T[] array, Func <T, RCBooleanRecord> converter) {
			RLBooleanRecordList result = new RLBooleanRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLBooleanRecordList FromRestList<T>(RestList<T> restList, Func <T, RCBooleanRecord> converter) {
			RLBooleanRecordList result = new RLBooleanRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLBooleanRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLBooleanRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLBooleanRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLBooleanRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCBooleanRecord> NewList() {
			return new RLBooleanRecordList();
		}


	} // RLBooleanRecordList

	/// <summary>
	/// RecordList type <code>RLDecimalRecordList</code> that represents a record list of
	///  <code>Decimal</code>
	/// </summary>
	[Serializable()]
	public partial class RLDecimalRecordList: GenericRecordList<RCDecimalRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDecimalRecord GetElementDefaultValue() {
			return new RCDecimalRecord("");
		}

		public T[] ToArray<T>(Func<RCDecimalRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDecimalRecordList recordlist, Func<RCDecimalRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDecimalRecordList(RCDecimalRecord[] array) {
			RLDecimalRecordList result = new RLDecimalRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDecimalRecordList ToList<T>(T[] array, Func <T, RCDecimalRecord> converter) {
			RLDecimalRecordList result = new RLDecimalRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDecimalRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDecimalRecord> converter) {
			RLDecimalRecordList result = new RLDecimalRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDecimalRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDecimalRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDecimalRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDecimalRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDecimalRecord> NewList() {
			return new RLDecimalRecordList();
		}


	} // RLDecimalRecordList

	/// <summary>
	/// RecordList type <code>RLDateTimeRecordList</code> that represents a record list of
	///  <code>DateTime</code>
	/// </summary>
	[Serializable()]
	public partial class RLDateTimeRecordList: GenericRecordList<RCDateTimeRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDateTimeRecord GetElementDefaultValue() {
			return new RCDateTimeRecord("");
		}

		public T[] ToArray<T>(Func<RCDateTimeRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDateTimeRecordList recordlist, Func<RCDateTimeRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDateTimeRecordList(RCDateTimeRecord[] array) {
			RLDateTimeRecordList result = new RLDateTimeRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDateTimeRecordList ToList<T>(T[] array, Func <T, RCDateTimeRecord> converter) {
			RLDateTimeRecordList result = new RLDateTimeRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDateTimeRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDateTimeRecord> converter) {
			RLDateTimeRecordList result = new RLDateTimeRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDateTimeRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDateTimeRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDateTimeRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDateTimeRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDateTimeRecord> NewList() {
			return new RLDateTimeRecordList();
		}


	} // RLDateTimeRecordList

	/// <summary>
	/// RecordList type <code>RLBinaryDataRecordList</code> that represents a record list of
	///  <code>BinaryData</code>
	/// </summary>
	[Serializable()]
	public partial class RLBinaryDataRecordList: GenericRecordList<RCBinaryDataRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCBinaryDataRecord GetElementDefaultValue() {
			return new RCBinaryDataRecord("");
		}

		public T[] ToArray<T>(Func<RCBinaryDataRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLBinaryDataRecordList recordlist, Func<RCBinaryDataRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLBinaryDataRecordList(RCBinaryDataRecord[] array) {
			RLBinaryDataRecordList result = new RLBinaryDataRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLBinaryDataRecordList ToList<T>(T[] array, Func <T, RCBinaryDataRecord> converter) {
			RLBinaryDataRecordList result = new RLBinaryDataRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLBinaryDataRecordList FromRestList<T>(RestList<T> restList, Func <T, RCBinaryDataRecord> converter) {
			RLBinaryDataRecordList result = new RLBinaryDataRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLBinaryDataRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLBinaryDataRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLBinaryDataRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLBinaryDataRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCBinaryDataRecord> NewList() {
			return new RLBinaryDataRecordList();
		}


	} // RLBinaryDataRecordList

	/// <summary>
	/// RecordList type <code>RLKeyValuePairRecordList</code> that represents a record list of
	///  <code>KeyValuePair</code>
	/// </summary>
	[Serializable()]
	public partial class RLKeyValuePairRecordList: GenericRecordList<RCKeyValuePairRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCKeyValuePairRecord GetElementDefaultValue() {
			return new RCKeyValuePairRecord("");
		}

		public T[] ToArray<T>(Func<RCKeyValuePairRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLKeyValuePairRecordList recordlist, Func<RCKeyValuePairRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLKeyValuePairRecordList(RCKeyValuePairRecord[] array) {
			RLKeyValuePairRecordList result = new RLKeyValuePairRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLKeyValuePairRecordList ToList<T>(T[] array, Func <T, RCKeyValuePairRecord> converter) {
			RLKeyValuePairRecordList result = new RLKeyValuePairRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLKeyValuePairRecordList FromRestList<T>(RestList<T> restList, Func <T, RCKeyValuePairRecord> converter) {
			RLKeyValuePairRecordList result = new RLKeyValuePairRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLKeyValuePairRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLKeyValuePairRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLKeyValuePairRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLKeyValuePairRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCKeyValuePairRecord> NewList() {
			return new RLKeyValuePairRecordList();
		}


	} // RLKeyValuePairRecordList

	/// <summary>
	/// RecordList type <code>RLEntityEventRecordList</code> that represents a record list of
	///  <code>EntityEvent</code>
	/// </summary>
	[Serializable()]
	public partial class RLEntityEventRecordList: GenericRecordList<RCEntityEventRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEntityEventRecord GetElementDefaultValue() {
			return new RCEntityEventRecord("");
		}

		public T[] ToArray<T>(Func<RCEntityEventRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEntityEventRecordList recordlist, Func<RCEntityEventRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEntityEventRecordList(RCEntityEventRecord[] array) {
			RLEntityEventRecordList result = new RLEntityEventRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEntityEventRecordList ToList<T>(T[] array, Func <T, RCEntityEventRecord> converter) {
			RLEntityEventRecordList result = new RLEntityEventRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEntityEventRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEntityEventRecord> converter) {
			RLEntityEventRecordList result = new RLEntityEventRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEntityEventRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityEventRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityEventRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEntityEventRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEntityEventRecord> NewList() {
			return new RLEntityEventRecordList();
		}


	} // RLEntityEventRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_ApplicationRecordList</code> that represents a record list of
	///  <code>SolutionPack_Application</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_ApplicationRecordList: GenericRecordList<RCSolutionPack_ApplicationRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_ApplicationRecord GetElementDefaultValue() {
			return new RCSolutionPack_ApplicationRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_ApplicationRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_ApplicationRecordList recordlist, Func<RCSolutionPack_ApplicationRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_ApplicationRecordList(RCSolutionPack_ApplicationRecord[] array) {
			RLSolutionPack_ApplicationRecordList result = new RLSolutionPack_ApplicationRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_ApplicationRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_ApplicationRecord> converter) {
			RLSolutionPack_ApplicationRecordList result = new RLSolutionPack_ApplicationRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_ApplicationRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_ApplicationRecord> converter) {
			RLSolutionPack_ApplicationRecordList result = new RLSolutionPack_ApplicationRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_ApplicationRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_ApplicationRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_ApplicationRecord> NewList() {
			return new RLSolutionPack_ApplicationRecordList();
		}


	} // RLSolutionPack_ApplicationRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_ApplicationModuleRecordList</code> that represents a record
	///  list of <code>SolutionPack_ApplicationModule</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_ApplicationModuleRecordList: GenericRecordList<RCSolutionPack_ApplicationModuleRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_ApplicationModuleRecord GetElementDefaultValue() {
			return new RCSolutionPack_ApplicationModuleRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_ApplicationModuleRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_ApplicationModuleRecordList recordlist, Func<RCSolutionPack_ApplicationModuleRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_ApplicationModuleRecordList(RCSolutionPack_ApplicationModuleRecord[] array) {
			RLSolutionPack_ApplicationModuleRecordList result = new RLSolutionPack_ApplicationModuleRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_ApplicationModuleRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_ApplicationModuleRecord> converter) {
			RLSolutionPack_ApplicationModuleRecordList result = new RLSolutionPack_ApplicationModuleRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_ApplicationModuleRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_ApplicationModuleRecord> converter) {
			RLSolutionPack_ApplicationModuleRecordList result = new RLSolutionPack_ApplicationModuleRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_ApplicationModuleRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationModuleRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationModuleRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_ApplicationModuleRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_ApplicationModuleRecord> NewList() {
			return new RLSolutionPack_ApplicationModuleRecordList();
		}


	} // RLSolutionPack_ApplicationModuleRecordList

	/// <summary>
	/// RecordList type <code>RLExtensionEntityInfoRecordList</code> that represents a record list of
	///  <code>ExtensionEntityInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLExtensionEntityInfoRecordList: GenericRecordList<RCExtensionEntityInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCExtensionEntityInfoRecord GetElementDefaultValue() {
			return new RCExtensionEntityInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCExtensionEntityInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLExtensionEntityInfoRecordList recordlist, Func<RCExtensionEntityInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLExtensionEntityInfoRecordList(RCExtensionEntityInfoRecord[] array) {
			RLExtensionEntityInfoRecordList result = new RLExtensionEntityInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLExtensionEntityInfoRecordList ToList<T>(T[] array, Func <T, RCExtensionEntityInfoRecord> converter) {
			RLExtensionEntityInfoRecordList result = new RLExtensionEntityInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLExtensionEntityInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCExtensionEntityInfoRecord> converter) {
			RLExtensionEntityInfoRecordList result = new RLExtensionEntityInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLExtensionEntityInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLExtensionEntityInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLExtensionEntityInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLExtensionEntityInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCExtensionEntityInfoRecord> NewList() {
			return new RLExtensionEntityInfoRecordList();
		}


	} // RLExtensionEntityInfoRecordList

	/// <summary>
	/// RecordList type <code>RLDALDBConfigParamRecordList</code> that represents a record list of
	///  <code>DALDBConfigParam</code>
	/// </summary>
	[Serializable()]
	public partial class RLDALDBConfigParamRecordList: GenericRecordList<RCDALDBConfigParamRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDALDBConfigParamRecord GetElementDefaultValue() {
			return new RCDALDBConfigParamRecord("");
		}

		public T[] ToArray<T>(Func<RCDALDBConfigParamRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDALDBConfigParamRecordList recordlist, Func<RCDALDBConfigParamRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDALDBConfigParamRecordList(RCDALDBConfigParamRecord[] array) {
			RLDALDBConfigParamRecordList result = new RLDALDBConfigParamRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDALDBConfigParamRecordList ToList<T>(T[] array, Func <T, RCDALDBConfigParamRecord> converter) {
			RLDALDBConfigParamRecordList result = new RLDALDBConfigParamRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDALDBConfigParamRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDALDBConfigParamRecord> converter) {
			RLDALDBConfigParamRecordList result = new RLDALDBConfigParamRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDALDBConfigParamRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALDBConfigParamRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALDBConfigParamRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDALDBConfigParamRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDALDBConfigParamRecord> NewList() {
			return new RLDALDBConfigParamRecordList();
		}


	} // RLDALDBConfigParamRecordList

	/// <summary>
	/// RecordList type <code>RLDALDBConfigProviderRecordList</code> that represents a record list of
	///  <code>DALDBConfigProvider</code>
	/// </summary>
	[Serializable()]
	public partial class RLDALDBConfigProviderRecordList: GenericRecordList<RCDALDBConfigProviderRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDALDBConfigProviderRecord GetElementDefaultValue() {
			return new RCDALDBConfigProviderRecord("");
		}

		public T[] ToArray<T>(Func<RCDALDBConfigProviderRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDALDBConfigProviderRecordList recordlist, Func<RCDALDBConfigProviderRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDALDBConfigProviderRecordList(RCDALDBConfigProviderRecord[] array) {
			RLDALDBConfigProviderRecordList result = new RLDALDBConfigProviderRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDALDBConfigProviderRecordList ToList<T>(T[] array, Func <T, RCDALDBConfigProviderRecord> converter) {
			RLDALDBConfigProviderRecordList result = new RLDALDBConfigProviderRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDALDBConfigProviderRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDALDBConfigProviderRecord> converter) {
			RLDALDBConfigProviderRecordList result = new RLDALDBConfigProviderRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDALDBConfigProviderRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALDBConfigProviderRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALDBConfigProviderRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDALDBConfigProviderRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDALDBConfigProviderRecord> NewList() {
			return new RLDALDBConfigProviderRecordList();
		}


	} // RLDALDBConfigProviderRecordList

	/// <summary>
	/// RecordList type <code>RLDALDBConfigEnumValueRecordList</code> that represents a record list of
	///  <code>DALDBConfigEnumValue</code>
	/// </summary>
	[Serializable()]
	public partial class RLDALDBConfigEnumValueRecordList: GenericRecordList<RCDALDBConfigEnumValueRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDALDBConfigEnumValueRecord GetElementDefaultValue() {
			return new RCDALDBConfigEnumValueRecord("");
		}

		public T[] ToArray<T>(Func<RCDALDBConfigEnumValueRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDALDBConfigEnumValueRecordList recordlist, Func<RCDALDBConfigEnumValueRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDALDBConfigEnumValueRecordList(RCDALDBConfigEnumValueRecord[] array) {
			RLDALDBConfigEnumValueRecordList result = new RLDALDBConfigEnumValueRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDALDBConfigEnumValueRecordList ToList<T>(T[] array, Func <T, RCDALDBConfigEnumValueRecord> converter) {
			RLDALDBConfigEnumValueRecordList result = new RLDALDBConfigEnumValueRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDALDBConfigEnumValueRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDALDBConfigEnumValueRecord> converter) {
			RLDALDBConfigEnumValueRecordList result = new RLDALDBConfigEnumValueRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDALDBConfigEnumValueRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALDBConfigEnumValueRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALDBConfigEnumValueRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDALDBConfigEnumValueRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDALDBConfigEnumValueRecord> NewList() {
			return new RLDALDBConfigEnumValueRecordList();
		}


	} // RLDALDBConfigEnumValueRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_ApplicationModulePublicElementRecordList</code> that
	///  represents a record list of <code>SolutionPack_ApplicationModulePublicElement</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_ApplicationModulePublicElementRecordList: GenericRecordList<RCSolutionPack_ApplicationModulePublicElementRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_ApplicationModulePublicElementRecord GetElementDefaultValue() {
			return new RCSolutionPack_ApplicationModulePublicElementRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_ApplicationModulePublicElementRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_ApplicationModulePublicElementRecordList recordlist, Func<RCSolutionPack_ApplicationModulePublicElementRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_ApplicationModulePublicElementRecordList(RCSolutionPack_ApplicationModulePublicElementRecord[] array) {
			RLSolutionPack_ApplicationModulePublicElementRecordList result = new RLSolutionPack_ApplicationModulePublicElementRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_ApplicationModulePublicElementRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_ApplicationModulePublicElementRecord> converter) {
			RLSolutionPack_ApplicationModulePublicElementRecordList result = new RLSolutionPack_ApplicationModulePublicElementRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_ApplicationModulePublicElementRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_ApplicationModulePublicElementRecord> converter) {
			RLSolutionPack_ApplicationModulePublicElementRecordList result = new RLSolutionPack_ApplicationModulePublicElementRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_ApplicationModulePublicElementRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationModulePublicElementRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationModulePublicElementRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_ApplicationModulePublicElementRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_ApplicationModulePublicElementRecord> NewList() {
			return new RLSolutionPack_ApplicationModulePublicElementRecordList();
		}


	} // RLSolutionPack_ApplicationModulePublicElementRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_ApplicationDependencyRecordList</code> that represents a
	///  record list of <code>SolutionPack_ApplicationDependency</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_ApplicationDependencyRecordList: GenericRecordList<RCSolutionPack_ApplicationDependencyRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_ApplicationDependencyRecord GetElementDefaultValue() {
			return new RCSolutionPack_ApplicationDependencyRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_ApplicationDependencyRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_ApplicationDependencyRecordList recordlist, Func<RCSolutionPack_ApplicationDependencyRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_ApplicationDependencyRecordList(RCSolutionPack_ApplicationDependencyRecord[] array) {
			RLSolutionPack_ApplicationDependencyRecordList result = new RLSolutionPack_ApplicationDependencyRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_ApplicationDependencyRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_ApplicationDependencyRecord> converter) {
			RLSolutionPack_ApplicationDependencyRecordList result = new RLSolutionPack_ApplicationDependencyRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_ApplicationDependencyRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_ApplicationDependencyRecord> converter) {
			RLSolutionPack_ApplicationDependencyRecordList result = new RLSolutionPack_ApplicationDependencyRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_ApplicationDependencyRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationDependencyRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationDependencyRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_ApplicationDependencyRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_ApplicationDependencyRecord> NewList() {
			return new RLSolutionPack_ApplicationDependencyRecordList();
		}


	} // RLSolutionPack_ApplicationDependencyRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_ApplicationReferencedModuleRecordList</code> that represents a
	///  record list of <code>SolutionPack_ApplicationReferencedModule</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_ApplicationReferencedModuleRecordList: GenericRecordList<RCSolutionPack_ApplicationReferencedModuleRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_ApplicationReferencedModuleRecord GetElementDefaultValue() {
			return new RCSolutionPack_ApplicationReferencedModuleRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_ApplicationReferencedModuleRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_ApplicationReferencedModuleRecordList recordlist, Func<RCSolutionPack_ApplicationReferencedModuleRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_ApplicationReferencedModuleRecordList(RCSolutionPack_ApplicationReferencedModuleRecord[] array) {
			RLSolutionPack_ApplicationReferencedModuleRecordList result = new RLSolutionPack_ApplicationReferencedModuleRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_ApplicationReferencedModuleRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_ApplicationReferencedModuleRecord> converter) {
			RLSolutionPack_ApplicationReferencedModuleRecordList result = new RLSolutionPack_ApplicationReferencedModuleRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_ApplicationReferencedModuleRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_ApplicationReferencedModuleRecord> converter) {
			RLSolutionPack_ApplicationReferencedModuleRecordList result = new RLSolutionPack_ApplicationReferencedModuleRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_ApplicationReferencedModuleRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationReferencedModuleRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_ApplicationReferencedModuleRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_ApplicationReferencedModuleRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_ApplicationReferencedModuleRecord> NewList() {
			return new RLSolutionPack_ApplicationReferencedModuleRecordList();
		}


	} // RLSolutionPack_ApplicationReferencedModuleRecordList

	/// <summary>
	/// RecordList type <code>RLEntityDBProviderKeyRecordList</code> that represents a record list of
	///  <code>EntityDBProviderKey</code>
	/// </summary>
	[Serializable()]
	public partial class RLEntityDBProviderKeyRecordList: GenericRecordList<RCEntityDBProviderKeyRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEntityDBProviderKeyRecord GetElementDefaultValue() {
			return new RCEntityDBProviderKeyRecord("");
		}

		public T[] ToArray<T>(Func<RCEntityDBProviderKeyRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEntityDBProviderKeyRecordList recordlist, Func<RCEntityDBProviderKeyRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEntityDBProviderKeyRecordList(RCEntityDBProviderKeyRecord[] array) {
			RLEntityDBProviderKeyRecordList result = new RLEntityDBProviderKeyRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEntityDBProviderKeyRecordList ToList<T>(T[] array, Func <T, RCEntityDBProviderKeyRecord> converter) {
			RLEntityDBProviderKeyRecordList result = new RLEntityDBProviderKeyRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEntityDBProviderKeyRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEntityDBProviderKeyRecord> converter) {
			RLEntityDBProviderKeyRecordList result = new RLEntityDBProviderKeyRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEntityDBProviderKeyRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityDBProviderKeyRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityDBProviderKeyRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEntityDBProviderKeyRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEntityDBProviderKeyRecord> NewList() {
			return new RLEntityDBProviderKeyRecordList();
		}


	} // RLEntityDBProviderKeyRecordList

	/// <summary>
	/// RecordList type <code>RLDALEntityHighlightingHashRecordList</code> that represents a record list of
	///  <code>DALEntityHighlightingHash</code>
	/// </summary>
	[Serializable()]
	public partial class RLDALEntityHighlightingHashRecordList: GenericRecordList<RCDALEntityHighlightingHashRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDALEntityHighlightingHashRecord GetElementDefaultValue() {
			return new RCDALEntityHighlightingHashRecord("");
		}

		public T[] ToArray<T>(Func<RCDALEntityHighlightingHashRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDALEntityHighlightingHashRecordList recordlist, Func<RCDALEntityHighlightingHashRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDALEntityHighlightingHashRecordList(RCDALEntityHighlightingHashRecord[] array) {
			RLDALEntityHighlightingHashRecordList result = new RLDALEntityHighlightingHashRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDALEntityHighlightingHashRecordList ToList<T>(T[] array, Func <T, RCDALEntityHighlightingHashRecord> converter) {
			RLDALEntityHighlightingHashRecordList result = new RLDALEntityHighlightingHashRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDALEntityHighlightingHashRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDALEntityHighlightingHashRecord> converter) {
			RLDALEntityHighlightingHashRecordList result = new RLDALEntityHighlightingHashRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDALEntityHighlightingHashRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALEntityHighlightingHashRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALEntityHighlightingHashRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDALEntityHighlightingHashRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDALEntityHighlightingHashRecord> NewList() {
			return new RLDALEntityHighlightingHashRecordList();
		}


	} // RLDALEntityHighlightingHashRecordList

	/// <summary>
	/// RecordList type <code>RLDALHighlightingDefinitionRecordList</code> that represents a record list of
	///  <code>DALHighlightingDefinition</code>
	/// </summary>
	[Serializable()]
	public partial class RLDALHighlightingDefinitionRecordList: GenericRecordList<RCDALHighlightingDefinitionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDALHighlightingDefinitionRecord GetElementDefaultValue() {
			return new RCDALHighlightingDefinitionRecord("");
		}

		public T[] ToArray<T>(Func<RCDALHighlightingDefinitionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDALHighlightingDefinitionRecordList recordlist, Func<RCDALHighlightingDefinitionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDALHighlightingDefinitionRecordList(RCDALHighlightingDefinitionRecord[] array) {
			RLDALHighlightingDefinitionRecordList result = new RLDALHighlightingDefinitionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDALHighlightingDefinitionRecordList ToList<T>(T[] array, Func <T, RCDALHighlightingDefinitionRecord> converter) {
			RLDALHighlightingDefinitionRecordList result = new RLDALHighlightingDefinitionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDALHighlightingDefinitionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDALHighlightingDefinitionRecord> converter) {
			RLDALHighlightingDefinitionRecordList result = new RLDALHighlightingDefinitionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDALHighlightingDefinitionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALHighlightingDefinitionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDALHighlightingDefinitionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDALHighlightingDefinitionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDALHighlightingDefinitionRecord> NewList() {
			return new RLDALHighlightingDefinitionRecordList();
		}


	} // RLDALHighlightingDefinitionRecordList

	/// <summary>
	/// RecordList type <code>RLModuleDefinitionRecordList</code> that represents a record list of
	///  <code>ModuleDefinition</code>
	/// </summary>
	[Serializable()]
	public partial class RLModuleDefinitionRecordList: GenericRecordList<RCModuleDefinitionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCModuleDefinitionRecord GetElementDefaultValue() {
			return new RCModuleDefinitionRecord("");
		}

		public T[] ToArray<T>(Func<RCModuleDefinitionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLModuleDefinitionRecordList recordlist, Func<RCModuleDefinitionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLModuleDefinitionRecordList(RCModuleDefinitionRecord[] array) {
			RLModuleDefinitionRecordList result = new RLModuleDefinitionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLModuleDefinitionRecordList ToList<T>(T[] array, Func <T, RCModuleDefinitionRecord> converter) {
			RLModuleDefinitionRecordList result = new RLModuleDefinitionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLModuleDefinitionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCModuleDefinitionRecord> converter) {
			RLModuleDefinitionRecordList result = new RLModuleDefinitionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLModuleDefinitionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLModuleDefinitionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLModuleDefinitionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLModuleDefinitionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCModuleDefinitionRecord> NewList() {
			return new RLModuleDefinitionRecordList();
		}


	} // RLModuleDefinitionRecordList

	/// <summary>
	/// RecordList type <code>RLEntityDefinitionRecordList</code> that represents a record list of
	///  <code>EntityDefinition</code>
	/// </summary>
	[Serializable()]
	public partial class RLEntityDefinitionRecordList: GenericRecordList<RCEntityDefinitionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEntityDefinitionRecord GetElementDefaultValue() {
			return new RCEntityDefinitionRecord("");
		}

		public T[] ToArray<T>(Func<RCEntityDefinitionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEntityDefinitionRecordList recordlist, Func<RCEntityDefinitionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEntityDefinitionRecordList(RCEntityDefinitionRecord[] array) {
			RLEntityDefinitionRecordList result = new RLEntityDefinitionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEntityDefinitionRecordList ToList<T>(T[] array, Func <T, RCEntityDefinitionRecord> converter) {
			RLEntityDefinitionRecordList result = new RLEntityDefinitionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEntityDefinitionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEntityDefinitionRecord> converter) {
			RLEntityDefinitionRecordList result = new RLEntityDefinitionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEntityDefinitionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityDefinitionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityDefinitionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEntityDefinitionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEntityDefinitionRecord> NewList() {
			return new RLEntityDefinitionRecordList();
		}


	} // RLEntityDefinitionRecordList

	/// <summary>
	/// RecordList type <code>RLAttributeDefinitionRecordList</code> that represents a record list of
	///  <code>AttributeDefinition</code>
	/// </summary>
	[Serializable()]
	public partial class RLAttributeDefinitionRecordList: GenericRecordList<RCAttributeDefinitionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAttributeDefinitionRecord GetElementDefaultValue() {
			return new RCAttributeDefinitionRecord("");
		}

		public T[] ToArray<T>(Func<RCAttributeDefinitionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAttributeDefinitionRecordList recordlist, Func<RCAttributeDefinitionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAttributeDefinitionRecordList(RCAttributeDefinitionRecord[] array) {
			RLAttributeDefinitionRecordList result = new RLAttributeDefinitionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAttributeDefinitionRecordList ToList<T>(T[] array, Func <T, RCAttributeDefinitionRecord> converter) {
			RLAttributeDefinitionRecordList result = new RLAttributeDefinitionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAttributeDefinitionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAttributeDefinitionRecord> converter) {
			RLAttributeDefinitionRecordList result = new RLAttributeDefinitionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAttributeDefinitionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttributeDefinitionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAttributeDefinitionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAttributeDefinitionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAttributeDefinitionRecord> NewList() {
			return new RLAttributeDefinitionRecordList();
		}


	} // RLAttributeDefinitionRecordList

	/// <summary>
	/// RecordList type <code>RLModuleVersionDefinitionRecordList</code> that represents a record list of
	///  <code>ModuleVersionDefinition</code>
	/// </summary>
	[Serializable()]
	public partial class RLModuleVersionDefinitionRecordList: GenericRecordList<RCModuleVersionDefinitionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCModuleVersionDefinitionRecord GetElementDefaultValue() {
			return new RCModuleVersionDefinitionRecord("");
		}

		public T[] ToArray<T>(Func<RCModuleVersionDefinitionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLModuleVersionDefinitionRecordList recordlist, Func<RCModuleVersionDefinitionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLModuleVersionDefinitionRecordList(RCModuleVersionDefinitionRecord[] array) {
			RLModuleVersionDefinitionRecordList result = new RLModuleVersionDefinitionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLModuleVersionDefinitionRecordList ToList<T>(T[] array, Func <T, RCModuleVersionDefinitionRecord> converter) {
			RLModuleVersionDefinitionRecordList result = new RLModuleVersionDefinitionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLModuleVersionDefinitionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCModuleVersionDefinitionRecord> converter) {
			RLModuleVersionDefinitionRecordList result = new RLModuleVersionDefinitionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLModuleVersionDefinitionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLModuleVersionDefinitionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLModuleVersionDefinitionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLModuleVersionDefinitionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCModuleVersionDefinitionRecord> NewList() {
			return new RLModuleVersionDefinitionRecordList();
		}


	} // RLModuleVersionDefinitionRecordList

	/// <summary>
	/// RecordList type <code>RLExternalAuthentication_PluginAPIStatusRecordList</code> that represents a
	///  record list of <code>ExternalAuthentication_PluginAPIStatus</code>
	/// </summary>
	[Serializable()]
	public partial class RLExternalAuthentication_PluginAPIStatusRecordList: GenericRecordList<RCExternalAuthentication_PluginAPIStatusRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCExternalAuthentication_PluginAPIStatusRecord GetElementDefaultValue() {
			return new RCExternalAuthentication_PluginAPIStatusRecord("");
		}

		public T[] ToArray<T>(Func<RCExternalAuthentication_PluginAPIStatusRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLExternalAuthentication_PluginAPIStatusRecordList recordlist, Func<RCExternalAuthentication_PluginAPIStatusRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLExternalAuthentication_PluginAPIStatusRecordList(RCExternalAuthentication_PluginAPIStatusRecord[] array) {
			RLExternalAuthentication_PluginAPIStatusRecordList result = new RLExternalAuthentication_PluginAPIStatusRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLExternalAuthentication_PluginAPIStatusRecordList ToList<T>(T[] array, Func <T, RCExternalAuthentication_PluginAPIStatusRecord> converter) {
			RLExternalAuthentication_PluginAPIStatusRecordList result = new RLExternalAuthentication_PluginAPIStatusRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLExternalAuthentication_PluginAPIStatusRecordList FromRestList<T>(RestList<T> restList, Func <T, RCExternalAuthentication_PluginAPIStatusRecord> converter) {
			RLExternalAuthentication_PluginAPIStatusRecordList result = new RLExternalAuthentication_PluginAPIStatusRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLExternalAuthentication_PluginAPIStatusRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLExternalAuthentication_PluginAPIStatusRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLExternalAuthentication_PluginAPIStatusRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLExternalAuthentication_PluginAPIStatusRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCExternalAuthentication_PluginAPIStatusRecord> NewList() {
			return new RLExternalAuthentication_PluginAPIStatusRecordList();
		}


	} // RLExternalAuthentication_PluginAPIStatusRecordList

	/// <summary>
	/// RecordList type <code>RLIntegrationPluginInfoRecordList</code> that represents a record list of
	///  <code>IntegrationPluginInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLIntegrationPluginInfoRecordList: GenericRecordList<RCIntegrationPluginInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCIntegrationPluginInfoRecord GetElementDefaultValue() {
			return new RCIntegrationPluginInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCIntegrationPluginInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLIntegrationPluginInfoRecordList recordlist, Func<RCIntegrationPluginInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLIntegrationPluginInfoRecordList(RCIntegrationPluginInfoRecord[] array) {
			RLIntegrationPluginInfoRecordList result = new RLIntegrationPluginInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLIntegrationPluginInfoRecordList ToList<T>(T[] array, Func <T, RCIntegrationPluginInfoRecord> converter) {
			RLIntegrationPluginInfoRecordList result = new RLIntegrationPluginInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLIntegrationPluginInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCIntegrationPluginInfoRecord> converter) {
			RLIntegrationPluginInfoRecordList result = new RLIntegrationPluginInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLIntegrationPluginInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIntegrationPluginInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIntegrationPluginInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLIntegrationPluginInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCIntegrationPluginInfoRecord> NewList() {
			return new RLIntegrationPluginInfoRecordList();
		}


	} // RLIntegrationPluginInfoRecordList

	/// <summary>
	/// RecordList type <code>RLFileRecordList</code> that represents a record list of <code>File</code>
	/// </summary>
	[Serializable()]
	public partial class RLFileRecordList: GenericRecordList<RCFileRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCFileRecord GetElementDefaultValue() {
			return new RCFileRecord("");
		}

		public T[] ToArray<T>(Func<RCFileRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLFileRecordList recordlist, Func<RCFileRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLFileRecordList(RCFileRecord[] array) {
			RLFileRecordList result = new RLFileRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLFileRecordList ToList<T>(T[] array, Func <T, RCFileRecord> converter) {
			RLFileRecordList result = new RLFileRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLFileRecordList FromRestList<T>(RestList<T> restList, Func <T, RCFileRecord> converter) {
			RLFileRecordList result = new RLFileRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLFileRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLFileRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLFileRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLFileRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCFileRecord> NewList() {
			return new RLFileRecordList();
		}


	} // RLFileRecordList

	/// <summary>
	/// RecordList type <code>RLLoginAttemptRecordList</code> that represents a record list of
	///  <code>LoginAttempt</code>
	/// </summary>
	[Serializable()]
	public partial class RLLoginAttemptRecordList: GenericRecordList<RCLoginAttemptRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCLoginAttemptRecord GetElementDefaultValue() {
			return new RCLoginAttemptRecord("");
		}

		public T[] ToArray<T>(Func<RCLoginAttemptRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLLoginAttemptRecordList recordlist, Func<RCLoginAttemptRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLLoginAttemptRecordList(RCLoginAttemptRecord[] array) {
			RLLoginAttemptRecordList result = new RLLoginAttemptRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLLoginAttemptRecordList ToList<T>(T[] array, Func <T, RCLoginAttemptRecord> converter) {
			RLLoginAttemptRecordList result = new RLLoginAttemptRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLLoginAttemptRecordList FromRestList<T>(RestList<T> restList, Func <T, RCLoginAttemptRecord> converter) {
			RLLoginAttemptRecordList result = new RLLoginAttemptRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLLoginAttemptRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLoginAttemptRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLLoginAttemptRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLLoginAttemptRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCLoginAttemptRecord> NewList() {
			return new RLLoginAttemptRecordList();
		}


	} // RLLoginAttemptRecordList

	/// <summary>
	/// RecordList type <code>RLJWTClaimsRecordList</code> that represents a record list of
	///  <code>JWTClaims</code>
	/// </summary>
	[Serializable()]
	public partial class RLJWTClaimsRecordList: GenericRecordList<RCJWTClaimsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCJWTClaimsRecord GetElementDefaultValue() {
			return new RCJWTClaimsRecord("");
		}

		public T[] ToArray<T>(Func<RCJWTClaimsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLJWTClaimsRecordList recordlist, Func<RCJWTClaimsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLJWTClaimsRecordList(RCJWTClaimsRecord[] array) {
			RLJWTClaimsRecordList result = new RLJWTClaimsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLJWTClaimsRecordList ToList<T>(T[] array, Func <T, RCJWTClaimsRecord> converter) {
			RLJWTClaimsRecordList result = new RLJWTClaimsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLJWTClaimsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCJWTClaimsRecord> converter) {
			RLJWTClaimsRecordList result = new RLJWTClaimsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLJWTClaimsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLJWTClaimsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLJWTClaimsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLJWTClaimsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCJWTClaimsRecord> NewList() {
			return new RLJWTClaimsRecordList();
		}


	} // RLJWTClaimsRecordList

	/// <summary>
	/// RecordList type <code>RLQueuedNativeBuildResultRecordList</code> that represents a record list of
	///  <code>QueuedNativeBuildResult</code>
	/// </summary>
	[Serializable()]
	public partial class RLQueuedNativeBuildResultRecordList: GenericRecordList<RCQueuedNativeBuildResultRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCQueuedNativeBuildResultRecord GetElementDefaultValue() {
			return new RCQueuedNativeBuildResultRecord("");
		}

		public T[] ToArray<T>(Func<RCQueuedNativeBuildResultRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLQueuedNativeBuildResultRecordList recordlist, Func<RCQueuedNativeBuildResultRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLQueuedNativeBuildResultRecordList(RCQueuedNativeBuildResultRecord[] array) {
			RLQueuedNativeBuildResultRecordList result = new RLQueuedNativeBuildResultRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLQueuedNativeBuildResultRecordList ToList<T>(T[] array, Func <T, RCQueuedNativeBuildResultRecord> converter) {
			RLQueuedNativeBuildResultRecordList result = new RLQueuedNativeBuildResultRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLQueuedNativeBuildResultRecordList FromRestList<T>(RestList<T> restList, Func <T, RCQueuedNativeBuildResultRecord> converter) {
			RLQueuedNativeBuildResultRecordList result = new RLQueuedNativeBuildResultRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLQueuedNativeBuildResultRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLQueuedNativeBuildResultRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLQueuedNativeBuildResultRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLQueuedNativeBuildResultRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCQueuedNativeBuildResultRecord> NewList() {
			return new RLQueuedNativeBuildResultRecordList();
		}


	} // RLQueuedNativeBuildResultRecordList

	/// <summary>
	/// RecordList type <code>RLNativePluginConfigurationRecordList</code> that represents a record list of
	///  <code>NativePluginConfiguration</code>
	/// </summary>
	[Serializable()]
	public partial class RLNativePluginConfigurationRecordList: GenericRecordList<RCNativePluginConfigurationRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCNativePluginConfigurationRecord GetElementDefaultValue() {
			return new RCNativePluginConfigurationRecord("");
		}

		public T[] ToArray<T>(Func<RCNativePluginConfigurationRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLNativePluginConfigurationRecordList recordlist, Func<RCNativePluginConfigurationRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLNativePluginConfigurationRecordList(RCNativePluginConfigurationRecord[] array) {
			RLNativePluginConfigurationRecordList result = new RLNativePluginConfigurationRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLNativePluginConfigurationRecordList ToList<T>(T[] array, Func <T, RCNativePluginConfigurationRecord> converter) {
			RLNativePluginConfigurationRecordList result = new RLNativePluginConfigurationRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLNativePluginConfigurationRecordList FromRestList<T>(RestList<T> restList, Func <T, RCNativePluginConfigurationRecord> converter) {
			RLNativePluginConfigurationRecordList result = new RLNativePluginConfigurationRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLNativePluginConfigurationRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLNativePluginConfigurationRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLNativePluginConfigurationRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLNativePluginConfigurationRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCNativePluginConfigurationRecord> NewList() {
			return new RLNativePluginConfigurationRecordList();
		}


	} // RLNativePluginConfigurationRecordList

	/// <summary>
	/// RecordList type <code>RLUserWithUserPoolRecordList</code> that represents a record list of
	///  <code>UserWithUserPool</code>
	/// </summary>
	[Serializable()]
	public partial class RLUserWithUserPoolRecordList: GenericRecordList<RCUserWithUserPoolRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCUserWithUserPoolRecord GetElementDefaultValue() {
			return new RCUserWithUserPoolRecord("");
		}

		public T[] ToArray<T>(Func<RCUserWithUserPoolRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLUserWithUserPoolRecordList recordlist, Func<RCUserWithUserPoolRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLUserWithUserPoolRecordList(RCUserWithUserPoolRecord[] array) {
			RLUserWithUserPoolRecordList result = new RLUserWithUserPoolRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLUserWithUserPoolRecordList ToList<T>(T[] array, Func <T, RCUserWithUserPoolRecord> converter) {
			RLUserWithUserPoolRecordList result = new RLUserWithUserPoolRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLUserWithUserPoolRecordList FromRestList<T>(RestList<T> restList, Func <T, RCUserWithUserPoolRecord> converter) {
			RLUserWithUserPoolRecordList result = new RLUserWithUserPoolRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLUserWithUserPoolRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUserWithUserPoolRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUserWithUserPoolRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLUserWithUserPoolRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCUserWithUserPoolRecord> NewList() {
			return new RLUserWithUserPoolRecordList();
		}


	} // RLUserWithUserPoolRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentDetailsRecordList</code> that represents a record list of
	///  <code>DeploymentDetails</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentDetailsRecordList: GenericRecordList<RCDeploymentDetailsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentDetailsRecord GetElementDefaultValue() {
			return new RCDeploymentDetailsRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentDetailsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentDetailsRecordList recordlist, Func<RCDeploymentDetailsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentDetailsRecordList(RCDeploymentDetailsRecord[] array) {
			RLDeploymentDetailsRecordList result = new RLDeploymentDetailsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentDetailsRecordList ToList<T>(T[] array, Func <T, RCDeploymentDetailsRecord> converter) {
			RLDeploymentDetailsRecordList result = new RLDeploymentDetailsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentDetailsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentDetailsRecord> converter) {
			RLDeploymentDetailsRecordList result = new RLDeploymentDetailsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentDetailsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentDetailsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentDetailsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentDetailsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentDetailsRecord> NewList() {
			return new RLDeploymentDetailsRecordList();
		}


	} // RLDeploymentDetailsRecordList

	/// <summary>
	/// RecordList type <code>RLEntityRecordRecordList</code> that represents a record list of
	///  <code>EntityRecord</code>
	/// </summary>
	[Serializable()]
	public partial class RLEntityRecordRecordList: GenericRecordList<RCEntityRecordRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEntityRecordRecord GetElementDefaultValue() {
			return new RCEntityRecordRecord("");
		}

		public T[] ToArray<T>(Func<RCEntityRecordRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEntityRecordRecordList recordlist, Func<RCEntityRecordRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEntityRecordRecordList(RCEntityRecordRecord[] array) {
			RLEntityRecordRecordList result = new RLEntityRecordRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEntityRecordRecordList ToList<T>(T[] array, Func <T, RCEntityRecordRecord> converter) {
			RLEntityRecordRecordList result = new RLEntityRecordRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEntityRecordRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEntityRecordRecord> converter) {
			RLEntityRecordRecordList result = new RLEntityRecordRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEntityRecordRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityRecordRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityRecordRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEntityRecordRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEntityRecordRecord> NewList() {
			return new RLEntityRecordRecordList();
		}


	} // RLEntityRecordRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentTechnologyRecordList</code> that represents a record list of
	///  <code>DeploymentTechnology</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentTechnologyRecordList: GenericRecordList<RCDeploymentTechnologyRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentTechnologyRecord GetElementDefaultValue() {
			return new RCDeploymentTechnologyRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentTechnologyRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentTechnologyRecordList recordlist, Func<RCDeploymentTechnologyRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentTechnologyRecordList(RCDeploymentTechnologyRecord[] array) {
			RLDeploymentTechnologyRecordList result = new RLDeploymentTechnologyRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentTechnologyRecordList ToList<T>(T[] array, Func <T, RCDeploymentTechnologyRecord> converter) {
			RLDeploymentTechnologyRecordList result = new RLDeploymentTechnologyRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentTechnologyRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentTechnologyRecord> converter) {
			RLDeploymentTechnologyRecordList result = new RLDeploymentTechnologyRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentTechnologyRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentTechnologyRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentTechnologyRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentTechnologyRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentTechnologyRecord> NewList() {
			return new RLDeploymentTechnologyRecordList();
		}


	} // RLDeploymentTechnologyRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentZone_VMRecordList</code> that represents a record list of
	///  <code>DeploymentZone_VM</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentZone_VMRecordList: GenericRecordList<RCDeploymentZone_VMRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentZone_VMRecord GetElementDefaultValue() {
			return new RCDeploymentZone_VMRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentZone_VMRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentZone_VMRecordList recordlist, Func<RCDeploymentZone_VMRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentZone_VMRecordList(RCDeploymentZone_VMRecord[] array) {
			RLDeploymentZone_VMRecordList result = new RLDeploymentZone_VMRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentZone_VMRecordList ToList<T>(T[] array, Func <T, RCDeploymentZone_VMRecord> converter) {
			RLDeploymentZone_VMRecordList result = new RLDeploymentZone_VMRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentZone_VMRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentZone_VMRecord> converter) {
			RLDeploymentZone_VMRecordList result = new RLDeploymentZone_VMRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentZone_VMRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_VMRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_VMRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentZone_VMRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentZone_VMRecord> NewList() {
			return new RLDeploymentZone_VMRecordList();
		}


	} // RLDeploymentZone_VMRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentZone_DockerRecordList</code> that represents a record list of
	///  <code>DeploymentZone_Docker</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentZone_DockerRecordList: GenericRecordList<RCDeploymentZone_DockerRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentZone_DockerRecord GetElementDefaultValue() {
			return new RCDeploymentZone_DockerRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentZone_DockerRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentZone_DockerRecordList recordlist, Func<RCDeploymentZone_DockerRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentZone_DockerRecordList(RCDeploymentZone_DockerRecord[] array) {
			RLDeploymentZone_DockerRecordList result = new RLDeploymentZone_DockerRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentZone_DockerRecordList ToList<T>(T[] array, Func <T, RCDeploymentZone_DockerRecord> converter) {
			RLDeploymentZone_DockerRecordList result = new RLDeploymentZone_DockerRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentZone_DockerRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentZone_DockerRecord> converter) {
			RLDeploymentZone_DockerRecordList result = new RLDeploymentZone_DockerRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentZone_DockerRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_DockerRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_DockerRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentZone_DockerRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentZone_DockerRecord> NewList() {
			return new RLDeploymentZone_DockerRecordList();
		}


	} // RLDeploymentZone_DockerRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentZoneRecordList</code> that represents a record list of
	///  <code>DeploymentZone</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentZoneRecordList: GenericRecordList<RCDeploymentZoneRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentZoneRecord GetElementDefaultValue() {
			return new RCDeploymentZoneRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentZoneRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentZoneRecordList recordlist, Func<RCDeploymentZoneRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentZoneRecordList(RCDeploymentZoneRecord[] array) {
			RLDeploymentZoneRecordList result = new RLDeploymentZoneRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentZoneRecordList ToList<T>(T[] array, Func <T, RCDeploymentZoneRecord> converter) {
			RLDeploymentZoneRecordList result = new RLDeploymentZoneRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentZoneRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentZoneRecord> converter) {
			RLDeploymentZoneRecordList result = new RLDeploymentZoneRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentZoneRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZoneRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZoneRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentZoneRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentZoneRecord> NewList() {
			return new RLDeploymentZoneRecordList();
		}


	} // RLDeploymentZoneRecordList

	/// <summary>
	/// RecordList type <code>RLApplicationModuleDetailsRecordList</code> that represents a record list of
	///  <code>ApplicationModuleDetails</code>
	/// </summary>
	[Serializable()]
	public partial class RLApplicationModuleDetailsRecordList: GenericRecordList<RCApplicationModuleDetailsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCApplicationModuleDetailsRecord GetElementDefaultValue() {
			return new RCApplicationModuleDetailsRecord("");
		}

		public T[] ToArray<T>(Func<RCApplicationModuleDetailsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLApplicationModuleDetailsRecordList recordlist, Func<RCApplicationModuleDetailsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLApplicationModuleDetailsRecordList(RCApplicationModuleDetailsRecord[] array) {
			RLApplicationModuleDetailsRecordList result = new RLApplicationModuleDetailsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLApplicationModuleDetailsRecordList ToList<T>(T[] array, Func <T, RCApplicationModuleDetailsRecord> converter) {
			RLApplicationModuleDetailsRecordList result = new RLApplicationModuleDetailsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLApplicationModuleDetailsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCApplicationModuleDetailsRecord> converter) {
			RLApplicationModuleDetailsRecordList result = new RLApplicationModuleDetailsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLApplicationModuleDetailsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLApplicationModuleDetailsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLApplicationModuleDetailsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLApplicationModuleDetailsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCApplicationModuleDetailsRecord> NewList() {
			return new RLApplicationModuleDetailsRecordList();
		}


	} // RLApplicationModuleDetailsRecordList

	/// <summary>
	/// RecordList type <code>RLGenericRecordDescriptionRecordList</code> that represents a record list of
	///  <code>GenericRecordDescription</code>
	/// </summary>
	[Serializable()]
	public partial class RLGenericRecordDescriptionRecordList: GenericRecordList<RCGenericRecordDescriptionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCGenericRecordDescriptionRecord GetElementDefaultValue() {
			return new RCGenericRecordDescriptionRecord("");
		}

		public T[] ToArray<T>(Func<RCGenericRecordDescriptionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLGenericRecordDescriptionRecordList recordlist, Func<RCGenericRecordDescriptionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLGenericRecordDescriptionRecordList(RCGenericRecordDescriptionRecord[] array) {
			RLGenericRecordDescriptionRecordList result = new RLGenericRecordDescriptionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLGenericRecordDescriptionRecordList ToList<T>(T[] array, Func <T, RCGenericRecordDescriptionRecord> converter) {
			RLGenericRecordDescriptionRecordList result = new RLGenericRecordDescriptionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLGenericRecordDescriptionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCGenericRecordDescriptionRecord> converter) {
			RLGenericRecordDescriptionRecordList result = new RLGenericRecordDescriptionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLGenericRecordDescriptionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLGenericRecordDescriptionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLGenericRecordDescriptionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLGenericRecordDescriptionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCGenericRecordDescriptionRecord> NewList() {
			return new RLGenericRecordDescriptionRecordList();
		}


	} // RLGenericRecordDescriptionRecordList

	/// <summary>
	/// RecordList type <code>RLESpaceDetailedInfoRecordList</code> that represents a record list of
	///  <code>ESpaceDetailedInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLESpaceDetailedInfoRecordList: GenericRecordList<RCESpaceDetailedInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCESpaceDetailedInfoRecord GetElementDefaultValue() {
			return new RCESpaceDetailedInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCESpaceDetailedInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLESpaceDetailedInfoRecordList recordlist, Func<RCESpaceDetailedInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLESpaceDetailedInfoRecordList(RCESpaceDetailedInfoRecord[] array) {
			RLESpaceDetailedInfoRecordList result = new RLESpaceDetailedInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLESpaceDetailedInfoRecordList ToList<T>(T[] array, Func <T, RCESpaceDetailedInfoRecord> converter) {
			RLESpaceDetailedInfoRecordList result = new RLESpaceDetailedInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLESpaceDetailedInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCESpaceDetailedInfoRecord> converter) {
			RLESpaceDetailedInfoRecordList result = new RLESpaceDetailedInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLESpaceDetailedInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLESpaceDetailedInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLESpaceDetailedInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLESpaceDetailedInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCESpaceDetailedInfoRecord> NewList() {
			return new RLESpaceDetailedInfoRecordList();
		}


	} // RLESpaceDetailedInfoRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentZone_PivotalRecordList</code> that represents a record list of
	///  <code>DeploymentZone_Pivotal</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentZone_PivotalRecordList: GenericRecordList<RCDeploymentZone_PivotalRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentZone_PivotalRecord GetElementDefaultValue() {
			return new RCDeploymentZone_PivotalRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentZone_PivotalRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentZone_PivotalRecordList recordlist, Func<RCDeploymentZone_PivotalRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentZone_PivotalRecordList(RCDeploymentZone_PivotalRecord[] array) {
			RLDeploymentZone_PivotalRecordList result = new RLDeploymentZone_PivotalRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentZone_PivotalRecordList ToList<T>(T[] array, Func <T, RCDeploymentZone_PivotalRecord> converter) {
			RLDeploymentZone_PivotalRecordList result = new RLDeploymentZone_PivotalRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentZone_PivotalRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentZone_PivotalRecord> converter) {
			RLDeploymentZone_PivotalRecordList result = new RLDeploymentZone_PivotalRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentZone_PivotalRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_PivotalRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_PivotalRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentZone_PivotalRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentZone_PivotalRecord> NewList() {
			return new RLDeploymentZone_PivotalRecordList();
		}


	} // RLDeploymentZone_PivotalRecordList

	/// <summary>
	/// RecordList type <code>RLCacheInvalidationServiceStatusRecordList</code> that represents a record
	///  list of <code>CacheInvalidationServiceStatus</code>
	/// </summary>
	[Serializable()]
	public partial class RLCacheInvalidationServiceStatusRecordList: GenericRecordList<RCCacheInvalidationServiceStatusRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCCacheInvalidationServiceStatusRecord GetElementDefaultValue() {
			return new RCCacheInvalidationServiceStatusRecord("");
		}

		public T[] ToArray<T>(Func<RCCacheInvalidationServiceStatusRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLCacheInvalidationServiceStatusRecordList recordlist, Func<RCCacheInvalidationServiceStatusRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLCacheInvalidationServiceStatusRecordList(RCCacheInvalidationServiceStatusRecord[] array) {
			RLCacheInvalidationServiceStatusRecordList result = new RLCacheInvalidationServiceStatusRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLCacheInvalidationServiceStatusRecordList ToList<T>(T[] array, Func <T, RCCacheInvalidationServiceStatusRecord> converter) {
			RLCacheInvalidationServiceStatusRecordList result = new RLCacheInvalidationServiceStatusRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLCacheInvalidationServiceStatusRecordList FromRestList<T>(RestList<T> restList, Func <T, RCCacheInvalidationServiceStatusRecord> converter) {
			RLCacheInvalidationServiceStatusRecordList result = new RLCacheInvalidationServiceStatusRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLCacheInvalidationServiceStatusRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCacheInvalidationServiceStatusRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCacheInvalidationServiceStatusRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLCacheInvalidationServiceStatusRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCCacheInvalidationServiceStatusRecord> NewList() {
			return new RLCacheInvalidationServiceStatusRecordList();
		}


	} // RLCacheInvalidationServiceStatusRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentZone_AzureContainerServiceRecordList</code> that represents a
	///  record list of <code>DeploymentZone_AzureContainerService</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentZone_AzureContainerServiceRecordList: GenericRecordList<RCDeploymentZone_AzureContainerServiceRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentZone_AzureContainerServiceRecord GetElementDefaultValue() {
			return new RCDeploymentZone_AzureContainerServiceRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentZone_AzureContainerServiceRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentZone_AzureContainerServiceRecordList recordlist, Func<RCDeploymentZone_AzureContainerServiceRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentZone_AzureContainerServiceRecordList(RCDeploymentZone_AzureContainerServiceRecord[] array) {
			RLDeploymentZone_AzureContainerServiceRecordList result = new RLDeploymentZone_AzureContainerServiceRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentZone_AzureContainerServiceRecordList ToList<T>(T[] array, Func <T, RCDeploymentZone_AzureContainerServiceRecord> converter) {
			RLDeploymentZone_AzureContainerServiceRecordList result = new RLDeploymentZone_AzureContainerServiceRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentZone_AzureContainerServiceRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentZone_AzureContainerServiceRecord> converter) {
			RLDeploymentZone_AzureContainerServiceRecordList result = new RLDeploymentZone_AzureContainerServiceRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentZone_AzureContainerServiceRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_AzureContainerServiceRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_AzureContainerServiceRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentZone_AzureContainerServiceRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentZone_AzureContainerServiceRecord> NewList() {
			return new RLDeploymentZone_AzureContainerServiceRecordList();
		}


	} // RLDeploymentZone_AzureContainerServiceRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentZone_AmazonECSRecordList</code> that represents a record list of
	///  <code>DeploymentZone_AmazonECS</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentZone_AmazonECSRecordList: GenericRecordList<RCDeploymentZone_AmazonECSRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentZone_AmazonECSRecord GetElementDefaultValue() {
			return new RCDeploymentZone_AmazonECSRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentZone_AmazonECSRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentZone_AmazonECSRecordList recordlist, Func<RCDeploymentZone_AmazonECSRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentZone_AmazonECSRecordList(RCDeploymentZone_AmazonECSRecord[] array) {
			RLDeploymentZone_AmazonECSRecordList result = new RLDeploymentZone_AmazonECSRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentZone_AmazonECSRecordList ToList<T>(T[] array, Func <T, RCDeploymentZone_AmazonECSRecord> converter) {
			RLDeploymentZone_AmazonECSRecordList result = new RLDeploymentZone_AmazonECSRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentZone_AmazonECSRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentZone_AmazonECSRecord> converter) {
			RLDeploymentZone_AmazonECSRecordList result = new RLDeploymentZone_AmazonECSRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentZone_AmazonECSRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_AmazonECSRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_AmazonECSRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentZone_AmazonECSRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentZone_AmazonECSRecord> NewList() {
			return new RLDeploymentZone_AmazonECSRecordList();
		}


	} // RLDeploymentZone_AmazonECSRecordList

	/// <summary>
	/// RecordList type <code>RLUserSecurityGrantsRecordList</code> that represents a record list of
	///  <code>UserSecurityGrants</code>
	/// </summary>
	[Serializable()]
	public partial class RLUserSecurityGrantsRecordList: GenericRecordList<RCUserSecurityGrantsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCUserSecurityGrantsRecord GetElementDefaultValue() {
			return new RCUserSecurityGrantsRecord("");
		}

		public T[] ToArray<T>(Func<RCUserSecurityGrantsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLUserSecurityGrantsRecordList recordlist, Func<RCUserSecurityGrantsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLUserSecurityGrantsRecordList(RCUserSecurityGrantsRecord[] array) {
			RLUserSecurityGrantsRecordList result = new RLUserSecurityGrantsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLUserSecurityGrantsRecordList ToList<T>(T[] array, Func <T, RCUserSecurityGrantsRecord> converter) {
			RLUserSecurityGrantsRecordList result = new RLUserSecurityGrantsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLUserSecurityGrantsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCUserSecurityGrantsRecord> converter) {
			RLUserSecurityGrantsRecordList result = new RLUserSecurityGrantsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLUserSecurityGrantsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUserSecurityGrantsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLUserSecurityGrantsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLUserSecurityGrantsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCUserSecurityGrantsRecord> NewList() {
			return new RLUserSecurityGrantsRecordList();
		}


	} // RLUserSecurityGrantsRecordList

	/// <summary>
	/// RecordList type <code>RLVersionComparisonRecordList</code> that represents a record list of
	///  <code>VersionComparison</code>
	/// </summary>
	[Serializable()]
	public partial class RLVersionComparisonRecordList: GenericRecordList<RCVersionComparisonRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCVersionComparisonRecord GetElementDefaultValue() {
			return new RCVersionComparisonRecord("");
		}

		public T[] ToArray<T>(Func<RCVersionComparisonRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLVersionComparisonRecordList recordlist, Func<RCVersionComparisonRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLVersionComparisonRecordList(RCVersionComparisonRecord[] array) {
			RLVersionComparisonRecordList result = new RLVersionComparisonRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLVersionComparisonRecordList ToList<T>(T[] array, Func <T, RCVersionComparisonRecord> converter) {
			RLVersionComparisonRecordList result = new RLVersionComparisonRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLVersionComparisonRecordList FromRestList<T>(RestList<T> restList, Func <T, RCVersionComparisonRecord> converter) {
			RLVersionComparisonRecordList result = new RLVersionComparisonRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLVersionComparisonRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLVersionComparisonRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLVersionComparisonRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLVersionComparisonRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCVersionComparisonRecord> NewList() {
			return new RLVersionComparisonRecordList();
		}


	} // RLVersionComparisonRecordList

	/// <summary>
	/// RecordList type <code>RLDBCatalogRecordList</code> that represents a record list of
	///  <code>DBCatalog</code>
	/// </summary>
	[Serializable()]
	public partial class RLDBCatalogRecordList: GenericRecordList<RCDBCatalogRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDBCatalogRecord GetElementDefaultValue() {
			return new RCDBCatalogRecord("");
		}

		public T[] ToArray<T>(Func<RCDBCatalogRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDBCatalogRecordList recordlist, Func<RCDBCatalogRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDBCatalogRecordList(RCDBCatalogRecord[] array) {
			RLDBCatalogRecordList result = new RLDBCatalogRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDBCatalogRecordList ToList<T>(T[] array, Func <T, RCDBCatalogRecord> converter) {
			RLDBCatalogRecordList result = new RLDBCatalogRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDBCatalogRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDBCatalogRecord> converter) {
			RLDBCatalogRecordList result = new RLDBCatalogRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDBCatalogRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDBCatalogRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDBCatalogRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDBCatalogRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDBCatalogRecord> NewList() {
			return new RLDBCatalogRecordList();
		}


	} // RLDBCatalogRecordList

	/// <summary>
	/// RecordList type <code>RLReferenceableModuleRecordList</code> that represents a record list of
	///  <code>ReferenceableModule</code>
	/// </summary>
	[Serializable()]
	public partial class RLReferenceableModuleRecordList: GenericRecordList<RCReferenceableModuleRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCReferenceableModuleRecord GetElementDefaultValue() {
			return new RCReferenceableModuleRecord("");
		}

		public T[] ToArray<T>(Func<RCReferenceableModuleRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLReferenceableModuleRecordList recordlist, Func<RCReferenceableModuleRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLReferenceableModuleRecordList(RCReferenceableModuleRecord[] array) {
			RLReferenceableModuleRecordList result = new RLReferenceableModuleRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLReferenceableModuleRecordList ToList<T>(T[] array, Func <T, RCReferenceableModuleRecord> converter) {
			RLReferenceableModuleRecordList result = new RLReferenceableModuleRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLReferenceableModuleRecordList FromRestList<T>(RestList<T> restList, Func <T, RCReferenceableModuleRecord> converter) {
			RLReferenceableModuleRecordList result = new RLReferenceableModuleRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLReferenceableModuleRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReferenceableModuleRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLReferenceableModuleRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLReferenceableModuleRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCReferenceableModuleRecord> NewList() {
			return new RLReferenceableModuleRecordList();
		}


	} // RLReferenceableModuleRecordList

	/// <summary>
	/// RecordList type <code>RLEspaceToPublishRecordList</code> that represents a record list of
	///  <code>EspaceToPublish</code>
	/// </summary>
	[Serializable()]
	public partial class RLEspaceToPublishRecordList: GenericRecordList<RCEspaceToPublishRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEspaceToPublishRecord GetElementDefaultValue() {
			return new RCEspaceToPublishRecord("");
		}

		public T[] ToArray<T>(Func<RCEspaceToPublishRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEspaceToPublishRecordList recordlist, Func<RCEspaceToPublishRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEspaceToPublishRecordList(RCEspaceToPublishRecord[] array) {
			RLEspaceToPublishRecordList result = new RLEspaceToPublishRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEspaceToPublishRecordList ToList<T>(T[] array, Func <T, RCEspaceToPublishRecord> converter) {
			RLEspaceToPublishRecordList result = new RLEspaceToPublishRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEspaceToPublishRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEspaceToPublishRecord> converter) {
			RLEspaceToPublishRecordList result = new RLEspaceToPublishRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEspaceToPublishRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEspaceToPublishRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEspaceToPublishRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEspaceToPublishRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEspaceToPublishRecord> NewList() {
			return new RLEspaceToPublishRecordList();
		}


	} // RLEspaceToPublishRecordList

	/// <summary>
	/// RecordList type <code>RLEspacePublishOptionsRecordList</code> that represents a record list of
	///  <code>EspacePublishOptions</code>
	/// </summary>
	[Serializable()]
	public partial class RLEspacePublishOptionsRecordList: GenericRecordList<RCEspacePublishOptionsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEspacePublishOptionsRecord GetElementDefaultValue() {
			return new RCEspacePublishOptionsRecord("");
		}

		public T[] ToArray<T>(Func<RCEspacePublishOptionsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEspacePublishOptionsRecordList recordlist, Func<RCEspacePublishOptionsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEspacePublishOptionsRecordList(RCEspacePublishOptionsRecord[] array) {
			RLEspacePublishOptionsRecordList result = new RLEspacePublishOptionsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEspacePublishOptionsRecordList ToList<T>(T[] array, Func <T, RCEspacePublishOptionsRecord> converter) {
			RLEspacePublishOptionsRecordList result = new RLEspacePublishOptionsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEspacePublishOptionsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEspacePublishOptionsRecord> converter) {
			RLEspacePublishOptionsRecordList result = new RLEspacePublishOptionsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEspacePublishOptionsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEspacePublishOptionsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEspacePublishOptionsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEspacePublishOptionsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEspacePublishOptionsRecord> NewList() {
			return new RLEspacePublishOptionsRecordList();
		}


	} // RLEspacePublishOptionsRecordList

	/// <summary>
	/// RecordList type <code>RLEspacePublishAsyncResultRecordList</code> that represents a record list of
	///  <code>EspacePublishAsyncResult</code>
	/// </summary>
	[Serializable()]
	public partial class RLEspacePublishAsyncResultRecordList: GenericRecordList<RCEspacePublishAsyncResultRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEspacePublishAsyncResultRecord GetElementDefaultValue() {
			return new RCEspacePublishAsyncResultRecord("");
		}

		public T[] ToArray<T>(Func<RCEspacePublishAsyncResultRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEspacePublishAsyncResultRecordList recordlist, Func<RCEspacePublishAsyncResultRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEspacePublishAsyncResultRecordList(RCEspacePublishAsyncResultRecord[] array) {
			RLEspacePublishAsyncResultRecordList result = new RLEspacePublishAsyncResultRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEspacePublishAsyncResultRecordList ToList<T>(T[] array, Func <T, RCEspacePublishAsyncResultRecord> converter) {
			RLEspacePublishAsyncResultRecordList result = new RLEspacePublishAsyncResultRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEspacePublishAsyncResultRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEspacePublishAsyncResultRecord> converter) {
			RLEspacePublishAsyncResultRecordList result = new RLEspacePublishAsyncResultRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEspacePublishAsyncResultRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEspacePublishAsyncResultRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEspacePublishAsyncResultRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEspacePublishAsyncResultRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEspacePublishAsyncResultRecord> NewList() {
			return new RLEspacePublishAsyncResultRecordList();
		}


	} // RLEspacePublishAsyncResultRecordList

	/// <summary>
	/// RecordList type <code>RLEnvironmentInfoRecordList</code> that represents a record list of
	///  <code>EnvironmentInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLEnvironmentInfoRecordList: GenericRecordList<RCEnvironmentInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEnvironmentInfoRecord GetElementDefaultValue() {
			return new RCEnvironmentInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCEnvironmentInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEnvironmentInfoRecordList recordlist, Func<RCEnvironmentInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEnvironmentInfoRecordList(RCEnvironmentInfoRecord[] array) {
			RLEnvironmentInfoRecordList result = new RLEnvironmentInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEnvironmentInfoRecordList ToList<T>(T[] array, Func <T, RCEnvironmentInfoRecord> converter) {
			RLEnvironmentInfoRecordList result = new RLEnvironmentInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEnvironmentInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEnvironmentInfoRecord> converter) {
			RLEnvironmentInfoRecordList result = new RLEnvironmentInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEnvironmentInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEnvironmentInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEnvironmentInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEnvironmentInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEnvironmentInfoRecord> NewList() {
			return new RLEnvironmentInfoRecordList();
		}


	} // RLEnvironmentInfoRecordList

	/// <summary>
	/// RecordList type <code>RLFeatureInfoRecordList</code> that represents a record list of
	///  <code>FeatureInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLFeatureInfoRecordList: GenericRecordList<RCFeatureInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCFeatureInfoRecord GetElementDefaultValue() {
			return new RCFeatureInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCFeatureInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLFeatureInfoRecordList recordlist, Func<RCFeatureInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLFeatureInfoRecordList(RCFeatureInfoRecord[] array) {
			RLFeatureInfoRecordList result = new RLFeatureInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLFeatureInfoRecordList ToList<T>(T[] array, Func <T, RCFeatureInfoRecord> converter) {
			RLFeatureInfoRecordList result = new RLFeatureInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLFeatureInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCFeatureInfoRecord> converter) {
			RLFeatureInfoRecordList result = new RLFeatureInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLFeatureInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLFeatureInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLFeatureInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLFeatureInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCFeatureInfoRecord> NewList() {
			return new RLFeatureInfoRecordList();
		}


	} // RLFeatureInfoRecordList

	/// <summary>
	/// RecordList type <code>RLPublicElementRecordList</code> that represents a record list of
	///  <code>PublicElement</code>
	/// </summary>
	[Serializable()]
	public partial class RLPublicElementRecordList: GenericRecordList<RCPublicElementRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCPublicElementRecord GetElementDefaultValue() {
			return new RCPublicElementRecord("");
		}

		public T[] ToArray<T>(Func<RCPublicElementRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLPublicElementRecordList recordlist, Func<RCPublicElementRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLPublicElementRecordList(RCPublicElementRecord[] array) {
			RLPublicElementRecordList result = new RLPublicElementRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLPublicElementRecordList ToList<T>(T[] array, Func <T, RCPublicElementRecord> converter) {
			RLPublicElementRecordList result = new RLPublicElementRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLPublicElementRecordList FromRestList<T>(RestList<T> restList, Func <T, RCPublicElementRecord> converter) {
			RLPublicElementRecordList result = new RLPublicElementRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLPublicElementRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLPublicElementRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLPublicElementRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLPublicElementRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCPublicElementRecord> NewList() {
			return new RLPublicElementRecordList();
		}


	} // RLPublicElementRecordList

	/// <summary>
	/// RecordList type <code>RLModuleVersionFeatureRecordList</code> that represents a record list of
	///  <code>ModuleVersionFeature</code>
	/// </summary>
	[Serializable()]
	public partial class RLModuleVersionFeatureRecordList: GenericRecordList<RCModuleVersionFeatureRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCModuleVersionFeatureRecord GetElementDefaultValue() {
			return new RCModuleVersionFeatureRecord("");
		}

		public T[] ToArray<T>(Func<RCModuleVersionFeatureRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLModuleVersionFeatureRecordList recordlist, Func<RCModuleVersionFeatureRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLModuleVersionFeatureRecordList(RCModuleVersionFeatureRecord[] array) {
			RLModuleVersionFeatureRecordList result = new RLModuleVersionFeatureRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLModuleVersionFeatureRecordList ToList<T>(T[] array, Func <T, RCModuleVersionFeatureRecord> converter) {
			RLModuleVersionFeatureRecordList result = new RLModuleVersionFeatureRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLModuleVersionFeatureRecordList FromRestList<T>(RestList<T> restList, Func <T, RCModuleVersionFeatureRecord> converter) {
			RLModuleVersionFeatureRecordList result = new RLModuleVersionFeatureRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLModuleVersionFeatureRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLModuleVersionFeatureRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLModuleVersionFeatureRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLModuleVersionFeatureRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCModuleVersionFeatureRecord> NewList() {
			return new RLModuleVersionFeatureRecordList();
		}


	} // RLModuleVersionFeatureRecordList

	/// <summary>
	/// RecordList type <code>RLExtensionEntityConfigRecordList</code> that represents a record list of
	///  <code>ExtensionEntityConfig</code>
	/// </summary>
	[Serializable()]
	public partial class RLExtensionEntityConfigRecordList: GenericRecordList<RCExtensionEntityConfigRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCExtensionEntityConfigRecord GetElementDefaultValue() {
			return new RCExtensionEntityConfigRecord("");
		}

		public T[] ToArray<T>(Func<RCExtensionEntityConfigRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLExtensionEntityConfigRecordList recordlist, Func<RCExtensionEntityConfigRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLExtensionEntityConfigRecordList(RCExtensionEntityConfigRecord[] array) {
			RLExtensionEntityConfigRecordList result = new RLExtensionEntityConfigRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLExtensionEntityConfigRecordList ToList<T>(T[] array, Func <T, RCExtensionEntityConfigRecord> converter) {
			RLExtensionEntityConfigRecordList result = new RLExtensionEntityConfigRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLExtensionEntityConfigRecordList FromRestList<T>(RestList<T> restList, Func <T, RCExtensionEntityConfigRecord> converter) {
			RLExtensionEntityConfigRecordList result = new RLExtensionEntityConfigRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLExtensionEntityConfigRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLExtensionEntityConfigRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLExtensionEntityConfigRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLExtensionEntityConfigRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCExtensionEntityConfigRecord> NewList() {
			return new RLExtensionEntityConfigRecordList();
		}


	} // RLExtensionEntityConfigRecordList

	/// <summary>
	/// RecordList type <code>RLDeploymentZone_AmazonEKSRecordList</code> that represents a record list of
	///  <code>DeploymentZone_AmazonEKS</code>
	/// </summary>
	[Serializable()]
	public partial class RLDeploymentZone_AmazonEKSRecordList: GenericRecordList<RCDeploymentZone_AmazonEKSRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCDeploymentZone_AmazonEKSRecord GetElementDefaultValue() {
			return new RCDeploymentZone_AmazonEKSRecord("");
		}

		public T[] ToArray<T>(Func<RCDeploymentZone_AmazonEKSRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLDeploymentZone_AmazonEKSRecordList recordlist, Func<RCDeploymentZone_AmazonEKSRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLDeploymentZone_AmazonEKSRecordList(RCDeploymentZone_AmazonEKSRecord[] array) {
			RLDeploymentZone_AmazonEKSRecordList result = new RLDeploymentZone_AmazonEKSRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLDeploymentZone_AmazonEKSRecordList ToList<T>(T[] array, Func <T, RCDeploymentZone_AmazonEKSRecord> converter) {
			RLDeploymentZone_AmazonEKSRecordList result = new RLDeploymentZone_AmazonEKSRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLDeploymentZone_AmazonEKSRecordList FromRestList<T>(RestList<T> restList, Func <T, RCDeploymentZone_AmazonEKSRecord> converter) {
			RLDeploymentZone_AmazonEKSRecordList result = new RLDeploymentZone_AmazonEKSRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLDeploymentZone_AmazonEKSRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_AmazonEKSRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLDeploymentZone_AmazonEKSRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLDeploymentZone_AmazonEKSRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCDeploymentZone_AmazonEKSRecord> NewList() {
			return new RLDeploymentZone_AmazonEKSRecordList();
		}


	} // RLDeploymentZone_AmazonEKSRecordList

	/// <summary>
	/// RecordList type <code>RLSolutionPack_SCEntityRecordList</code> that represents a record list of
	///  <code>SolutionPack_SCEntity</code>
	/// </summary>
	[Serializable()]
	public partial class RLSolutionPack_SCEntityRecordList: GenericRecordList<RCSolutionPack_SCEntityRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCSolutionPack_SCEntityRecord GetElementDefaultValue() {
			return new RCSolutionPack_SCEntityRecord("");
		}

		public T[] ToArray<T>(Func<RCSolutionPack_SCEntityRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLSolutionPack_SCEntityRecordList recordlist, Func<RCSolutionPack_SCEntityRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLSolutionPack_SCEntityRecordList(RCSolutionPack_SCEntityRecord[] array) {
			RLSolutionPack_SCEntityRecordList result = new RLSolutionPack_SCEntityRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLSolutionPack_SCEntityRecordList ToList<T>(T[] array, Func <T, RCSolutionPack_SCEntityRecord> converter) {
			RLSolutionPack_SCEntityRecordList result = new RLSolutionPack_SCEntityRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLSolutionPack_SCEntityRecordList FromRestList<T>(RestList<T> restList, Func <T, RCSolutionPack_SCEntityRecord> converter) {
			RLSolutionPack_SCEntityRecordList result = new RLSolutionPack_SCEntityRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLSolutionPack_SCEntityRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SCEntityRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLSolutionPack_SCEntityRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLSolutionPack_SCEntityRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCSolutionPack_SCEntityRecord> NewList() {
			return new RLSolutionPack_SCEntityRecordList();
		}


	} // RLSolutionPack_SCEntityRecordList

	/// <summary>
	/// RecordList type <code>RLProducerModuleSignatureRecordList</code> that represents a record list of
	///  <code>ProducerModuleSignature</code>
	/// </summary>
	[Serializable()]
	public partial class RLProducerModuleSignatureRecordList: GenericRecordList<RCProducerModuleSignatureRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCProducerModuleSignatureRecord GetElementDefaultValue() {
			return new RCProducerModuleSignatureRecord("");
		}

		public T[] ToArray<T>(Func<RCProducerModuleSignatureRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLProducerModuleSignatureRecordList recordlist, Func<RCProducerModuleSignatureRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLProducerModuleSignatureRecordList(RCProducerModuleSignatureRecord[] array) {
			RLProducerModuleSignatureRecordList result = new RLProducerModuleSignatureRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLProducerModuleSignatureRecordList ToList<T>(T[] array, Func <T, RCProducerModuleSignatureRecord> converter) {
			RLProducerModuleSignatureRecordList result = new RLProducerModuleSignatureRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLProducerModuleSignatureRecordList FromRestList<T>(RestList<T> restList, Func <T, RCProducerModuleSignatureRecord> converter) {
			RLProducerModuleSignatureRecordList result = new RLProducerModuleSignatureRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLProducerModuleSignatureRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProducerModuleSignatureRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLProducerModuleSignatureRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLProducerModuleSignatureRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCProducerModuleSignatureRecord> NewList() {
			return new RLProducerModuleSignatureRecordList();
		}


	} // RLProducerModuleSignatureRecordList

	/// <summary>
	/// RecordList type <code>RLCheckReferenceStatusResultRecordList</code> that represents a record list
	///  of <code>CheckReferenceStatusResult</code>
	/// </summary>
	[Serializable()]
	public partial class RLCheckReferenceStatusResultRecordList: GenericRecordList<RCCheckReferenceStatusResultRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCCheckReferenceStatusResultRecord GetElementDefaultValue() {
			return new RCCheckReferenceStatusResultRecord("");
		}

		public T[] ToArray<T>(Func<RCCheckReferenceStatusResultRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLCheckReferenceStatusResultRecordList recordlist, Func<RCCheckReferenceStatusResultRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLCheckReferenceStatusResultRecordList(RCCheckReferenceStatusResultRecord[] array) {
			RLCheckReferenceStatusResultRecordList result = new RLCheckReferenceStatusResultRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLCheckReferenceStatusResultRecordList ToList<T>(T[] array, Func <T, RCCheckReferenceStatusResultRecord> converter) {
			RLCheckReferenceStatusResultRecordList result = new RLCheckReferenceStatusResultRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLCheckReferenceStatusResultRecordList FromRestList<T>(RestList<T> restList, Func <T, RCCheckReferenceStatusResultRecord> converter) {
			RLCheckReferenceStatusResultRecordList result = new RLCheckReferenceStatusResultRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLCheckReferenceStatusResultRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCheckReferenceStatusResultRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCheckReferenceStatusResultRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLCheckReferenceStatusResultRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCCheckReferenceStatusResultRecord> NewList() {
			return new RLCheckReferenceStatusResultRecordList();
		}


	} // RLCheckReferenceStatusResultRecordList

	/// <summary>
	/// RecordList type <code>RLIncompatibleModuleRecordList</code> that represents a record list of
	///  <code>IncompatibleModule</code>
	/// </summary>
	[Serializable()]
	public partial class RLIncompatibleModuleRecordList: GenericRecordList<RCIncompatibleModuleRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCIncompatibleModuleRecord GetElementDefaultValue() {
			return new RCIncompatibleModuleRecord("");
		}

		public T[] ToArray<T>(Func<RCIncompatibleModuleRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLIncompatibleModuleRecordList recordlist, Func<RCIncompatibleModuleRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLIncompatibleModuleRecordList(RCIncompatibleModuleRecord[] array) {
			RLIncompatibleModuleRecordList result = new RLIncompatibleModuleRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLIncompatibleModuleRecordList ToList<T>(T[] array, Func <T, RCIncompatibleModuleRecord> converter) {
			RLIncompatibleModuleRecordList result = new RLIncompatibleModuleRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLIncompatibleModuleRecordList FromRestList<T>(RestList<T> restList, Func <T, RCIncompatibleModuleRecord> converter) {
			RLIncompatibleModuleRecordList result = new RLIncompatibleModuleRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLIncompatibleModuleRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIncompatibleModuleRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIncompatibleModuleRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLIncompatibleModuleRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCIncompatibleModuleRecord> NewList() {
			return new RLIncompatibleModuleRecordList();
		}


	} // RLIncompatibleModuleRecordList

	/// <summary>
	/// RecordList type <code>RLIncompatibleElementRecordList</code> that represents a record list of
	///  <code>IncompatibleElement</code>
	/// </summary>
	[Serializable()]
	public partial class RLIncompatibleElementRecordList: GenericRecordList<RCIncompatibleElementRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCIncompatibleElementRecord GetElementDefaultValue() {
			return new RCIncompatibleElementRecord("");
		}

		public T[] ToArray<T>(Func<RCIncompatibleElementRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLIncompatibleElementRecordList recordlist, Func<RCIncompatibleElementRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLIncompatibleElementRecordList(RCIncompatibleElementRecord[] array) {
			RLIncompatibleElementRecordList result = new RLIncompatibleElementRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLIncompatibleElementRecordList ToList<T>(T[] array, Func <T, RCIncompatibleElementRecord> converter) {
			RLIncompatibleElementRecordList result = new RLIncompatibleElementRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLIncompatibleElementRecordList FromRestList<T>(RestList<T> restList, Func <T, RCIncompatibleElementRecord> converter) {
			RLIncompatibleElementRecordList result = new RLIncompatibleElementRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLIncompatibleElementRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIncompatibleElementRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIncompatibleElementRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLIncompatibleElementRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCIncompatibleElementRecord> NewList() {
			return new RLIncompatibleElementRecordList();
		}


	} // RLIncompatibleElementRecordList
}
