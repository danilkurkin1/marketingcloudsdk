using System;
using System.Runtime.InteropServices;
using CFNetwork;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreLocation;
using CoreText;
using CoreVideo;
using Foundation;
using IOSurface;
using ImageIO;
using Metal;
using ObjCRuntime;
using OpenGLES;
using Security;
using UIKit;

[StructLayout (LayoutKind.Explicit)]
public struct __darwin_mbstate_t
{
    [FieldOffset (0)]
    public sbyte[] __mbstate8;

    [FieldOffset (0)]
    public long _mbstateL;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_pthread_handler_rec
{
    public unsafe Action<void*>* __routine;

    public unsafe void* __arg;

    public unsafe __darwin_pthread_handler_rec* __next;
}

[StructLayout (LayoutKind.Sequential)]
public struct pthread_attr_t
{
    public nint __sig;

    public sbyte[] __opaque;
}

[StructLayout (LayoutKind.Sequential)]
public struct pthread_cond_t
{
    public nint __sig;

    public sbyte[] __opaque;
}

[StructLayout (LayoutKind.Sequential)]
public struct pthread_condattr_t
{
    public nint __sig;

    public sbyte[] __opaque;
}

[StructLayout (LayoutKind.Sequential)]
public struct pthread_mutex_t
{
    public nint __sig;

    public sbyte[] __opaque;
}

[StructLayout (LayoutKind.Sequential)]
public struct pthread_mutexattr_t
{
    public nint __sig;

    public sbyte[] __opaque;
}

[StructLayout (LayoutKind.Sequential)]
public struct pthread_once_t
{
    public nint __sig;

    public sbyte[] __opaque;
}

[StructLayout (LayoutKind.Sequential)]
public struct pthread_rwlock_t
{
    public nint __sig;

    public sbyte[] __opaque;
}

[StructLayout (LayoutKind.Sequential)]
public struct pthread_rwlockattr_t
{
    public nint __sig;

    public sbyte[] __opaque;
}

[StructLayout (LayoutKind.Sequential)]
public struct _opaque_pthread_t
{
    public nint __sig;

    public unsafe __darwin_pthread_handler_rec* __cleanup_stack;

    public sbyte[] __opaque;
}

static class CFunctions
{
    // uint16_t _OSSwapInt16 (uint16_t data);
    [DllImport ("__Internal")]
    
    static extern ushort _OSSwapInt16 (ushort data);

    // uint32_t _OSSwapInt32 (uint32_t data);
    [DllImport ("__Internal")]
    
    static extern uint _OSSwapInt32 (uint data);

    // extern unsigned int __builtin_bswap32 (unsigned int) __attribute__((nothrow)) __attribute__((const));
    [DllImport ("__Internal")]
    
    static extern uint __builtin_bswap32 (uint data);

    // uint64_t _OSSwapInt64 (uint64_t data);
    [DllImport ("__Internal")]
    
    static extern ulong _OSSwapInt64 (ulong data);

   
    // uint16_t OSReadSwapInt16 (const volatile void *base, uintptr_t offset);
    [DllImport ("__Internal")]
    
    static extern unsafe ushort OSReadSwapInt16 (void* @base, UIntPtr offset);

    // uint32_t OSReadSwapInt32 (const volatile void *base, uintptr_t offset);
    [DllImport ("__Internal")]
    
    static extern unsafe uint OSReadSwapInt32 (void* @base, UIntPtr offset);

    // uint64_t OSReadSwapInt64 (const volatile void *base, uintptr_t offset);
    [DllImport ("__Internal")]
    
    static extern unsafe ulong OSReadSwapInt64 (void* @base, UIntPtr offset);

    // void OSWriteSwapInt16 (volatile void *base, uintptr_t offset, uint16_t data);
    [DllImport ("__Internal")]
    
    static extern unsafe void OSWriteSwapInt16 (void* @base, UIntPtr offset, ushort data);

    // void OSWriteSwapInt32 (volatile void *base, uintptr_t offset, uint32_t data);
    [DllImport ("__Internal")]
    
    static extern unsafe void OSWriteSwapInt32 (void* @base, UIntPtr offset, uint data);

    // void OSWriteSwapInt64 (volatile void *base, uintptr_t offset, uint64_t data);
    [DllImport ("__Internal")]
    
    static extern unsafe void OSWriteSwapInt64 (void* @base, UIntPtr offset, ulong data);

    // int __darwin_fd_isset (int _n, const struct fd_set *_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int __darwin_fd_isset (int _n, fd_set* _p);

   
   

    // extern void Debugger () __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern void Debugger ();

    // extern void DebugStr (ConstStr255Param debuggerMsg) __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe void DebugStr (byte* debuggerMsg);

    // extern void SysBreak () __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern void SysBreak ();

    // extern void SysBreakStr (ConstStr255Param debuggerMsg) __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe void SysBreakStr (byte* debuggerMsg);

    // extern void SysBreakFunc (ConstStr255Param debuggerMsg) __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe void SysBreakFunc (byte* debuggerMsg);

    // CFRange CFRangeMake (CFIndex loc, CFIndex len) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern CFRange CFRangeMake (nint loc, nint len);

    // extern CFRange __CFRangeMake (CFIndex loc, CFIndex len);
    [DllImport ("__Internal")]
    
    static extern CFRange __CFRangeMake (nint loc, nint len);

    // extern CFTypeID CFNullGetTypeID ();
    [DllImport ("__Internal")]
    
    static extern nuint CFNullGetTypeID ();

    // extern CFTypeID CFAllocatorGetTypeID ();
    [DllImport ("__Internal")]
    
    static extern nuint CFAllocatorGetTypeID ();

    // extern void CFAllocatorSetDefault (CFAllocatorRef allocator);
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAllocatorSetDefault (CFAllocatorRef* allocator);

    // extern CFAllocatorRef CFAllocatorGetDefault ();
    [DllImport ("__Internal")]
    
    static extern unsafe CFAllocatorRef* CFAllocatorGetDefault ();

    // extern CFAllocatorRef CFAllocatorCreate (CFAllocatorRef allocator, CFAllocatorContext *context);
    [DllImport ("__Internal")]
    
    static extern unsafe CFAllocatorRef* CFAllocatorCreate (CFAllocatorRef* allocator, CFAllocatorContext* context);

    // extern void * CFAllocatorAllocate (CFAllocatorRef allocator, CFIndex size, CFOptionFlags hint);
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFAllocatorAllocate (CFAllocatorRef* allocator, nint size, nuint hint);

    // extern void * CFAllocatorReallocate (CFAllocatorRef allocator, void *ptr, CFIndex newsize, CFOptionFlags hint);
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFAllocatorReallocate (CFAllocatorRef* allocator, void* ptr, nint newsize, nuint hint);

    // extern void CFAllocatorDeallocate (CFAllocatorRef allocator, void *ptr);
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAllocatorDeallocate (CFAllocatorRef* allocator, void* ptr);

    // extern CFIndex CFAllocatorGetPreferredSizeForSize (CFAllocatorRef allocator, CFIndex size, CFOptionFlags hint);
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFAllocatorGetPreferredSizeForSize (CFAllocatorRef* allocator, nint size, nuint hint);

    // extern void CFAllocatorGetContext (CFAllocatorRef allocator, CFAllocatorContext *context);
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAllocatorGetContext (CFAllocatorRef* allocator, CFAllocatorContext* context);

    // extern CFTypeID CFGetTypeID (CFTypeRef cf) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CFGetTypeID (void* cf);

    // extern CFStringRef CFCopyTypeIDDescription (CFTypeID type_id) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFCopyTypeIDDescription (nuint type_id);

    // extern CFTypeRef CFRetain (CFTypeRef cf) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFRetain (void* cf);

    // extern void CFRelease (CFTypeRef cf) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRelease (void* cf);

    // extern CFTypeRef CFAutorelease (CFTypeRef arg) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(macos, introduced=10.9))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFAutorelease (void* arg);

    // extern CFIndex CFGetRetainCount (CFTypeRef cf) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFGetRetainCount (void* cf);

    // extern Boolean CFEqual (CFTypeRef cf1, CFTypeRef cf2) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFEqual (void* cf1, void* cf2);

    // extern CFHashCode CFHash (CFTypeRef cf) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CFHash (void* cf);

    // extern CFStringRef CFCopyDescription (CFTypeRef cf) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFCopyDescription (void* cf);

    // extern CFAllocatorRef CFGetAllocator (CFTypeRef cf) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFAllocatorRef* CFGetAllocator (void* cf);

    // extern CFTypeRef CFMakeCollectable (CFTypeRef cf);
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFMakeCollectable (void* cf);

    // extern CFTypeID CFArrayGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFArrayGetTypeID ();

    // extern CFArrayRef CFArrayCreate (CFAllocatorRef allocator, const void **values, CFIndex numValues, const CFArrayCallBacks *callBacks) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFArrayCreate (CFAllocatorRef* allocator, void** values, nint numValues, CFArrayCallBacks* callBacks);

    // extern CFArrayRef CFArrayCreateCopy (CFAllocatorRef allocator, CFArrayRef theArray) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFArrayCreateCopy (CFAllocatorRef* allocator, CFArrayRef* theArray);

    // extern CFMutableArrayRef CFArrayCreateMutable (CFAllocatorRef allocator, CFIndex capacity, const CFArrayCallBacks *callBacks) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableArrayRef* CFArrayCreateMutable (CFAllocatorRef* allocator, nint capacity, CFArrayCallBacks* callBacks);

    // extern CFMutableArrayRef CFArrayCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFArrayRef theArray) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableArrayRef* CFArrayCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFArrayRef* theArray);

    // extern CFIndex CFArrayGetCount (CFArrayRef theArray) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFArrayGetCount (CFArrayRef* theArray);

    // extern CFIndex CFArrayGetCountOfValue (CFArrayRef theArray, CFRange range, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFArrayGetCountOfValue (CFArrayRef* theArray, CFRange range, void* value);

    // extern Boolean CFArrayContainsValue (CFArrayRef theArray, CFRange range, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFArrayContainsValue (CFArrayRef* theArray, CFRange range, void* value);

    // extern const void * CFArrayGetValueAtIndex (CFArrayRef theArray, CFIndex idx) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFArrayGetValueAtIndex (CFArrayRef* theArray, nint idx);

    // extern void CFArrayGetValues (CFArrayRef theArray, CFRange range, const void **values) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayGetValues (CFArrayRef* theArray, CFRange range, void** values);

    // extern void CFArrayApplyFunction (CFArrayRef theArray, CFRange range, CFArrayApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayApplyFunction (CFArrayRef* theArray, CFRange range, CFArrayApplierFunction* applier, void* context);

    // extern CFIndex CFArrayGetFirstIndexOfValue (CFArrayRef theArray, CFRange range, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFArrayGetFirstIndexOfValue (CFArrayRef* theArray, CFRange range, void* value);

    // extern CFIndex CFArrayGetLastIndexOfValue (CFArrayRef theArray, CFRange range, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFArrayGetLastIndexOfValue (CFArrayRef* theArray, CFRange range, void* value);

    // extern CFIndex CFArrayBSearchValues (CFArrayRef theArray, CFRange range, const void *value, CFComparatorFunction comparator, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFArrayBSearchValues (CFArrayRef* theArray, CFRange range, void* value, CFComparatorFunction* comparator, void* context);

    // extern void CFArrayAppendValue (CFMutableArrayRef theArray, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayAppendValue (CFMutableArrayRef* theArray, void* value);

    // extern void CFArrayInsertValueAtIndex (CFMutableArrayRef theArray, CFIndex idx, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayInsertValueAtIndex (CFMutableArrayRef* theArray, nint idx, void* value);

    // extern void CFArraySetValueAtIndex (CFMutableArrayRef theArray, CFIndex idx, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArraySetValueAtIndex (CFMutableArrayRef* theArray, nint idx, void* value);

    // extern void CFArrayRemoveValueAtIndex (CFMutableArrayRef theArray, CFIndex idx) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayRemoveValueAtIndex (CFMutableArrayRef* theArray, nint idx);

    // extern void CFArrayRemoveAllValues (CFMutableArrayRef theArray) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayRemoveAllValues (CFMutableArrayRef* theArray);

    // extern void CFArrayReplaceValues (CFMutableArrayRef theArray, CFRange range, const void **newValues, CFIndex newCount) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayReplaceValues (CFMutableArrayRef* theArray, CFRange range, void** newValues, nint newCount);

    // extern void CFArrayExchangeValuesAtIndices (CFMutableArrayRef theArray, CFIndex idx1, CFIndex idx2) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayExchangeValuesAtIndices (CFMutableArrayRef* theArray, nint idx1, nint idx2);

    // extern void CFArraySortValues (CFMutableArrayRef theArray, CFRange range, CFComparatorFunction comparator, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArraySortValues (CFMutableArrayRef* theArray, CFRange range, CFComparatorFunction* comparator, void* context);

    // extern void CFArrayAppendArray (CFMutableArrayRef theArray, CFArrayRef otherArray, CFRange otherRange) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFArrayAppendArray (CFMutableArrayRef* theArray, CFArrayRef* otherArray, CFRange otherRange);

    // extern CFTypeID CFBagGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFBagGetTypeID ();

    // extern CFBagRef CFBagCreate (CFAllocatorRef allocator, const void **values, CFIndex numValues, const CFBagCallBacks *callBacks) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBagRef* CFBagCreate (CFAllocatorRef* allocator, void** values, nint numValues, CFBagCallBacks* callBacks);

    // extern CFBagRef CFBagCreateCopy (CFAllocatorRef allocator, CFBagRef theBag) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBagRef* CFBagCreateCopy (CFAllocatorRef* allocator, CFBagRef* theBag);

    // extern CFMutableBagRef CFBagCreateMutable (CFAllocatorRef allocator, CFIndex capacity, const CFBagCallBacks *callBacks) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableBagRef* CFBagCreateMutable (CFAllocatorRef* allocator, nint capacity, CFBagCallBacks* callBacks);

    // extern CFMutableBagRef CFBagCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFBagRef theBag) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableBagRef* CFBagCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFBagRef* theBag);

    // extern CFIndex CFBagGetCount (CFBagRef theBag) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFBagGetCount (CFBagRef* theBag);

    // extern CFIndex CFBagGetCountOfValue (CFBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFBagGetCountOfValue (CFBagRef* theBag, void* value);

    // extern Boolean CFBagContainsValue (CFBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBagContainsValue (CFBagRef* theBag, void* value);

    // extern const void * CFBagGetValue (CFBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFBagGetValue (CFBagRef* theBag, void* value);

    // extern Boolean CFBagGetValueIfPresent (CFBagRef theBag, const void *candidate, const void **value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBagGetValueIfPresent (CFBagRef* theBag, void* candidate, void** value);

    // extern void CFBagGetValues (CFBagRef theBag, const void **values) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBagGetValues (CFBagRef* theBag, void** values);

    // extern void CFBagApplyFunction (CFBagRef theBag, CFBagApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBagApplyFunction (CFBagRef* theBag, CFBagApplierFunction* applier, void* context);

    // extern void CFBagAddValue (CFMutableBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBagAddValue (CFMutableBagRef* theBag, void* value);

    // extern void CFBagReplaceValue (CFMutableBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBagReplaceValue (CFMutableBagRef* theBag, void* value);

    // extern void CFBagSetValue (CFMutableBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBagSetValue (CFMutableBagRef* theBag, void* value);

    // extern void CFBagRemoveValue (CFMutableBagRef theBag, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBagRemoveValue (CFMutableBagRef* theBag, void* value);

    // extern void CFBagRemoveAllValues (CFMutableBagRef theBag) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBagRemoveAllValues (CFMutableBagRef* theBag);

    // extern CFTypeID CFBinaryHeapGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFBinaryHeapGetTypeID ();

    // extern CFBinaryHeapRef CFBinaryHeapCreate (CFAllocatorRef allocator, CFIndex capacity, const CFBinaryHeapCallBacks *callBacks, const CFBinaryHeapCompareContext *compareContext) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBinaryHeapRef* CFBinaryHeapCreate (CFAllocatorRef* allocator, nint capacity, CFBinaryHeapCallBacks* callBacks, CFBinaryHeapCompareContext* compareContext);

    // extern CFBinaryHeapRef CFBinaryHeapCreateCopy (CFAllocatorRef allocator, CFIndex capacity, CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBinaryHeapRef* CFBinaryHeapCreateCopy (CFAllocatorRef* allocator, nint capacity, CFBinaryHeapRef* heap);

    // extern CFIndex CFBinaryHeapGetCount (CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFBinaryHeapGetCount (CFBinaryHeapRef* heap);

    // extern CFIndex CFBinaryHeapGetCountOfValue (CFBinaryHeapRef heap, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFBinaryHeapGetCountOfValue (CFBinaryHeapRef* heap, void* value);

    // extern Boolean CFBinaryHeapContainsValue (CFBinaryHeapRef heap, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBinaryHeapContainsValue (CFBinaryHeapRef* heap, void* value);

    // extern const void * CFBinaryHeapGetMinimum (CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFBinaryHeapGetMinimum (CFBinaryHeapRef* heap);

    // extern Boolean CFBinaryHeapGetMinimumIfPresent (CFBinaryHeapRef heap, const void **value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBinaryHeapGetMinimumIfPresent (CFBinaryHeapRef* heap, void** value);

    // extern void CFBinaryHeapGetValues (CFBinaryHeapRef heap, const void **values) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBinaryHeapGetValues (CFBinaryHeapRef* heap, void** values);

    // extern void CFBinaryHeapApplyFunction (CFBinaryHeapRef heap, CFBinaryHeapApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBinaryHeapApplyFunction (CFBinaryHeapRef* heap, CFBinaryHeapApplierFunction* applier, void* context);

    // extern void CFBinaryHeapAddValue (CFBinaryHeapRef heap, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBinaryHeapAddValue (CFBinaryHeapRef* heap, void* value);

    // extern void CFBinaryHeapRemoveMinimumValue (CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBinaryHeapRemoveMinimumValue (CFBinaryHeapRef* heap);

    // extern void CFBinaryHeapRemoveAllValues (CFBinaryHeapRef heap) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBinaryHeapRemoveAllValues (CFBinaryHeapRef* heap);

    // extern CFTypeID CFBitVectorGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFBitVectorGetTypeID ();

    // extern CFBitVectorRef CFBitVectorCreate (CFAllocatorRef allocator, const UInt8 *bytes, CFIndex numBits) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBitVectorRef* CFBitVectorCreate (CFAllocatorRef* allocator, byte* bytes, nint numBits);

    // extern CFBitVectorRef CFBitVectorCreateCopy (CFAllocatorRef allocator, CFBitVectorRef bv) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBitVectorRef* CFBitVectorCreateCopy (CFAllocatorRef* allocator, CFBitVectorRef* bv);

    // extern CFMutableBitVectorRef CFBitVectorCreateMutable (CFAllocatorRef allocator, CFIndex capacity) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableBitVectorRef* CFBitVectorCreateMutable (CFAllocatorRef* allocator, nint capacity);

    // extern CFMutableBitVectorRef CFBitVectorCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFBitVectorRef bv) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableBitVectorRef* CFBitVectorCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFBitVectorRef* bv);

    // extern CFIndex CFBitVectorGetCount (CFBitVectorRef bv) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFBitVectorGetCount (CFBitVectorRef* bv);

    // extern CFIndex CFBitVectorGetCountOfBit (CFBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFBitVectorGetCountOfBit (CFBitVectorRef* bv, CFRange range, uint value);

    // extern Boolean CFBitVectorContainsBit (CFBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBitVectorContainsBit (CFBitVectorRef* bv, CFRange range, uint value);

    // extern CFBit CFBitVectorGetBitAtIndex (CFBitVectorRef bv, CFIndex idx) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe uint CFBitVectorGetBitAtIndex (CFBitVectorRef* bv, nint idx);

    // extern void CFBitVectorGetBits (CFBitVectorRef bv, CFRange range, UInt8 *bytes) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBitVectorGetBits (CFBitVectorRef* bv, CFRange range, byte* bytes);

    // extern CFIndex CFBitVectorGetFirstIndexOfBit (CFBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFBitVectorGetFirstIndexOfBit (CFBitVectorRef* bv, CFRange range, uint value);

    // extern CFIndex CFBitVectorGetLastIndexOfBit (CFBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFBitVectorGetLastIndexOfBit (CFBitVectorRef* bv, CFRange range, uint value);

    // extern void CFBitVectorSetCount (CFMutableBitVectorRef bv, CFIndex count) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBitVectorSetCount (CFMutableBitVectorRef* bv, nint count);

    // extern void CFBitVectorFlipBitAtIndex (CFMutableBitVectorRef bv, CFIndex idx) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBitVectorFlipBitAtIndex (CFMutableBitVectorRef* bv, nint idx);

    // extern void CFBitVectorFlipBits (CFMutableBitVectorRef bv, CFRange range) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBitVectorFlipBits (CFMutableBitVectorRef* bv, CFRange range);

    // extern void CFBitVectorSetBitAtIndex (CFMutableBitVectorRef bv, CFIndex idx, CFBit value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBitVectorSetBitAtIndex (CFMutableBitVectorRef* bv, nint idx, uint value);

    // extern void CFBitVectorSetBits (CFMutableBitVectorRef bv, CFRange range, CFBit value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBitVectorSetBits (CFMutableBitVectorRef* bv, CFRange range, uint value);

    // extern void CFBitVectorSetAllBits (CFMutableBitVectorRef bv, CFBit value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBitVectorSetAllBits (CFMutableBitVectorRef* bv, uint value);

    // int32_t OSHostByteOrder ();
    [DllImport ("__Internal")]
    
    static extern int OSHostByteOrder ();

    // uint16_t _OSReadInt16 (const volatile void *base, uintptr_t byteOffset);
    [DllImport ("__Internal")]
    
    static extern unsafe ushort _OSReadInt16 (void* @base, UIntPtr byteOffset);

    // uint32_t _OSReadInt32 (const volatile void *base, uintptr_t byteOffset);
    [DllImport ("__Internal")]
    
    static extern unsafe uint _OSReadInt32 (void* @base, UIntPtr byteOffset);

    // uint64_t _OSReadInt64 (const volatile void *base, uintptr_t byteOffset);
    [DllImport ("__Internal")]
    
    static extern unsafe ulong _OSReadInt64 (void* @base, UIntPtr byteOffset);

    // void _OSWriteInt16 (volatile void *base, uintptr_t byteOffset, uint16_t data);
    [DllImport ("__Internal")]
    
    static extern unsafe void _OSWriteInt16 (void* @base, UIntPtr byteOffset, ushort data);

    // void _OSWriteInt32 (volatile void *base, uintptr_t byteOffset, uint32_t data);
    [DllImport ("__Internal")]
    
    static extern unsafe void _OSWriteInt32 (void* @base, UIntPtr byteOffset, uint data);

    // void _OSWriteInt64 (volatile void *base, uintptr_t byteOffset, uint64_t data);
    [DllImport ("__Internal")]
    
    static extern unsafe void _OSWriteInt64 (void* @base, UIntPtr byteOffset, ulong data);

    // CFByteOrder CFByteOrderGetCurrent () __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern nint CFByteOrderGetCurrent ();

    // uint16_t CFSwapInt16 (uint16_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort CFSwapInt16 (ushort arg);

    // extern int __builtin_constant_p () __attribute__((nothrow)) __attribute__((const));
    [DllImport ("__Internal")]
    
    static extern int __builtin_constant_p ();

    // uint32_t CFSwapInt32 (uint32_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint CFSwapInt32 (uint arg);

    // uint64_t CFSwapInt64 (uint64_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong CFSwapInt64 (ulong arg);

    // uint16_t CFSwapInt16BigToHost (uint16_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort CFSwapInt16BigToHost (ushort arg);

    // uint32_t CFSwapInt32BigToHost (uint32_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint CFSwapInt32BigToHost (uint arg);

    // uint64_t CFSwapInt64BigToHost (uint64_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong CFSwapInt64BigToHost (ulong arg);

    // uint16_t CFSwapInt16HostToBig (uint16_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort CFSwapInt16HostToBig (ushort arg);

    // uint32_t CFSwapInt32HostToBig (uint32_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint CFSwapInt32HostToBig (uint arg);

    // uint64_t CFSwapInt64HostToBig (uint64_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong CFSwapInt64HostToBig (ulong arg);

    // uint16_t CFSwapInt16LittleToHost (uint16_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort CFSwapInt16LittleToHost (ushort arg);

    // uint32_t CFSwapInt32LittleToHost (uint32_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint CFSwapInt32LittleToHost (uint arg);

    // uint64_t CFSwapInt64LittleToHost (uint64_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong CFSwapInt64LittleToHost (ulong arg);

    // uint16_t CFSwapInt16HostToLittle (uint16_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort CFSwapInt16HostToLittle (ushort arg);

    // uint32_t CFSwapInt32HostToLittle (uint32_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint CFSwapInt32HostToLittle (uint arg);

    // uint64_t CFSwapInt64HostToLittle (uint64_t arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong CFSwapInt64HostToLittle (ulong arg);

    // CFSwappedFloat32 CFConvertFloat32HostToSwapped (Float32 arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern CFSwappedFloat32 CFConvertFloat32HostToSwapped (float arg);

    // Float32 CFConvertFloat32SwappedToHost (CFSwappedFloat32 arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern float CFConvertFloat32SwappedToHost (CFSwappedFloat32 arg);

    // CFSwappedFloat64 CFConvertFloat64HostToSwapped (Float64 arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern CFSwappedFloat64 CFConvertFloat64HostToSwapped (double arg);

    // Float64 CFConvertFloat64SwappedToHost (CFSwappedFloat64 arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern double CFConvertFloat64SwappedToHost (CFSwappedFloat64 arg);

    // CFSwappedFloat32 CFConvertFloatHostToSwapped (float arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern CFSwappedFloat32 CFConvertFloatHostToSwapped (float arg);

    // float CFConvertFloatSwappedToHost (CFSwappedFloat32 arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern float CFConvertFloatSwappedToHost (CFSwappedFloat32 arg);

    // CFSwappedFloat64 CFConvertDoubleHostToSwapped (double arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern CFSwappedFloat64 CFConvertDoubleHostToSwapped (double arg);

    // double CFConvertDoubleSwappedToHost (CFSwappedFloat64 arg) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern double CFConvertDoubleSwappedToHost (CFSwappedFloat64 arg);

    // extern CFTypeID CFDictionaryGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFDictionaryGetTypeID ();

    // extern CFDictionaryRef CFDictionaryCreate (CFAllocatorRef allocator, const void **keys, const void **values, CFIndex numValues, const CFDictionaryKeyCallBacks *keyCallBacks, const CFDictionaryValueCallBacks *valueCallBacks) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFDictionaryCreate (CFAllocatorRef* allocator, void** keys, void** values, nint numValues, CFDictionaryKeyCallBacks* keyCallBacks, CFDictionaryValueCallBacks* valueCallBacks);

    // extern CFDictionaryRef CFDictionaryCreateCopy (CFAllocatorRef allocator, CFDictionaryRef theDict) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFDictionaryCreateCopy (CFAllocatorRef* allocator, CFDictionaryRef* theDict);

    // extern CFMutableDictionaryRef CFDictionaryCreateMutable (CFAllocatorRef allocator, CFIndex capacity, const CFDictionaryKeyCallBacks *keyCallBacks, const CFDictionaryValueCallBacks *valueCallBacks) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableDictionaryRef* CFDictionaryCreateMutable (CFAllocatorRef* allocator, nint capacity, CFDictionaryKeyCallBacks* keyCallBacks, CFDictionaryValueCallBacks* valueCallBacks);

    // extern CFMutableDictionaryRef CFDictionaryCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFDictionaryRef theDict) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableDictionaryRef* CFDictionaryCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFDictionaryRef* theDict);

    // extern CFIndex CFDictionaryGetCount (CFDictionaryRef theDict) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFDictionaryGetCount (CFDictionaryRef* theDict);

    // extern CFIndex CFDictionaryGetCountOfKey (CFDictionaryRef theDict, const void *key) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFDictionaryGetCountOfKey (CFDictionaryRef* theDict, void* key);

    // extern CFIndex CFDictionaryGetCountOfValue (CFDictionaryRef theDict, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFDictionaryGetCountOfValue (CFDictionaryRef* theDict, void* value);

    // extern Boolean CFDictionaryContainsKey (CFDictionaryRef theDict, const void *key) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFDictionaryContainsKey (CFDictionaryRef* theDict, void* key);

    // extern Boolean CFDictionaryContainsValue (CFDictionaryRef theDict, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFDictionaryContainsValue (CFDictionaryRef* theDict, void* value);

    // extern const void * CFDictionaryGetValue (CFDictionaryRef theDict, const void *key) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFDictionaryGetValue (CFDictionaryRef* theDict, void* key);

    // extern Boolean CFDictionaryGetValueIfPresent (CFDictionaryRef theDict, const void *key, const void **value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFDictionaryGetValueIfPresent (CFDictionaryRef* theDict, void* key, void** value);

    // extern void CFDictionaryGetKeysAndValues (CFDictionaryRef theDict, const void **keys, const void **values) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDictionaryGetKeysAndValues (CFDictionaryRef* theDict, void** keys, void** values);

    // extern void CFDictionaryApplyFunction (CFDictionaryRef theDict, CFDictionaryApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDictionaryApplyFunction (CFDictionaryRef* theDict, CFDictionaryApplierFunction* applier, void* context);

    // extern void CFDictionaryAddValue (CFMutableDictionaryRef theDict, const void *key, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDictionaryAddValue (CFMutableDictionaryRef* theDict, void* key, void* value);

    // extern void CFDictionarySetValue (CFMutableDictionaryRef theDict, const void *key, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDictionarySetValue (CFMutableDictionaryRef* theDict, void* key, void* value);

    // extern void CFDictionaryReplaceValue (CFMutableDictionaryRef theDict, const void *key, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDictionaryReplaceValue (CFMutableDictionaryRef* theDict, void* key, void* value);

    // extern void CFDictionaryRemoveValue (CFMutableDictionaryRef theDict, const void *key) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDictionaryRemoveValue (CFMutableDictionaryRef* theDict, void* key);

    // extern void CFDictionaryRemoveAllValues (CFMutableDictionaryRef theDict) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDictionaryRemoveAllValues (CFMutableDictionaryRef* theDict);

    // extern CFTypeID CFNotificationCenterGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFNotificationCenterGetTypeID ();

    // extern CFNotificationCenterRef CFNotificationCenterGetLocalCenter () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFNotificationCenterRef* CFNotificationCenterGetLocalCenter ();

    // extern CFNotificationCenterRef CFNotificationCenterGetDarwinNotifyCenter () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFNotificationCenterRef* CFNotificationCenterGetDarwinNotifyCenter ();

    // extern void CFNotificationCenterAddObserver (CFNotificationCenterRef center, const void *observer, CFNotificationCallback callBack, CFStringRef name, const void *object, CFNotificationSuspensionBehavior suspensionBehavior) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNotificationCenterAddObserver (CFNotificationCenterRef* center, void* observer, CFNotificationCallback* callBack, CFStringRef* name, void* @object, CFNotificationSuspensionBehavior suspensionBehavior);

    // extern void CFNotificationCenterRemoveObserver (CFNotificationCenterRef center, const void *observer, CFNotificationName name, const void *object) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNotificationCenterRemoveObserver (CFNotificationCenterRef* center, void* observer, CFNotificationName* name, void* @object);

    // extern void CFNotificationCenterRemoveEveryObserver (CFNotificationCenterRef center, const void *observer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNotificationCenterRemoveEveryObserver (CFNotificationCenterRef* center, void* observer);

    // extern void CFNotificationCenterPostNotification (CFNotificationCenterRef center, CFNotificationName name, const void *object, CFDictionaryRef userInfo, Boolean deliverImmediately) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNotificationCenterPostNotification (CFNotificationCenterRef* center, CFNotificationName* name, void* @object, CFDictionaryRef* userInfo, byte deliverImmediately);

    // extern void CFNotificationCenterPostNotificationWithOptions (CFNotificationCenterRef center, CFNotificationName name, const void *object, CFDictionaryRef userInfo, CFOptionFlags options) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNotificationCenterPostNotificationWithOptions (CFNotificationCenterRef* center, CFNotificationName* name, void* @object, CFDictionaryRef* userInfo, nuint options);

    // extern CFTypeID CFLocaleGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFLocaleGetTypeID ();

    // extern CFLocaleRef CFLocaleGetSystem () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleRef* CFLocaleGetSystem ();

    // extern CFLocaleRef CFLocaleCopyCurrent () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleRef* CFLocaleCopyCurrent ();

    // extern CFArrayRef CFLocaleCopyAvailableLocaleIdentifiers () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFLocaleCopyAvailableLocaleIdentifiers ();

    // extern CFArrayRef CFLocaleCopyISOLanguageCodes () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFLocaleCopyISOLanguageCodes ();

    // extern CFArrayRef CFLocaleCopyISOCountryCodes () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFLocaleCopyISOCountryCodes ();

    // extern CFArrayRef CFLocaleCopyISOCurrencyCodes () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFLocaleCopyISOCurrencyCodes ();

    // extern CFArrayRef CFLocaleCopyCommonISOCurrencyCodes () __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFLocaleCopyCommonISOCurrencyCodes ();

    // extern CFArrayRef CFLocaleCopyPreferredLanguages () __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFLocaleCopyPreferredLanguages ();

    // extern CFLocaleIdentifier CFLocaleCreateCanonicalLanguageIdentifierFromString (CFAllocatorRef allocator, CFStringRef localeIdentifier) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleIdentifier* CFLocaleCreateCanonicalLanguageIdentifierFromString (CFAllocatorRef* allocator, CFStringRef* localeIdentifier);

    // extern CFLocaleIdentifier CFLocaleCreateCanonicalLocaleIdentifierFromString (CFAllocatorRef allocator, CFStringRef localeIdentifier) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleIdentifier* CFLocaleCreateCanonicalLocaleIdentifierFromString (CFAllocatorRef* allocator, CFStringRef* localeIdentifier);

    // extern CFLocaleIdentifier CFLocaleCreateCanonicalLocaleIdentifierFromScriptManagerCodes (CFAllocatorRef allocator, LangCode lcode, RegionCode rcode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleIdentifier* CFLocaleCreateCanonicalLocaleIdentifierFromScriptManagerCodes (CFAllocatorRef* allocator, short lcode, short rcode);

    // extern CFLocaleIdentifier CFLocaleCreateLocaleIdentifierFromWindowsLocaleCode (CFAllocatorRef allocator, uint32_t lcid) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleIdentifier* CFLocaleCreateLocaleIdentifierFromWindowsLocaleCode (CFAllocatorRef* allocator, uint lcid);

    // extern uint32_t CFLocaleGetWindowsLocaleCodeFromLocaleIdentifier (CFLocaleIdentifier localeIdentifier) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe uint CFLocaleGetWindowsLocaleCodeFromLocaleIdentifier (CFLocaleIdentifier* localeIdentifier);

    // extern CFLocaleLanguageDirection CFLocaleGetLanguageCharacterDirection (CFStringRef isoLangCode) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleLanguageDirection CFLocaleGetLanguageCharacterDirection (CFStringRef* isoLangCode);

    // extern CFLocaleLanguageDirection CFLocaleGetLanguageLineDirection (CFStringRef isoLangCode) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleLanguageDirection CFLocaleGetLanguageLineDirection (CFStringRef* isoLangCode);

    // extern CFDictionaryRef CFLocaleCreateComponentsFromLocaleIdentifier (CFAllocatorRef allocator, CFLocaleIdentifier localeID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFLocaleCreateComponentsFromLocaleIdentifier (CFAllocatorRef* allocator, CFLocaleIdentifier* localeID);

    // extern CFLocaleIdentifier CFLocaleCreateLocaleIdentifierFromComponents (CFAllocatorRef allocator, CFDictionaryRef dictionary) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleIdentifier* CFLocaleCreateLocaleIdentifierFromComponents (CFAllocatorRef* allocator, CFDictionaryRef* dictionary);

    // extern CFLocaleRef CFLocaleCreate (CFAllocatorRef allocator, CFLocaleIdentifier localeIdentifier) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleRef* CFLocaleCreate (CFAllocatorRef* allocator, CFLocaleIdentifier* localeIdentifier);

    // extern CFLocaleRef CFLocaleCreateCopy (CFAllocatorRef allocator, CFLocaleRef locale) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleRef* CFLocaleCreateCopy (CFAllocatorRef* allocator, CFLocaleRef* locale);

    // extern CFLocaleIdentifier CFLocaleGetIdentifier (CFLocaleRef locale) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleIdentifier* CFLocaleGetIdentifier (CFLocaleRef* locale);

    // extern CFTypeRef CFLocaleGetValue (CFLocaleRef locale, CFLocaleKey key) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFLocaleGetValue (CFLocaleRef* locale, CFLocaleKey* key);

    // extern CFStringRef CFLocaleCopyDisplayNameForPropertyValue (CFLocaleRef displayLocale, CFLocaleKey key, CFStringRef value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFLocaleCopyDisplayNameForPropertyValue (CFLocaleRef* displayLocale, CFLocaleKey* key, CFStringRef* value);

    // extern CFAbsoluteTime CFAbsoluteTimeGetCurrent () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern double CFAbsoluteTimeGetCurrent ();

    // extern CFTypeID CFDateGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFDateGetTypeID ();

    // extern CFDateRef CFDateCreate (CFAllocatorRef allocator, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDateRef* CFDateCreate (CFAllocatorRef* allocator, double at);

    // extern CFAbsoluteTime CFDateGetAbsoluteTime (CFDateRef theDate) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe double CFDateGetAbsoluteTime (CFDateRef* theDate);

    // extern CFTimeInterval CFDateGetTimeIntervalSinceDate (CFDateRef theDate, CFDateRef otherDate) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe double CFDateGetTimeIntervalSinceDate (CFDateRef* theDate, CFDateRef* otherDate);

    // extern CFComparisonResult CFDateCompare (CFDateRef theDate, CFDateRef otherDate, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFComparisonResult CFDateCompare (CFDateRef* theDate, CFDateRef* otherDate, void* context);

    // extern Boolean CFGregorianDateIsValid (CFGregorianDate gdate, CFOptionFlags unitFlags) __attribute__((availability(ios, introduced=2_0, deprecated=8_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [DllImport ("__Internal")]
    
    static extern byte CFGregorianDateIsValid (CFGregorianDate gdate, nuint unitFlags);

    // extern CFAbsoluteTime CFGregorianDateGetAbsoluteTime (CFGregorianDate gdate, CFTimeZoneRef tz) __attribute__((availability(ios, introduced=2_0, deprecated=8_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [DllImport ("__Internal")]
    
    static extern unsafe double CFGregorianDateGetAbsoluteTime (CFGregorianDate gdate, CFTimeZoneRef* tz);

    // extern CFGregorianDate CFAbsoluteTimeGetGregorianDate (CFAbsoluteTime at, CFTimeZoneRef tz) __attribute__((availability(ios, introduced=2_0, deprecated=8_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFGregorianDate CFAbsoluteTimeGetGregorianDate (double at, CFTimeZoneRef* tz);

    // extern CFAbsoluteTime CFAbsoluteTimeAddGregorianUnits (CFAbsoluteTime at, CFTimeZoneRef tz, CFGregorianUnits units) __attribute__((availability(ios, introduced=2_0, deprecated=8_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [DllImport ("__Internal")]
    
    static extern unsafe double CFAbsoluteTimeAddGregorianUnits (double at, CFTimeZoneRef* tz, CFGregorianUnits units);

    // extern CFGregorianUnits CFAbsoluteTimeGetDifferenceAsGregorianUnits (CFAbsoluteTime at1, CFAbsoluteTime at2, CFTimeZoneRef tz, CFOptionFlags unitFlags) __attribute__((availability(ios, introduced=2_0, deprecated=8_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFGregorianUnits CFAbsoluteTimeGetDifferenceAsGregorianUnits (double at1, double at2, CFTimeZoneRef* tz, nuint unitFlags);

    // extern SInt32 CFAbsoluteTimeGetDayOfWeek (CFAbsoluteTime at, CFTimeZoneRef tz) __attribute__((availability(ios, introduced=2_0, deprecated=8_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [DllImport ("__Internal")]
    
    static extern unsafe int CFAbsoluteTimeGetDayOfWeek (double at, CFTimeZoneRef* tz);

    // extern SInt32 CFAbsoluteTimeGetDayOfYear (CFAbsoluteTime at, CFTimeZoneRef tz) __attribute__((availability(ios, introduced=2_0, deprecated=8_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [DllImport ("__Internal")]
    
    static extern unsafe int CFAbsoluteTimeGetDayOfYear (double at, CFTimeZoneRef* tz);

    // extern SInt32 CFAbsoluteTimeGetWeekOfYear (CFAbsoluteTime at, CFTimeZoneRef tz) __attribute__((availability(ios, introduced=2_0, deprecated=8_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFCalendar or NSCalendar API instead")]
    [DllImport ("__Internal")]
    
    static extern unsafe int CFAbsoluteTimeGetWeekOfYear (double at, CFTimeZoneRef* tz);

    // extern CFTypeID CFDataGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFDataGetTypeID ();

    // extern CFDataRef CFDataCreate (CFAllocatorRef allocator, const UInt8 *bytes, CFIndex length) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFDataCreate (CFAllocatorRef* allocator, byte* bytes, nint length);

    // extern CFDataRef CFDataCreateWithBytesNoCopy (CFAllocatorRef allocator, const UInt8 *bytes, CFIndex length, CFAllocatorRef bytesDeallocator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFDataCreateWithBytesNoCopy (CFAllocatorRef* allocator, byte* bytes, nint length, CFAllocatorRef* bytesDeallocator);

    // extern CFDataRef CFDataCreateCopy (CFAllocatorRef allocator, CFDataRef theData) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFDataCreateCopy (CFAllocatorRef* allocator, CFDataRef* theData);

    // extern CFMutableDataRef CFDataCreateMutable (CFAllocatorRef allocator, CFIndex capacity) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableDataRef* CFDataCreateMutable (CFAllocatorRef* allocator, nint capacity);

    // extern CFMutableDataRef CFDataCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFDataRef theData) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableDataRef* CFDataCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFDataRef* theData);

    // extern CFIndex CFDataGetLength (CFDataRef theData) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFDataGetLength (CFDataRef* theData);

    // extern const UInt8 * CFDataGetBytePtr (CFDataRef theData) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte* CFDataGetBytePtr (CFDataRef* theData);

    // extern UInt8 * CFDataGetMutableBytePtr (CFMutableDataRef theData) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte* CFDataGetMutableBytePtr (CFMutableDataRef* theData);

    // extern void CFDataGetBytes (CFDataRef theData, CFRange range, UInt8 *buffer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDataGetBytes (CFDataRef* theData, CFRange range, byte* buffer);

    // extern void CFDataSetLength (CFMutableDataRef theData, CFIndex length) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDataSetLength (CFMutableDataRef* theData, nint length);

    // extern void CFDataIncreaseLength (CFMutableDataRef theData, CFIndex extraLength) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDataIncreaseLength (CFMutableDataRef* theData, nint extraLength);

    // extern void CFDataAppendBytes (CFMutableDataRef theData, const UInt8 *bytes, CFIndex length) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDataAppendBytes (CFMutableDataRef* theData, byte* bytes, nint length);

    // extern void CFDataReplaceBytes (CFMutableDataRef theData, CFRange range, const UInt8 *newBytes, CFIndex newLength) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDataReplaceBytes (CFMutableDataRef* theData, CFRange range, byte* newBytes, nint newLength);

    // extern void CFDataDeleteBytes (CFMutableDataRef theData, CFRange range) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDataDeleteBytes (CFMutableDataRef* theData, CFRange range);

    // extern CFRange CFDataFind (CFDataRef theData, CFDataRef dataToFind, CFRange searchRange, CFDataSearchFlags compareOptions) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFRange CFDataFind (CFDataRef* theData, CFDataRef* dataToFind, CFRange searchRange, CFDataSearchFlags compareOptions);

    // extern CFTypeID CFCharacterSetGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFCharacterSetGetTypeID ();

    // extern CFCharacterSetRef CFCharacterSetGetPredefined (CFCharacterSetPredefinedSet theSetIdentifier) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCharacterSetRef* CFCharacterSetGetPredefined (CFCharacterSetPredefinedSet theSetIdentifier);

    // extern CFCharacterSetRef CFCharacterSetCreateWithCharactersInRange (CFAllocatorRef alloc, CFRange theRange) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCharacterSetRef* CFCharacterSetCreateWithCharactersInRange (CFAllocatorRef* alloc, CFRange theRange);

    // extern CFCharacterSetRef CFCharacterSetCreateWithCharactersInString (CFAllocatorRef alloc, CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCharacterSetRef* CFCharacterSetCreateWithCharactersInString (CFAllocatorRef* alloc, CFStringRef* theString);

    // extern CFCharacterSetRef CFCharacterSetCreateWithBitmapRepresentation (CFAllocatorRef alloc, CFDataRef theData) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCharacterSetRef* CFCharacterSetCreateWithBitmapRepresentation (CFAllocatorRef* alloc, CFDataRef* theData);

    // extern CFCharacterSetRef CFCharacterSetCreateInvertedSet (CFAllocatorRef alloc, CFCharacterSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCharacterSetRef* CFCharacterSetCreateInvertedSet (CFAllocatorRef* alloc, CFCharacterSetRef* theSet);

    // extern Boolean CFCharacterSetIsSupersetOfSet (CFCharacterSetRef theSet, CFCharacterSetRef theOtherset) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCharacterSetIsSupersetOfSet (CFCharacterSetRef* theSet, CFCharacterSetRef* theOtherset);

    // extern Boolean CFCharacterSetHasMemberInPlane (CFCharacterSetRef theSet, CFIndex thePlane) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCharacterSetHasMemberInPlane (CFCharacterSetRef* theSet, nint thePlane);

    // extern CFMutableCharacterSetRef CFCharacterSetCreateMutable (CFAllocatorRef alloc) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableCharacterSetRef* CFCharacterSetCreateMutable (CFAllocatorRef* alloc);

    // extern CFCharacterSetRef CFCharacterSetCreateCopy (CFAllocatorRef alloc, CFCharacterSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCharacterSetRef* CFCharacterSetCreateCopy (CFAllocatorRef* alloc, CFCharacterSetRef* theSet);

    // extern CFMutableCharacterSetRef CFCharacterSetCreateMutableCopy (CFAllocatorRef alloc, CFCharacterSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableCharacterSetRef* CFCharacterSetCreateMutableCopy (CFAllocatorRef* alloc, CFCharacterSetRef* theSet);

    // extern Boolean CFCharacterSetIsCharacterMember (CFCharacterSetRef theSet, UniChar theChar) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCharacterSetIsCharacterMember (CFCharacterSetRef* theSet, ushort theChar);

    // extern Boolean CFCharacterSetIsLongCharacterMember (CFCharacterSetRef theSet, UTF32Char theChar) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCharacterSetIsLongCharacterMember (CFCharacterSetRef* theSet, uint theChar);

    // extern CFDataRef CFCharacterSetCreateBitmapRepresentation (CFAllocatorRef alloc, CFCharacterSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFCharacterSetCreateBitmapRepresentation (CFAllocatorRef* alloc, CFCharacterSetRef* theSet);

    // extern void CFCharacterSetAddCharactersInRange (CFMutableCharacterSetRef theSet, CFRange theRange) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCharacterSetAddCharactersInRange (CFMutableCharacterSetRef* theSet, CFRange theRange);

    // extern void CFCharacterSetRemoveCharactersInRange (CFMutableCharacterSetRef theSet, CFRange theRange) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCharacterSetRemoveCharactersInRange (CFMutableCharacterSetRef* theSet, CFRange theRange);

    // extern void CFCharacterSetAddCharactersInString (CFMutableCharacterSetRef theSet, CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCharacterSetAddCharactersInString (CFMutableCharacterSetRef* theSet, CFStringRef* theString);

    // extern void CFCharacterSetRemoveCharactersInString (CFMutableCharacterSetRef theSet, CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCharacterSetRemoveCharactersInString (CFMutableCharacterSetRef* theSet, CFStringRef* theString);

    // extern void CFCharacterSetUnion (CFMutableCharacterSetRef theSet, CFCharacterSetRef theOtherSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCharacterSetUnion (CFMutableCharacterSetRef* theSet, CFCharacterSetRef* theOtherSet);

    // extern void CFCharacterSetIntersect (CFMutableCharacterSetRef theSet, CFCharacterSetRef theOtherSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCharacterSetIntersect (CFMutableCharacterSetRef* theSet, CFCharacterSetRef* theOtherSet);

    // extern void CFCharacterSetInvert (CFMutableCharacterSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCharacterSetInvert (CFMutableCharacterSetRef* theSet);

    // extern CFTypeID CFStringGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFStringGetTypeID ();

    // extern CFStringRef CFStringCreateWithPascalString (CFAllocatorRef alloc, ConstStr255Param pStr, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithPascalString (CFAllocatorRef* alloc, byte* pStr, uint encoding);

    // extern CFStringRef CFStringCreateWithCString (CFAllocatorRef alloc, const char *cStr, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithCString (CFAllocatorRef* alloc, sbyte* cStr, uint encoding);

    // extern CFStringRef CFStringCreateWithBytes (CFAllocatorRef alloc, const UInt8 *bytes, CFIndex numBytes, CFStringEncoding encoding, Boolean isExternalRepresentation) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithBytes (CFAllocatorRef* alloc, byte* bytes, nint numBytes, uint encoding, byte isExternalRepresentation);

    // extern CFStringRef CFStringCreateWithCharacters (CFAllocatorRef alloc, const UniChar *chars, CFIndex numChars) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithCharacters (CFAllocatorRef* alloc, ushort* chars, nint numChars);

    // extern CFStringRef CFStringCreateWithPascalStringNoCopy (CFAllocatorRef alloc, ConstStr255Param pStr, CFStringEncoding encoding, CFAllocatorRef contentsDeallocator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithPascalStringNoCopy (CFAllocatorRef* alloc, byte* pStr, uint encoding, CFAllocatorRef* contentsDeallocator);

    // extern CFStringRef CFStringCreateWithCStringNoCopy (CFAllocatorRef alloc, const char *cStr, CFStringEncoding encoding, CFAllocatorRef contentsDeallocator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithCStringNoCopy (CFAllocatorRef* alloc, sbyte* cStr, uint encoding, CFAllocatorRef* contentsDeallocator);

    // extern CFStringRef CFStringCreateWithBytesNoCopy (CFAllocatorRef alloc, const UInt8 *bytes, CFIndex numBytes, CFStringEncoding encoding, Boolean isExternalRepresentation, CFAllocatorRef contentsDeallocator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithBytesNoCopy (CFAllocatorRef* alloc, byte* bytes, nint numBytes, uint encoding, byte isExternalRepresentation, CFAllocatorRef* contentsDeallocator);

    // extern CFStringRef CFStringCreateWithCharactersNoCopy (CFAllocatorRef alloc, const UniChar *chars, CFIndex numChars, CFAllocatorRef contentsDeallocator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithCharactersNoCopy (CFAllocatorRef* alloc, ushort* chars, nint numChars, CFAllocatorRef* contentsDeallocator);

    // extern CFStringRef CFStringCreateWithSubstring (CFAllocatorRef alloc, CFStringRef str, CFRange range) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithSubstring (CFAllocatorRef* alloc, CFStringRef* str, CFRange range);

    // extern CFStringRef CFStringCreateCopy (CFAllocatorRef alloc, CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateCopy (CFAllocatorRef* alloc, CFStringRef* theString);

    // extern CFStringRef CFStringCreateWithFormat (CFAllocatorRef alloc, CFDictionaryRef formatOptions, CFStringRef format, ...) __attribute__((format(CFString, 3, 4))) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithFormat (CFAllocatorRef* alloc, CFDictionaryRef* formatOptions, CFStringRef* format, IntPtr varArgs);

    // extern CFStringRef CFStringCreateWithFormatAndArguments (CFAllocatorRef alloc, CFDictionaryRef formatOptions, CFStringRef format, va_list arguments) __attribute__((format(CFString, 3, 0))) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithFormatAndArguments (CFAllocatorRef* alloc, CFDictionaryRef* formatOptions, CFStringRef* format, sbyte* arguments);

    // extern CFMutableStringRef CFStringCreateMutable (CFAllocatorRef alloc, CFIndex maxLength) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableStringRef* CFStringCreateMutable (CFAllocatorRef* alloc, nint maxLength);

    // extern CFMutableStringRef CFStringCreateMutableCopy (CFAllocatorRef alloc, CFIndex maxLength, CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableStringRef* CFStringCreateMutableCopy (CFAllocatorRef* alloc, nint maxLength, CFStringRef* theString);

    // extern CFMutableStringRef CFStringCreateMutableWithExternalCharactersNoCopy (CFAllocatorRef alloc, UniChar *chars, CFIndex numChars, CFIndex capacity, CFAllocatorRef externalCharactersAllocator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableStringRef* CFStringCreateMutableWithExternalCharactersNoCopy (CFAllocatorRef* alloc, ushort* chars, nint numChars, nint capacity, CFAllocatorRef* externalCharactersAllocator);

    // extern CFIndex CFStringGetLength (CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFStringGetLength (CFStringRef* theString);

    // extern UniChar CFStringGetCharacterAtIndex (CFStringRef theString, CFIndex idx) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe ushort CFStringGetCharacterAtIndex (CFStringRef* theString, nint idx);

    // extern void CFStringGetCharacters (CFStringRef theString, CFRange range, UniChar *buffer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringGetCharacters (CFStringRef* theString, CFRange range, ushort* buffer);

    // extern Boolean CFStringGetPascalString (CFStringRef theString, StringPtr buffer, CFIndex bufferSize, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringGetPascalString (CFStringRef* theString, byte* buffer, nint bufferSize, uint encoding);

    // extern Boolean CFStringGetCString (CFStringRef theString, char *buffer, CFIndex bufferSize, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringGetCString (CFStringRef* theString, sbyte* buffer, nint bufferSize, uint encoding);

    // extern ConstStringPtr CFStringGetPascalStringPtr (CFStringRef theString, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte* CFStringGetPascalStringPtr (CFStringRef* theString, uint encoding);

    // extern const char * CFStringGetCStringPtr (CFStringRef theString, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe sbyte* CFStringGetCStringPtr (CFStringRef* theString, uint encoding);

    // extern const UniChar * CFStringGetCharactersPtr (CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe ushort* CFStringGetCharactersPtr (CFStringRef* theString);

    // extern CFIndex CFStringGetBytes (CFStringRef theString, CFRange range, CFStringEncoding encoding, UInt8 lossByte, Boolean isExternalRepresentation, UInt8 *buffer, CFIndex maxBufLen, CFIndex *usedBufLen) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFStringGetBytes (CFStringRef* theString, CFRange range, uint encoding, byte lossByte, byte isExternalRepresentation, byte* buffer, nint maxBufLen, nint* usedBufLen);

    // extern CFStringRef CFStringCreateFromExternalRepresentation (CFAllocatorRef alloc, CFDataRef data, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateFromExternalRepresentation (CFAllocatorRef* alloc, CFDataRef* data, uint encoding);

    // extern CFDataRef CFStringCreateExternalRepresentation (CFAllocatorRef alloc, CFStringRef theString, CFStringEncoding encoding, UInt8 lossByte) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFStringCreateExternalRepresentation (CFAllocatorRef* alloc, CFStringRef* theString, uint encoding, byte lossByte);

    // extern CFStringEncoding CFStringGetSmallestEncoding (CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe uint CFStringGetSmallestEncoding (CFStringRef* theString);

    // extern CFStringEncoding CFStringGetFastestEncoding (CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe uint CFStringGetFastestEncoding (CFStringRef* theString);

    // extern CFStringEncoding CFStringGetSystemEncoding () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern uint CFStringGetSystemEncoding ();

    // extern CFIndex CFStringGetMaximumSizeForEncoding (CFIndex length, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nint CFStringGetMaximumSizeForEncoding (nint length, uint encoding);

    // extern Boolean CFStringGetFileSystemRepresentation (CFStringRef string, char *buffer, CFIndex maxBufLen) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringGetFileSystemRepresentation (CFStringRef* @string, sbyte* buffer, nint maxBufLen);

    // extern CFIndex CFStringGetMaximumSizeOfFileSystemRepresentation (CFStringRef string) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFStringGetMaximumSizeOfFileSystemRepresentation (CFStringRef* @string);

    // extern CFStringRef CFStringCreateWithFileSystemRepresentation (CFAllocatorRef alloc, const char *buffer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateWithFileSystemRepresentation (CFAllocatorRef* alloc, sbyte* buffer);

    // extern CFComparisonResult CFStringCompareWithOptionsAndLocale (CFStringRef theString1, CFStringRef theString2, CFRange rangeToCompare, CFStringCompareFlags compareOptions, CFLocaleRef locale) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFComparisonResult CFStringCompareWithOptionsAndLocale (CFStringRef* theString1, CFStringRef* theString2, CFRange rangeToCompare, CFStringCompareFlags compareOptions, CFLocaleRef* locale);

    // extern CFComparisonResult CFStringCompareWithOptions (CFStringRef theString1, CFStringRef theString2, CFRange rangeToCompare, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFComparisonResult CFStringCompareWithOptions (CFStringRef* theString1, CFStringRef* theString2, CFRange rangeToCompare, CFStringCompareFlags compareOptions);

    // extern CFComparisonResult CFStringCompare (CFStringRef theString1, CFStringRef theString2, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFComparisonResult CFStringCompare (CFStringRef* theString1, CFStringRef* theString2, CFStringCompareFlags compareOptions);

    // extern Boolean CFStringFindWithOptionsAndLocale (CFStringRef theString, CFStringRef stringToFind, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFLocaleRef locale, CFRange *result) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringFindWithOptionsAndLocale (CFStringRef* theString, CFStringRef* stringToFind, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFLocaleRef* locale, CFRange* result);

    // extern Boolean CFStringFindWithOptions (CFStringRef theString, CFStringRef stringToFind, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFRange *result) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringFindWithOptions (CFStringRef* theString, CFStringRef* stringToFind, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFRange* result);

    // extern CFArrayRef CFStringCreateArrayWithFindResults (CFAllocatorRef alloc, CFStringRef theString, CFStringRef stringToFind, CFRange rangeToSearch, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFStringCreateArrayWithFindResults (CFAllocatorRef* alloc, CFStringRef* theString, CFStringRef* stringToFind, CFRange rangeToSearch, CFStringCompareFlags compareOptions);

    // extern CFRange CFStringFind (CFStringRef theString, CFStringRef stringToFind, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRange CFStringFind (CFStringRef* theString, CFStringRef* stringToFind, CFStringCompareFlags compareOptions);

    // extern Boolean CFStringHasPrefix (CFStringRef theString, CFStringRef prefix) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringHasPrefix (CFStringRef* theString, CFStringRef* prefix);

    // extern Boolean CFStringHasSuffix (CFStringRef theString, CFStringRef suffix) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringHasSuffix (CFStringRef* theString, CFStringRef* suffix);

    // extern CFRange CFStringGetRangeOfComposedCharactersAtIndex (CFStringRef theString, CFIndex theIndex) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRange CFStringGetRangeOfComposedCharactersAtIndex (CFStringRef* theString, nint theIndex);

    // extern Boolean CFStringFindCharacterFromSet (CFStringRef theString, CFCharacterSetRef theSet, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFRange *result) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringFindCharacterFromSet (CFStringRef* theString, CFCharacterSetRef* theSet, CFRange rangeToSearch, CFStringCompareFlags searchOptions, CFRange* result);

    // extern void CFStringGetLineBounds (CFStringRef theString, CFRange range, CFIndex *lineBeginIndex, CFIndex *lineEndIndex, CFIndex *contentsEndIndex) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringGetLineBounds (CFStringRef* theString, CFRange range, nint* lineBeginIndex, nint* lineEndIndex, nint* contentsEndIndex);

    // extern void CFStringGetParagraphBounds (CFStringRef string, CFRange range, CFIndex *parBeginIndex, CFIndex *parEndIndex, CFIndex *contentsEndIndex) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringGetParagraphBounds (CFStringRef* @string, CFRange range, nint* parBeginIndex, nint* parEndIndex, nint* contentsEndIndex);

    // extern CFIndex CFStringGetHyphenationLocationBeforeIndex (CFStringRef string, CFIndex location, CFRange limitRange, CFOptionFlags options, CFLocaleRef locale, UTF32Char *character) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.2))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (4,2)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFStringGetHyphenationLocationBeforeIndex (CFStringRef* @string, nint location, CFRange limitRange, nuint options, CFLocaleRef* locale, uint* character);

    // extern Boolean CFStringIsHyphenationAvailableForLocale (CFLocaleRef locale) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.3))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringIsHyphenationAvailableForLocale (CFLocaleRef* locale);

    // extern CFStringRef CFStringCreateByCombiningStrings (CFAllocatorRef alloc, CFArrayRef theArray, CFStringRef separatorString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringCreateByCombiningStrings (CFAllocatorRef* alloc, CFArrayRef* theArray, CFStringRef* separatorString);

    // extern CFArrayRef CFStringCreateArrayBySeparatingStrings (CFAllocatorRef alloc, CFStringRef theString, CFStringRef separatorString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFStringCreateArrayBySeparatingStrings (CFAllocatorRef* alloc, CFStringRef* theString, CFStringRef* separatorString);

    // extern SInt32 CFStringGetIntValue (CFStringRef str) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe int CFStringGetIntValue (CFStringRef* str);

    // extern double CFStringGetDoubleValue (CFStringRef str) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe double CFStringGetDoubleValue (CFStringRef* str);

    // extern void CFStringAppend (CFMutableStringRef theString, CFStringRef appendedString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringAppend (CFMutableStringRef* theString, CFStringRef* appendedString);

    // extern void CFStringAppendCharacters (CFMutableStringRef theString, const UniChar *chars, CFIndex numChars) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringAppendCharacters (CFMutableStringRef* theString, ushort* chars, nint numChars);

    // extern void CFStringAppendPascalString (CFMutableStringRef theString, ConstStr255Param pStr, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringAppendPascalString (CFMutableStringRef* theString, byte* pStr, uint encoding);

    // extern void CFStringAppendCString (CFMutableStringRef theString, const char *cStr, CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringAppendCString (CFMutableStringRef* theString, sbyte* cStr, uint encoding);

    // extern void CFStringAppendFormat (CFMutableStringRef theString, CFDictionaryRef formatOptions, CFStringRef format, ...) __attribute__((format(CFString, 3, 4))) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringAppendFormat (CFMutableStringRef* theString, CFDictionaryRef* formatOptions, CFStringRef* format, IntPtr varArgs);

    // extern void CFStringAppendFormatAndArguments (CFMutableStringRef theString, CFDictionaryRef formatOptions, CFStringRef format, va_list arguments) __attribute__((format(CFString, 3, 0))) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringAppendFormatAndArguments (CFMutableStringRef* theString, CFDictionaryRef* formatOptions, CFStringRef* format, sbyte* arguments);

    // extern void CFStringInsert (CFMutableStringRef str, CFIndex idx, CFStringRef insertedStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringInsert (CFMutableStringRef* str, nint idx, CFStringRef* insertedStr);

    // extern void CFStringDelete (CFMutableStringRef theString, CFRange range) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringDelete (CFMutableStringRef* theString, CFRange range);

    // extern void CFStringReplace (CFMutableStringRef theString, CFRange range, CFStringRef replacement) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringReplace (CFMutableStringRef* theString, CFRange range, CFStringRef* replacement);

    // extern void CFStringReplaceAll (CFMutableStringRef theString, CFStringRef replacement) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringReplaceAll (CFMutableStringRef* theString, CFStringRef* replacement);

    // extern CFIndex CFStringFindAndReplace (CFMutableStringRef theString, CFStringRef stringToFind, CFStringRef replacementString, CFRange rangeToSearch, CFStringCompareFlags compareOptions) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFStringFindAndReplace (CFMutableStringRef* theString, CFStringRef* stringToFind, CFStringRef* replacementString, CFRange rangeToSearch, CFStringCompareFlags compareOptions);

    // extern void CFStringSetExternalCharactersNoCopy (CFMutableStringRef theString, UniChar *chars, CFIndex length, CFIndex capacity) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringSetExternalCharactersNoCopy (CFMutableStringRef* theString, ushort* chars, nint length, nint capacity);

    // extern void CFStringPad (CFMutableStringRef theString, CFStringRef padString, CFIndex length, CFIndex indexIntoPad) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringPad (CFMutableStringRef* theString, CFStringRef* padString, nint length, nint indexIntoPad);

    // extern void CFStringTrim (CFMutableStringRef theString, CFStringRef trimString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringTrim (CFMutableStringRef* theString, CFStringRef* trimString);

    // extern void CFStringTrimWhitespace (CFMutableStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringTrimWhitespace (CFMutableStringRef* theString);

    // extern void CFStringLowercase (CFMutableStringRef theString, CFLocaleRef locale) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringLowercase (CFMutableStringRef* theString, CFLocaleRef* locale);

    // extern void CFStringUppercase (CFMutableStringRef theString, CFLocaleRef locale) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringUppercase (CFMutableStringRef* theString, CFLocaleRef* locale);

    // extern void CFStringCapitalize (CFMutableStringRef theString, CFLocaleRef locale) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringCapitalize (CFMutableStringRef* theString, CFLocaleRef* locale);

    // extern void CFStringNormalize (CFMutableStringRef theString, CFStringNormalizationForm theForm) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringNormalize (CFMutableStringRef* theString, CFStringNormalizationForm theForm);

    // extern void CFStringFold (CFMutableStringRef theString, CFStringCompareFlags theFlags, CFLocaleRef theLocale) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringFold (CFMutableStringRef* theString, CFStringCompareFlags theFlags, CFLocaleRef* theLocale);

    // extern Boolean CFStringTransform (CFMutableStringRef string, CFRange *range, CFStringRef transform, Boolean reverse) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringTransform (CFMutableStringRef* @string, CFRange* range, CFStringRef* transform, byte reverse);

    // extern Boolean CFStringIsEncodingAvailable (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern byte CFStringIsEncodingAvailable (uint encoding);

    // extern const CFStringEncoding * CFStringGetListOfAvailableEncodings () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe uint* CFStringGetListOfAvailableEncodings ();

    // extern CFStringRef CFStringGetNameOfEncoding (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringGetNameOfEncoding (uint encoding);

    // extern unsigned long CFStringConvertEncodingToNSStringEncoding (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFStringConvertEncodingToNSStringEncoding (uint encoding);

    // extern CFStringEncoding CFStringConvertNSStringEncodingToEncoding (unsigned long encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern uint CFStringConvertNSStringEncodingToEncoding (nuint encoding);

    // extern UInt32 CFStringConvertEncodingToWindowsCodepage (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern uint CFStringConvertEncodingToWindowsCodepage (uint encoding);

    // extern CFStringEncoding CFStringConvertWindowsCodepageToEncoding (UInt32 codepage) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern uint CFStringConvertWindowsCodepageToEncoding (uint codepage);

    // extern CFStringEncoding CFStringConvertIANACharSetNameToEncoding (CFStringRef theString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe uint CFStringConvertIANACharSetNameToEncoding (CFStringRef* theString);

    // extern CFStringRef CFStringConvertEncodingToIANACharSetName (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringConvertEncodingToIANACharSetName (uint encoding);

    // extern CFStringEncoding CFStringGetMostCompatibleMacStringEncoding (CFStringEncoding encoding) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern uint CFStringGetMostCompatibleMacStringEncoding (uint encoding);

    // void CFStringInitInlineBuffer (CFStringRef str, CFStringInlineBuffer *buf, CFRange range) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringInitInlineBuffer (CFStringRef* str, CFStringInlineBuffer* buf, CFRange range);

    // UniChar CFStringGetCharacterFromInlineBuffer (CFStringInlineBuffer *buf, CFIndex idx) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe ushort CFStringGetCharacterFromInlineBuffer (CFStringInlineBuffer* buf, nint idx);

    // Boolean CFStringIsSurrogateHighCharacter (UniChar character) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern byte CFStringIsSurrogateHighCharacter (ushort character);

    // Boolean CFStringIsSurrogateLowCharacter (UniChar character) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern byte CFStringIsSurrogateLowCharacter (ushort character);

    // UTF32Char CFStringGetLongCharacterForSurrogatePair (UniChar surrogateHigh, UniChar surrogateLow) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern uint CFStringGetLongCharacterForSurrogatePair (ushort surrogateHigh, ushort surrogateLow);

    // Boolean CFStringGetSurrogatePairForLongCharacter (UTF32Char character, UniChar *surrogates) __attribute__((always_inline)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFStringGetSurrogatePairForLongCharacter (uint character, ushort* surrogates);

    // extern void CFShow (CFTypeRef obj) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFShow (void* obj);

    // extern void CFShowStr (CFStringRef str) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFShowStr (CFStringRef* str);

    // extern CFStringRef __CFStringMakeConstantString (const char *cStr) __attribute__((format_arg(1))) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* __CFStringMakeConstantString (sbyte* cStr);

    // extern CFTypeID CFTimeZoneGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFTimeZoneGetTypeID ();

    // extern CFTimeZoneRef CFTimeZoneCopySystem () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTimeZoneRef* CFTimeZoneCopySystem ();

    // extern void CFTimeZoneResetSystem () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern void CFTimeZoneResetSystem ();

    // extern CFTimeZoneRef CFTimeZoneCopyDefault () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTimeZoneRef* CFTimeZoneCopyDefault ();

    // extern void CFTimeZoneSetDefault (CFTimeZoneRef tz) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTimeZoneSetDefault (CFTimeZoneRef* tz);

    // extern CFArrayRef CFTimeZoneCopyKnownNames () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFTimeZoneCopyKnownNames ();

    // extern CFDictionaryRef CFTimeZoneCopyAbbreviationDictionary () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFTimeZoneCopyAbbreviationDictionary ();

    // extern void CFTimeZoneSetAbbreviationDictionary (CFDictionaryRef dict) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTimeZoneSetAbbreviationDictionary (CFDictionaryRef* dict);

    // extern CFTimeZoneRef CFTimeZoneCreate (CFAllocatorRef allocator, CFStringRef name, CFDataRef data) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTimeZoneRef* CFTimeZoneCreate (CFAllocatorRef* allocator, CFStringRef* name, CFDataRef* data);

    // extern CFTimeZoneRef CFTimeZoneCreateWithTimeIntervalFromGMT (CFAllocatorRef allocator, CFTimeInterval ti) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTimeZoneRef* CFTimeZoneCreateWithTimeIntervalFromGMT (CFAllocatorRef* allocator, double ti);

    // extern CFTimeZoneRef CFTimeZoneCreateWithName (CFAllocatorRef allocator, CFStringRef name, Boolean tryAbbrev) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTimeZoneRef* CFTimeZoneCreateWithName (CFAllocatorRef* allocator, CFStringRef* name, byte tryAbbrev);

    // extern CFStringRef CFTimeZoneGetName (CFTimeZoneRef tz) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFTimeZoneGetName (CFTimeZoneRef* tz);

    // extern CFDataRef CFTimeZoneGetData (CFTimeZoneRef tz) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFTimeZoneGetData (CFTimeZoneRef* tz);

    // extern CFTimeInterval CFTimeZoneGetSecondsFromGMT (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe double CFTimeZoneGetSecondsFromGMT (CFTimeZoneRef* tz, double at);

    // extern CFStringRef CFTimeZoneCopyAbbreviation (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFTimeZoneCopyAbbreviation (CFTimeZoneRef* tz, double at);

    // extern Boolean CFTimeZoneIsDaylightSavingTime (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFTimeZoneIsDaylightSavingTime (CFTimeZoneRef* tz, double at);

    // extern CFTimeInterval CFTimeZoneGetDaylightSavingTimeOffset (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe double CFTimeZoneGetDaylightSavingTimeOffset (CFTimeZoneRef* tz, double at);

    // extern CFAbsoluteTime CFTimeZoneGetNextDaylightSavingTimeTransition (CFTimeZoneRef tz, CFAbsoluteTime at) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe double CFTimeZoneGetNextDaylightSavingTimeTransition (CFTimeZoneRef* tz, double at);

    // extern CFStringRef CFTimeZoneCopyLocalizedName (CFTimeZoneRef tz, CFTimeZoneNameStyle style, CFLocaleRef locale) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFTimeZoneCopyLocalizedName (CFTimeZoneRef* tz, CFTimeZoneNameStyle style, CFLocaleRef* locale);

    // extern CFTypeID CFCalendarGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFCalendarGetTypeID ();

    // extern CFCalendarRef CFCalendarCopyCurrent () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCalendarRef* CFCalendarCopyCurrent ();

    // extern CFCalendarRef CFCalendarCreateWithIdentifier (CFAllocatorRef allocator, CFCalendarIdentifier identifier) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCalendarRef* CFCalendarCreateWithIdentifier (CFAllocatorRef* allocator, CFCalendarIdentifier* identifier);

    // extern CFCalendarIdentifier CFCalendarGetIdentifier (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFCalendarIdentifier* CFCalendarGetIdentifier (CFCalendarRef* calendar);

    // extern CFLocaleRef CFCalendarCopyLocale (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleRef* CFCalendarCopyLocale (CFCalendarRef* calendar);

    // extern void CFCalendarSetLocale (CFCalendarRef calendar, CFLocaleRef locale) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCalendarSetLocale (CFCalendarRef* calendar, CFLocaleRef* locale);

    // extern CFTimeZoneRef CFCalendarCopyTimeZone (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTimeZoneRef* CFCalendarCopyTimeZone (CFCalendarRef* calendar);

    // extern void CFCalendarSetTimeZone (CFCalendarRef calendar, CFTimeZoneRef tz) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCalendarSetTimeZone (CFCalendarRef* calendar, CFTimeZoneRef* tz);

    // extern CFIndex CFCalendarGetFirstWeekday (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFCalendarGetFirstWeekday (CFCalendarRef* calendar);

    // extern void CFCalendarSetFirstWeekday (CFCalendarRef calendar, CFIndex wkdy) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCalendarSetFirstWeekday (CFCalendarRef* calendar, nint wkdy);

    // extern CFIndex CFCalendarGetMinimumDaysInFirstWeek (CFCalendarRef calendar) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFCalendarGetMinimumDaysInFirstWeek (CFCalendarRef* calendar);

    // extern void CFCalendarSetMinimumDaysInFirstWeek (CFCalendarRef calendar, CFIndex mwd) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFCalendarSetMinimumDaysInFirstWeek (CFCalendarRef* calendar, nint mwd);

    // extern CFRange CFCalendarGetMinimumRangeOfUnit (CFCalendarRef calendar, CFCalendarUnit unit) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRange CFCalendarGetMinimumRangeOfUnit (CFCalendarRef* calendar, CFCalendarUnit unit);

    // extern CFRange CFCalendarGetMaximumRangeOfUnit (CFCalendarRef calendar, CFCalendarUnit unit) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRange CFCalendarGetMaximumRangeOfUnit (CFCalendarRef* calendar, CFCalendarUnit unit);

    // extern CFRange CFCalendarGetRangeOfUnit (CFCalendarRef calendar, CFCalendarUnit smallerUnit, CFCalendarUnit biggerUnit, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRange CFCalendarGetRangeOfUnit (CFCalendarRef* calendar, CFCalendarUnit smallerUnit, CFCalendarUnit biggerUnit, double at);

    // extern CFIndex CFCalendarGetOrdinalityOfUnit (CFCalendarRef calendar, CFCalendarUnit smallerUnit, CFCalendarUnit biggerUnit, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFCalendarGetOrdinalityOfUnit (CFCalendarRef* calendar, CFCalendarUnit smallerUnit, CFCalendarUnit biggerUnit, double at);

    // extern Boolean CFCalendarGetTimeRangeOfUnit (CFCalendarRef calendar, CFCalendarUnit unit, CFAbsoluteTime at, CFAbsoluteTime *startp, CFTimeInterval *tip) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCalendarGetTimeRangeOfUnit (CFCalendarRef* calendar, CFCalendarUnit unit, double at, double* startp, double* tip);

    // extern Boolean CFCalendarComposeAbsoluteTime (CFCalendarRef calendar, CFAbsoluteTime *at, const char *componentDesc, ...) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCalendarComposeAbsoluteTime (CFCalendarRef* calendar, double* at, sbyte* componentDesc, IntPtr varArgs);

    // extern Boolean CFCalendarDecomposeAbsoluteTime (CFCalendarRef calendar, CFAbsoluteTime at, const char *componentDesc, ...) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCalendarDecomposeAbsoluteTime (CFCalendarRef* calendar, double at, sbyte* componentDesc, IntPtr varArgs);

    // extern Boolean CFCalendarAddComponents (CFCalendarRef calendar, CFAbsoluteTime *at, CFOptionFlags options, const char *componentDesc, ...) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCalendarAddComponents (CFCalendarRef* calendar, double* at, nuint options, sbyte* componentDesc, IntPtr varArgs);

    // extern Boolean CFCalendarGetComponentDifference (CFCalendarRef calendar, CFAbsoluteTime startingAT, CFAbsoluteTime resultAT, CFOptionFlags options, const char *componentDesc, ...) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFCalendarGetComponentDifference (CFCalendarRef* calendar, double startingAT, double resultAT, nuint options, sbyte* componentDesc, IntPtr varArgs);

    // extern CFStringRef CFDateFormatterCreateDateFormatFromTemplate (CFAllocatorRef allocator, CFStringRef tmplate, CFOptionFlags options, CFLocaleRef locale) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFDateFormatterCreateDateFormatFromTemplate (CFAllocatorRef* allocator, CFStringRef* tmplate, nuint options, CFLocaleRef* locale);

    // extern CFTypeID CFDateFormatterGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFDateFormatterGetTypeID ();

    // extern CFDateFormatterRef CFDateFormatterCreateISO8601Formatter (CFAllocatorRef allocator, CFISO8601DateFormatOptions formatOptions) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDateFormatterRef* CFDateFormatterCreateISO8601Formatter (CFAllocatorRef* allocator, CFISO8601DateFormatOptions formatOptions);

    // extern CFDateFormatterRef CFDateFormatterCreate (CFAllocatorRef allocator, CFLocaleRef locale, CFDateFormatterStyle dateStyle, CFDateFormatterStyle timeStyle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDateFormatterRef* CFDateFormatterCreate (CFAllocatorRef* allocator, CFLocaleRef* locale, CFDateFormatterStyle dateStyle, CFDateFormatterStyle timeStyle);

    // extern CFLocaleRef CFDateFormatterGetLocale (CFDateFormatterRef formatter) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleRef* CFDateFormatterGetLocale (CFDateFormatterRef* formatter);

    // extern CFDateFormatterStyle CFDateFormatterGetDateStyle (CFDateFormatterRef formatter) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDateFormatterStyle CFDateFormatterGetDateStyle (CFDateFormatterRef* formatter);

    // extern CFDateFormatterStyle CFDateFormatterGetTimeStyle (CFDateFormatterRef formatter) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDateFormatterStyle CFDateFormatterGetTimeStyle (CFDateFormatterRef* formatter);

    // extern CFStringRef CFDateFormatterGetFormat (CFDateFormatterRef formatter) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFDateFormatterGetFormat (CFDateFormatterRef* formatter);

    // extern void CFDateFormatterSetFormat (CFDateFormatterRef formatter, CFStringRef formatString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDateFormatterSetFormat (CFDateFormatterRef* formatter, CFStringRef* formatString);

    // extern CFStringRef CFDateFormatterCreateStringWithDate (CFAllocatorRef allocator, CFDateFormatterRef formatter, CFDateRef date) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFDateFormatterCreateStringWithDate (CFAllocatorRef* allocator, CFDateFormatterRef* formatter, CFDateRef* date);

    // extern CFStringRef CFDateFormatterCreateStringWithAbsoluteTime (CFAllocatorRef allocator, CFDateFormatterRef formatter, CFAbsoluteTime at) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFDateFormatterCreateStringWithAbsoluteTime (CFAllocatorRef* allocator, CFDateFormatterRef* formatter, double at);

    // extern CFDateRef CFDateFormatterCreateDateFromString (CFAllocatorRef allocator, CFDateFormatterRef formatter, CFStringRef string, CFRange *rangep) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDateRef* CFDateFormatterCreateDateFromString (CFAllocatorRef* allocator, CFDateFormatterRef* formatter, CFStringRef* @string, CFRange* rangep);

    // extern Boolean CFDateFormatterGetAbsoluteTimeFromString (CFDateFormatterRef formatter, CFStringRef string, CFRange *rangep, CFAbsoluteTime *atp) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFDateFormatterGetAbsoluteTimeFromString (CFDateFormatterRef* formatter, CFStringRef* @string, CFRange* rangep, double* atp);

    // extern void CFDateFormatterSetProperty (CFDateFormatterRef formatter, CFStringRef key, CFTypeRef value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFDateFormatterSetProperty (CFDateFormatterRef* formatter, CFStringRef* key, void* value);

    // extern CFTypeRef CFDateFormatterCopyProperty (CFDateFormatterRef formatter, CFDateFormatterKey key) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFDateFormatterCopyProperty (CFDateFormatterRef* formatter, CFDateFormatterKey* key);

    // extern CFTypeID CFErrorGetTypeID () __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFErrorGetTypeID ();

    // extern CFErrorRef CFErrorCreate (CFAllocatorRef allocator, CFErrorDomain domain, CFIndex code, CFDictionaryRef userInfo) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFErrorRef* CFErrorCreate (CFAllocatorRef* allocator, CFErrorDomain* domain, nint code, CFDictionaryRef* userInfo);

    // extern CFErrorRef CFErrorCreateWithUserInfoKeysAndValues (CFAllocatorRef allocator, CFErrorDomain domain, CFIndex code, const void *const *userInfoKeys, const void *const *userInfoValues, CFIndex numUserInfoValues) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFErrorRef* CFErrorCreateWithUserInfoKeysAndValues (CFAllocatorRef* allocator, CFErrorDomain* domain, nint code, void** userInfoKeys, void** userInfoValues, nint numUserInfoValues);

    // extern CFErrorDomain CFErrorGetDomain (CFErrorRef err) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFErrorDomain* CFErrorGetDomain (CFErrorRef* err);

    // extern CFIndex CFErrorGetCode (CFErrorRef err) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFErrorGetCode (CFErrorRef* err);

    // extern CFDictionaryRef CFErrorCopyUserInfo (CFErrorRef err) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFErrorCopyUserInfo (CFErrorRef* err);

    // extern CFStringRef CFErrorCopyDescription (CFErrorRef err) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFErrorCopyDescription (CFErrorRef* err);

    // extern CFStringRef CFErrorCopyFailureReason (CFErrorRef err) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFErrorCopyFailureReason (CFErrorRef* err);

    // extern CFStringRef CFErrorCopyRecoverySuggestion (CFErrorRef err) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFErrorCopyRecoverySuggestion (CFErrorRef* err);

    // extern CFTypeID CFBooleanGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFBooleanGetTypeID ();

    // extern Boolean CFBooleanGetValue (CFBooleanRef boolean) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBooleanGetValue (CFBooleanRef* boolean);

    // extern CFTypeID CFNumberGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFNumberGetTypeID ();

    // extern CFNumberRef CFNumberCreate (CFAllocatorRef allocator, CFNumberType theType, const void *valuePtr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFNumberRef* CFNumberCreate (CFAllocatorRef* allocator, CFNumberType theType, void* valuePtr);

    // extern CFNumberType CFNumberGetType (CFNumberRef number) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFNumberType CFNumberGetType (CFNumberRef* number);

    // extern CFIndex CFNumberGetByteSize (CFNumberRef number) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFNumberGetByteSize (CFNumberRef* number);

    // extern Boolean CFNumberIsFloatType (CFNumberRef number) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNumberIsFloatType (CFNumberRef* number);

    // extern Boolean CFNumberGetValue (CFNumberRef number, CFNumberType theType, void *valuePtr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNumberGetValue (CFNumberRef* number, CFNumberType theType, void* valuePtr);

    // extern CFComparisonResult CFNumberCompare (CFNumberRef number, CFNumberRef otherNumber, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFComparisonResult CFNumberCompare (CFNumberRef* number, CFNumberRef* otherNumber, void* context);

    // extern CFTypeID CFNumberFormatterGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFNumberFormatterGetTypeID ();

    // extern CFNumberFormatterRef CFNumberFormatterCreate (CFAllocatorRef allocator, CFLocaleRef locale, CFNumberFormatterStyle style) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFNumberFormatterRef* CFNumberFormatterCreate (CFAllocatorRef* allocator, CFLocaleRef* locale, CFNumberFormatterStyle style);

    // extern CFLocaleRef CFNumberFormatterGetLocale (CFNumberFormatterRef formatter) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFLocaleRef* CFNumberFormatterGetLocale (CFNumberFormatterRef* formatter);

    // extern CFNumberFormatterStyle CFNumberFormatterGetStyle (CFNumberFormatterRef formatter) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFNumberFormatterStyle CFNumberFormatterGetStyle (CFNumberFormatterRef* formatter);

    // extern CFStringRef CFNumberFormatterGetFormat (CFNumberFormatterRef formatter) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFNumberFormatterGetFormat (CFNumberFormatterRef* formatter);

    // extern void CFNumberFormatterSetFormat (CFNumberFormatterRef formatter, CFStringRef formatString) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNumberFormatterSetFormat (CFNumberFormatterRef* formatter, CFStringRef* formatString);

    // extern CFStringRef CFNumberFormatterCreateStringWithNumber (CFAllocatorRef allocator, CFNumberFormatterRef formatter, CFNumberRef number) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFNumberFormatterCreateStringWithNumber (CFAllocatorRef* allocator, CFNumberFormatterRef* formatter, CFNumberRef* number);

    // extern CFStringRef CFNumberFormatterCreateStringWithValue (CFAllocatorRef allocator, CFNumberFormatterRef formatter, CFNumberType numberType, const void *valuePtr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFNumberFormatterCreateStringWithValue (CFAllocatorRef* allocator, CFNumberFormatterRef* formatter, CFNumberType numberType, void* valuePtr);

    // extern CFNumberRef CFNumberFormatterCreateNumberFromString (CFAllocatorRef allocator, CFNumberFormatterRef formatter, CFStringRef string, CFRange *rangep, CFOptionFlags options) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFNumberRef* CFNumberFormatterCreateNumberFromString (CFAllocatorRef* allocator, CFNumberFormatterRef* formatter, CFStringRef* @string, CFRange* rangep, nuint options);

    // extern Boolean CFNumberFormatterGetValueFromString (CFNumberFormatterRef formatter, CFStringRef string, CFRange *rangep, CFNumberType numberType, void *valuePtr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNumberFormatterGetValueFromString (CFNumberFormatterRef* formatter, CFStringRef* @string, CFRange* rangep, CFNumberType numberType, void* valuePtr);

    // extern void CFNumberFormatterSetProperty (CFNumberFormatterRef formatter, CFNumberFormatterKey key, CFTypeRef value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNumberFormatterSetProperty (CFNumberFormatterRef* formatter, CFNumberFormatterKey* key, void* value);

    // extern CFTypeRef CFNumberFormatterCopyProperty (CFNumberFormatterRef formatter, CFNumberFormatterKey key) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFNumberFormatterCopyProperty (CFNumberFormatterRef* formatter, CFNumberFormatterKey* key);

    // extern Boolean CFNumberFormatterGetDecimalInfoForCurrencyCode (CFStringRef currencyCode, int32_t *defaultFractionDigits, double *roundingIncrement) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNumberFormatterGetDecimalInfoForCurrencyCode (CFStringRef* currencyCode, int* defaultFractionDigits, double* roundingIncrement);

    // extern CFPropertyListRef _Nullable CFPreferencesCopyAppValue (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CFPreferencesCopyAppValue (CFStringRef* key, CFStringRef* applicationID);

    // extern Boolean CFPreferencesGetAppBooleanValue (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID, Boolean * _Nullable keyExistsAndHasValidFormat) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPreferencesGetAppBooleanValue (CFStringRef* key, CFStringRef* applicationID, [NullAllowed] byte* keyExistsAndHasValidFormat);

    // extern CFIndex CFPreferencesGetAppIntegerValue (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID, Boolean * _Nullable keyExistsAndHasValidFormat) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFPreferencesGetAppIntegerValue (CFStringRef* key, CFStringRef* applicationID, [NullAllowed] byte* keyExistsAndHasValidFormat);

    // extern void CFPreferencesSetAppValue (CFStringRef _Nonnull key, CFPropertyListRef _Nullable value, CFStringRef _Nonnull applicationID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFPreferencesSetAppValue (CFStringRef* key, [NullAllowed] void* value, CFStringRef* applicationID);

    // extern void CFPreferencesAddSuitePreferencesToApp (CFStringRef _Nonnull applicationID, CFStringRef _Nonnull suiteID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFPreferencesAddSuitePreferencesToApp (CFStringRef* applicationID, CFStringRef* suiteID);

    // extern void CFPreferencesRemoveSuitePreferencesFromApp (CFStringRef _Nonnull applicationID, CFStringRef _Nonnull suiteID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFPreferencesRemoveSuitePreferencesFromApp (CFStringRef* applicationID, CFStringRef* suiteID);

    // extern Boolean CFPreferencesAppSynchronize (CFStringRef _Nonnull applicationID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPreferencesAppSynchronize (CFStringRef* applicationID);

    // extern CFPropertyListRef _Nullable CFPreferencesCopyValue (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CFPreferencesCopyValue (CFStringRef* key, CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

    // extern CFDictionaryRef _Nonnull CFPreferencesCopyMultiple (CFArrayRef _Nullable keysToFetch, CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFPreferencesCopyMultiple ([NullAllowed] CFArrayRef* keysToFetch, CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

    // extern void CFPreferencesSetValue (CFStringRef _Nonnull key, CFPropertyListRef _Nullable value, CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFPreferencesSetValue (CFStringRef* key, [NullAllowed] void* value, CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

    // extern void CFPreferencesSetMultiple (CFDictionaryRef _Nullable keysToSet, CFArrayRef _Nullable keysToRemove, CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFPreferencesSetMultiple ([NullAllowed] CFDictionaryRef* keysToSet, [NullAllowed] CFArrayRef* keysToRemove, CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

    // extern Boolean CFPreferencesSynchronize (CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPreferencesSynchronize (CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

    // extern CFArrayRef _Nullable CFPreferencesCopyApplicationList (CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Unsupported API")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Unsupported API")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Unsupported API")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Unsupported API")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Unsupported API")]
    [Deprecated (PlatformName.iOS, 7, 0, message: "Unsupported API")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Unsupported API")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "Unsupported API")]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CFPreferencesCopyApplicationList (CFStringRef* userName, CFStringRef* hostName);

    // extern CFArrayRef _Nullable CFPreferencesCopyKeyList (CFStringRef _Nonnull applicationID, CFStringRef _Nonnull userName, CFStringRef _Nonnull hostName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CFPreferencesCopyKeyList (CFStringRef* applicationID, CFStringRef* userName, CFStringRef* hostName);

    // extern Boolean CFPreferencesAppValueIsForced (CFStringRef _Nonnull key, CFStringRef _Nonnull applicationID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPreferencesAppValueIsForced (CFStringRef* key, CFStringRef* applicationID);

    // extern CFTypeID CFURLGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFURLGetTypeID ();

    // extern CFURLRef CFURLCreateWithBytes (CFAllocatorRef allocator, const UInt8 *URLBytes, CFIndex length, CFStringEncoding encoding, CFURLRef baseURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateWithBytes (CFAllocatorRef* allocator, byte* URLBytes, nint length, uint encoding, CFURLRef* baseURL);

    // extern CFDataRef CFURLCreateData (CFAllocatorRef allocator, CFURLRef url, CFStringEncoding encoding, Boolean escapeWhitespace) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFURLCreateData (CFAllocatorRef* allocator, CFURLRef* url, uint encoding, byte escapeWhitespace);

    // extern CFURLRef CFURLCreateWithString (CFAllocatorRef allocator, CFStringRef URLString, CFURLRef baseURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateWithString (CFAllocatorRef* allocator, CFStringRef* URLString, CFURLRef* baseURL);

    // extern CFURLRef CFURLCreateAbsoluteURLWithBytes (CFAllocatorRef alloc, const UInt8 *relativeURLBytes, CFIndex length, CFStringEncoding encoding, CFURLRef baseURL, Boolean useCompatibilityMode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateAbsoluteURLWithBytes (CFAllocatorRef* alloc, byte* relativeURLBytes, nint length, uint encoding, CFURLRef* baseURL, byte useCompatibilityMode);

    // extern CFURLRef CFURLCreateWithFileSystemPath (CFAllocatorRef allocator, CFStringRef filePath, CFURLPathStyle pathStyle, Boolean isDirectory) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateWithFileSystemPath (CFAllocatorRef* allocator, CFStringRef* filePath, CFURLPathStyle pathStyle, byte isDirectory);

    // extern CFURLRef CFURLCreateFromFileSystemRepresentation (CFAllocatorRef allocator, const UInt8 *buffer, CFIndex bufLen, Boolean isDirectory) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateFromFileSystemRepresentation (CFAllocatorRef* allocator, byte* buffer, nint bufLen, byte isDirectory);

    // extern CFURLRef CFURLCreateWithFileSystemPathRelativeToBase (CFAllocatorRef allocator, CFStringRef filePath, CFURLPathStyle pathStyle, Boolean isDirectory, CFURLRef baseURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateWithFileSystemPathRelativeToBase (CFAllocatorRef* allocator, CFStringRef* filePath, CFURLPathStyle pathStyle, byte isDirectory, CFURLRef* baseURL);

    // extern CFURLRef CFURLCreateFromFileSystemRepresentationRelativeToBase (CFAllocatorRef allocator, const UInt8 *buffer, CFIndex bufLen, Boolean isDirectory, CFURLRef baseURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateFromFileSystemRepresentationRelativeToBase (CFAllocatorRef* allocator, byte* buffer, nint bufLen, byte isDirectory, CFURLRef* baseURL);

    // extern Boolean CFURLGetFileSystemRepresentation (CFURLRef url, Boolean resolveAgainstBase, UInt8 *buffer, CFIndex maxBufLen) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLGetFileSystemRepresentation (CFURLRef* url, byte resolveAgainstBase, byte* buffer, nint maxBufLen);

    // extern CFURLRef CFURLCopyAbsoluteURL (CFURLRef relativeURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCopyAbsoluteURL (CFURLRef* relativeURL);

    // extern CFStringRef CFURLGetString (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLGetString (CFURLRef* anURL);

    // extern CFURLRef CFURLGetBaseURL (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLGetBaseURL (CFURLRef* anURL);

    // extern Boolean CFURLCanBeDecomposed (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLCanBeDecomposed (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyScheme (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyScheme (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyNetLocation (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyNetLocation (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyPath (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyPath (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyStrictPath (CFURLRef anURL, Boolean *isAbsolute) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyStrictPath (CFURLRef* anURL, byte* isAbsolute);

    // extern CFStringRef CFURLCopyFileSystemPath (CFURLRef anURL, CFURLPathStyle pathStyle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyFileSystemPath (CFURLRef* anURL, CFURLPathStyle pathStyle);

    // extern Boolean CFURLHasDirectoryPath (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLHasDirectoryPath (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyResourceSpecifier (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyResourceSpecifier (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyHostName (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyHostName (CFURLRef* anURL);

    // extern SInt32 CFURLGetPortNumber (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe int CFURLGetPortNumber (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyUserName (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyUserName (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyPassword (CFURLRef anURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyPassword (CFURLRef* anURL);

    // extern CFStringRef CFURLCopyParameterString (CFURLRef anURL, CFStringRef charactersToLeaveEscaped) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyParameterString (CFURLRef* anURL, CFStringRef* charactersToLeaveEscaped);

    // extern CFStringRef CFURLCopyQueryString (CFURLRef anURL, CFStringRef charactersToLeaveEscaped) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyQueryString (CFURLRef* anURL, CFStringRef* charactersToLeaveEscaped);

    // extern CFStringRef CFURLCopyFragment (CFURLRef anURL, CFStringRef charactersToLeaveEscaped) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyFragment (CFURLRef* anURL, CFStringRef* charactersToLeaveEscaped);

    // extern CFStringRef CFURLCopyLastPathComponent (CFURLRef url) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyLastPathComponent (CFURLRef* url);

    // extern CFStringRef CFURLCopyPathExtension (CFURLRef url) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCopyPathExtension (CFURLRef* url);

    // extern CFURLRef CFURLCreateCopyAppendingPathComponent (CFAllocatorRef allocator, CFURLRef url, CFStringRef pathComponent, Boolean isDirectory) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateCopyAppendingPathComponent (CFAllocatorRef* allocator, CFURLRef* url, CFStringRef* pathComponent, byte isDirectory);

    // extern CFURLRef CFURLCreateCopyDeletingLastPathComponent (CFAllocatorRef allocator, CFURLRef url) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateCopyDeletingLastPathComponent (CFAllocatorRef* allocator, CFURLRef* url);

    // extern CFURLRef CFURLCreateCopyAppendingPathExtension (CFAllocatorRef allocator, CFURLRef url, CFStringRef extension) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateCopyAppendingPathExtension (CFAllocatorRef* allocator, CFURLRef* url, CFStringRef* extension);

    // extern CFURLRef CFURLCreateCopyDeletingPathExtension (CFAllocatorRef allocator, CFURLRef url) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateCopyDeletingPathExtension (CFAllocatorRef* allocator, CFURLRef* url);

    // extern CFIndex CFURLGetBytes (CFURLRef url, UInt8 *buffer, CFIndex bufferLength) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFURLGetBytes (CFURLRef* url, byte* buffer, nint bufferLength);

    // extern CFRange CFURLGetByteRangeForComponent (CFURLRef url, CFURLComponentType component, CFRange *rangeIncludingSeparators) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRange CFURLGetByteRangeForComponent (CFURLRef* url, CFURLComponentType component, CFRange* rangeIncludingSeparators);

    // extern CFStringRef CFURLCreateStringByReplacingPercentEscapes (CFAllocatorRef allocator, CFStringRef originalString, CFStringRef charactersToLeaveEscaped) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCreateStringByReplacingPercentEscapes (CFAllocatorRef* allocator, CFStringRef* originalString, CFStringRef* charactersToLeaveEscaped);

    // extern CFStringRef CFURLCreateStringByReplacingPercentEscapesUsingEncoding (CFAllocatorRef allocator, CFStringRef origString, CFStringRef charsToLeaveEscaped, CFStringEncoding encoding) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.11))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
    [Deprecated (PlatformName.iOS, 9, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
    [Deprecated (PlatformName.MacOSX, 10, 11, message: "Use [NSString stringByRemovingPercentEncoding] or CFURLCreateStringByReplacingPercentEscapes() instead, which always uses the recommended UTF-8 encoding.")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCreateStringByReplacingPercentEscapesUsingEncoding (CFAllocatorRef* allocator, CFStringRef* origString, CFStringRef* charsToLeaveEscaped, uint encoding);

    // extern CFStringRef CFURLCreateStringByAddingPercentEscapes (CFAllocatorRef allocator, CFStringRef originalString, CFStringRef charactersToLeaveUnescaped, CFStringRef legalURLCharactersToBeEscaped, CFStringEncoding encoding) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=9.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.11))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
    [Deprecated (PlatformName.iOS, 9, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
    [Deprecated (PlatformName.MacOSX, 10, 11, message: "Use [NSString stringByAddingPercentEncodingWithAllowedCharacters:] instead, which always uses the recommended UTF-8 encoding, and which encodes for a specific URL component or subcomponent (since each URL component or subcomponent has different rules for what characters are valid).")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFURLCreateStringByAddingPercentEscapes (CFAllocatorRef* allocator, CFStringRef* originalString, CFStringRef* charactersToLeaveUnescaped, CFStringRef* legalURLCharactersToBeEscaped, uint encoding);

    // extern Boolean CFURLIsFileReferenceURL (CFURLRef url) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(macos, introduced=10.9)));
    [Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLIsFileReferenceURL (CFURLRef* url);

    // extern CFURLRef CFURLCreateFileReferenceURL (CFAllocatorRef allocator, CFURLRef url, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateFileReferenceURL (CFAllocatorRef* allocator, CFURLRef* url, CFErrorRef** error);

    // extern CFURLRef CFURLCreateFilePathURL (CFAllocatorRef allocator, CFURLRef url, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateFilePathURL (CFAllocatorRef* allocator, CFURLRef* url, CFErrorRef** error);

    // extern CFURLRef CFURLCreateFromFSRef (CFAllocatorRef allocator, const struct FSRef *fsRef) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
    [Deprecated (PlatformName.iOS, 7, 0, message: "Not supported")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "Not supported")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateFromFSRef (CFAllocatorRef* allocator, FSRef* fsRef);

    // extern Boolean CFURLGetFSRef (CFURLRef url, struct FSRef *fsRef) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
    [Deprecated (PlatformName.iOS, 7, 0, message: "Not supported")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "Not supported")]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLGetFSRef (CFURLRef* url, FSRef* fsRef);

    // extern Boolean CFURLCopyResourcePropertyForKey (CFURLRef url, CFStringRef key, void *propertyValueTypeRefPtr, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLCopyResourcePropertyForKey (CFURLRef* url, CFStringRef* key, void* propertyValueTypeRefPtr, CFErrorRef** error);

    // extern CFDictionaryRef CFURLCopyResourcePropertiesForKeys (CFURLRef url, CFArrayRef keys, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFURLCopyResourcePropertiesForKeys (CFURLRef* url, CFArrayRef* keys, CFErrorRef** error);

    // extern Boolean CFURLSetResourcePropertyForKey (CFURLRef url, CFStringRef key, CFTypeRef propertyValue, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLSetResourcePropertyForKey (CFURLRef* url, CFStringRef* key, void* propertyValue, CFErrorRef** error);

    // extern Boolean CFURLSetResourcePropertiesForKeys (CFURLRef url, CFDictionaryRef keyedPropertyValues, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLSetResourcePropertiesForKeys (CFURLRef* url, CFDictionaryRef* keyedPropertyValues, CFErrorRef** error);

    // extern void CFURLClearResourcePropertyCacheForKey (CFURLRef url, CFStringRef key) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFURLClearResourcePropertyCacheForKey (CFURLRef* url, CFStringRef* key);

    // extern void CFURLClearResourcePropertyCache (CFURLRef url) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFURLClearResourcePropertyCache (CFURLRef* url);

    // extern void CFURLSetTemporaryResourcePropertyForKey (CFURLRef url, CFStringRef key, CFTypeRef propertyValue) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFURLSetTemporaryResourcePropertyForKey (CFURLRef* url, CFStringRef* key, void* propertyValue);

    // extern Boolean CFURLResourceIsReachable (CFURLRef url, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLResourceIsReachable (CFURLRef* url, CFErrorRef** error);

    // extern CFDataRef CFURLCreateBookmarkData (CFAllocatorRef allocator, CFURLRef url, CFURLBookmarkCreationOptions options, CFArrayRef resourcePropertiesToInclude, CFURLRef relativeToURL, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFURLCreateBookmarkData (CFAllocatorRef* allocator, CFURLRef* url, CFURLBookmarkCreationOptions options, CFArrayRef* resourcePropertiesToInclude, CFURLRef* relativeToURL, CFErrorRef** error);

    // extern CFURLRef CFURLCreateByResolvingBookmarkData (CFAllocatorRef allocator, CFDataRef bookmark, CFURLBookmarkResolutionOptions options, CFURLRef relativeToURL, CFArrayRef resourcePropertiesToInclude, Boolean *isStale, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFURLCreateByResolvingBookmarkData (CFAllocatorRef* allocator, CFDataRef* bookmark, CFURLBookmarkResolutionOptions options, CFURLRef* relativeToURL, CFArrayRef* resourcePropertiesToInclude, byte* isStale, CFErrorRef** error);

    // extern CFDictionaryRef CFURLCreateResourcePropertiesForKeysFromBookmarkData (CFAllocatorRef allocator, CFArrayRef resourcePropertiesToReturn, CFDataRef bookmark) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFURLCreateResourcePropertiesForKeysFromBookmarkData (CFAllocatorRef* allocator, CFArrayRef* resourcePropertiesToReturn, CFDataRef* bookmark);

    // extern CFTypeRef CFURLCreateResourcePropertyForKeyFromBookmarkData (CFAllocatorRef allocator, CFStringRef resourcePropertyKey, CFDataRef bookmark) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFURLCreateResourcePropertyForKeyFromBookmarkData (CFAllocatorRef* allocator, CFStringRef* resourcePropertyKey, CFDataRef* bookmark);

    // extern CFDataRef CFURLCreateBookmarkDataFromFile (CFAllocatorRef allocator, CFURLRef fileURL, CFErrorRef *errorRef) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFURLCreateBookmarkDataFromFile (CFAllocatorRef* allocator, CFURLRef* fileURL, CFErrorRef** errorRef);

    // extern Boolean CFURLWriteBookmarkDataToFile (CFDataRef bookmarkRef, CFURLRef fileURL, CFURLBookmarkFileCreationOptions options, CFErrorRef *errorRef) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLWriteBookmarkDataToFile (CFDataRef* bookmarkRef, CFURLRef* fileURL, nuint options, CFErrorRef** errorRef);

    // extern CFDataRef CFURLCreateBookmarkDataFromAliasRecord (CFAllocatorRef allocatorRef, CFDataRef aliasRecordDataRef) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, unavailable))) __attribute__((availability(macos, introduced=10.6)));
    [NoWatch, NoTV, NoiOS, Mac (10,6)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFURLCreateBookmarkDataFromAliasRecord (CFAllocatorRef* allocatorRef, CFDataRef* aliasRecordDataRef);

    // extern Boolean CFURLStartAccessingSecurityScopedResource (CFURLRef url) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLStartAccessingSecurityScopedResource (CFURLRef* url);

    // extern void CFURLStopAccessingSecurityScopedResource (CFURLRef url) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFURLStopAccessingSecurityScopedResource (CFURLRef* url);

    // extern CFTypeID CFRunLoopGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFRunLoopGetTypeID ();

    // extern CFRunLoopRef CFRunLoopGetCurrent () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopRef* CFRunLoopGetCurrent ();

    // extern CFRunLoopRef CFRunLoopGetMain () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopRef* CFRunLoopGetMain ();

    // extern CFRunLoopMode CFRunLoopCopyCurrentMode (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopMode* CFRunLoopCopyCurrentMode (CFRunLoopRef* rl);

    // extern CFArrayRef CFRunLoopCopyAllModes (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFRunLoopCopyAllModes (CFRunLoopRef* rl);

    // extern void CFRunLoopAddCommonMode (CFRunLoopRef rl, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopAddCommonMode (CFRunLoopRef* rl, CFRunLoopMode* mode);

    // extern CFAbsoluteTime CFRunLoopGetNextTimerFireDate (CFRunLoopRef rl, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe double CFRunLoopGetNextTimerFireDate (CFRunLoopRef* rl, CFRunLoopMode* mode);

    // extern void CFRunLoopRun () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern void CFRunLoopRun ();

    // extern CFRunLoopRunResult CFRunLoopRunInMode (CFRunLoopMode mode, CFTimeInterval seconds, Boolean returnAfterSourceHandled) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopRunResult CFRunLoopRunInMode (CFRunLoopMode* mode, double seconds, byte returnAfterSourceHandled);

    // extern Boolean CFRunLoopIsWaiting (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopIsWaiting (CFRunLoopRef* rl);

    // extern void CFRunLoopWakeUp (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopWakeUp (CFRunLoopRef* rl);

    // extern void CFRunLoopStop (CFRunLoopRef rl) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopStop (CFRunLoopRef* rl);

    // extern void CFRunLoopPerformBlock (CFRunLoopRef rl, CFTypeRef mode, void (^block)()) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopPerformBlock (CFRunLoopRef* rl, void* mode, Action block);

    // extern Boolean CFRunLoopContainsSource (CFRunLoopRef rl, CFRunLoopSourceRef source, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopContainsSource (CFRunLoopRef* rl, CFRunLoopSourceRef* source, CFRunLoopMode* mode);

    // extern void CFRunLoopAddSource (CFRunLoopRef rl, CFRunLoopSourceRef source, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopAddSource (CFRunLoopRef* rl, CFRunLoopSourceRef* source, CFRunLoopMode* mode);

    // extern void CFRunLoopRemoveSource (CFRunLoopRef rl, CFRunLoopSourceRef source, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopRemoveSource (CFRunLoopRef* rl, CFRunLoopSourceRef* source, CFRunLoopMode* mode);

    // extern Boolean CFRunLoopContainsObserver (CFRunLoopRef rl, CFRunLoopObserverRef observer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopContainsObserver (CFRunLoopRef* rl, CFRunLoopObserverRef* observer, CFRunLoopMode* mode);

    // extern void CFRunLoopAddObserver (CFRunLoopRef rl, CFRunLoopObserverRef observer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopAddObserver (CFRunLoopRef* rl, CFRunLoopObserverRef* observer, CFRunLoopMode* mode);

    // extern void CFRunLoopRemoveObserver (CFRunLoopRef rl, CFRunLoopObserverRef observer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopRemoveObserver (CFRunLoopRef* rl, CFRunLoopObserverRef* observer, CFRunLoopMode* mode);

    // extern Boolean CFRunLoopContainsTimer (CFRunLoopRef rl, CFRunLoopTimerRef timer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopContainsTimer (CFRunLoopRef* rl, CFRunLoopTimerRef* timer, CFRunLoopMode* mode);

    // extern void CFRunLoopAddTimer (CFRunLoopRef rl, CFRunLoopTimerRef timer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopAddTimer (CFRunLoopRef* rl, CFRunLoopTimerRef* timer, CFRunLoopMode* mode);

    // extern void CFRunLoopRemoveTimer (CFRunLoopRef rl, CFRunLoopTimerRef timer, CFRunLoopMode mode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopRemoveTimer (CFRunLoopRef* rl, CFRunLoopTimerRef* timer, CFRunLoopMode* mode);

    // extern CFTypeID CFRunLoopSourceGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFRunLoopSourceGetTypeID ();

    // extern CFRunLoopSourceRef CFRunLoopSourceCreate (CFAllocatorRef allocator, CFIndex order, CFRunLoopSourceContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopSourceRef* CFRunLoopSourceCreate (CFAllocatorRef* allocator, nint order, CFRunLoopSourceContext* context);

    // extern CFIndex CFRunLoopSourceGetOrder (CFRunLoopSourceRef source) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFRunLoopSourceGetOrder (CFRunLoopSourceRef* source);

    // extern void CFRunLoopSourceInvalidate (CFRunLoopSourceRef source) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopSourceInvalidate (CFRunLoopSourceRef* source);

    // extern Boolean CFRunLoopSourceIsValid (CFRunLoopSourceRef source) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopSourceIsValid (CFRunLoopSourceRef* source);

    // extern void CFRunLoopSourceGetContext (CFRunLoopSourceRef source, CFRunLoopSourceContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopSourceGetContext (CFRunLoopSourceRef* source, CFRunLoopSourceContext* context);

    // extern void CFRunLoopSourceSignal (CFRunLoopSourceRef source) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopSourceSignal (CFRunLoopSourceRef* source);

    // extern CFTypeID CFRunLoopObserverGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFRunLoopObserverGetTypeID ();

    // extern CFRunLoopObserverRef CFRunLoopObserverCreate (CFAllocatorRef allocator, CFOptionFlags activities, Boolean repeats, CFIndex order, CFRunLoopObserverCallBack callout, CFRunLoopObserverContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopObserverRef* CFRunLoopObserverCreate (CFAllocatorRef* allocator, nuint activities, byte repeats, nint order, CFRunLoopObserverCallBack* callout, CFRunLoopObserverContext* context);

    // extern CFRunLoopObserverRef CFRunLoopObserverCreateWithHandler (CFAllocatorRef allocator, CFOptionFlags activities, Boolean repeats, CFIndex order, void (^block)(CFRunLoopObserverRef, CFRunLoopActivity)) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopObserverRef* CFRunLoopObserverCreateWithHandler (CFAllocatorRef* allocator, nuint activities, byte repeats, nint order, Action<CoreFoundation.CFRunLoopObserverRef*, CFRunLoopActivity> block);

    // extern CFOptionFlags CFRunLoopObserverGetActivities (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CFRunLoopObserverGetActivities (CFRunLoopObserverRef* observer);

    // extern Boolean CFRunLoopObserverDoesRepeat (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopObserverDoesRepeat (CFRunLoopObserverRef* observer);

    // extern CFIndex CFRunLoopObserverGetOrder (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFRunLoopObserverGetOrder (CFRunLoopObserverRef* observer);

    // extern void CFRunLoopObserverInvalidate (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopObserverInvalidate (CFRunLoopObserverRef* observer);

    // extern Boolean CFRunLoopObserverIsValid (CFRunLoopObserverRef observer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopObserverIsValid (CFRunLoopObserverRef* observer);

    // extern void CFRunLoopObserverGetContext (CFRunLoopObserverRef observer, CFRunLoopObserverContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopObserverGetContext (CFRunLoopObserverRef* observer, CFRunLoopObserverContext* context);

    // extern CFTypeID CFRunLoopTimerGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFRunLoopTimerGetTypeID ();

    // extern CFRunLoopTimerRef CFRunLoopTimerCreate (CFAllocatorRef allocator, CFAbsoluteTime fireDate, CFTimeInterval interval, CFOptionFlags flags, CFIndex order, CFRunLoopTimerCallBack callout, CFRunLoopTimerContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopTimerRef* CFRunLoopTimerCreate (CFAllocatorRef* allocator, double fireDate, double interval, nuint flags, nint order, CFRunLoopTimerCallBack* callout, CFRunLoopTimerContext* context);

    // extern CFRunLoopTimerRef CFRunLoopTimerCreateWithHandler (CFAllocatorRef allocator, CFAbsoluteTime fireDate, CFTimeInterval interval, CFOptionFlags flags, CFIndex order, void (^block)(CFRunLoopTimerRef)) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopTimerRef* CFRunLoopTimerCreateWithHandler (CFAllocatorRef* allocator, double fireDate, double interval, nuint flags, nint order, Action<CoreFoundation.CFRunLoopTimerRef*> block);

    // extern CFAbsoluteTime CFRunLoopTimerGetNextFireDate (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe double CFRunLoopTimerGetNextFireDate (CFRunLoopTimerRef* timer);

    // extern void CFRunLoopTimerSetNextFireDate (CFRunLoopTimerRef timer, CFAbsoluteTime fireDate) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopTimerSetNextFireDate (CFRunLoopTimerRef* timer, double fireDate);

    // extern CFTimeInterval CFRunLoopTimerGetInterval (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe double CFRunLoopTimerGetInterval (CFRunLoopTimerRef* timer);

    // extern Boolean CFRunLoopTimerDoesRepeat (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopTimerDoesRepeat (CFRunLoopTimerRef* timer);

    // extern CFIndex CFRunLoopTimerGetOrder (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFRunLoopTimerGetOrder (CFRunLoopTimerRef* timer);

    // extern void CFRunLoopTimerInvalidate (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopTimerInvalidate (CFRunLoopTimerRef* timer);

    // extern Boolean CFRunLoopTimerIsValid (CFRunLoopTimerRef timer) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFRunLoopTimerIsValid (CFRunLoopTimerRef* timer);

    // extern void CFRunLoopTimerGetContext (CFRunLoopTimerRef timer, CFRunLoopTimerContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopTimerGetContext (CFRunLoopTimerRef* timer, CFRunLoopTimerContext* context);

    // extern CFTimeInterval CFRunLoopTimerGetTolerance (CFRunLoopTimerRef timer) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(macos, introduced=10.9))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe double CFRunLoopTimerGetTolerance (CFRunLoopTimerRef* timer);

    // extern void CFRunLoopTimerSetTolerance (CFRunLoopTimerRef timer, CFTimeInterval tolerance) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(macos, introduced=10.9))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFRunLoopTimerSetTolerance (CFRunLoopTimerRef* timer, double tolerance);

    // extern CFTypeID CFSocketGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFSocketGetTypeID ();

    // extern CFSocketRef CFSocketCreate (CFAllocatorRef allocator, SInt32 protocolFamily, SInt32 socketType, SInt32 protocol, CFOptionFlags callBackTypes, CFSocketCallBack callout, const CFSocketContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketRef* CFSocketCreate (CFAllocatorRef* allocator, int protocolFamily, int socketType, int protocol, nuint callBackTypes, CFSocketCallBack* callout, CFSocketContext* context);

    // extern CFSocketRef CFSocketCreateWithNative (CFAllocatorRef allocator, CFSocketNativeHandle sock, CFOptionFlags callBackTypes, CFSocketCallBack callout, const CFSocketContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketRef* CFSocketCreateWithNative (CFAllocatorRef* allocator, int sock, nuint callBackTypes, CFSocketCallBack* callout, CFSocketContext* context);

    // extern CFSocketRef CFSocketCreateWithSocketSignature (CFAllocatorRef allocator, const CFSocketSignature *signature, CFOptionFlags callBackTypes, CFSocketCallBack callout, const CFSocketContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketRef* CFSocketCreateWithSocketSignature (CFAllocatorRef* allocator, CFSocketSignature* signature, nuint callBackTypes, CFSocketCallBack* callout, CFSocketContext* context);

    // extern CFSocketRef CFSocketCreateConnectedToSocketSignature (CFAllocatorRef allocator, const CFSocketSignature *signature, CFOptionFlags callBackTypes, CFSocketCallBack callout, const CFSocketContext *context, CFTimeInterval timeout) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketRef* CFSocketCreateConnectedToSocketSignature (CFAllocatorRef* allocator, CFSocketSignature* signature, nuint callBackTypes, CFSocketCallBack* callout, CFSocketContext* context, double timeout);

    // extern CFSocketError CFSocketSetAddress (CFSocketRef s, CFDataRef address) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketError CFSocketSetAddress (CFSocketRef* s, CFDataRef* address);

    // extern CFSocketError CFSocketConnectToAddress (CFSocketRef s, CFDataRef address, CFTimeInterval timeout) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketError CFSocketConnectToAddress (CFSocketRef* s, CFDataRef* address, double timeout);

    // extern void CFSocketInvalidate (CFSocketRef s) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSocketInvalidate (CFSocketRef* s);

    // extern Boolean CFSocketIsValid (CFSocketRef s) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFSocketIsValid (CFSocketRef* s);

    // extern CFDataRef CFSocketCopyAddress (CFSocketRef s) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFSocketCopyAddress (CFSocketRef* s);

    // extern CFDataRef CFSocketCopyPeerAddress (CFSocketRef s) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFSocketCopyPeerAddress (CFSocketRef* s);

    // extern void CFSocketGetContext (CFSocketRef s, CFSocketContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSocketGetContext (CFSocketRef* s, CFSocketContext* context);

    // extern CFSocketNativeHandle CFSocketGetNative (CFSocketRef s) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe int CFSocketGetNative (CFSocketRef* s);

    // extern CFRunLoopSourceRef CFSocketCreateRunLoopSource (CFAllocatorRef allocator, CFSocketRef s, CFIndex order) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopSourceRef* CFSocketCreateRunLoopSource (CFAllocatorRef* allocator, CFSocketRef* s, nint order);

    // extern CFOptionFlags CFSocketGetSocketFlags (CFSocketRef s) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CFSocketGetSocketFlags (CFSocketRef* s);

    // extern void CFSocketSetSocketFlags (CFSocketRef s, CFOptionFlags flags) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSocketSetSocketFlags (CFSocketRef* s, nuint flags);

    // extern void CFSocketDisableCallBacks (CFSocketRef s, CFOptionFlags callBackTypes) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSocketDisableCallBacks (CFSocketRef* s, nuint callBackTypes);

    // extern void CFSocketEnableCallBacks (CFSocketRef s, CFOptionFlags callBackTypes) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSocketEnableCallBacks (CFSocketRef* s, nuint callBackTypes);

    // extern CFSocketError CFSocketSendData (CFSocketRef s, CFDataRef address, CFDataRef data, CFTimeInterval timeout) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketError CFSocketSendData (CFSocketRef* s, CFDataRef* address, CFDataRef* data, double timeout);

    // extern CFSocketError CFSocketRegisterValue (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name, CFPropertyListRef value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketError CFSocketRegisterValue (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name, void* value);

    // extern CFSocketError CFSocketCopyRegisteredValue (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name, CFPropertyListRef *value, CFDataRef *nameServerAddress) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketError CFSocketCopyRegisteredValue (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name, void** value, CFDataRef** nameServerAddress);

    // extern CFSocketError CFSocketRegisterSocketSignature (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name, const CFSocketSignature *signature) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketError CFSocketRegisterSocketSignature (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name, CFSocketSignature* signature);

    // extern CFSocketError CFSocketCopyRegisteredSocketSignature (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name, CFSocketSignature *signature, CFDataRef *nameServerAddress) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketError CFSocketCopyRegisteredSocketSignature (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name, CFSocketSignature* signature, CFDataRef** nameServerAddress);

    // extern CFSocketError CFSocketUnregister (const CFSocketSignature *nameServerSignature, CFTimeInterval timeout, CFStringRef name) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSocketError CFSocketUnregister (CFSocketSignature* nameServerSignature, double timeout, CFStringRef* name);

    // extern void CFSocketSetDefaultNameRegistryPortNumber (UInt16 port) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern void CFSocketSetDefaultNameRegistryPortNumber (ushort port);

    // extern UInt16 CFSocketGetDefaultNameRegistryPortNumber () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern ushort CFSocketGetDefaultNameRegistryPortNumber ();

   
    // extern filesec_t filesec_init ();
    [DllImport ("__Internal")]
    
    static extern unsafe filesec_t* filesec_init ();

   
    // extern const char * _Nonnull sel_getName (SEL _Nonnull sel) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.0)));
    [Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe sbyte* sel_getName (Selector sel);

    // extern SEL _Nonnull sel_registerName (const char * _Nonnull str) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.0)));
    [Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe Selector sel_registerName (sbyte* str);

    // extern const char * _Nonnull object_getClassName (id _Nullable obj) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.0)));
    [Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe sbyte* object_getClassName ([NullAllowed] NSObject obj);

    // extern void * _Nullable object_getIndexedIvars (id _Nullable obj) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.0)));
    [Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* object_getIndexedIvars ([NullAllowed] NSObject obj);

    // extern BOOL sel_isMapped (SEL _Nonnull sel) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.0)));
    [Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool sel_isMapped (Selector sel);

    // extern SEL _Nonnull sel_getUid (const char * _Nonnull str) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=1.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.0)));
    [Watch (1,0), TV (9,0), Mac (10,0), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe Selector sel_getUid (sbyte* str);

    // extern void * os_retain (void *object) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void* os_retain (void* @object);

    // extern void os_release (void *object) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void os_release (void* @object);

    // extern dispatch_time_t dispatch_time (dispatch_time_t when, int64_t delta) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern ulong dispatch_time (ulong when, long delta);

    // extern dispatch_time_t dispatch_walltime (const struct timespec * _Nullable when, int64_t delta) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe ulong dispatch_walltime ([NullAllowed] timespec* when, long delta);

    // void _dispatch_object_validate (dispatch_object_t _Nonnull object) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern void _dispatch_object_validate (DispatchObject @object);

    // extern void dispatch_retain (dispatch_object_t _Nonnull object) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_retain (DispatchObject @object);

    // extern void dispatch_release (dispatch_object_t _Nonnull object) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_release (DispatchObject @object);

    // extern void * _Nullable dispatch_get_context (dispatch_object_t _Nonnull object) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((pure)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* dispatch_get_context (DispatchObject @object);

    // extern void dispatch_set_context (dispatch_object_t _Nonnull object, void * _Nullable context) __attribute__((nothrow)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_set_context (DispatchObject @object, [NullAllowed] void* context);

    // extern void dispatch_set_finalizer_f (dispatch_object_t _Nonnull object, dispatch_function_t _Nullable finalizer) __attribute__((nothrow)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_set_finalizer_f (DispatchObject @object, [NullAllowed] dispatch_function_t* finalizer);

    // extern void dispatch_activate (dispatch_object_t _Nonnull object) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12)));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_activate (DispatchObject @object);

    // extern void dispatch_suspend (dispatch_object_t _Nonnull object) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_suspend (DispatchObject @object);

    // extern void dispatch_resume (dispatch_object_t _Nonnull object) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_resume (DispatchObject @object);

    // extern void dispatch_debug (dispatch_object_t _Nonnull object, const char * _Nonnull message, ...) __attribute__((format(printf, 2, 3))) __attribute__((nothrow)) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0, deprecated=6.0))) __attribute__((availability(macos, introduced=10.6, deprecated=10.9)));
    [Introduced (PlatformName.iOS, 4, 0, message: "unsupported interface")]
    [Deprecated (PlatformName.iOS, 6, 0, message: "unsupported interface")]
    [Introduced (PlatformName.MacOSX, 10, 6, message: "unsupported interface")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "unsupported interface")]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_debug (DispatchObject @object, sbyte* message, IntPtr varArgs);

    // extern void dispatch_debugv (dispatch_object_t _Nonnull object, const char * _Nonnull message, va_list ap) __attribute__((format(printf, 2, 0))) __attribute__((nothrow)) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0, deprecated=6.0))) __attribute__((availability(macos, introduced=10.6, deprecated=10.9)));
    [Introduced (PlatformName.iOS, 4, 0, message: "unsupported interface")]
    [Deprecated (PlatformName.iOS, 6, 0, message: "unsupported interface")]
    [Introduced (PlatformName.MacOSX, 10, 6, message: "unsupported interface")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "unsupported interface")]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_debugv (DispatchObject @object, sbyte* message, sbyte* ap);

    // extern qos_class_t qos_class_self () __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern qos_class_t qos_class_self ();

    // extern qos_class_t qos_class_main () __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern qos_class_t qos_class_main ();

    // extern void dispatch_async (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_async (DispatchQueue queue, dispatch_block_t block);

    // extern void dispatch_async_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((nothrow)) __attribute__((nonnull(2))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_async_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

    // extern void dispatch_sync (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_sync (DispatchQueue queue, dispatch_block_t block);

    // extern void dispatch_sync_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((nothrow)) __attribute__((nonnull(2))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_sync_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

    // extern void dispatch_apply (size_t iterations, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(size_t) block) __attribute__((nothrow)) __attribute__((nonnull(2))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_apply (nuint iterations, DispatchQueue queue, Action<nuint> block);

    // extern void dispatch_apply_f (size_t iterations, dispatch_queue_t _Nonnull queue, void * _Nullable context, void (* _Nonnull)(void * _Nullable, size_t) work) __attribute__((nothrow)) __attribute__((nonnull(3))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_apply_f (nuint iterations, DispatchQueue queue, [NullAllowed] void* context, Action<void*, nuint>* work);

    // extern dispatch_queue_t _Nonnull dispatch_get_current_queue () __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((pure)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0, deprecated=6.0))) __attribute__((availability(macos, introduced=10.6, deprecated=10.9)));
    [Introduced (PlatformName.iOS, 4, 0, message: "unsupported interface")]
    [Deprecated (PlatformName.iOS, 6, 0, message: "unsupported interface")]
    [Introduced (PlatformName.MacOSX, 10, 6, message: "unsupported interface")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "unsupported interface")]
    [DllImport ("__Internal")]
    
    static extern DispatchQueue dispatch_get_current_queue ();

    // dispatch_queue_t _Nonnull dispatch_get_main_queue () __attribute__((nothrow)) __attribute__((const)) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern DispatchQueue dispatch_get_main_queue ();

    // extern dispatch_queue_t _Nonnull dispatch_get_global_queue (long identifier, unsigned long flags) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((const)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern DispatchQueue dispatch_get_global_queue (nint identifier, nuint flags);

    // extern dispatch_queue_attr_t _Nonnull dispatch_queue_attr_make_initially_inactive (dispatch_queue_attr_t _Nullable attr) __attribute__((nothrow)) __attribute__((pure)) __attribute__((warn_unused_result)) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12)));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern OS_dispatch_queue_attr dispatch_queue_attr_make_initially_inactive ([NullAllowed] OS_dispatch_queue_attr attr);

    // extern dispatch_queue_attr_t _Nonnull dispatch_queue_attr_make_with_autorelease_frequency (dispatch_queue_attr_t _Nullable attr, dispatch_autorelease_frequency_t frequency) __attribute__((nothrow)) __attribute__((pure)) __attribute__((warn_unused_result)) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12)));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern OS_dispatch_queue_attr dispatch_queue_attr_make_with_autorelease_frequency ([NullAllowed] OS_dispatch_queue_attr attr, dispatch_autorelease_frequency_t frequency);

    // extern dispatch_queue_attr_t _Nonnull dispatch_queue_attr_make_with_qos_class (dispatch_queue_attr_t _Nullable attr, dispatch_qos_class_t qos_class, int relative_priority) __attribute__((nothrow)) __attribute__((pure)) __attribute__((warn_unused_result)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern OS_dispatch_queue_attr dispatch_queue_attr_make_with_qos_class ([NullAllowed] OS_dispatch_queue_attr attr, dispatch_qos_class_t qos_class, int relative_priority);

    // extern dispatch_queue_t _Nonnull dispatch_queue_create_with_target (const char * _Nullable label, dispatch_queue_attr_t _Nullable attr, dispatch_queue_t _Nullable target) asm("_dispatch_queue_create_with_target$V2") __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((ns_returns_retained)) __attribute__((malloc));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe DispatchQueue dispatch_queue_create_with_target ([NullAllowed] sbyte* label, [NullAllowed] OS_dispatch_queue_attr attr, [NullAllowed] DispatchQueue target);

    // extern dispatch_queue_t _Nonnull dispatch_queue_create (const char * _Nullable label, dispatch_queue_attr_t _Nullable attr) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((ns_returns_retained)) __attribute__((malloc));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe DispatchQueue dispatch_queue_create ([NullAllowed] sbyte* label, [NullAllowed] OS_dispatch_queue_attr attr);

    // extern const char * _Nonnull dispatch_queue_get_label (dispatch_queue_t _Nullable queue) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((pure)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe sbyte* dispatch_queue_get_label ([NullAllowed] DispatchQueue queue);

    // extern dispatch_qos_class_t dispatch_queue_get_qos_class (dispatch_queue_t _Nonnull queue, int * _Nullable relative_priority_ptr) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((warn_unused_result)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe dispatch_qos_class_t dispatch_queue_get_qos_class (DispatchQueue queue, [NullAllowed] int* relative_priority_ptr);

    // extern void dispatch_set_target_queue (dispatch_object_t _Nonnull object, dispatch_queue_t _Nullable queue) __attribute__((nothrow)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_set_target_queue (DispatchObject @object, [NullAllowed] DispatchQueue queue);

    // extern void dispatch_main () __attribute__((nothrow)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((nothrow));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_main ();

    // extern void dispatch_after (dispatch_time_t when, dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull(2))) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_after (ulong when, DispatchQueue queue, dispatch_block_t block);

    // extern void dispatch_after_f (dispatch_time_t when, dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((nothrow)) __attribute__((nonnull(3))) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_after_f (ulong when, DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

    // extern void dispatch_barrier_async (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.3))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_barrier_async (DispatchQueue queue, dispatch_block_t block);

    // extern void dispatch_barrier_async_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((nothrow)) __attribute__((nonnull(2))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.3))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_barrier_async_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

    // extern void dispatch_barrier_sync (dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.3))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_barrier_sync (DispatchQueue queue, dispatch_block_t block);

    // extern void dispatch_barrier_sync_f (dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((nothrow)) __attribute__((nonnull(2))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.3))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_barrier_sync_f (DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

    // extern void dispatch_queue_set_specific (dispatch_queue_t _Nonnull queue, const void * _Nonnull key, void * _Nullable context, dispatch_function_t _Nullable destructor) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_queue_set_specific (DispatchQueue queue, void* key, [NullAllowed] void* context, [NullAllowed] dispatch_function_t* destructor);

    // extern void * _Nullable dispatch_queue_get_specific (dispatch_queue_t _Nonnull queue, const void * _Nonnull key) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((pure)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* dispatch_queue_get_specific (DispatchQueue queue, void* key);

    // extern void * _Nullable dispatch_get_specific (const void * _Nonnull key) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((pure)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* dispatch_get_specific (void* key);

    // extern void dispatch_assert_queue (dispatch_queue_t _Nonnull queue) asm("_dispatch_assert_queue$V2") __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12)));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_assert_queue (DispatchQueue queue);

    // extern void dispatch_assert_queue_barrier (dispatch_queue_t _Nonnull queue) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12)));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_assert_queue_barrier (DispatchQueue queue);

    // extern void dispatch_assert_queue_not (dispatch_queue_t _Nonnull queue) asm("_dispatch_assert_queue_not$V2") __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12)));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_assert_queue_not (DispatchQueue queue);

    // extern dispatch_block_t _Nonnull dispatch_block_create (dispatch_block_flags_t flags, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10))) __attribute__((ns_returns_retained)) __attribute__((nonnull(1)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern dispatch_block_t dispatch_block_create (dispatch_block_flags_t flags, dispatch_block_t block);

    // extern dispatch_block_t _Nonnull dispatch_block_create_with_qos_class (dispatch_block_flags_t flags, dispatch_qos_class_t qos_class, int relative_priority, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((nonnull(3))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10))) __attribute__((ns_returns_retained)) __attribute__((nonnull(3)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern dispatch_block_t dispatch_block_create_with_qos_class (dispatch_block_flags_t flags, dispatch_qos_class_t qos_class, int relative_priority, dispatch_block_t block);

    // extern void dispatch_block_perform (dispatch_block_flags_t flags, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_block_perform (dispatch_block_flags_t flags, dispatch_block_t block);

    // extern long dispatch_block_wait (dispatch_block_t _Nonnull block, dispatch_time_t timeout) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern nint dispatch_block_wait (dispatch_block_t block, ulong timeout);

    // extern void dispatch_block_notify (dispatch_block_t _Nonnull block, dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull notification_block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_block_notify (dispatch_block_t block, DispatchQueue queue, dispatch_block_t notification_block);

    // extern void dispatch_block_cancel (dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_block_cancel (dispatch_block_t block);

    // extern long dispatch_block_testcancel (dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((pure)) __attribute__((warn_unused_result)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.10)));
    [Mac (10,10), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern nint dispatch_block_testcancel (dispatch_block_t block);

    // extern mach_msg_return_t mach_msg_overwrite (mach_msg_header_t *msg, mach_msg_option_t option, mach_msg_size_t send_size, mach_msg_size_t rcv_size, mach_port_name_t rcv_name, mach_msg_timeout_t timeout, mach_port_name_t notify, mach_msg_header_t *rcv_msg, mach_msg_size_t rcv_limit) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
    [NoWatch, NoTV]
    [DllImport ("__Internal")]
    
    static extern unsafe int mach_msg_overwrite (mach_msg_header_t* msg, int option, uint send_size, uint rcv_size, uint rcv_name, uint timeout, uint notify, mach_msg_header_t* rcv_msg, uint rcv_limit);

    // extern mach_msg_return_t mach_msg (mach_msg_header_t *msg, mach_msg_option_t option, mach_msg_size_t send_size, mach_msg_size_t rcv_size, mach_port_name_t rcv_name, mach_msg_timeout_t timeout, mach_port_name_t notify) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
    [NoWatch, NoTV]
    [DllImport ("__Internal")]
    
    static extern unsafe int mach_msg (mach_msg_header_t* msg, int option, uint send_size, uint rcv_size, uint rcv_name, uint timeout, uint notify);

    // extern kern_return_t mach_voucher_deallocate (mach_port_name_t voucher) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
    [NoWatch, NoTV]
    [DllImport ("__Internal")]
    
    static extern int mach_voucher_deallocate (uint voucher);

    // extern dispatch_source_t _Nonnull dispatch_source_create (dispatch_source_type_t _Nonnull type, uintptr_t handle, unsigned long mask, dispatch_queue_t _Nullable queue) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((ns_returns_retained)) __attribute__((malloc));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe OS_dispatch_source dispatch_source_create (dispatch_source_type_t* type, UIntPtr handle, nuint mask, [NullAllowed] DispatchQueue queue);

    // extern void dispatch_source_set_event_handler (dispatch_source_t _Nonnull source, dispatch_block_t _Nullable handler) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_source_set_event_handler (OS_dispatch_source source, [NullAllowed] dispatch_block_t handler);

    // extern void dispatch_source_set_event_handler_f (dispatch_source_t _Nonnull source, dispatch_function_t _Nullable handler) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_source_set_event_handler_f (OS_dispatch_source source, [NullAllowed] dispatch_function_t* handler);

    // extern void dispatch_source_set_cancel_handler (dispatch_source_t _Nonnull source, dispatch_block_t _Nullable handler) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_source_set_cancel_handler (OS_dispatch_source source, [NullAllowed] dispatch_block_t handler);

    // extern void dispatch_source_set_cancel_handler_f (dispatch_source_t _Nonnull source, dispatch_function_t _Nullable handler) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_source_set_cancel_handler_f (OS_dispatch_source source, [NullAllowed] dispatch_function_t* handler);

    // extern void dispatch_source_cancel (dispatch_source_t _Nonnull source) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_source_cancel (OS_dispatch_source source);

    // extern long dispatch_source_testcancel (dispatch_source_t _Nonnull source) __attribute__((nothrow)) __attribute__((pure)) __attribute__((warn_unused_result)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nint dispatch_source_testcancel (OS_dispatch_source source);

    // extern uintptr_t dispatch_source_get_handle (dispatch_source_t _Nonnull source) __attribute__((nothrow)) __attribute__((pure)) __attribute__((warn_unused_result)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern UIntPtr dispatch_source_get_handle (OS_dispatch_source source);

    // extern unsigned long dispatch_source_get_mask (dispatch_source_t _Nonnull source) __attribute__((nothrow)) __attribute__((pure)) __attribute__((warn_unused_result)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nuint dispatch_source_get_mask (OS_dispatch_source source);

    // extern unsigned long dispatch_source_get_data (dispatch_source_t _Nonnull source) __attribute__((nothrow)) __attribute__((pure)) __attribute__((warn_unused_result)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nuint dispatch_source_get_data (OS_dispatch_source source);

    // extern void dispatch_source_merge_data (dispatch_source_t _Nonnull source, unsigned long value) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_source_merge_data (OS_dispatch_source source, nuint value);

    // extern void dispatch_source_set_timer (dispatch_source_t _Nonnull source, dispatch_time_t start, uint64_t interval, uint64_t leeway) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_source_set_timer (OS_dispatch_source source, ulong start, ulong interval, ulong leeway);

    // extern void dispatch_source_set_registration_handler (dispatch_source_t _Nonnull source, dispatch_block_t _Nullable handler) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.3))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_source_set_registration_handler (OS_dispatch_source source, [NullAllowed] dispatch_block_t handler);

    // extern void dispatch_source_set_registration_handler_f (dispatch_source_t _Nonnull source, dispatch_function_t _Nullable handler) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.3))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_source_set_registration_handler_f (OS_dispatch_source source, [NullAllowed] dispatch_function_t* handler);

    // extern dispatch_group_t _Nonnull dispatch_group_create () __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((ns_returns_retained)) __attribute__((malloc));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern DispatchGroup dispatch_group_create ();

    // extern void dispatch_group_async (dispatch_group_t _Nonnull group, dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_group_async (DispatchGroup group, DispatchQueue queue, dispatch_block_t block);

    // extern void dispatch_group_async_f (dispatch_group_t _Nonnull group, dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((nothrow)) __attribute__((nonnull(3))) __attribute__((nonnull(1))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_group_async_f (DispatchGroup group, DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

    // extern long dispatch_group_wait (dispatch_group_t _Nonnull group, dispatch_time_t timeout) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nint dispatch_group_wait (DispatchGroup group, ulong timeout);

    // extern void dispatch_group_notify (dispatch_group_t _Nonnull group, dispatch_queue_t _Nonnull queue, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_group_notify (DispatchGroup group, DispatchQueue queue, dispatch_block_t block);

    // extern void dispatch_group_notify_f (dispatch_group_t _Nonnull group, dispatch_queue_t _Nonnull queue, void * _Nullable context, dispatch_function_t _Nonnull work) __attribute__((nothrow)) __attribute__((nonnull(3))) __attribute__((nonnull(1))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_group_notify_f (DispatchGroup group, DispatchQueue queue, [NullAllowed] void* context, dispatch_function_t* work);

    // extern void dispatch_group_enter (dispatch_group_t _Nonnull group) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_group_enter (DispatchGroup group);

    // extern void dispatch_group_leave (dispatch_group_t _Nonnull group) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_group_leave (DispatchGroup group);

    // extern dispatch_semaphore_t _Nonnull dispatch_semaphore_create (long value) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((ns_returns_retained)) __attribute__((malloc));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern OS_dispatch_semaphore dispatch_semaphore_create (nint value);

    // extern long dispatch_semaphore_wait (dispatch_semaphore_t _Nonnull dsema, dispatch_time_t timeout) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nint dispatch_semaphore_wait (OS_dispatch_semaphore dsema, ulong timeout);

    // extern long dispatch_semaphore_signal (dispatch_semaphore_t _Nonnull dsema) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nint dispatch_semaphore_signal (OS_dispatch_semaphore dsema);

    // extern void dispatch_once (dispatch_once_t * _Nonnull predicate, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_once (nint* predicate, dispatch_block_t block);

    // void _dispatch_once (dispatch_once_t * _Nonnull predicate, dispatch_block_t _Nonnull block) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern unsafe void _dispatch_once (nint* predicate, dispatch_block_t block);
   
    // extern void dispatch_once_f (dispatch_once_t * _Nonnull predicate, void * _Nullable context, dispatch_function_t _Nonnull function) __attribute__((nothrow)) __attribute__((nonnull(2))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void dispatch_once_f (nint* predicate, [NullAllowed] void* context, dispatch_function_t* function);

    // void _dispatch_once_f (dispatch_once_t * _Nonnull predicate, void * _Nullable context, dispatch_function_t _Nonnull function) __attribute__((nothrow)) __attribute__((nonnull(2))) __attribute__((nonnull(0))) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern unsafe void _dispatch_once_f (nint* predicate, [NullAllowed] void* context, dispatch_function_t* function);

    // extern dispatch_data_t _Nonnull dispatch_data_create (const void * _Nonnull buffer, size_t size, dispatch_queue_t _Nullable queue, dispatch_block_t _Nullable destructor) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((ns_returns_retained));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe OS_dispatch_data dispatch_data_create (void* buffer, nuint size, [NullAllowed] DispatchQueue queue, [NullAllowed] dispatch_block_t destructor);

    // extern size_t dispatch_data_get_size (dispatch_data_t _Nonnull data) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((pure)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern nuint dispatch_data_get_size (OS_dispatch_data data);

    // extern dispatch_data_t _Nonnull dispatch_data_create_map (dispatch_data_t _Nonnull data, const void * _Nullable * _Nullable buffer_ptr, size_t * _Nullable size_ptr) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((ns_returns_retained)) __attribute__((nonnull(0)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe OS_dispatch_data dispatch_data_create_map (OS_dispatch_data data, [NullAllowed] void** buffer_ptr, [NullAllowed] nuint* size_ptr);

    // extern dispatch_data_t _Nonnull dispatch_data_create_concat (dispatch_data_t _Nonnull data1, dispatch_data_t _Nonnull data2) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((ns_returns_retained)) __attribute__((nonnull()));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern OS_dispatch_data dispatch_data_create_concat (OS_dispatch_data data1, OS_dispatch_data data2);

    // extern dispatch_data_t _Nonnull dispatch_data_create_subrange (dispatch_data_t _Nonnull data, size_t offset, size_t length) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((ns_returns_retained)) __attribute__((nonnull(0)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern OS_dispatch_data dispatch_data_create_subrange (OS_dispatch_data data, nuint offset, nuint length);

    // extern _Bool dispatch_data_apply (dispatch_data_t _Nonnull data, dispatch_data_applier_t _Nonnull applier) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern bool dispatch_data_apply (OS_dispatch_data data, dispatch_data_applier_t applier);

    // extern dispatch_data_t _Nonnull dispatch_data_copy_region (dispatch_data_t _Nonnull data, size_t location, size_t * _Nonnull offset_ptr) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((nonnull(2))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((ns_returns_retained)) __attribute__((nonnull(2))) __attribute__((nonnull(0)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe OS_dispatch_data dispatch_data_copy_region (OS_dispatch_data data, nuint location, nuint* offset_ptr);

    // extern void dispatch_read (dispatch_fd_t fd, size_t length, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(dispatch_data_t _Nonnull, int) handler) __attribute__((nothrow)) __attribute__((nonnull(3))) __attribute__((nonnull(2))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_read (int fd, nuint length, DispatchQueue queue, Action<OS_dispatch_data, int> handler);

    // extern void dispatch_write (dispatch_fd_t fd, dispatch_data_t _Nonnull data, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(dispatch_data_t _Nullable, int) handler) __attribute__((nothrow)) __attribute__((nonnull(3))) __attribute__((nonnull(2))) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_write (int fd, OS_dispatch_data data, DispatchQueue queue, Action<OS_dispatch_data, int> handler);

    // extern dispatch_io_t _Nonnull dispatch_io_create (dispatch_io_type_t type, dispatch_fd_t fd, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(int) cleanup_handler) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((ns_returns_retained)) __attribute__((malloc));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern OS_dispatch_io dispatch_io_create (nuint type, int fd, DispatchQueue queue, Action<int> cleanup_handler);

    // extern dispatch_io_t _Nonnull dispatch_io_create_with_path (dispatch_io_type_t type, const char * _Nonnull path, int oflag, mode_t mode, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(int) cleanup_handler) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((nonnull(1)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe OS_dispatch_io dispatch_io_create_with_path (nuint type, sbyte* path, int oflag, ushort mode, DispatchQueue queue, Action<int> cleanup_handler);

    // extern dispatch_io_t _Nonnull dispatch_io_create_with_io (dispatch_io_type_t type, dispatch_io_t _Nonnull io, dispatch_queue_t _Nonnull queue, void (^ _Nonnull)(int) cleanup_handler) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((nonnull(1))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((ns_returns_retained)) __attribute__((malloc)) __attribute__((nonnull(1)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern OS_dispatch_io dispatch_io_create_with_io (nuint type, OS_dispatch_io io, DispatchQueue queue, Action<int> cleanup_handler);

    // extern void dispatch_io_read (dispatch_io_t _Nonnull channel, off_t offset, size_t length, dispatch_queue_t _Nonnull queue, dispatch_io_handler_t _Nonnull io_handler) __attribute__((nothrow)) __attribute__((nonnull(4))) __attribute__((nonnull(3))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_io_read (OS_dispatch_io channel, long offset, nuint length, DispatchQueue queue, dispatch_io_handler_t io_handler);

    // extern void dispatch_io_write (dispatch_io_t _Nonnull channel, off_t offset, dispatch_data_t _Nonnull data, dispatch_queue_t _Nonnull queue, dispatch_io_handler_t _Nonnull io_handler) __attribute__((nothrow)) __attribute__((nonnull(4))) __attribute__((nonnull(3))) __attribute__((nonnull(2))) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_io_write (OS_dispatch_io channel, long offset, OS_dispatch_data data, DispatchQueue queue, dispatch_io_handler_t io_handler);

    // extern void dispatch_io_close (dispatch_io_t _Nonnull channel, dispatch_io_close_flags_t flags) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_io_close (OS_dispatch_io channel, nuint flags);

    // extern void dispatch_io_barrier (dispatch_io_t _Nonnull channel, dispatch_block_t _Nonnull barrier) __attribute__((nothrow)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_io_barrier (OS_dispatch_io channel, dispatch_block_t barrier);

    // extern dispatch_fd_t dispatch_io_get_descriptor (dispatch_io_t _Nonnull channel) __attribute__((nothrow)) __attribute__((warn_unused_result)) __attribute__((nonnull())) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern int dispatch_io_get_descriptor (OS_dispatch_io channel);

    // extern void dispatch_io_set_high_water (dispatch_io_t _Nonnull channel, size_t high_water) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_io_set_high_water (OS_dispatch_io channel, nuint high_water);

    // extern void dispatch_io_set_low_water (dispatch_io_t _Nonnull channel, size_t low_water) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_io_set_low_water (OS_dispatch_io channel, nuint low_water);

    // extern void dispatch_io_set_interval (dispatch_io_t _Nonnull channel, uint64_t interval, dispatch_io_interval_flags_t flags) __attribute__((nothrow)) __attribute__((nonnull(0))) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7)));
    [Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void dispatch_io_set_interval (OS_dispatch_io channel, ulong interval, nuint flags);

    // extern CFTypeID CFReadStreamGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFReadStreamGetTypeID ();

    // extern CFTypeID CFWriteStreamGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFWriteStreamGetTypeID ();

    // extern CFReadStreamRef CFReadStreamCreateWithBytesNoCopy (CFAllocatorRef alloc, const UInt8 *bytes, CFIndex length, CFAllocatorRef bytesDeallocator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFReadStreamRef* CFReadStreamCreateWithBytesNoCopy (CFAllocatorRef* alloc, byte* bytes, nint length, CFAllocatorRef* bytesDeallocator);

    // extern CFWriteStreamRef CFWriteStreamCreateWithBuffer (CFAllocatorRef alloc, UInt8 *buffer, CFIndex bufferCapacity) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFWriteStreamRef* CFWriteStreamCreateWithBuffer (CFAllocatorRef* alloc, byte* buffer, nint bufferCapacity);

    // extern CFWriteStreamRef CFWriteStreamCreateWithAllocatedBuffers (CFAllocatorRef alloc, CFAllocatorRef bufferAllocator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFWriteStreamRef* CFWriteStreamCreateWithAllocatedBuffers (CFAllocatorRef* alloc, CFAllocatorRef* bufferAllocator);

    // extern CFReadStreamRef CFReadStreamCreateWithFile (CFAllocatorRef alloc, CFURLRef fileURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFReadStreamRef* CFReadStreamCreateWithFile (CFAllocatorRef* alloc, CFURLRef* fileURL);

    // extern CFWriteStreamRef CFWriteStreamCreateWithFile (CFAllocatorRef alloc, CFURLRef fileURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFWriteStreamRef* CFWriteStreamCreateWithFile (CFAllocatorRef* alloc, CFURLRef* fileURL);

    // extern void CFStreamCreateBoundPair (CFAllocatorRef alloc, CFReadStreamRef *readStream, CFWriteStreamRef *writeStream, CFIndex transferBufferSize);
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStreamCreateBoundPair (CFAllocatorRef* alloc, CFReadStreamRef** readStream, CFWriteStreamRef** writeStream, nint transferBufferSize);

    // extern void CFStreamCreatePairWithSocket (CFAllocatorRef alloc, CFSocketNativeHandle sock, CFReadStreamRef *readStream, CFWriteStreamRef *writeStream);
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStreamCreatePairWithSocket (CFAllocatorRef* alloc, int sock, CFReadStreamRef** readStream, CFWriteStreamRef** writeStream);

    // extern void CFStreamCreatePairWithSocketToHost (CFAllocatorRef alloc, CFStringRef host, UInt32 port, CFReadStreamRef *readStream, CFWriteStreamRef *writeStream);
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStreamCreatePairWithSocketToHost (CFAllocatorRef* alloc, CFStringRef* host, uint port, CFReadStreamRef** readStream, CFWriteStreamRef** writeStream);

    // extern void CFStreamCreatePairWithPeerSocketSignature (CFAllocatorRef alloc, const CFSocketSignature *signature, CFReadStreamRef *readStream, CFWriteStreamRef *writeStream);
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStreamCreatePairWithPeerSocketSignature (CFAllocatorRef* alloc, CFSocketSignature* signature, CFReadStreamRef** readStream, CFWriteStreamRef** writeStream);

    // extern CFStreamStatus CFReadStreamGetStatus (CFReadStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStreamStatus CFReadStreamGetStatus (CFReadStreamRef* stream);

    // extern CFStreamStatus CFWriteStreamGetStatus (CFWriteStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStreamStatus CFWriteStreamGetStatus (CFWriteStreamRef* stream);

    // extern CFErrorRef CFReadStreamCopyError (CFReadStreamRef stream) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFErrorRef* CFReadStreamCopyError (CFReadStreamRef* stream);

    // extern CFErrorRef CFWriteStreamCopyError (CFWriteStreamRef stream) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFErrorRef* CFWriteStreamCopyError (CFWriteStreamRef* stream);

    // extern Boolean CFReadStreamOpen (CFReadStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFReadStreamOpen (CFReadStreamRef* stream);

    // extern Boolean CFWriteStreamOpen (CFWriteStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFWriteStreamOpen (CFWriteStreamRef* stream);

    // extern void CFReadStreamClose (CFReadStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFReadStreamClose (CFReadStreamRef* stream);

    // extern void CFWriteStreamClose (CFWriteStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFWriteStreamClose (CFWriteStreamRef* stream);

    // extern Boolean CFReadStreamHasBytesAvailable (CFReadStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFReadStreamHasBytesAvailable (CFReadStreamRef* stream);

    // extern CFIndex CFReadStreamRead (CFReadStreamRef stream, UInt8 *buffer, CFIndex bufferLength) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFReadStreamRead (CFReadStreamRef* stream, byte* buffer, nint bufferLength);

    // extern const UInt8 * CFReadStreamGetBuffer (CFReadStreamRef stream, CFIndex maxBytesToRead, CFIndex *numBytesRead) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte* CFReadStreamGetBuffer (CFReadStreamRef* stream, nint maxBytesToRead, nint* numBytesRead);

    // extern Boolean CFWriteStreamCanAcceptBytes (CFWriteStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFWriteStreamCanAcceptBytes (CFWriteStreamRef* stream);

    // extern CFIndex CFWriteStreamWrite (CFWriteStreamRef stream, const UInt8 *buffer, CFIndex bufferLength) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFWriteStreamWrite (CFWriteStreamRef* stream, byte* buffer, nint bufferLength);

    // extern CFTypeRef CFReadStreamCopyProperty (CFReadStreamRef stream, CFStreamPropertyKey propertyName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFReadStreamCopyProperty (CFReadStreamRef* stream, CFStreamPropertyKey* propertyName);

    // extern CFTypeRef CFWriteStreamCopyProperty (CFWriteStreamRef stream, CFStreamPropertyKey propertyName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFWriteStreamCopyProperty (CFWriteStreamRef* stream, CFStreamPropertyKey* propertyName);

    // extern Boolean CFReadStreamSetProperty (CFReadStreamRef stream, CFStreamPropertyKey propertyName, CFTypeRef propertyValue) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFReadStreamSetProperty (CFReadStreamRef* stream, CFStreamPropertyKey* propertyName, void* propertyValue);

    // extern Boolean CFWriteStreamSetProperty (CFWriteStreamRef stream, CFStreamPropertyKey propertyName, CFTypeRef propertyValue) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFWriteStreamSetProperty (CFWriteStreamRef* stream, CFStreamPropertyKey* propertyName, void* propertyValue);

    // extern Boolean CFReadStreamSetClient (CFReadStreamRef stream, CFOptionFlags streamEvents, CFReadStreamClientCallBack clientCB, CFStreamClientContext *clientContext) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFReadStreamSetClient (CFReadStreamRef* stream, nuint streamEvents, CFReadStreamClientCallBack* clientCB, CFStreamClientContext* clientContext);

    // extern Boolean CFWriteStreamSetClient (CFWriteStreamRef stream, CFOptionFlags streamEvents, CFWriteStreamClientCallBack clientCB, CFStreamClientContext *clientContext) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFWriteStreamSetClient (CFWriteStreamRef* stream, nuint streamEvents, CFWriteStreamClientCallBack* clientCB, CFStreamClientContext* clientContext);

    // extern void CFReadStreamScheduleWithRunLoop (CFReadStreamRef stream, CFRunLoopRef runLoop, CFRunLoopMode runLoopMode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFReadStreamScheduleWithRunLoop (CFReadStreamRef* stream, CFRunLoopRef* runLoop, CFRunLoopMode* runLoopMode);

    // extern void CFWriteStreamScheduleWithRunLoop (CFWriteStreamRef stream, CFRunLoopRef runLoop, CFRunLoopMode runLoopMode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFWriteStreamScheduleWithRunLoop (CFWriteStreamRef* stream, CFRunLoopRef* runLoop, CFRunLoopMode* runLoopMode);

    // extern void CFReadStreamUnscheduleFromRunLoop (CFReadStreamRef stream, CFRunLoopRef runLoop, CFRunLoopMode runLoopMode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFReadStreamUnscheduleFromRunLoop (CFReadStreamRef* stream, CFRunLoopRef* runLoop, CFRunLoopMode* runLoopMode);

    // extern void CFWriteStreamUnscheduleFromRunLoop (CFWriteStreamRef stream, CFRunLoopRef runLoop, CFRunLoopMode runLoopMode) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFWriteStreamUnscheduleFromRunLoop (CFWriteStreamRef* stream, CFRunLoopRef* runLoop, CFRunLoopMode* runLoopMode);

    // extern void CFReadStreamSetDispatchQueue (CFReadStreamRef stream, dispatch_queue_t q) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(macos, introduced=10.9))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFReadStreamSetDispatchQueue (CFReadStreamRef* stream, DispatchQueue q);

    // extern void CFWriteStreamSetDispatchQueue (CFWriteStreamRef stream, dispatch_queue_t q) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(macos, introduced=10.9))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFWriteStreamSetDispatchQueue (CFWriteStreamRef* stream, DispatchQueue q);

    // extern dispatch_queue_t CFReadStreamCopyDispatchQueue (CFReadStreamRef stream) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(macos, introduced=10.9))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe DispatchQueue CFReadStreamCopyDispatchQueue (CFReadStreamRef* stream);

    // extern dispatch_queue_t CFWriteStreamCopyDispatchQueue (CFWriteStreamRef stream) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(macos, introduced=10.9))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe DispatchQueue CFWriteStreamCopyDispatchQueue (CFWriteStreamRef* stream);

    // extern CFStreamError CFReadStreamGetError (CFReadStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStreamError CFReadStreamGetError (CFReadStreamRef* stream);

    // extern CFStreamError CFWriteStreamGetError (CFWriteStreamRef stream) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStreamError CFWriteStreamGetError (CFWriteStreamRef* stream);

    // extern CFPropertyListRef CFPropertyListCreateFromXMLData (CFAllocatorRef allocator, CFDataRef xmlData, CFOptionFlags mutabilityOption, CFStringRef *errorString) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.10)));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateWithData instead.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateWithData instead.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateWithData instead.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateWithData instead.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFPropertyListCreateWithData instead.")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFPropertyListCreateWithData instead.")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFPropertyListCreateWithData instead.")]
    [Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFPropertyListCreateWithData instead.")]
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFPropertyListCreateFromXMLData (CFAllocatorRef* allocator, CFDataRef* xmlData, nuint mutabilityOption, CFStringRef** errorString);

    // extern CFDataRef CFPropertyListCreateXMLData (CFAllocatorRef allocator, CFPropertyListRef propertyList) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.10)));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateData instead.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateData instead.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateData instead.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateData instead.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFPropertyListCreateData instead.")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFPropertyListCreateData instead.")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFPropertyListCreateData instead.")]
    [Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFPropertyListCreateData instead.")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFPropertyListCreateXMLData (CFAllocatorRef* allocator, void* propertyList);

    // extern CFPropertyListRef CFPropertyListCreateDeepCopy (CFAllocatorRef allocator, CFPropertyListRef propertyList, CFOptionFlags mutabilityOption) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFPropertyListCreateDeepCopy (CFAllocatorRef* allocator, void* propertyList, nuint mutabilityOption);

    // extern Boolean CFPropertyListIsValid (CFPropertyListRef plist, CFPropertyListFormat format) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPropertyListIsValid (void* plist, CFPropertyListFormat format);

    // extern CFIndex CFPropertyListWriteToStream (CFPropertyListRef propertyList, CFWriteStreamRef stream, CFPropertyListFormat format, CFStringRef *errorString) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(macos, introduced=10.2, deprecated=10.10)));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListWrite instead.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListWrite instead.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListWrite instead.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListWrite instead.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFPropertyListWrite instead.")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFPropertyListWrite instead.")]
    [Introduced (PlatformName.MacOSX, 10, 2, message: "Use CFPropertyListWrite instead.")]
    [Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFPropertyListWrite instead.")]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFPropertyListWriteToStream (void* propertyList, CFWriteStreamRef* stream, CFPropertyListFormat format, CFStringRef** errorString);

    // extern CFPropertyListRef CFPropertyListCreateFromStream (CFAllocatorRef allocator, CFReadStreamRef stream, CFIndex streamLength, CFOptionFlags mutabilityOption, CFPropertyListFormat *format, CFStringRef *errorString) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(macos, introduced=10.2, deprecated=10.10)));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateWithStream instead.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFPropertyListCreateWithStream instead.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateWithStream instead.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFPropertyListCreateWithStream instead.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFPropertyListCreateWithStream instead.")]
    [Deprecated (PlatformName.iOS, 8, 0, message: "Use CFPropertyListCreateWithStream instead.")]
    [Introduced (PlatformName.MacOSX, 10, 2, message: "Use CFPropertyListCreateWithStream instead.")]
    [Deprecated (PlatformName.MacOSX, 10, 10, message: "Use CFPropertyListCreateWithStream instead.")]
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFPropertyListCreateFromStream (CFAllocatorRef* allocator, CFReadStreamRef* stream, nint streamLength, nuint mutabilityOption, CFPropertyListFormat* format, CFStringRef** errorString);

    // extern CFPropertyListRef CFPropertyListCreateWithData (CFAllocatorRef allocator, CFDataRef data, CFOptionFlags options, CFPropertyListFormat *format, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFPropertyListCreateWithData (CFAllocatorRef* allocator, CFDataRef* data, nuint options, CFPropertyListFormat* format, CFErrorRef** error);

    // extern CFPropertyListRef CFPropertyListCreateWithStream (CFAllocatorRef allocator, CFReadStreamRef stream, CFIndex streamLength, CFOptionFlags options, CFPropertyListFormat *format, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFPropertyListCreateWithStream (CFAllocatorRef* allocator, CFReadStreamRef* stream, nint streamLength, nuint options, CFPropertyListFormat* format, CFErrorRef** error);

    // extern CFIndex CFPropertyListWrite (CFPropertyListRef propertyList, CFWriteStreamRef stream, CFPropertyListFormat format, CFOptionFlags options, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFPropertyListWrite (void* propertyList, CFWriteStreamRef* stream, CFPropertyListFormat format, nuint options, CFErrorRef** error);

    // extern CFDataRef CFPropertyListCreateData (CFAllocatorRef allocator, CFPropertyListRef propertyList, CFPropertyListFormat format, CFOptionFlags options, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* CFPropertyListCreateData (CFAllocatorRef* allocator, void* propertyList, CFPropertyListFormat format, nuint options, CFErrorRef** error);

    // extern CFTypeID CFSetGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFSetGetTypeID ();

    // extern CFSetRef CFSetCreate (CFAllocatorRef allocator, const void **values, CFIndex numValues, const CFSetCallBacks *callBacks) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSetRef* CFSetCreate (CFAllocatorRef* allocator, void** values, nint numValues, CFSetCallBacks* callBacks);

    // extern CFSetRef CFSetCreateCopy (CFAllocatorRef allocator, CFSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFSetRef* CFSetCreateCopy (CFAllocatorRef* allocator, CFSetRef* theSet);

    // extern CFMutableSetRef CFSetCreateMutable (CFAllocatorRef allocator, CFIndex capacity, const CFSetCallBacks *callBacks) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableSetRef* CFSetCreateMutable (CFAllocatorRef* allocator, nint capacity, CFSetCallBacks* callBacks);

    // extern CFMutableSetRef CFSetCreateMutableCopy (CFAllocatorRef allocator, CFIndex capacity, CFSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableSetRef* CFSetCreateMutableCopy (CFAllocatorRef* allocator, nint capacity, CFSetRef* theSet);

    // extern CFIndex CFSetGetCount (CFSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFSetGetCount (CFSetRef* theSet);

    // extern CFIndex CFSetGetCountOfValue (CFSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFSetGetCountOfValue (CFSetRef* theSet, void* value);

    // extern Boolean CFSetContainsValue (CFSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFSetContainsValue (CFSetRef* theSet, void* value);

    // extern const void * CFSetGetValue (CFSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFSetGetValue (CFSetRef* theSet, void* value);

    // extern Boolean CFSetGetValueIfPresent (CFSetRef theSet, const void *candidate, const void **value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFSetGetValueIfPresent (CFSetRef* theSet, void* candidate, void** value);

    // extern void CFSetGetValues (CFSetRef theSet, const void **values) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSetGetValues (CFSetRef* theSet, void** values);

    // extern void CFSetApplyFunction (CFSetRef theSet, CFSetApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSetApplyFunction (CFSetRef* theSet, CFSetApplierFunction* applier, void* context);

    // extern void CFSetAddValue (CFMutableSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSetAddValue (CFMutableSetRef* theSet, void* value);

    // extern void CFSetReplaceValue (CFMutableSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSetReplaceValue (CFMutableSetRef* theSet, void* value);

    // extern void CFSetSetValue (CFMutableSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSetSetValue (CFMutableSetRef* theSet, void* value);

    // extern void CFSetRemoveValue (CFMutableSetRef theSet, const void *value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSetRemoveValue (CFMutableSetRef* theSet, void* value);

    // extern void CFSetRemoveAllValues (CFMutableSetRef theSet) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFSetRemoveAllValues (CFMutableSetRef* theSet);

    // extern CFTypeID CFTreeGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFTreeGetTypeID ();

    // extern CFTreeRef CFTreeCreate (CFAllocatorRef allocator, const CFTreeContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTreeRef* CFTreeCreate (CFAllocatorRef* allocator, CFTreeContext* context);

    // extern CFTreeRef CFTreeGetParent (CFTreeRef tree) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTreeRef* CFTreeGetParent (CFTreeRef* tree);

    // extern CFTreeRef CFTreeGetNextSibling (CFTreeRef tree) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTreeRef* CFTreeGetNextSibling (CFTreeRef* tree);

    // extern CFTreeRef CFTreeGetFirstChild (CFTreeRef tree) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTreeRef* CFTreeGetFirstChild (CFTreeRef* tree);

    // extern void CFTreeGetContext (CFTreeRef tree, CFTreeContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeGetContext (CFTreeRef* tree, CFTreeContext* context);

    // extern CFIndex CFTreeGetChildCount (CFTreeRef tree) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFTreeGetChildCount (CFTreeRef* tree);

    // extern CFTreeRef CFTreeGetChildAtIndex (CFTreeRef tree, CFIndex idx) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTreeRef* CFTreeGetChildAtIndex (CFTreeRef* tree, nint idx);

    // extern void CFTreeGetChildren (CFTreeRef tree, CFTreeRef *children) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeGetChildren (CFTreeRef* tree, CFTreeRef** children);

    // extern void CFTreeApplyFunctionToChildren (CFTreeRef tree, CFTreeApplierFunction applier, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeApplyFunctionToChildren (CFTreeRef* tree, CFTreeApplierFunction* applier, void* context);

    // extern CFTreeRef CFTreeFindRoot (CFTreeRef tree) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFTreeRef* CFTreeFindRoot (CFTreeRef* tree);

    // extern void CFTreeSetContext (CFTreeRef tree, const CFTreeContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeSetContext (CFTreeRef* tree, CFTreeContext* context);

    // extern void CFTreePrependChild (CFTreeRef tree, CFTreeRef newChild) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreePrependChild (CFTreeRef* tree, CFTreeRef* newChild);

    // extern void CFTreeAppendChild (CFTreeRef tree, CFTreeRef newChild) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeAppendChild (CFTreeRef* tree, CFTreeRef* newChild);

    // extern void CFTreeInsertSibling (CFTreeRef tree, CFTreeRef newSibling) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeInsertSibling (CFTreeRef* tree, CFTreeRef* newSibling);

    // extern void CFTreeRemove (CFTreeRef tree) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeRemove (CFTreeRef* tree);

    // extern void CFTreeRemoveAllChildren (CFTreeRef tree) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeRemoveAllChildren (CFTreeRef* tree);

    // extern void CFTreeSortChildren (CFTreeRef tree, CFComparatorFunction comparator, void *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFTreeSortChildren (CFTreeRef* tree, CFComparatorFunction* comparator, void* context);

    // extern Boolean CFURLCreateDataAndPropertiesFromResource (CFAllocatorRef alloc, CFURLRef url, CFDataRef *resourceData, CFDictionaryRef *properties, CFArrayRef desiredProperties, SInt32 *errorCode) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
    [Deprecated (PlatformName.iOS, 7, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "For resource data, use the CFReadStream API. For file resource properties, use CFURLCopyResourcePropertiesForKeys.")]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLCreateDataAndPropertiesFromResource (CFAllocatorRef* alloc, CFURLRef* url, CFDataRef** resourceData, CFDictionaryRef** properties, CFArrayRef* desiredProperties, int* errorCode);

    // extern Boolean CFURLWriteDataAndPropertiesToResource (CFURLRef url, CFDataRef dataToWrite, CFDictionaryRef propertiesToWrite, SInt32 *errorCode) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
    [Deprecated (PlatformName.iOS, 7, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "For resource data, use the CFWriteStream API. For file resource properties, use CFURLSetResourcePropertiesForKeys.")]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLWriteDataAndPropertiesToResource (CFURLRef* url, CFDataRef* dataToWrite, CFDictionaryRef* propertiesToWrite, int* errorCode);

    // extern Boolean CFURLDestroyResource (CFURLRef url, SInt32 *errorCode) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
    [Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLGetFileSystemRepresentation and removefile(3) instead.")]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLDestroyResource (CFURLRef* url, int* errorCode);

    // extern CFTypeRef CFURLCreatePropertyFromResource (CFAllocatorRef alloc, CFURLRef url, CFStringRef property, SInt32 *errorCode) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
    [Introduced (PlatformName.iOS, 2, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
    [Deprecated (PlatformName.iOS, 7, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
    [Deprecated (PlatformName.MacOSX, 10, 9, message: "For file resource properties, use CFURLCopyResourcePropertyForKey.")]
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFURLCreatePropertyFromResource (CFAllocatorRef* alloc, CFURLRef* url, CFStringRef* property, int* errorCode);

    // extern CFTypeID CFUUIDGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFUUIDGetTypeID ();

    // extern CFUUIDRef CFUUIDCreate (CFAllocatorRef alloc) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFUUIDRef* CFUUIDCreate (CFAllocatorRef* alloc);

    // extern CFUUIDRef CFUUIDCreateWithBytes (CFAllocatorRef alloc, UInt8 byte0, UInt8 byte1, UInt8 byte2, UInt8 byte3, UInt8 byte4, UInt8 byte5, UInt8 byte6, UInt8 byte7, UInt8 byte8, UInt8 byte9, UInt8 byte10, UInt8 byte11, UInt8 byte12, UInt8 byte13, UInt8 byte14, UInt8 byte15) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFUUIDRef* CFUUIDCreateWithBytes (CFAllocatorRef* alloc, byte byte0, byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7, byte byte8, byte byte9, byte byte10, byte byte11, byte byte12, byte byte13, byte byte14, byte byte15);

    // extern CFUUIDRef CFUUIDCreateFromString (CFAllocatorRef alloc, CFStringRef uuidStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFUUIDRef* CFUUIDCreateFromString (CFAllocatorRef* alloc, CFStringRef* uuidStr);

    // extern CFStringRef CFUUIDCreateString (CFAllocatorRef alloc, CFUUIDRef uuid) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFUUIDCreateString (CFAllocatorRef* alloc, CFUUIDRef* uuid);

    // extern CFUUIDRef CFUUIDGetConstantUUIDWithBytes (CFAllocatorRef alloc, UInt8 byte0, UInt8 byte1, UInt8 byte2, UInt8 byte3, UInt8 byte4, UInt8 byte5, UInt8 byte6, UInt8 byte7, UInt8 byte8, UInt8 byte9, UInt8 byte10, UInt8 byte11, UInt8 byte12, UInt8 byte13, UInt8 byte14, UInt8 byte15) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFUUIDRef* CFUUIDGetConstantUUIDWithBytes (CFAllocatorRef* alloc, byte byte0, byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7, byte byte8, byte byte9, byte byte10, byte byte11, byte byte12, byte byte13, byte byte14, byte byte15);

    // extern CFUUIDBytes CFUUIDGetUUIDBytes (CFUUIDRef uuid) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFUUIDBytes CFUUIDGetUUIDBytes (CFUUIDRef* uuid);

    // extern CFUUIDRef CFUUIDCreateFromUUIDBytes (CFAllocatorRef alloc, CFUUIDBytes bytes) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFUUIDRef* CFUUIDCreateFromUUIDBytes (CFAllocatorRef* alloc, CFUUIDBytes bytes);

    // extern CFURLRef CFCopyHomeDirectoryURL () __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFCopyHomeDirectoryURL ();

    // extern CFBundleRef CFBundleGetMainBundle () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBundleRef* CFBundleGetMainBundle ();

    // extern CFBundleRef CFBundleGetBundleWithIdentifier (CFStringRef bundleID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBundleRef* CFBundleGetBundleWithIdentifier (CFStringRef* bundleID);

    // extern CFArrayRef CFBundleGetAllBundles () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleGetAllBundles ();

    // extern CFTypeID CFBundleGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFBundleGetTypeID ();

    // extern CFBundleRef CFBundleCreate (CFAllocatorRef allocator, CFURLRef bundleURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBundleRef* CFBundleCreate (CFAllocatorRef* allocator, CFURLRef* bundleURL);

    // extern CFArrayRef CFBundleCreateBundlesFromDirectory (CFAllocatorRef allocator, CFURLRef directoryURL, CFStringRef bundleType) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCreateBundlesFromDirectory (CFAllocatorRef* allocator, CFURLRef* directoryURL, CFStringRef* bundleType);

    // extern CFURLRef CFBundleCopyBundleURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyBundleURL (CFBundleRef* bundle);

    // extern CFTypeRef CFBundleGetValueForInfoDictionaryKey (CFBundleRef bundle, CFStringRef key) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFBundleGetValueForInfoDictionaryKey (CFBundleRef* bundle, CFStringRef* key);

    // extern CFDictionaryRef CFBundleGetInfoDictionary (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFBundleGetInfoDictionary (CFBundleRef* bundle);

    // extern CFDictionaryRef CFBundleGetLocalInfoDictionary (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFBundleGetLocalInfoDictionary (CFBundleRef* bundle);

    // extern void CFBundleGetPackageInfo (CFBundleRef bundle, UInt32 *packageType, UInt32 *packageCreator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBundleGetPackageInfo (CFBundleRef* bundle, uint* packageType, uint* packageCreator);

    // extern CFStringRef CFBundleGetIdentifier (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFBundleGetIdentifier (CFBundleRef* bundle);

    // extern UInt32 CFBundleGetVersionNumber (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe uint CFBundleGetVersionNumber (CFBundleRef* bundle);

    // extern CFStringRef CFBundleGetDevelopmentRegion (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFBundleGetDevelopmentRegion (CFBundleRef* bundle);

    // extern CFURLRef CFBundleCopySupportFilesDirectoryURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopySupportFilesDirectoryURL (CFBundleRef* bundle);

    // extern CFURLRef CFBundleCopyResourcesDirectoryURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyResourcesDirectoryURL (CFBundleRef* bundle);

    // extern CFURLRef CFBundleCopyPrivateFrameworksURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyPrivateFrameworksURL (CFBundleRef* bundle);

    // extern CFURLRef CFBundleCopySharedFrameworksURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopySharedFrameworksURL (CFBundleRef* bundle);

    // extern CFURLRef CFBundleCopySharedSupportURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopySharedSupportURL (CFBundleRef* bundle);

    // extern CFURLRef CFBundleCopyBuiltInPlugInsURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyBuiltInPlugInsURL (CFBundleRef* bundle);

    // extern CFDictionaryRef CFBundleCopyInfoDictionaryInDirectory (CFURLRef bundleURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFBundleCopyInfoDictionaryInDirectory (CFURLRef* bundleURL);

    // extern Boolean CFBundleGetPackageInfoInDirectory (CFURLRef url, UInt32 *packageType, UInt32 *packageCreator) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBundleGetPackageInfoInDirectory (CFURLRef* url, uint* packageType, uint* packageCreator);

    // extern CFURLRef CFBundleCopyResourceURL (CFBundleRef bundle, CFStringRef resourceName, CFStringRef resourceType, CFStringRef subDirName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyResourceURL (CFBundleRef* bundle, CFStringRef* resourceName, CFStringRef* resourceType, CFStringRef* subDirName);

    // extern CFArrayRef CFBundleCopyResourceURLsOfType (CFBundleRef bundle, CFStringRef resourceType, CFStringRef subDirName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyResourceURLsOfType (CFBundleRef* bundle, CFStringRef* resourceType, CFStringRef* subDirName);

    // extern CFStringRef CFBundleCopyLocalizedString (CFBundleRef bundle, CFStringRef key, CFStringRef value, CFStringRef tableName) __attribute__((format_arg(2))) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFBundleCopyLocalizedString (CFBundleRef* bundle, CFStringRef* key, CFStringRef* value, CFStringRef* tableName);

    // extern CFURLRef CFBundleCopyResourceURLInDirectory (CFURLRef bundleURL, CFStringRef resourceName, CFStringRef resourceType, CFStringRef subDirName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyResourceURLInDirectory (CFURLRef* bundleURL, CFStringRef* resourceName, CFStringRef* resourceType, CFStringRef* subDirName);

    // extern CFArrayRef CFBundleCopyResourceURLsOfTypeInDirectory (CFURLRef bundleURL, CFStringRef resourceType, CFStringRef subDirName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyResourceURLsOfTypeInDirectory (CFURLRef* bundleURL, CFStringRef* resourceType, CFStringRef* subDirName);

    // extern CFArrayRef CFBundleCopyBundleLocalizations (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyBundleLocalizations (CFBundleRef* bundle);

    // extern CFArrayRef CFBundleCopyPreferredLocalizationsFromArray (CFArrayRef locArray) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyPreferredLocalizationsFromArray (CFArrayRef* locArray);

    // extern CFArrayRef CFBundleCopyLocalizationsForPreferences (CFArrayRef locArray, CFArrayRef prefArray) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyLocalizationsForPreferences (CFArrayRef* locArray, CFArrayRef* prefArray);

    // extern CFURLRef CFBundleCopyResourceURLForLocalization (CFBundleRef bundle, CFStringRef resourceName, CFStringRef resourceType, CFStringRef subDirName, CFStringRef localizationName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyResourceURLForLocalization (CFBundleRef* bundle, CFStringRef* resourceName, CFStringRef* resourceType, CFStringRef* subDirName, CFStringRef* localizationName);

    // extern CFArrayRef CFBundleCopyResourceURLsOfTypeForLocalization (CFBundleRef bundle, CFStringRef resourceType, CFStringRef subDirName, CFStringRef localizationName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyResourceURLsOfTypeForLocalization (CFBundleRef* bundle, CFStringRef* resourceType, CFStringRef* subDirName, CFStringRef* localizationName);

    // extern CFDictionaryRef CFBundleCopyInfoDictionaryForURL (CFURLRef url) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFBundleCopyInfoDictionaryForURL (CFURLRef* url);

    // extern CFArrayRef CFBundleCopyLocalizationsForURL (CFURLRef url) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyLocalizationsForURL (CFURLRef* url);

    // extern CFArrayRef CFBundleCopyExecutableArchitecturesForURL (CFURLRef url) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyExecutableArchitecturesForURL (CFURLRef* url);

    // extern CFURLRef CFBundleCopyExecutableURL (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyExecutableURL (CFBundleRef* bundle);

    // extern CFArrayRef CFBundleCopyExecutableArchitectures (CFBundleRef bundle) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFBundleCopyExecutableArchitectures (CFBundleRef* bundle);

    // extern Boolean CFBundlePreflightExecutable (CFBundleRef bundle, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBundlePreflightExecutable (CFBundleRef* bundle, CFErrorRef** error);

    // extern Boolean CFBundleLoadExecutableAndReturnError (CFBundleRef bundle, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBundleLoadExecutableAndReturnError (CFBundleRef* bundle, CFErrorRef** error);

    // extern Boolean CFBundleLoadExecutable (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBundleLoadExecutable (CFBundleRef* bundle);

    // extern Boolean CFBundleIsExecutableLoaded (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFBundleIsExecutableLoaded (CFBundleRef* bundle);

    // extern void CFBundleUnloadExecutable (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBundleUnloadExecutable (CFBundleRef* bundle);

    // extern void * CFBundleGetFunctionPointerForName (CFBundleRef bundle, CFStringRef functionName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFBundleGetFunctionPointerForName (CFBundleRef* bundle, CFStringRef* functionName);

    // extern void CFBundleGetFunctionPointersForNames (CFBundleRef bundle, CFArrayRef functionNames, void **ftbl) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBundleGetFunctionPointersForNames (CFBundleRef* bundle, CFArrayRef* functionNames, void*[] ftbl);

    // extern void * CFBundleGetDataPointerForName (CFBundleRef bundle, CFStringRef symbolName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFBundleGetDataPointerForName (CFBundleRef* bundle, CFStringRef* symbolName);

    // extern void CFBundleGetDataPointersForNames (CFBundleRef bundle, CFArrayRef symbolNames, void **stbl) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBundleGetDataPointersForNames (CFBundleRef* bundle, CFArrayRef* symbolNames, void*[] stbl);

    // extern CFURLRef CFBundleCopyAuxiliaryExecutableURL (CFBundleRef bundle, CFStringRef executableName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLRef* CFBundleCopyAuxiliaryExecutableURL (CFBundleRef* bundle, CFStringRef* executableName);

    // extern CFPlugInRef CFBundleGetPlugIn (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFPlugInRef* CFBundleGetPlugIn (CFBundleRef* bundle);

    // extern CFBundleRefNum CFBundleOpenBundleResourceMap (CFBundleRef bundle) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe int CFBundleOpenBundleResourceMap (CFBundleRef* bundle);

    // extern SInt32 CFBundleOpenBundleResourceFiles (CFBundleRef bundle, CFBundleRefNum *refNum, CFBundleRefNum *localizedRefNum) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe int CFBundleOpenBundleResourceFiles (CFBundleRef* bundle, int* refNum, int* localizedRefNum);

    // extern void CFBundleCloseBundleResourceMap (CFBundleRef bundle, CFBundleRefNum refNum) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFBundleCloseBundleResourceMap (CFBundleRef* bundle, int refNum);

    // extern CFTypeID CFMessagePortGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFMessagePortGetTypeID ();

    // extern CFMessagePortRef CFMessagePortCreateLocal (CFAllocatorRef allocator, CFStringRef name, CFMessagePortCallBack callout, CFMessagePortContext *context, Boolean *shouldFreeInfo) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMessagePortRef* CFMessagePortCreateLocal (CFAllocatorRef* allocator, CFStringRef* name, CFMessagePortCallBack* callout, CFMessagePortContext* context, byte* shouldFreeInfo);

    // extern CFMessagePortRef CFMessagePortCreateRemote (CFAllocatorRef allocator, CFStringRef name) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMessagePortRef* CFMessagePortCreateRemote (CFAllocatorRef* allocator, CFStringRef* name);

    // extern Boolean CFMessagePortIsRemote (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFMessagePortIsRemote (CFMessagePortRef* ms);

    // extern CFStringRef CFMessagePortGetName (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFMessagePortGetName (CFMessagePortRef* ms);

    // extern Boolean CFMessagePortSetName (CFMessagePortRef ms, CFStringRef newName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFMessagePortSetName (CFMessagePortRef* ms, CFStringRef* newName);

    // extern void CFMessagePortGetContext (CFMessagePortRef ms, CFMessagePortContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFMessagePortGetContext (CFMessagePortRef* ms, CFMessagePortContext* context);

    // extern void CFMessagePortInvalidate (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFMessagePortInvalidate (CFMessagePortRef* ms);

    // extern Boolean CFMessagePortIsValid (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFMessagePortIsValid (CFMessagePortRef* ms);

    // extern CFMessagePortInvalidationCallBack CFMessagePortGetInvalidationCallBack (CFMessagePortRef ms) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMessagePortInvalidationCallBack* CFMessagePortGetInvalidationCallBack (CFMessagePortRef* ms);

    // extern void CFMessagePortSetInvalidationCallBack (CFMessagePortRef ms, CFMessagePortInvalidationCallBack callout) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFMessagePortSetInvalidationCallBack (CFMessagePortRef* ms, CFMessagePortInvalidationCallBack* callout);

    // extern SInt32 CFMessagePortSendRequest (CFMessagePortRef remote, SInt32 msgid, CFDataRef data, CFTimeInterval sendTimeout, CFTimeInterval rcvTimeout, CFStringRef replyMode, CFDataRef *returnData) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe int CFMessagePortSendRequest (CFMessagePortRef* remote, int msgid, CFDataRef* data, double sendTimeout, double rcvTimeout, CFStringRef* replyMode, CFDataRef** returnData);

    // extern CFRunLoopSourceRef CFMessagePortCreateRunLoopSource (CFAllocatorRef allocator, CFMessagePortRef local, CFIndex order) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopSourceRef* CFMessagePortCreateRunLoopSource (CFAllocatorRef* allocator, CFMessagePortRef* local, nint order);

    // extern void CFMessagePortSetDispatchQueue (CFMessagePortRef ms, dispatch_queue_t queue) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFMessagePortSetDispatchQueue (CFMessagePortRef* ms, DispatchQueue queue);

    // extern CFTypeID CFPlugInGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFPlugInGetTypeID ();

    // extern CFPlugInRef CFPlugInCreate (CFAllocatorRef allocator, CFURLRef plugInURL) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFPlugInRef* CFPlugInCreate (CFAllocatorRef* allocator, CFURLRef* plugInURL);

    // extern CFBundleRef CFPlugInGetBundle (CFPlugInRef plugIn) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFBundleRef* CFPlugInGetBundle (CFPlugInRef* plugIn);

    // extern void CFPlugInSetLoadOnDemand (CFPlugInRef plugIn, Boolean flag) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFPlugInSetLoadOnDemand (CFPlugInRef* plugIn, byte flag);

    // extern Boolean CFPlugInIsLoadOnDemand (CFPlugInRef plugIn) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPlugInIsLoadOnDemand (CFPlugInRef* plugIn);

    // extern CFArrayRef CFPlugInFindFactoriesForPlugInType (CFUUIDRef typeUUID) __attribute__((cf_returns_retained)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFPlugInFindFactoriesForPlugInType (CFUUIDRef* typeUUID);

    // extern CFArrayRef CFPlugInFindFactoriesForPlugInTypeInPlugIn (CFUUIDRef typeUUID, CFPlugInRef plugIn) __attribute__((cf_returns_retained)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFPlugInFindFactoriesForPlugInTypeInPlugIn (CFUUIDRef* typeUUID, CFPlugInRef* plugIn);

    // extern void * CFPlugInInstanceCreate (CFAllocatorRef allocator, CFUUIDRef factoryUUID, CFUUIDRef typeUUID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFPlugInInstanceCreate (CFAllocatorRef* allocator, CFUUIDRef* factoryUUID, CFUUIDRef* typeUUID);

    // extern Boolean CFPlugInRegisterFactoryFunction (CFUUIDRef factoryUUID, CFPlugInFactoryFunction func) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPlugInRegisterFactoryFunction (CFUUIDRef* factoryUUID, CFPlugInFactoryFunction* func);

    // extern Boolean CFPlugInRegisterFactoryFunctionByName (CFUUIDRef factoryUUID, CFPlugInRef plugIn, CFStringRef functionName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPlugInRegisterFactoryFunctionByName (CFUUIDRef* factoryUUID, CFPlugInRef* plugIn, CFStringRef* functionName);

    // extern Boolean CFPlugInUnregisterFactory (CFUUIDRef factoryUUID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPlugInUnregisterFactory (CFUUIDRef* factoryUUID);

    // extern Boolean CFPlugInRegisterPlugInType (CFUUIDRef factoryUUID, CFUUIDRef typeUUID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPlugInRegisterPlugInType (CFUUIDRef* factoryUUID, CFUUIDRef* typeUUID);

    // extern Boolean CFPlugInUnregisterPlugInType (CFUUIDRef factoryUUID, CFUUIDRef typeUUID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPlugInUnregisterPlugInType (CFUUIDRef* factoryUUID, CFUUIDRef* typeUUID);

    // extern void CFPlugInAddInstanceForFactory (CFUUIDRef factoryID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFPlugInAddInstanceForFactory (CFUUIDRef* factoryID);

    // extern void CFPlugInRemoveInstanceForFactory (CFUUIDRef factoryID) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFPlugInRemoveInstanceForFactory (CFUUIDRef* factoryID);

    // extern Boolean CFPlugInInstanceGetInterfaceFunctionTable (CFPlugInInstanceRef instance, CFStringRef interfaceName, void **ftbl) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFPlugInInstanceGetInterfaceFunctionTable (CFPlugInInstanceRef* instance, CFStringRef* interfaceName, void** ftbl);

    // extern CFStringRef CFPlugInInstanceGetFactoryName (CFPlugInInstanceRef instance) __attribute__((cf_returns_retained)) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFPlugInInstanceGetFactoryName (CFPlugInInstanceRef* instance);

    // extern void * CFPlugInInstanceGetInstanceData (CFPlugInInstanceRef instance) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFPlugInInstanceGetInstanceData (CFPlugInInstanceRef* instance);

    // extern CFTypeID CFPlugInInstanceGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFPlugInInstanceGetTypeID ();

    // extern CFPlugInInstanceRef CFPlugInInstanceCreateWithInstanceDataSize (CFAllocatorRef allocator, CFIndex instanceDataSize, CFPlugInInstanceDeallocateInstanceDataFunction deallocateInstanceFunction, CFStringRef factoryName, CFPlugInInstanceGetInterfaceFunction getInterfaceFunction) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFPlugInInstanceRef* CFPlugInInstanceCreateWithInstanceDataSize (CFAllocatorRef* allocator, nint instanceDataSize, CFPlugInInstanceDeallocateInstanceDataFunction* deallocateInstanceFunction, CFStringRef* factoryName, CFPlugInInstanceGetInterfaceFunction* getInterfaceFunction);

    // extern CFTypeID CFMachPortGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFMachPortGetTypeID ();

    // extern CFMachPortRef CFMachPortCreate (CFAllocatorRef allocator, CFMachPortCallBack callout, CFMachPortContext *context, Boolean *shouldFreeInfo) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMachPortRef* CFMachPortCreate (CFAllocatorRef* allocator, CFMachPortCallBack* callout, CFMachPortContext* context, byte* shouldFreeInfo);

    // extern CFMachPortRef CFMachPortCreateWithPort (CFAllocatorRef allocator, mach_port_t portNum, CFMachPortCallBack callout, CFMachPortContext *context, Boolean *shouldFreeInfo) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMachPortRef* CFMachPortCreateWithPort (CFAllocatorRef* allocator, uint portNum, CFMachPortCallBack* callout, CFMachPortContext* context, byte* shouldFreeInfo);

    // extern mach_port_t CFMachPortGetPort (CFMachPortRef port) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe uint CFMachPortGetPort (CFMachPortRef* port);

    // extern void CFMachPortGetContext (CFMachPortRef port, CFMachPortContext *context) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFMachPortGetContext (CFMachPortRef* port, CFMachPortContext* context);

    // extern void CFMachPortInvalidate (CFMachPortRef port) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFMachPortInvalidate (CFMachPortRef* port);

    // extern Boolean CFMachPortIsValid (CFMachPortRef port) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFMachPortIsValid (CFMachPortRef* port);

    // extern CFMachPortInvalidationCallBack CFMachPortGetInvalidationCallBack (CFMachPortRef port) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMachPortInvalidationCallBack* CFMachPortGetInvalidationCallBack (CFMachPortRef* port);

    // extern void CFMachPortSetInvalidationCallBack (CFMachPortRef port, CFMachPortInvalidationCallBack callout) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFMachPortSetInvalidationCallBack (CFMachPortRef* port, CFMachPortInvalidationCallBack* callout);

    // extern CFRunLoopSourceRef CFMachPortCreateRunLoopSource (CFAllocatorRef allocator, CFMachPortRef port, CFIndex order) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopSourceRef* CFMachPortCreateRunLoopSource (CFAllocatorRef* allocator, CFMachPortRef* port, nint order);

    // extern CFTypeID CFAttributedStringGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CFAttributedStringGetTypeID ();

    // extern CFAttributedStringRef CFAttributedStringCreate (CFAllocatorRef alloc, CFStringRef str, CFDictionaryRef attributes) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFAttributedStringRef* CFAttributedStringCreate (CFAllocatorRef* alloc, CFStringRef* str, CFDictionaryRef* attributes);

    // extern CFAttributedStringRef CFAttributedStringCreateWithSubstring (CFAllocatorRef alloc, CFAttributedStringRef aStr, CFRange range) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFAttributedStringRef* CFAttributedStringCreateWithSubstring (CFAllocatorRef* alloc, CFAttributedStringRef* aStr, CFRange range);

    // extern CFAttributedStringRef CFAttributedStringCreateCopy (CFAllocatorRef alloc, CFAttributedStringRef aStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFAttributedStringRef* CFAttributedStringCreateCopy (CFAllocatorRef* alloc, CFAttributedStringRef* aStr);

    // extern CFStringRef CFAttributedStringGetString (CFAttributedStringRef aStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFAttributedStringGetString (CFAttributedStringRef* aStr);

    // extern CFIndex CFAttributedStringGetLength (CFAttributedStringRef aStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFAttributedStringGetLength (CFAttributedStringRef* aStr);

    // extern CFDictionaryRef CFAttributedStringGetAttributes (CFAttributedStringRef aStr, CFIndex loc, CFRange *effectiveRange) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFAttributedStringGetAttributes (CFAttributedStringRef* aStr, nint loc, CFRange* effectiveRange);

    // extern CFTypeRef CFAttributedStringGetAttribute (CFAttributedStringRef aStr, CFIndex loc, CFStringRef attrName, CFRange *effectiveRange) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFAttributedStringGetAttribute (CFAttributedStringRef* aStr, nint loc, CFStringRef* attrName, CFRange* effectiveRange);

    // extern CFDictionaryRef CFAttributedStringGetAttributesAndLongestEffectiveRange (CFAttributedStringRef aStr, CFIndex loc, CFRange inRange, CFRange *longestEffectiveRange) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CFAttributedStringGetAttributesAndLongestEffectiveRange (CFAttributedStringRef* aStr, nint loc, CFRange inRange, CFRange* longestEffectiveRange);

    // extern CFTypeRef CFAttributedStringGetAttributeAndLongestEffectiveRange (CFAttributedStringRef aStr, CFIndex loc, CFStringRef attrName, CFRange inRange, CFRange *longestEffectiveRange) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFAttributedStringGetAttributeAndLongestEffectiveRange (CFAttributedStringRef* aStr, nint loc, CFStringRef* attrName, CFRange inRange, CFRange* longestEffectiveRange);

    // extern CFMutableAttributedStringRef CFAttributedStringCreateMutableCopy (CFAllocatorRef alloc, CFIndex maxLength, CFAttributedStringRef aStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableAttributedStringRef* CFAttributedStringCreateMutableCopy (CFAllocatorRef* alloc, nint maxLength, CFAttributedStringRef* aStr);

    // extern CFMutableAttributedStringRef CFAttributedStringCreateMutable (CFAllocatorRef alloc, CFIndex maxLength) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableAttributedStringRef* CFAttributedStringCreateMutable (CFAllocatorRef* alloc, nint maxLength);

    // extern void CFAttributedStringReplaceString (CFMutableAttributedStringRef aStr, CFRange range, CFStringRef replacement) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAttributedStringReplaceString (CFMutableAttributedStringRef* aStr, CFRange range, CFStringRef* replacement);

    // extern CFMutableStringRef CFAttributedStringGetMutableString (CFMutableAttributedStringRef aStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe CFMutableStringRef* CFAttributedStringGetMutableString (CFMutableAttributedStringRef* aStr);

    // extern void CFAttributedStringSetAttributes (CFMutableAttributedStringRef aStr, CFRange range, CFDictionaryRef replacement, Boolean clearOtherAttributes) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAttributedStringSetAttributes (CFMutableAttributedStringRef* aStr, CFRange range, CFDictionaryRef* replacement, byte clearOtherAttributes);

    // extern void CFAttributedStringSetAttribute (CFMutableAttributedStringRef aStr, CFRange range, CFStringRef attrName, CFTypeRef value) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAttributedStringSetAttribute (CFMutableAttributedStringRef* aStr, CFRange range, CFStringRef* attrName, void* value);

    // extern void CFAttributedStringRemoveAttribute (CFMutableAttributedStringRef aStr, CFRange range, CFStringRef attrName) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAttributedStringRemoveAttribute (CFMutableAttributedStringRef* aStr, CFRange range, CFStringRef* attrName);

    // extern void CFAttributedStringReplaceAttributedString (CFMutableAttributedStringRef aStr, CFRange range, CFAttributedStringRef replacement) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAttributedStringReplaceAttributedString (CFMutableAttributedStringRef* aStr, CFRange range, CFAttributedStringRef* replacement);

    // extern void CFAttributedStringBeginEditing (CFMutableAttributedStringRef aStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAttributedStringBeginEditing (CFMutableAttributedStringRef* aStr);

    // extern void CFAttributedStringEndEditing (CFMutableAttributedStringRef aStr) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CFAttributedStringEndEditing (CFMutableAttributedStringRef* aStr);

    // extern CFTypeID CFURLEnumeratorGetTypeID () __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFURLEnumeratorGetTypeID ();

    // extern CFURLEnumeratorRef CFURLEnumeratorCreateForDirectoryURL (CFAllocatorRef alloc, CFURLRef directoryURL, CFURLEnumeratorOptions option, CFArrayRef propertyKeys) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLEnumeratorRef* CFURLEnumeratorCreateForDirectoryURL (CFAllocatorRef* alloc, CFURLRef* directoryURL, CFURLEnumeratorOptions option, CFArrayRef* propertyKeys);

    // extern CFURLEnumeratorRef CFURLEnumeratorCreateForMountedVolumes (CFAllocatorRef alloc, CFURLEnumeratorOptions option, CFArrayRef propertyKeys) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLEnumeratorRef* CFURLEnumeratorCreateForMountedVolumes (CFAllocatorRef* alloc, CFURLEnumeratorOptions option, CFArrayRef* propertyKeys);

    // extern CFURLEnumeratorResult CFURLEnumeratorGetNextURL (CFURLEnumeratorRef enumerator, CFURLRef *url, CFErrorRef *error) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFURLEnumeratorResult CFURLEnumeratorGetNextURL (CFURLEnumeratorRef* enumerator, CFURLRef** url, CFErrorRef** error);

    // extern void CFURLEnumeratorSkipDescendents (CFURLEnumeratorRef enumerator) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFURLEnumeratorSkipDescendents (CFURLEnumeratorRef* enumerator);

    // extern CFIndex CFURLEnumeratorGetDescendentLevel (CFURLEnumeratorRef enumerator) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFURLEnumeratorGetDescendentLevel (CFURLEnumeratorRef* enumerator);

    // extern Boolean CFURLEnumeratorGetSourceDidChange (CFURLEnumeratorRef enumerator) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=4.0, deprecated=5.0))) __attribute__((availability(macos, introduced=10.6, deprecated=10.7))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use File System Events API instead")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use File System Events API instead")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use File System Events API instead")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use File System Events API instead")]
    [Introduced (PlatformName.iOS, 4, 0, message: "Use File System Events API instead")]
    [Deprecated (PlatformName.iOS, 5, 0, message: "Use File System Events API instead")]
    [Introduced (PlatformName.MacOSX, 10, 6, message: "Use File System Events API instead")]
    [Deprecated (PlatformName.MacOSX, 10, 7, message: "Use File System Events API instead")]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFURLEnumeratorGetSourceDidChange (CFURLEnumeratorRef* enumerator);

    // extern acl_t acl_dup (acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_dup (acl_t* acl);

    // extern int acl_free (void *obj_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_free (void* obj_p);

    // extern acl_t acl_init (int count);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_init (int count);

    // extern int acl_copy_entry (acl_entry_t dest_d, acl_entry_t src_d);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_copy_entry (acl_entry_t* dest_d, acl_entry_t* src_d);

    // extern int acl_create_entry (acl_t *acl_p, acl_entry_t *entry_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_create_entry (acl_t** acl_p, acl_entry_t** entry_p);

    // extern int acl_create_entry_np (acl_t *acl_p, acl_entry_t *entry_p, int entry_index);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_create_entry_np (acl_t** acl_p, acl_entry_t** entry_p, int entry_index);

    // extern int acl_delete_entry (acl_t acl, acl_entry_t entry_d);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_delete_entry (acl_t* acl, acl_entry_t* entry_d);

    // extern int acl_get_entry (acl_t acl, int entry_id, acl_entry_t *entry_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_get_entry (acl_t* acl, int entry_id, acl_entry_t** entry_p);

    // extern int acl_valid (acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_valid (acl_t* acl);

    // extern int acl_valid_fd_np (int fd, acl_type_t type, acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_valid_fd_np (int fd, acl_type_t type, acl_t* acl);

    // extern int acl_valid_file_np (const char *path, acl_type_t type, acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_valid_file_np (sbyte* path, acl_type_t type, acl_t* acl);

    // extern int acl_valid_link_np (const char *path, acl_type_t type, acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_valid_link_np (sbyte* path, acl_type_t type, acl_t* acl);

    // extern int acl_add_perm (acl_permset_t permset_d, acl_perm_t perm);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_add_perm (acl_permset_t* permset_d, acl_perm_t perm);

    // extern int acl_calc_mask (acl_t *acl_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_calc_mask (acl_t** acl_p);

    // extern int acl_clear_perms (acl_permset_t permset_d);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_clear_perms (acl_permset_t* permset_d);

    // extern int acl_delete_perm (acl_permset_t permset_d, acl_perm_t perm);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_delete_perm (acl_permset_t* permset_d, acl_perm_t perm);

    // extern int acl_get_perm_np (acl_permset_t permset_d, acl_perm_t perm);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_get_perm_np (acl_permset_t* permset_d, acl_perm_t perm);

    // extern int acl_get_permset (acl_entry_t entry_d, acl_permset_t *permset_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_get_permset (acl_entry_t* entry_d, acl_permset_t** permset_p);

    // extern int acl_set_permset (acl_entry_t entry_d, acl_permset_t permset_d);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_permset (acl_entry_t* entry_d, acl_permset_t* permset_d);

    // extern int acl_maximal_permset_mask_np (acl_permset_mask_t *mask_p) __attribute__((availability(ios, introduced=4.3)));
    [iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_maximal_permset_mask_np (ulong* mask_p);

    // extern int acl_get_permset_mask_np (acl_entry_t entry_d, acl_permset_mask_t *mask_p) __attribute__((availability(ios, introduced=4.3)));
    [iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_get_permset_mask_np (acl_entry_t* entry_d, ulong* mask_p);

    // extern int acl_set_permset_mask_np (acl_entry_t entry_d, acl_permset_mask_t mask) __attribute__((availability(ios, introduced=4.3)));
    [iOS (4,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_permset_mask_np (acl_entry_t* entry_d, ulong mask);

    // extern int acl_add_flag_np (acl_flagset_t flagset_d, acl_flag_t flag);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_add_flag_np (acl_flagset_t* flagset_d, acl_flag_t flag);

    // extern int acl_clear_flags_np (acl_flagset_t flagset_d);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_clear_flags_np (acl_flagset_t* flagset_d);

    // extern int acl_delete_flag_np (acl_flagset_t flagset_d, acl_flag_t flag);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_delete_flag_np (acl_flagset_t* flagset_d, acl_flag_t flag);

    // extern int acl_get_flag_np (acl_flagset_t flagset_d, acl_flag_t flag);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_get_flag_np (acl_flagset_t* flagset_d, acl_flag_t flag);

    // extern int acl_get_flagset_np (void *obj_p, acl_flagset_t *flagset_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_get_flagset_np (void* obj_p, acl_flagset_t** flagset_p);

    // extern int acl_set_flagset_np (void *obj_p, acl_flagset_t flagset_d);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_flagset_np (void* obj_p, acl_flagset_t* flagset_d);

    // extern void * acl_get_qualifier (acl_entry_t entry_d);
    [DllImport ("__Internal")]
    
    static extern unsafe void* acl_get_qualifier (acl_entry_t* entry_d);

    // extern int acl_get_tag_type (acl_entry_t entry_d, acl_tag_t *tag_type_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_get_tag_type (acl_entry_t* entry_d, acl_tag_t* tag_type_p);

    // extern int acl_set_qualifier (acl_entry_t entry_d, const void *tag_qualifier_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_qualifier (acl_entry_t* entry_d, void* tag_qualifier_p);

    // extern int acl_set_tag_type (acl_entry_t entry_d, acl_tag_t tag_type);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_tag_type (acl_entry_t* entry_d, acl_tag_t tag_type);

    // extern int acl_delete_def_file (const char *path_p);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_delete_def_file (sbyte* path_p);

    // extern acl_t acl_get_fd (int fd);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_get_fd (int fd);

    // extern acl_t acl_get_fd_np (int fd, acl_type_t type);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_get_fd_np (int fd, acl_type_t type);

    // extern acl_t acl_get_file (const char *path_p, acl_type_t type);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_get_file (sbyte* path_p, acl_type_t type);

    // extern acl_t acl_get_link_np (const char *path_p, acl_type_t type);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_get_link_np (sbyte* path_p, acl_type_t type);

    // extern int acl_set_fd (int fd, acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_fd (int fd, acl_t* acl);

    // extern int acl_set_fd_np (int fd, acl_t acl, acl_type_t acl_type);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_fd_np (int fd, acl_t* acl, acl_type_t acl_type);

    // extern int acl_set_file (const char *path_p, acl_type_t type, acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_file (sbyte* path_p, acl_type_t type, acl_t* acl);

    // extern int acl_set_link_np (const char *path_p, acl_type_t type, acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe int acl_set_link_np (sbyte* path_p, acl_type_t type, acl_t* acl);

    // extern ssize_t acl_copy_ext (void *buf_p, acl_t acl, ssize_t size);
    [DllImport ("__Internal")]
    
    static extern unsafe nint acl_copy_ext (void* buf_p, acl_t* acl, nint size);

    // extern ssize_t acl_copy_ext_native (void *buf_p, acl_t acl, ssize_t size);
    [DllImport ("__Internal")]
    
    static extern unsafe nint acl_copy_ext_native (void* buf_p, acl_t* acl, nint size);

    // extern acl_t acl_copy_int (const void *buf_p);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_copy_int (void* buf_p);

    // extern acl_t acl_copy_int_native (const void *buf_p);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_copy_int_native (void* buf_p);

    // extern acl_t acl_from_text (const char *buf_p);
    [DllImport ("__Internal")]
    
    static extern unsafe acl_t* acl_from_text (sbyte* buf_p);

    // extern ssize_t acl_size (acl_t acl);
    [DllImport ("__Internal")]
    
    static extern unsafe nint acl_size (acl_t* acl);

    // extern char * acl_to_text (acl_t acl, ssize_t *len_p);
    [DllImport ("__Internal")]
    
    static extern unsafe sbyte* acl_to_text (acl_t* acl, nint* len_p);

    // extern CFTypeID CFFileSecurityGetTypeID () __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFFileSecurityGetTypeID ();

    // extern CFFileSecurityRef CFFileSecurityCreate (CFAllocatorRef allocator) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFFileSecurityRef* CFFileSecurityCreate (CFAllocatorRef* allocator);

    // extern CFFileSecurityRef CFFileSecurityCreateCopy (CFAllocatorRef allocator, CFFileSecurityRef fileSec) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFFileSecurityRef* CFFileSecurityCreateCopy (CFAllocatorRef* allocator, CFFileSecurityRef* fileSec);

    // extern Boolean CFFileSecurityCopyOwnerUUID (CFFileSecurityRef fileSec, CFUUIDRef *ownerUUID) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecurityCopyOwnerUUID (CFFileSecurityRef* fileSec, CFUUIDRef** ownerUUID);

    // extern Boolean CFFileSecuritySetOwnerUUID (CFFileSecurityRef fileSec, CFUUIDRef ownerUUID) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecuritySetOwnerUUID (CFFileSecurityRef* fileSec, CFUUIDRef* ownerUUID);

    // extern Boolean CFFileSecurityCopyGroupUUID (CFFileSecurityRef fileSec, CFUUIDRef *groupUUID) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecurityCopyGroupUUID (CFFileSecurityRef* fileSec, CFUUIDRef** groupUUID);

    // extern Boolean CFFileSecuritySetGroupUUID (CFFileSecurityRef fileSec, CFUUIDRef groupUUID) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecuritySetGroupUUID (CFFileSecurityRef* fileSec, CFUUIDRef* groupUUID);

    // extern Boolean CFFileSecurityCopyAccessControlList (CFFileSecurityRef fileSec, acl_t *accessControlList) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecurityCopyAccessControlList (CFFileSecurityRef* fileSec, acl_t** accessControlList);

    // extern Boolean CFFileSecuritySetAccessControlList (CFFileSecurityRef fileSec, acl_t accessControlList) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecuritySetAccessControlList (CFFileSecurityRef* fileSec, acl_t* accessControlList);

    // extern Boolean CFFileSecurityGetOwner (CFFileSecurityRef fileSec, uid_t *owner) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecurityGetOwner (CFFileSecurityRef* fileSec, uint* owner);

    // extern Boolean CFFileSecuritySetOwner (CFFileSecurityRef fileSec, uid_t owner) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecuritySetOwner (CFFileSecurityRef* fileSec, uint owner);

    // extern Boolean CFFileSecurityGetGroup (CFFileSecurityRef fileSec, gid_t *group) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecurityGetGroup (CFFileSecurityRef* fileSec, uint* group);

    // extern Boolean CFFileSecuritySetGroup (CFFileSecurityRef fileSec, gid_t group) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecuritySetGroup (CFFileSecurityRef* fileSec, uint group);

    // extern Boolean CFFileSecurityGetMode (CFFileSecurityRef fileSec, mode_t *mode) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecurityGetMode (CFFileSecurityRef* fileSec, ushort* mode);

    // extern Boolean CFFileSecuritySetMode (CFFileSecurityRef fileSec, mode_t mode) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(macos, introduced=10.7))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecuritySetMode (CFFileSecurityRef* fileSec, ushort mode);

    // extern Boolean CFFileSecurityClearProperties (CFFileSecurityRef fileSec, CFFileSecurityClearOptions clearPropertyMask) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=6.0))) __attribute__((availability(macos, introduced=10.8))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,8), iOS (6,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileSecurityClearProperties (CFFileSecurityRef* fileSec, CFFileSecurityClearOptions clearPropertyMask);

    // extern CFStringRef CFStringTokenizerCopyBestStringLanguage (CFStringRef string, CFRange range) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFStringTokenizerCopyBestStringLanguage (CFStringRef* @string, CFRange range);

    // extern CFTypeID CFStringTokenizerGetTypeID () __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFStringTokenizerGetTypeID ();

    // extern CFStringTokenizerRef CFStringTokenizerCreate (CFAllocatorRef alloc, CFStringRef string, CFRange range, CFOptionFlags options, CFLocaleRef locale) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringTokenizerRef* CFStringTokenizerCreate (CFAllocatorRef* alloc, CFStringRef* @string, CFRange range, nuint options, CFLocaleRef* locale);

    // extern void CFStringTokenizerSetString (CFStringTokenizerRef tokenizer, CFStringRef string, CFRange range) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStringTokenizerSetString (CFStringTokenizerRef* tokenizer, CFStringRef* @string, CFRange range);

    // extern CFStringTokenizerTokenType CFStringTokenizerGoToTokenAtIndex (CFStringTokenizerRef tokenizer, CFIndex index) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringTokenizerTokenType CFStringTokenizerGoToTokenAtIndex (CFStringTokenizerRef* tokenizer, nint index);

    // extern CFStringTokenizerTokenType CFStringTokenizerAdvanceToNextToken (CFStringTokenizerRef tokenizer) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringTokenizerTokenType CFStringTokenizerAdvanceToNextToken (CFStringTokenizerRef* tokenizer);

    // extern CFRange CFStringTokenizerGetCurrentTokenRange (CFStringTokenizerRef tokenizer) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFRange CFStringTokenizerGetCurrentTokenRange (CFStringTokenizerRef* tokenizer);

    // extern CFTypeRef CFStringTokenizerCopyCurrentTokenAttribute (CFStringTokenizerRef tokenizer, CFOptionFlags attribute) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void* CFStringTokenizerCopyCurrentTokenAttribute (CFStringTokenizerRef* tokenizer, nuint attribute);

    // extern CFIndex CFStringTokenizerGetCurrentSubTokens (CFStringTokenizerRef tokenizer, CFRange *ranges, CFIndex maxRangeLength, CFMutableArrayRef derivedSubTokens) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFStringTokenizerGetCurrentSubTokens (CFStringTokenizerRef* tokenizer, CFRange* ranges, nint maxRangeLength, CFMutableArrayRef* derivedSubTokens);

    // extern CFTypeID CFFileDescriptorGetTypeID () __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFFileDescriptorGetTypeID ();

    // extern CFFileDescriptorRef CFFileDescriptorCreate (CFAllocatorRef allocator, CFFileDescriptorNativeDescriptor fd, Boolean closeOnInvalidate, CFFileDescriptorCallBack callout, const CFFileDescriptorContext *context) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFFileDescriptorRef* CFFileDescriptorCreate (CFAllocatorRef* allocator, int fd, byte closeOnInvalidate, CFFileDescriptorCallBack* callout, CFFileDescriptorContext* context);

    // extern CFFileDescriptorNativeDescriptor CFFileDescriptorGetNativeDescriptor (CFFileDescriptorRef f) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CFFileDescriptorGetNativeDescriptor (CFFileDescriptorRef* f);

    // extern void CFFileDescriptorGetContext (CFFileDescriptorRef f, CFFileDescriptorContext *context) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFFileDescriptorGetContext (CFFileDescriptorRef* f, CFFileDescriptorContext* context);

    // extern void CFFileDescriptorEnableCallBacks (CFFileDescriptorRef f, CFOptionFlags callBackTypes) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFFileDescriptorEnableCallBacks (CFFileDescriptorRef* f, nuint callBackTypes);

    // extern void CFFileDescriptorDisableCallBacks (CFFileDescriptorRef f, CFOptionFlags callBackTypes) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFFileDescriptorDisableCallBacks (CFFileDescriptorRef* f, nuint callBackTypes);

    // extern void CFFileDescriptorInvalidate (CFFileDescriptorRef f) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFFileDescriptorInvalidate (CFFileDescriptorRef* f);

    // extern Boolean CFFileDescriptorIsValid (CFFileDescriptorRef f) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFFileDescriptorIsValid (CFFileDescriptorRef* f);

    // extern CFRunLoopSourceRef CFFileDescriptorCreateRunLoopSource (CFAllocatorRef allocator, CFFileDescriptorRef f, CFIndex order) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopSourceRef* CFFileDescriptorCreateRunLoopSource (CFAllocatorRef* allocator, CFFileDescriptorRef* f, nint order);

    // extern NSString * _Nonnull NSStringFromSelector (SEL _Nonnull aSelector);
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromSelector (Selector aSelector);

    // extern SEL _Nonnull NSSelectorFromString (NSString * _Nonnull aSelectorName);
    [DllImport ("__Internal")]
    
    static extern Selector NSSelectorFromString (NSString aSelectorName);

    // extern NSString * _Nonnull NSStringFromClass (Class _Nonnull aClass);
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromClass (Class aClass);

    // extern Class _Nullable NSClassFromString (NSString * _Nonnull aClassName);
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern Class NSClassFromString (NSString aClassName);

    // extern NSString * _Nonnull NSStringFromProtocol (Protocol * _Nonnull proto) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromProtocol (Protocol proto);

    // extern Protocol * _Nullable NSProtocolFromString (NSString * _Nonnull namestr) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern Protocol NSProtocolFromString (NSString namestr);

    // extern const char * _Nonnull NSGetSizeAndAlignment (const char * _Nonnull typePtr, NSUInteger * _Nullable sizep, NSUInteger * _Nullable alignp);
    [DllImport ("__Internal")]
    
    static extern unsafe sbyte* NSGetSizeAndAlignment (sbyte* typePtr, [NullAllowed] nuint* sizep, [NullAllowed] nuint* alignp);

   
    // extern void NSLogv (NSString * _Nonnull format, va_list args) __attribute__((not_tail_called)) __attribute__((format(NSString, 1, 0)));
    [DllImport ("__Internal")]
    
    static extern unsafe void NSLogv (NSString format, sbyte* args);

    // extern NSZone * _Nonnull NSDefaultMallocZone ();
    [DllImport ("__Internal")]
    
    static extern unsafe NSZone* NSDefaultMallocZone ();

    // extern NSZone * _Nonnull NSCreateZone (NSUInteger startSize, NSUInteger granularity, BOOL canFree);
    [DllImport ("__Internal")]
    
    static extern unsafe NSZone* NSCreateZone (nuint startSize, nuint granularity, bool canFree);

    // extern void NSRecycleZone (NSZone * _Nonnull zone);
    [DllImport ("__Internal")]
    
    static extern unsafe void NSRecycleZone (NSZone* zone);

    // extern void NSSetZoneName (NSZone * _Nullable zone, NSString * _Nonnull name);
    [DllImport ("__Internal")]
    
    static extern unsafe void NSSetZoneName ([NullAllowed] NSZone* zone, NSString name);

    // extern NSString * _Nonnull NSZoneName (NSZone * _Nullable zone);
    [DllImport ("__Internal")]
    
    static extern unsafe NSString NSZoneName ([NullAllowed] NSZone* zone);

    // extern NSZone * _Nullable NSZoneFromPointer (void * _Nonnull ptr);
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe NSZone* NSZoneFromPointer (void* ptr);

    // extern void * _Nonnull NSZoneMalloc (NSZone * _Nullable zone, NSUInteger size);
    [DllImport ("__Internal")]
    
    static extern unsafe void* NSZoneMalloc ([NullAllowed] NSZone* zone, nuint size);

    // extern void * _Nonnull NSZoneCalloc (NSZone * _Nullable zone, NSUInteger numElems, NSUInteger byteSize);
    [DllImport ("__Internal")]
    
    static extern unsafe void* NSZoneCalloc ([NullAllowed] NSZone* zone, nuint numElems, nuint byteSize);

    // extern void * _Nonnull NSZoneRealloc (NSZone * _Nullable zone, void * _Nullable ptr, NSUInteger size);
    [DllImport ("__Internal")]
    
    static extern unsafe void* NSZoneRealloc ([NullAllowed] NSZone* zone, [NullAllowed] void* ptr, nuint size);

    // extern void NSZoneFree (NSZone * _Nullable zone, void * _Nonnull ptr);
    [DllImport ("__Internal")]
    
    static extern unsafe void NSZoneFree ([NullAllowed] NSZone* zone, void* ptr);

    // id _Nullable NSMakeCollectable (CFTypeRef _Nullable cf) __attribute__((ns_returns_retained)) __attribute__((always_inline)) __attribute__((ns_returns_retained));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe NSObject NSMakeCollectable ([NullAllowed] void* cf);

    // id _Nullable NSMakeCollectable (CFTypeRef _Nullable cf) __attribute__((ns_returns_retained)) __attribute__((always_inline)) __attribute__((ns_returns_retained));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe NSObject NSMakeCollectable ([NullAllowed] void* cf);

    // extern NSUInteger NSPageSize ();
    [DllImport ("__Internal")]
    
    static extern nuint NSPageSize ();

    // extern NSUInteger NSLogPageSize ();
    [DllImport ("__Internal")]
    
    static extern nuint NSLogPageSize ();

    // extern NSUInteger NSRoundUpToMultipleOfPageSize (NSUInteger bytes);
    [DllImport ("__Internal")]
    
    static extern nuint NSRoundUpToMultipleOfPageSize (nuint bytes);

    // extern NSUInteger NSRoundDownToMultipleOfPageSize (NSUInteger bytes);
    [DllImport ("__Internal")]
    
    static extern nuint NSRoundDownToMultipleOfPageSize (nuint bytes);

    // extern void * _Nonnull NSAllocateMemoryPages (NSUInteger bytes);
    [DllImport ("__Internal")]
    
    static extern unsafe void* NSAllocateMemoryPages (nuint bytes);

    // extern void NSDeallocateMemoryPages (void * _Nonnull ptr, NSUInteger bytes);
    [DllImport ("__Internal")]
    
    static extern unsafe void NSDeallocateMemoryPages (void* ptr, nuint bytes);

    // extern void NSCopyMemoryPages (const void * _Nonnull source, void * _Nonnull dest, NSUInteger bytes);
    [DllImport ("__Internal")]
    
    static extern unsafe void NSCopyMemoryPages (void* source, void* dest, nuint bytes);

    // extern NSUInteger NSRealMemoryAvailable () __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=6.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.8)));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Use NSProcessInfo instead")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSProcessInfo instead")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSProcessInfo instead")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSProcessInfo instead")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Use NSProcessInfo instead")]
    [Deprecated (PlatformName.iOS, 6, 0, message: "Use NSProcessInfo instead")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Use NSProcessInfo instead")]
    [Deprecated (PlatformName.MacOSX, 10, 8, message: "Use NSProcessInfo instead")]
    [DllImport ("__Internal")]
    
    static extern nuint NSRealMemoryAvailable ();

    // extern id _Nonnull NSAllocateObject (Class _Nonnull aClass, NSUInteger extraBytes, NSZone * _Nullable zone);
    [DllImport ("__Internal")]
    
    static extern unsafe NSObject NSAllocateObject (Class aClass, nuint extraBytes, [NullAllowed] NSZone* zone);

    // extern void NSDeallocateObject (id _Nonnull object);
    [DllImport ("__Internal")]
    
    static extern void NSDeallocateObject (NSObject @object);

    // extern id _Nonnull NSCopyObject (id _Nonnull object, NSUInteger extraBytes, NSZone * _Nullable zone) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(ios, introduced=2.0, deprecated=6.0))) __attribute__((availability(macos, introduced=10.0, deprecated=10.8)));
    [Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
    [Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
    [Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
    [Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
    [Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
    [Deprecated (PlatformName.iOS, 6, 0, message: "Not supported")]
    [Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
    [Deprecated (PlatformName.MacOSX, 10, 8, message: "Not supported")]
    [DllImport ("__Internal")]
    
    static extern unsafe NSObject NSCopyObject (NSObject @object, nuint extraBytes, [NullAllowed] NSZone* zone);

    // extern BOOL NSShouldRetainWithZone (id _Nonnull anObject, NSZone * _Nullable requestedZone);
    [DllImport ("__Internal")]
    
    static extern unsafe bool NSShouldRetainWithZone (NSObject anObject, [NullAllowed] NSZone* requestedZone);

    // extern void NSIncrementExtraRefCount (id _Nonnull object);
    [DllImport ("__Internal")]
    
    static extern void NSIncrementExtraRefCount (NSObject @object);

    // extern BOOL NSDecrementExtraRefCountWasZero (id _Nonnull object);
    [DllImport ("__Internal")]
    
    static extern bool NSDecrementExtraRefCountWasZero (NSObject @object);

    // extern NSUInteger NSExtraRefCount (id _Nonnull object);
    [DllImport ("__Internal")]
    
    static extern nuint NSExtraRefCount (NSObject @object);

    // CFTypeRef _Nullable CFBridgingRetain (id _Nullable X) __attribute__((cf_returns_retained)) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CFBridgingRetain ([NullAllowed] NSObject X);

    // id _Nullable CFBridgingRelease (CFTypeRef _Nullable X) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe NSObject CFBridgingRelease ([NullAllowed] void* X);

    // NSRange NSMakeRange (NSUInteger loc, NSUInteger len) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSRange NSMakeRange (nuint loc, nuint len);

    // NSUInteger NSMaxRange (NSRange range) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern nuint NSMaxRange (NSRange range);

    // BOOL NSLocationInRange (NSUInteger loc, NSRange range) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern bool NSLocationInRange (nuint loc, NSRange range);

    // BOOL NSEqualRanges (NSRange range1, NSRange range2) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern bool NSEqualRanges (NSRange range1, NSRange range2);

    // extern NSRange NSUnionRange (NSRange range1, NSRange range2);
    [DllImport ("__Internal")]
    
    static extern NSRange NSUnionRange (NSRange range1, NSRange range2);

    // extern NSRange NSIntersectionRange (NSRange range1, NSRange range2);
    [DllImport ("__Internal")]
    
    static extern NSRange NSIntersectionRange (NSRange range1, NSRange range2);

    // extern NSString * _Nonnull NSStringFromRange (NSRange range);
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromRange (NSRange range);

    // extern NSRange NSRangeFromString (NSString * _Nonnull aString);
    [DllImport ("__Internal")]
    
    static extern NSRange NSRangeFromString (NSString aString);

    // long NSHostByteOrder () __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern nint NSHostByteOrder ();

    // unsigned short NSSwapShort (unsigned short inv) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort NSSwapShort (ushort inv);

    // unsigned int NSSwapInt (unsigned int inv) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint NSSwapInt (uint inv);

    // unsigned long NSSwapLong (unsigned long inv) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern nuint NSSwapLong (nuint inv);

    // unsigned long long NSSwapLongLong (unsigned long long inv) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong NSSwapLongLong (ulong inv);

    // unsigned short NSSwapBigShortToHost (unsigned short x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort NSSwapBigShortToHost (ushort x);

    // unsigned int NSSwapBigIntToHost (unsigned int x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint NSSwapBigIntToHost (uint x);

    // unsigned long NSSwapBigLongToHost (unsigned long x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern nuint NSSwapBigLongToHost (nuint x);

    // unsigned long long NSSwapBigLongLongToHost (unsigned long long x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong NSSwapBigLongLongToHost (ulong x);

    // unsigned short NSSwapHostShortToBig (unsigned short x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort NSSwapHostShortToBig (ushort x);

    // unsigned int NSSwapHostIntToBig (unsigned int x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint NSSwapHostIntToBig (uint x);

    // unsigned long NSSwapHostLongToBig (unsigned long x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern nuint NSSwapHostLongToBig (nuint x);

    // unsigned long long NSSwapHostLongLongToBig (unsigned long long x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong NSSwapHostLongLongToBig (ulong x);

    // unsigned short NSSwapLittleShortToHost (unsigned short x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort NSSwapLittleShortToHost (ushort x);

    // unsigned int NSSwapLittleIntToHost (unsigned int x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint NSSwapLittleIntToHost (uint x);

    // unsigned long NSSwapLittleLongToHost (unsigned long x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern nuint NSSwapLittleLongToHost (nuint x);

    // unsigned long long NSSwapLittleLongLongToHost (unsigned long long x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong NSSwapLittleLongLongToHost (ulong x);

    // unsigned short NSSwapHostShortToLittle (unsigned short x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ushort NSSwapHostShortToLittle (ushort x);

    // unsigned int NSSwapHostIntToLittle (unsigned int x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern uint NSSwapHostIntToLittle (uint x);

    // unsigned long NSSwapHostLongToLittle (unsigned long x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern nuint NSSwapHostLongToLittle (nuint x);

    // unsigned long long NSSwapHostLongLongToLittle (unsigned long long x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern ulong NSSwapHostLongLongToLittle (ulong x);

    // NSSwappedFloat NSConvertHostFloatToSwapped (float x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSSwappedFloat NSConvertHostFloatToSwapped (float x);

    // float NSConvertSwappedFloatToHost (NSSwappedFloat x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern float NSConvertSwappedFloatToHost (NSSwappedFloat x);

    // NSSwappedDouble NSConvertHostDoubleToSwapped (double x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSSwappedDouble NSConvertHostDoubleToSwapped (double x);

    // double NSConvertSwappedDoubleToHost (NSSwappedDouble x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern double NSConvertSwappedDoubleToHost (NSSwappedDouble x);

    // NSSwappedFloat NSSwapFloat (NSSwappedFloat x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSSwappedFloat NSSwapFloat (NSSwappedFloat x);

    // NSSwappedDouble NSSwapDouble (NSSwappedDouble x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSSwappedDouble NSSwapDouble (NSSwappedDouble x);

    // double NSSwapBigDoubleToHost (NSSwappedDouble x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern double NSSwapBigDoubleToHost (NSSwappedDouble x);

    // float NSSwapBigFloatToHost (NSSwappedFloat x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern float NSSwapBigFloatToHost (NSSwappedFloat x);

    // NSSwappedDouble NSSwapHostDoubleToBig (double x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSSwappedDouble NSSwapHostDoubleToBig (double x);

    // NSSwappedFloat NSSwapHostFloatToBig (float x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSSwappedFloat NSSwapHostFloatToBig (float x);

    // double NSSwapLittleDoubleToHost (NSSwappedDouble x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern double NSSwapLittleDoubleToHost (NSSwappedDouble x);

    // float NSSwapLittleFloatToHost (NSSwappedFloat x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern float NSSwapLittleFloatToHost (NSSwappedFloat x);

    // NSSwappedDouble NSSwapHostDoubleToLittle (double x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSSwappedDouble NSSwapHostDoubleToLittle (double x);

    // NSSwappedFloat NSSwapHostFloatToLittle (float x) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern NSSwappedFloat NSSwapHostFloatToLittle (float x);

    // BOOL NSDecimalIsNotANumber (const NSDecimal * _Nonnull dcm) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern unsafe bool NSDecimalIsNotANumber (NSDecimal* dcm);

    // extern void NSDecimalCopy (NSDecimal * _Nonnull destination, const NSDecimal * _Nonnull source);
    [DllImport ("__Internal")]
    
    static extern unsafe void NSDecimalCopy (NSDecimal* destination, NSDecimal* source);

    // extern void NSDecimalCompact (NSDecimal * _Nonnull number);
    [DllImport ("__Internal")]
    
    static extern unsafe void NSDecimalCompact (NSDecimal* number);

    // extern NSComparisonResult NSDecimalCompare (const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand);
    [DllImport ("__Internal")]
    
    static extern unsafe NSComparisonResult NSDecimalCompare (NSDecimal* leftOperand, NSDecimal* rightOperand);

    // extern void NSDecimalRound (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull number, NSInteger scale, NSRoundingMode roundingMode);
    [DllImport ("__Internal")]
    
    static extern unsafe void NSDecimalRound (NSDecimal* result, NSDecimal* number, nint scale, NSRoundingMode roundingMode);

    // extern NSCalculationError NSDecimalNormalize (NSDecimal * _Nonnull number1, NSDecimal * _Nonnull number2, NSRoundingMode roundingMode);
    [DllImport ("__Internal")]
    
    static extern unsafe NSCalculationError NSDecimalNormalize (NSDecimal* number1, NSDecimal* number2, NSRoundingMode roundingMode);

    // extern NSCalculationError NSDecimalAdd (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand, NSRoundingMode roundingMode);
    [DllImport ("__Internal")]
    
    static extern unsafe NSCalculationError NSDecimalAdd (NSDecimal* result, NSDecimal* leftOperand, NSDecimal* rightOperand, NSRoundingMode roundingMode);

    // extern NSCalculationError NSDecimalSubtract (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand, NSRoundingMode roundingMode);
    [DllImport ("__Internal")]
    
    static extern unsafe NSCalculationError NSDecimalSubtract (NSDecimal* result, NSDecimal* leftOperand, NSDecimal* rightOperand, NSRoundingMode roundingMode);

    // extern NSCalculationError NSDecimalMultiply (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand, NSRoundingMode roundingMode);
    [DllImport ("__Internal")]
    
    static extern unsafe NSCalculationError NSDecimalMultiply (NSDecimal* result, NSDecimal* leftOperand, NSDecimal* rightOperand, NSRoundingMode roundingMode);

    // extern NSCalculationError NSDecimalDivide (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull leftOperand, const NSDecimal * _Nonnull rightOperand, NSRoundingMode roundingMode);
    [DllImport ("__Internal")]
    
    static extern unsafe NSCalculationError NSDecimalDivide (NSDecimal* result, NSDecimal* leftOperand, NSDecimal* rightOperand, NSRoundingMode roundingMode);

    // extern NSCalculationError NSDecimalPower (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull number, NSUInteger power, NSRoundingMode roundingMode);
    [DllImport ("__Internal")]
    
    static extern unsafe NSCalculationError NSDecimalPower (NSDecimal* result, NSDecimal* number, nuint power, NSRoundingMode roundingMode);

    // extern NSCalculationError NSDecimalMultiplyByPowerOf10 (NSDecimal * _Nonnull result, const NSDecimal * _Nonnull number, short power, NSRoundingMode roundingMode);
    [DllImport ("__Internal")]
    
    static extern unsafe NSCalculationError NSDecimalMultiplyByPowerOf10 (NSDecimal* result, NSDecimal* number, short power, NSRoundingMode roundingMode);

    // extern NSString * _Nonnull NSDecimalString (const NSDecimal * _Nonnull dcm, id _Nullable locale);
    [DllImport ("__Internal")]
    
    static extern unsafe NSString NSDecimalString (NSDecimal* dcm, [NullAllowed] NSObject locale);

    // extern NSUncaughtExceptionHandler * _Nullable NSGetUncaughtExceptionHandler ();
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe NSUncaughtExceptionHandler* NSGetUncaughtExceptionHandler ();

  
    // extern NSString * _Nonnull NSUserName ();
    [DllImport ("__Internal")]
    
    static extern NSString NSUserName ();

    // extern NSString * _Nonnull NSFullUserName ();
    [DllImport ("__Internal")]
    
    static extern NSString NSFullUserName ();

    // extern NSString * _Nonnull NSHomeDirectory ();
    [DllImport ("__Internal")]
    
    static extern NSString NSHomeDirectory ();

    // extern NSString * _Nullable NSHomeDirectoryForUser (NSString * _Nullable userName);
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern NSString NSHomeDirectoryForUser ([NullAllowed] NSString userName);

    // extern NSString * _Nonnull NSTemporaryDirectory ();
    [DllImport ("__Internal")]
    
    static extern NSString NSTemporaryDirectory ();

    // extern NSString * _Nonnull NSOpenStepRootDirectory ();
    [DllImport ("__Internal")]
    
    static extern NSString NSOpenStepRootDirectory ();

    // extern NSArray<NSString *> * _Nonnull NSSearchPathForDirectoriesInDomains (NSSearchPathDirectory directory, NSSearchPathDomainMask domainMask, BOOL expandTilde);
    [DllImport ("__Internal")]
    
    static extern NSString[] NSSearchPathForDirectoriesInDomains (NSSearchPathDirectory directory, NSSearchPathDomainMask domainMask, bool expandTilde);

    // extern CFTypeID SecCertificateGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint SecCertificateGetTypeID ();

    // extern SecCertificateRef _Nullable SecCertificateCreateWithData (CFAllocatorRef _Nullable allocator, CFDataRef _Nonnull data) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecCertificateRef* SecCertificateCreateWithData ([NullAllowed] CFAllocatorRef* allocator, CFDataRef* data);

    // extern CFDataRef _Nonnull SecCertificateCopyData (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* SecCertificateCopyData (SecCertificateRef* certificate);

    // extern CFStringRef _Nullable SecCertificateCopySubjectSummary (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* SecCertificateCopySubjectSummary (SecCertificateRef* certificate);

    // extern OSStatus SecCertificateCopyCommonName (SecCertificateRef _Nonnull certificate, CFStringRef  _Nullable * _Nonnull commonName) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
    [iOS (10,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecCertificateCopyCommonName (SecCertificateRef* certificate, [NullAllowed] CFStringRef** commonName);

    // extern OSStatus SecCertificateCopyEmailAddresses (SecCertificateRef _Nonnull certificate, CFArrayRef  _Nullable * _Nonnull emailAddresses) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
    [iOS (10,3)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecCertificateCopyEmailAddresses (SecCertificateRef* certificate, [NullAllowed] CFArrayRef** emailAddresses);

    // extern CFDataRef _Nullable SecCertificateCopyNormalizedIssuerSequence (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
    [iOS (10,3)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecCertificateCopyNormalizedIssuerSequence (SecCertificateRef* certificate);

    // extern CFDataRef _Nullable SecCertificateCopyNormalizedSubjectSequence (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
    [iOS (10,3)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecCertificateCopyNormalizedSubjectSequence (SecCertificateRef* certificate);

    // extern SecKeyRef _Nullable SecCertificateCopyPublicKey (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=10.3))) __attribute__((cf_audited_transfer));
    [iOS (10,3)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecKeyRef* SecCertificateCopyPublicKey (SecCertificateRef* certificate);

    // extern CFDataRef _Nullable SecCertificateCopySerialNumberData (SecCertificateRef _Nonnull certificate, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecCertificateCopySerialNumberData (SecCertificateRef* certificate, [NullAllowed] CFErrorRef** error);

    // extern CFDataRef _Nullable SecCertificateCopySerialNumber (SecCertificateRef _Nonnull certificate) __attribute__((availability(ios, introduced=10.3, deprecated=11.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 10, 3, message: "SecCertificateCopySerialNumber is deprecated. Use SecCertificateCopySerialNumberData instead.")]
    [Deprecated (PlatformName.iOS, 11, 0, message: "SecCertificateCopySerialNumber is deprecated. Use SecCertificateCopySerialNumberData instead.")]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecCertificateCopySerialNumber (SecCertificateRef* certificate);

    // extern CFTypeID SecIdentityGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint SecIdentityGetTypeID ();

    // extern OSStatus SecIdentityCopyCertificate (SecIdentityRef _Nonnull identityRef, SecCertificateRef  _Nullable * _Nonnull certificateRef) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecIdentityCopyCertificate (SecIdentityRef* identityRef, [NullAllowed] SecCertificateRef** certificateRef);

    // extern OSStatus SecIdentityCopyPrivateKey (SecIdentityRef _Nonnull identityRef, SecKeyRef  _Nullable * _Nonnull privateKeyRef) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecIdentityCopyPrivateKey (SecIdentityRef* identityRef, [NullAllowed] SecKeyRef** privateKeyRef);

    // extern CFTypeID SecAccessControlGetTypeID () __attribute__((availability(ios, introduced=8.0))) __attribute__((cf_audited_transfer));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern nuint SecAccessControlGetTypeID ();

    // extern SecAccessControlRef _Nullable SecAccessControlCreateWithFlags (CFAllocatorRef _Nullable allocator, CFTypeRef _Nonnull protection, SecAccessControlCreateFlags flags, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(ios, introduced=8.0))) __attribute__((cf_audited_transfer));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecAccessControlRef* SecAccessControlCreateWithFlags ([NullAllowed] CFAllocatorRef* allocator, void* protection, SecAccessControlCreateFlags flags, [NullAllowed] CFErrorRef** error);

    // extern OSStatus SecItemCopyMatching (CFDictionaryRef _Nonnull query, CFTypeRef  _Nullable * _Nullable result) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecItemCopyMatching (CFDictionaryRef* query, [NullAllowed] void** result);

    // extern OSStatus SecItemAdd (CFDictionaryRef _Nonnull attributes, CFTypeRef  _Nullable * _Nullable result) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecItemAdd (CFDictionaryRef* attributes, [NullAllowed] void** result);

    // extern OSStatus SecItemUpdate (CFDictionaryRef _Nonnull query, CFDictionaryRef _Nonnull attributesToUpdate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecItemUpdate (CFDictionaryRef* query, CFDictionaryRef* attributesToUpdate);

    // extern OSStatus SecItemDelete (CFDictionaryRef _Nonnull query) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecItemDelete (CFDictionaryRef* query);

    // extern CFTypeID SecKeyGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint SecKeyGetTypeID ();

    // extern OSStatus SecKeyGeneratePair (CFDictionaryRef _Nonnull parameters, SecKeyRef  _Nullable * _Nullable publicKey, SecKeyRef  _Nullable * _Nullable privateKey) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecKeyGeneratePair (CFDictionaryRef* parameters, [NullAllowed] SecKeyRef** publicKey, [NullAllowed] SecKeyRef** privateKey);

    // extern OSStatus SecKeyRawSign (SecKeyRef _Nonnull key, SecPadding padding, const uint8_t * _Nonnull dataToSign, size_t dataToSignLen, uint8_t * _Nonnull sig, size_t * _Nonnull sigLen) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecKeyRawSign (SecKeyRef* key, SecPadding padding, byte* dataToSign, nuint dataToSignLen, byte* sig, nuint* sigLen);

    // extern OSStatus SecKeyRawVerify (SecKeyRef _Nonnull key, SecPadding padding, const uint8_t * _Nonnull signedData, size_t signedDataLen, const uint8_t * _Nonnull sig, size_t sigLen) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecKeyRawVerify (SecKeyRef* key, SecPadding padding, byte* signedData, nuint signedDataLen, byte* sig, nuint sigLen);

    // extern OSStatus SecKeyEncrypt (SecKeyRef _Nonnull key, SecPadding padding, const uint8_t * _Nonnull plainText, size_t plainTextLen, uint8_t * _Nonnull cipherText, size_t * _Nonnull cipherTextLen) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecKeyEncrypt (SecKeyRef* key, SecPadding padding, byte* plainText, nuint plainTextLen, byte* cipherText, nuint* cipherTextLen);

    // extern OSStatus SecKeyDecrypt (SecKeyRef _Nonnull key, SecPadding padding, const uint8_t * _Nonnull cipherText, size_t cipherTextLen, uint8_t * _Nonnull plainText, size_t * _Nonnull plainTextLen) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecKeyDecrypt (SecKeyRef* key, SecPadding padding, byte* cipherText, nuint cipherTextLen, byte* plainText, nuint* plainTextLen);

    // extern SecKeyRef _Nullable SecKeyCreateRandomKey (CFDictionaryRef _Nonnull parameters, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecKeyRef* SecKeyCreateRandomKey (CFDictionaryRef* parameters, [NullAllowed] CFErrorRef** error);

    // extern SecKeyRef _Nullable SecKeyCreateWithData (CFDataRef _Nonnull keyData, CFDictionaryRef _Nonnull attributes, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecKeyRef* SecKeyCreateWithData (CFDataRef* keyData, CFDictionaryRef* attributes, [NullAllowed] CFErrorRef** error);

    // extern size_t SecKeyGetBlockSize (SecKeyRef _Nonnull key) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint SecKeyGetBlockSize (SecKeyRef* key);

    // extern CFDataRef _Nullable SecKeyCopyExternalRepresentation (SecKeyRef _Nonnull key, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecKeyCopyExternalRepresentation (SecKeyRef* key, [NullAllowed] CFErrorRef** error);

    // extern CFDictionaryRef _Nullable SecKeyCopyAttributes (SecKeyRef _Nonnull key) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* SecKeyCopyAttributes (SecKeyRef* key);

    // extern SecKeyRef _Nullable SecKeyCopyPublicKey (SecKeyRef _Nonnull key) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecKeyRef* SecKeyCopyPublicKey (SecKeyRef* key);

    // extern CFDataRef _Nullable SecKeyCreateSignature (SecKeyRef _Nonnull key, SecKeyAlgorithm _Nonnull algorithm, CFDataRef _Nonnull dataToSign, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecKeyCreateSignature (SecKeyRef* key, SecKeyAlgorithm* algorithm, CFDataRef* dataToSign, [NullAllowed] CFErrorRef** error);

    // extern Boolean SecKeyVerifySignature (SecKeyRef _Nonnull key, SecKeyAlgorithm _Nonnull algorithm, CFDataRef _Nonnull signedData, CFDataRef _Nonnull signature, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte SecKeyVerifySignature (SecKeyRef* key, SecKeyAlgorithm* algorithm, CFDataRef* signedData, CFDataRef* signature, [NullAllowed] CFErrorRef** error);

    // extern CFDataRef _Nullable SecKeyCreateEncryptedData (SecKeyRef _Nonnull key, SecKeyAlgorithm _Nonnull algorithm, CFDataRef _Nonnull plaintext, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecKeyCreateEncryptedData (SecKeyRef* key, SecKeyAlgorithm* algorithm, CFDataRef* plaintext, [NullAllowed] CFErrorRef** error);

    // extern CFDataRef _Nullable SecKeyCreateDecryptedData (SecKeyRef _Nonnull key, SecKeyAlgorithm _Nonnull algorithm, CFDataRef _Nonnull ciphertext, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecKeyCreateDecryptedData (SecKeyRef* key, SecKeyAlgorithm* algorithm, CFDataRef* ciphertext, [NullAllowed] CFErrorRef** error);

    // extern CFDataRef _Nullable SecKeyCopyKeyExchangeResult (SecKeyRef _Nonnull privateKey, SecKeyAlgorithm _Nonnull algorithm, SecKeyRef _Nonnull publicKey, CFDictionaryRef _Nonnull parameters, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* SecKeyCopyKeyExchangeResult (SecKeyRef* privateKey, SecKeyAlgorithm* algorithm, SecKeyRef* publicKey, CFDictionaryRef* parameters, [NullAllowed] CFErrorRef** error);

    // extern Boolean SecKeyIsAlgorithmSupported (SecKeyRef _Nonnull key, SecKeyOperationType operation, SecKeyAlgorithm _Nonnull algorithm) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(macos, introduced=10.12))) __attribute__((cf_audited_transfer));
    [Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte SecKeyIsAlgorithmSupported (SecKeyRef* key, SecKeyOperationType operation, SecKeyAlgorithm* algorithm);

    // extern CFTypeID SecPolicyGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint SecPolicyGetTypeID ();

    // extern CFDictionaryRef _Nullable SecPolicyCopyProperties (SecPolicyRef _Nonnull policyRef) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* SecPolicyCopyProperties (SecPolicyRef* policyRef);

    // extern SecPolicyRef _Nonnull SecPolicyCreateBasicX509 () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe SecPolicyRef* SecPolicyCreateBasicX509 ();

    // extern SecPolicyRef _Nonnull SecPolicyCreateSSL (Boolean server, CFStringRef _Nullable hostname) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe SecPolicyRef* SecPolicyCreateSSL (byte server, [NullAllowed] CFStringRef* hostname);

    // extern SecPolicyRef _Nullable SecPolicyCreateRevocation (CFOptionFlags revocationFlags) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecPolicyRef* SecPolicyCreateRevocation (nuint revocationFlags);

    // extern SecPolicyRef _Nullable SecPolicyCreateWithProperties (CFTypeRef _Nonnull policyIdentifier, CFDictionaryRef _Nullable properties) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecPolicyRef* SecPolicyCreateWithProperties (void* policyIdentifier, [NullAllowed] CFDictionaryRef* properties);

    // extern int SecRandomCopyBytes (SecRandomRef _Nullable rnd, size_t count, void * _Nonnull bytes) __attribute__((availability(ios, introduced=2.0))) __attribute__((warn_unused_result)) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecRandomCopyBytes ([NullAllowed] SecRandomRef* rnd, nuint count, void* bytes);

    // extern OSStatus SecPKCS12Import (CFDataRef _Nonnull pkcs12_data, CFDictionaryRef _Nonnull options, CFArrayRef  _Nullable * _Nonnull items) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecPKCS12Import (CFDataRef* pkcs12_data, CFDictionaryRef* options, [NullAllowed] CFArrayRef** items);

    // extern CFTypeID SecTrustGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint SecTrustGetTypeID ();

    // extern OSStatus SecTrustCreateWithCertificates (CFTypeRef _Nonnull certificates, CFTypeRef _Nullable policies, SecTrustRef  _Nullable * _Nonnull trust) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustCreateWithCertificates (void* certificates, [NullAllowed] void* policies, [NullAllowed] SecTrustRef** trust);

    // extern OSStatus SecTrustSetPolicies (SecTrustRef _Nonnull trust, CFTypeRef _Nonnull policies) __attribute__((availability(ios, introduced=6.0))) __attribute__((cf_audited_transfer));
    [iOS (6,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustSetPolicies (SecTrustRef* trust, void* policies);

    // extern OSStatus SecTrustCopyPolicies (SecTrustRef _Nonnull trust, CFArrayRef  _Nullable * _Nonnull policies) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustCopyPolicies (SecTrustRef* trust, [NullAllowed] CFArrayRef** policies);

    // extern OSStatus SecTrustSetNetworkFetchAllowed (SecTrustRef _Nonnull trust, Boolean allowFetch) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustSetNetworkFetchAllowed (SecTrustRef* trust, byte allowFetch);

    // extern OSStatus SecTrustGetNetworkFetchAllowed (SecTrustRef _Nonnull trust, Boolean * _Nonnull allowFetch) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustGetNetworkFetchAllowed (SecTrustRef* trust, byte* allowFetch);

    // extern OSStatus SecTrustSetAnchorCertificates (SecTrustRef _Nonnull trust, CFArrayRef _Nonnull anchorCertificates) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustSetAnchorCertificates (SecTrustRef* trust, CFArrayRef* anchorCertificates);

    // extern OSStatus SecTrustSetAnchorCertificatesOnly (SecTrustRef _Nonnull trust, Boolean anchorCertificatesOnly) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustSetAnchorCertificatesOnly (SecTrustRef* trust, byte anchorCertificatesOnly);

    // extern OSStatus SecTrustCopyCustomAnchorCertificates (SecTrustRef _Nonnull trust, CFArrayRef  _Nullable * _Nonnull anchors) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustCopyCustomAnchorCertificates (SecTrustRef* trust, [NullAllowed] CFArrayRef** anchors);

    // extern OSStatus SecTrustSetVerifyDate (SecTrustRef _Nonnull trust, CFDateRef _Nonnull verifyDate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustSetVerifyDate (SecTrustRef* trust, CFDateRef* verifyDate);

    // extern CFAbsoluteTime SecTrustGetVerifyTime (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe double SecTrustGetVerifyTime (SecTrustRef* trust);

    // extern OSStatus SecTrustEvaluate (SecTrustRef _Nonnull trust, SecTrustResultType * _Nullable result) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustEvaluate (SecTrustRef* trust, [NullAllowed] SecTrustResultType* result);

    // extern OSStatus SecTrustEvaluateAsync (SecTrustRef _Nonnull trust, dispatch_queue_t _Nullable queue, SecTrustCallback _Nonnull result) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustEvaluateAsync (SecTrustRef* trust, [NullAllowed] DispatchQueue queue, SecTrustCallback result);

    // extern OSStatus SecTrustGetTrustResult (SecTrustRef _Nonnull trust, SecTrustResultType * _Nonnull result) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustGetTrustResult (SecTrustRef* trust, SecTrustResultType* result);

    // extern SecKeyRef _Nullable SecTrustCopyPublicKey (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecKeyRef* SecTrustCopyPublicKey (SecTrustRef* trust);

    // extern CFIndex SecTrustGetCertificateCount (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint SecTrustGetCertificateCount (SecTrustRef* trust);

    // extern SecCertificateRef _Nullable SecTrustGetCertificateAtIndex (SecTrustRef _Nonnull trust, CFIndex ix) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SecCertificateRef* SecTrustGetCertificateAtIndex (SecTrustRef* trust, nint ix);

    // extern CFDataRef _Nonnull SecTrustCopyExceptions (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDataRef* SecTrustCopyExceptions (SecTrustRef* trust);

    // extern _Bool SecTrustSetExceptions (SecTrustRef _Nonnull trust, CFDataRef _Nullable exceptions) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool SecTrustSetExceptions (SecTrustRef* trust, [NullAllowed] CFDataRef* exceptions);

    // extern CFArrayRef _Nullable SecTrustCopyProperties (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* SecTrustCopyProperties (SecTrustRef* trust);

    // extern CFDictionaryRef _Nullable SecTrustCopyResult (SecTrustRef _Nonnull trust) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* SecTrustCopyResult (SecTrustRef* trust);

    // extern OSStatus SecTrustSetOCSPResponse (SecTrustRef _Nonnull trust, CFTypeRef _Nullable responseData) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SecTrustSetOCSPResponse (SecTrustRef* trust, [NullAllowed] void* responseData);

    // extern void SecAddSharedWebCredential (CFStringRef _Nonnull fqdn, CFStringRef _Nonnull account, CFStringRef _Nullable password, void (^ _Nonnull)(CFErrorRef _Nullable) completionHandler) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=8.0))) __attribute__((cf_audited_transfer));
    [NoWatch, NoTV, iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void SecAddSharedWebCredential (CFStringRef* fqdn, CFStringRef* account, [NullAllowed] CFStringRef* password, Action<CoreFoundation.CFErrorRef*> completionHandler);

    // extern void SecRequestSharedWebCredential (CFStringRef _Nullable fqdn, CFStringRef _Nullable account, void (^ _Nonnull)(CFArrayRef _Nullable, CFErrorRef _Nullable) completionHandler) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=8.0))) __attribute__((cf_audited_transfer));
    [NoWatch, NoTV, iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void SecRequestSharedWebCredential ([NullAllowed] CFStringRef* fqdn, [NullAllowed] CFStringRef* account, Action<CoreFoundation.CFArrayRef*, CoreFoundation.CFErrorRef*> completionHandler);

    // extern CFStringRef _Nullable SecCreateSharedWebCredentialPassword () __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=8.0))) __attribute__((cf_audited_transfer));
    [NoWatch, NoTV, iOS (8,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* SecCreateSharedWebCredentialPassword ();

    // extern CFTypeID CFHostGetTypeID () __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFHostGetTypeID ();

    // extern CFHostRef _Nonnull CFHostCreateWithName (CFAllocatorRef _Nullable allocator, CFStringRef _Nonnull hostname) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFHostRef* CFHostCreateWithName ([NullAllowed] CFAllocatorRef* allocator, CFStringRef* hostname);

    // extern CFHostRef _Nonnull CFHostCreateWithAddress (CFAllocatorRef _Nullable allocator, CFDataRef _Nonnull addr) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFHostRef* CFHostCreateWithAddress ([NullAllowed] CFAllocatorRef* allocator, CFDataRef* addr);

    // extern CFHostRef _Nonnull CFHostCreateCopy (CFAllocatorRef _Nullable alloc, CFHostRef _Nonnull host) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFHostRef* CFHostCreateCopy ([NullAllowed] CFAllocatorRef* alloc, CFHostRef* host);

    // extern Boolean CFHostStartInfoResolution (CFHostRef _Nonnull theHost, CFHostInfoType info, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHostStartInfoResolution (CFHostRef* theHost, CFHostInfoType info, [NullAllowed] CFStreamError* error);

    // extern CFArrayRef _Nullable CFHostGetAddressing (CFHostRef _Nonnull theHost, Boolean * _Nullable hasBeenResolved) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CFHostGetAddressing (CFHostRef* theHost, [NullAllowed] byte* hasBeenResolved);

    // extern CFArrayRef _Nullable CFHostGetNames (CFHostRef _Nonnull theHost, Boolean * _Nullable hasBeenResolved) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CFHostGetNames (CFHostRef* theHost, [NullAllowed] byte* hasBeenResolved);

    // extern CFDataRef _Nullable CFHostGetReachability (CFHostRef _Nonnull theHost, Boolean * _Nullable hasBeenResolved) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CFHostGetReachability (CFHostRef* theHost, [NullAllowed] byte* hasBeenResolved);

    // extern void CFHostCancelInfoResolution (CFHostRef _Nonnull theHost, CFHostInfoType info) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFHostCancelInfoResolution (CFHostRef* theHost, CFHostInfoType info);

    // extern Boolean CFHostSetClient (CFHostRef _Nonnull theHost, CFHostClientCallBack _Nullable clientCB, CFHostClientContext * _Nullable clientContext) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHostSetClient (CFHostRef* theHost, [NullAllowed] CFHostClientCallBack* clientCB, [NullAllowed] CFHostClientContext* clientContext);

    // extern void CFHostScheduleWithRunLoop (CFHostRef _Nonnull theHost, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFHostScheduleWithRunLoop (CFHostRef* theHost, CFRunLoopRef* runLoop, CFStringRef* runLoopMode);

    // extern void CFHostUnscheduleFromRunLoop (CFHostRef _Nonnull theHost, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFHostUnscheduleFromRunLoop (CFHostRef* theHost, CFRunLoopRef* runLoop, CFStringRef* runLoopMode);

    // extern CFTypeID CFNetServiceGetTypeID () __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFNetServiceGetTypeID ();

    // extern CFTypeID CFNetServiceMonitorGetTypeID () __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFNetServiceMonitorGetTypeID ();

    // extern CFTypeID CFNetServiceBrowserGetTypeID () __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFNetServiceBrowserGetTypeID ();

    // extern CFNetServiceRef _Nonnull CFNetServiceCreate (CFAllocatorRef _Nullable alloc, CFStringRef _Nonnull domain, CFStringRef _Nonnull serviceType, CFStringRef _Nonnull name, SInt32 port) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFNetServiceRef* CFNetServiceCreate ([NullAllowed] CFAllocatorRef* alloc, CFStringRef* domain, CFStringRef* serviceType, CFStringRef* name, int port);

    // extern CFNetServiceRef _Nonnull CFNetServiceCreateCopy (CFAllocatorRef _Nullable alloc, CFNetServiceRef _Nonnull service) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFNetServiceRef* CFNetServiceCreateCopy ([NullAllowed] CFAllocatorRef* alloc, CFNetServiceRef* service);

    // extern CFStringRef _Nonnull CFNetServiceGetDomain (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFNetServiceGetDomain (CFNetServiceRef* theService);

    // extern CFStringRef _Nonnull CFNetServiceGetType (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFNetServiceGetType (CFNetServiceRef* theService);

    // extern CFStringRef _Nonnull CFNetServiceGetName (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFNetServiceGetName (CFNetServiceRef* theService);

    // extern Boolean CFNetServiceRegisterWithOptions (CFNetServiceRef _Nonnull theService, CFOptionFlags options, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceRegisterWithOptions (CFNetServiceRef* theService, nuint options, [NullAllowed] CFStreamError* error);

    // extern Boolean CFNetServiceResolveWithTimeout (CFNetServiceRef _Nonnull theService, CFTimeInterval timeout, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceResolveWithTimeout (CFNetServiceRef* theService, double timeout, [NullAllowed] CFStreamError* error);

    // extern void CFNetServiceCancel (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceCancel (CFNetServiceRef* theService);

    // extern CFStringRef _Nullable CFNetServiceGetTargetHost (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CFNetServiceGetTargetHost (CFNetServiceRef* theService);

    // extern SInt32 CFNetServiceGetPortNumber (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CFNetServiceGetPortNumber (CFNetServiceRef* theService);

    // extern CFArrayRef _Nullable CFNetServiceGetAddressing (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CFNetServiceGetAddressing (CFNetServiceRef* theService);

    // extern CFDataRef _Nullable CFNetServiceGetTXTData (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CFNetServiceGetTXTData (CFNetServiceRef* theService);

    // extern Boolean CFNetServiceSetTXTData (CFNetServiceRef _Nonnull theService, CFDataRef _Nonnull txtRecord) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceSetTXTData (CFNetServiceRef* theService, CFDataRef* txtRecord);

    // extern CFDictionaryRef _Nullable CFNetServiceCreateDictionaryWithTXTData (CFAllocatorRef _Nullable alloc, CFDataRef _Nonnull txtRecord) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CFNetServiceCreateDictionaryWithTXTData ([NullAllowed] CFAllocatorRef* alloc, CFDataRef* txtRecord);

    // extern CFDataRef _Nullable CFNetServiceCreateTXTDataWithDictionary (CFAllocatorRef _Nullable alloc, CFDictionaryRef _Nonnull keyValuePairs) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CFNetServiceCreateTXTDataWithDictionary ([NullAllowed] CFAllocatorRef* alloc, CFDictionaryRef* keyValuePairs);

    // extern Boolean CFNetServiceSetClient (CFNetServiceRef _Nonnull theService, CFNetServiceClientCallBack _Nullable clientCB, CFNetServiceClientContext * _Nullable clientContext) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceSetClient (CFNetServiceRef* theService, [NullAllowed] CFNetServiceClientCallBack* clientCB, [NullAllowed] CFNetServiceClientContext* clientContext);

    // extern void CFNetServiceScheduleWithRunLoop (CFNetServiceRef _Nonnull theService, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceScheduleWithRunLoop (CFNetServiceRef* theService, CFRunLoopRef* runLoop, CFStringRef* runLoopMode);

    // extern void CFNetServiceUnscheduleFromRunLoop (CFNetServiceRef _Nonnull theService, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceUnscheduleFromRunLoop (CFNetServiceRef* theService, CFRunLoopRef* runLoop, CFStringRef* runLoopMode);

    // extern CFNetServiceMonitorRef _Nonnull CFNetServiceMonitorCreate (CFAllocatorRef _Nullable alloc, CFNetServiceRef _Nonnull theService, CFNetServiceMonitorClientCallBack _Nonnull clientCB, CFNetServiceClientContext * _Nonnull clientContext) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFNetServiceMonitorRef* CFNetServiceMonitorCreate ([NullAllowed] CFAllocatorRef* alloc, CFNetServiceRef* theService, CFNetServiceMonitorClientCallBack* clientCB, CFNetServiceClientContext* clientContext);

    // extern void CFNetServiceMonitorInvalidate (CFNetServiceMonitorRef _Nonnull monitor) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceMonitorInvalidate (CFNetServiceMonitorRef* monitor);

    // extern Boolean CFNetServiceMonitorStart (CFNetServiceMonitorRef _Nonnull monitor, CFNetServiceMonitorType recordType, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceMonitorStart (CFNetServiceMonitorRef* monitor, CFNetServiceMonitorType recordType, [NullAllowed] CFStreamError* error);

    // extern void CFNetServiceMonitorStop (CFNetServiceMonitorRef _Nonnull monitor, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceMonitorStop (CFNetServiceMonitorRef* monitor, [NullAllowed] CFStreamError* error);

    // extern void CFNetServiceMonitorScheduleWithRunLoop (CFNetServiceMonitorRef _Nonnull monitor, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceMonitorScheduleWithRunLoop (CFNetServiceMonitorRef* monitor, CFRunLoopRef* runLoop, CFStringRef* runLoopMode);

    // extern void CFNetServiceMonitorUnscheduleFromRunLoop (CFNetServiceMonitorRef _Nonnull monitor, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceMonitorUnscheduleFromRunLoop (CFNetServiceMonitorRef* monitor, CFRunLoopRef* runLoop, CFStringRef* runLoopMode);

    // extern CFNetServiceBrowserRef _Nonnull CFNetServiceBrowserCreate (CFAllocatorRef _Nullable alloc, CFNetServiceBrowserClientCallBack _Nonnull clientCB, CFNetServiceClientContext * _Nonnull clientContext) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFNetServiceBrowserRef* CFNetServiceBrowserCreate ([NullAllowed] CFAllocatorRef* alloc, CFNetServiceBrowserClientCallBack* clientCB, CFNetServiceClientContext* clientContext);

    // extern void CFNetServiceBrowserInvalidate (CFNetServiceBrowserRef _Nonnull browser) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceBrowserInvalidate (CFNetServiceBrowserRef* browser);

    // extern Boolean CFNetServiceBrowserSearchForDomains (CFNetServiceBrowserRef _Nonnull browser, Boolean registrationDomains, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceBrowserSearchForDomains (CFNetServiceBrowserRef* browser, byte registrationDomains, [NullAllowed] CFStreamError* error);

    // extern Boolean CFNetServiceBrowserSearchForServices (CFNetServiceBrowserRef _Nonnull browser, CFStringRef _Nonnull domain, CFStringRef _Nonnull serviceType, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceBrowserSearchForServices (CFNetServiceBrowserRef* browser, CFStringRef* domain, CFStringRef* serviceType, [NullAllowed] CFStreamError* error);

    // extern void CFNetServiceBrowserStopSearch (CFNetServiceBrowserRef _Nonnull browser, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceBrowserStopSearch (CFNetServiceBrowserRef* browser, [NullAllowed] CFStreamError* error);

    // extern void CFNetServiceBrowserScheduleWithRunLoop (CFNetServiceBrowserRef _Nonnull browser, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceBrowserScheduleWithRunLoop (CFNetServiceBrowserRef* browser, CFRunLoopRef* runLoop, CFStringRef* runLoopMode);

    // extern void CFNetServiceBrowserUnscheduleFromRunLoop (CFNetServiceBrowserRef _Nonnull browser, CFRunLoopRef _Nonnull runLoop, CFStringRef _Nonnull runLoopMode) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceBrowserUnscheduleFromRunLoop (CFNetServiceBrowserRef* browser, CFRunLoopRef* runLoop, CFStringRef* runLoopMode);

    // extern Boolean CFNetServiceRegister (CFNetServiceRef _Nonnull theService, CFStreamError * _Nullable error) __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceRegister (CFNetServiceRef* theService, [NullAllowed] CFStreamError* error);

    // extern Boolean CFNetServiceResolve (CFNetServiceRef _Nonnull theService, CFStreamError * _Nullable error) __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFNetServiceResolve (CFNetServiceRef* theService, [NullAllowed] CFStreamError* error);

    // extern CFStringRef _Nullable CFNetServiceGetProtocolSpecificInformation (CFNetServiceRef _Nonnull theService) __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CFNetServiceGetProtocolSpecificInformation (CFNetServiceRef* theService);

    // extern void CFNetServiceSetProtocolSpecificInformation (CFNetServiceRef _Nonnull theService, CFStringRef _Nullable theInfo) __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetServiceSetProtocolSpecificInformation (CFNetServiceRef* theService, [NullAllowed] CFStringRef* theInfo);

    // SInt32 CFSocketStreamSOCKSGetErrorSubdomain (const CFStreamError * _Nonnull error) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern unsafe int CFSocketStreamSOCKSGetErrorSubdomain (CFStreamError* error);

    // SInt32 CFSocketStreamSOCKSGetError (const CFStreamError * _Nonnull error) __attribute__((always_inline));
    [DllImport ("__Internal")]
    
    static extern unsafe int CFSocketStreamSOCKSGetError (CFStreamError* error);

    // extern void CFStreamCreatePairWithSocketToCFHost (CFAllocatorRef _Nullable alloc, CFHostRef _Nonnull host, SInt32 port, CFReadStreamRef  _Nullable * _Nullable readStream, CFWriteStreamRef  _Nullable * _Nullable writeStream) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStreamCreatePairWithSocketToCFHost ([NullAllowed] CFAllocatorRef* alloc, CFHostRef* host, int port, [NullAllowed] CFReadStreamRef** readStream, [NullAllowed] CFWriteStreamRef** writeStream);

    // extern void CFStreamCreatePairWithSocketToNetService (CFAllocatorRef _Nullable alloc, CFNetServiceRef _Nonnull service, CFReadStreamRef  _Nullable * _Nullable readStream, CFWriteStreamRef  _Nullable * _Nullable writeStream) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFStreamCreatePairWithSocketToNetService ([NullAllowed] CFAllocatorRef* alloc, CFNetServiceRef* service, [NullAllowed] CFReadStreamRef** readStream, [NullAllowed] CFWriteStreamRef** writeStream);

    // extern CFReadStreamRef _Nonnull CFReadStreamCreateWithFTPURL (CFAllocatorRef _Nullable alloc, CFURLRef _Nonnull ftpURL) __attribute__((availability(ios, introduced=2_0, deprecated=9_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
    [Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFReadStreamRef* CFReadStreamCreateWithFTPURL ([NullAllowed] CFAllocatorRef* alloc, CFURLRef* ftpURL);

    // extern CFIndex CFFTPCreateParsedResourceListing (CFAllocatorRef _Nullable alloc, const UInt8 * _Nonnull buffer, CFIndex bufferLength, CFDictionaryRef  _Nullable * _Nullable parsed) __attribute__((availability(ios, introduced=2_0, deprecated=9_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
    [Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFFTPCreateParsedResourceListing ([NullAllowed] CFAllocatorRef* alloc, byte* buffer, nint bufferLength, [NullAllowed] CFDictionaryRef** parsed);

    // extern CFWriteStreamRef _Nonnull CFWriteStreamCreateWithFTPURL (CFAllocatorRef _Nullable alloc, CFURLRef _Nonnull ftpURL) __attribute__((availability(ios, introduced=2_0, deprecated=9_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
    [Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFWriteStreamRef* CFWriteStreamCreateWithFTPURL ([NullAllowed] CFAllocatorRef* alloc, CFURLRef* ftpURL);

    // extern CFTypeID CFHTTPMessageGetTypeID () __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFHTTPMessageGetTypeID ();

    // extern CFHTTPMessageRef _Nonnull CFHTTPMessageCreateRequest (CFAllocatorRef _Nullable alloc, CFStringRef _Nonnull requestMethod, CFURLRef _Nonnull url, CFStringRef _Nonnull httpVersion) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFHTTPMessageRef* CFHTTPMessageCreateRequest ([NullAllowed] CFAllocatorRef* alloc, CFStringRef* requestMethod, CFURLRef* url, CFStringRef* httpVersion);

    // extern CFHTTPMessageRef _Nonnull CFHTTPMessageCreateResponse (CFAllocatorRef _Nullable alloc, CFIndex statusCode, CFStringRef _Nullable statusDescription, CFStringRef _Nonnull httpVersion) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFHTTPMessageRef* CFHTTPMessageCreateResponse ([NullAllowed] CFAllocatorRef* alloc, nint statusCode, [NullAllowed] CFStringRef* statusDescription, CFStringRef* httpVersion);

    // extern CFHTTPMessageRef _Nonnull CFHTTPMessageCreateEmpty (CFAllocatorRef _Nullable alloc, Boolean isRequest) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFHTTPMessageRef* CFHTTPMessageCreateEmpty ([NullAllowed] CFAllocatorRef* alloc, byte isRequest);

    // extern CFHTTPMessageRef _Nonnull CFHTTPMessageCreateCopy (CFAllocatorRef _Nullable alloc, CFHTTPMessageRef _Nonnull message) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFHTTPMessageRef* CFHTTPMessageCreateCopy ([NullAllowed] CFAllocatorRef* alloc, CFHTTPMessageRef* message);

    // extern Boolean CFHTTPMessageIsRequest (CFHTTPMessageRef _Nonnull message) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPMessageIsRequest (CFHTTPMessageRef* message);

    // extern CFStringRef _Nonnull CFHTTPMessageCopyVersion (CFHTTPMessageRef _Nonnull message) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFHTTPMessageCopyVersion (CFHTTPMessageRef* message);

    // extern CFDataRef _Nullable CFHTTPMessageCopyBody (CFHTTPMessageRef _Nonnull message) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CFHTTPMessageCopyBody (CFHTTPMessageRef* message);

    // extern void CFHTTPMessageSetBody (CFHTTPMessageRef _Nonnull message, CFDataRef _Nonnull bodyData) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFHTTPMessageSetBody (CFHTTPMessageRef* message, CFDataRef* bodyData);

    // extern CFStringRef _Nullable CFHTTPMessageCopyHeaderFieldValue (CFHTTPMessageRef _Nonnull message, CFStringRef _Nonnull headerField) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CFHTTPMessageCopyHeaderFieldValue (CFHTTPMessageRef* message, CFStringRef* headerField);

    // extern CFDictionaryRef _Nullable CFHTTPMessageCopyAllHeaderFields (CFHTTPMessageRef _Nonnull message) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CFHTTPMessageCopyAllHeaderFields (CFHTTPMessageRef* message);

    // extern void CFHTTPMessageSetHeaderFieldValue (CFHTTPMessageRef _Nonnull message, CFStringRef _Nonnull headerField, CFStringRef _Nullable value) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFHTTPMessageSetHeaderFieldValue (CFHTTPMessageRef* message, CFStringRef* headerField, [NullAllowed] CFStringRef* value);

    // extern Boolean CFHTTPMessageAppendBytes (CFHTTPMessageRef _Nonnull message, const UInt8 * _Nonnull newBytes, CFIndex numBytes) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPMessageAppendBytes (CFHTTPMessageRef* message, byte* newBytes, nint numBytes);

    // extern Boolean CFHTTPMessageIsHeaderComplete (CFHTTPMessageRef _Nonnull message) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPMessageIsHeaderComplete (CFHTTPMessageRef* message);

    // extern CFDataRef _Nullable CFHTTPMessageCopySerializedMessage (CFHTTPMessageRef _Nonnull message) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CFHTTPMessageCopySerializedMessage (CFHTTPMessageRef* message);

    // extern CFURLRef _Nullable CFHTTPMessageCopyRequestURL (CFHTTPMessageRef _Nonnull request) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFURLRef* CFHTTPMessageCopyRequestURL (CFHTTPMessageRef* request);

    // extern CFStringRef _Nullable CFHTTPMessageCopyRequestMethod (CFHTTPMessageRef _Nonnull request) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CFHTTPMessageCopyRequestMethod (CFHTTPMessageRef* request);

    // extern Boolean CFHTTPMessageAddAuthentication (CFHTTPMessageRef _Nonnull request, CFHTTPMessageRef _Nullable authenticationFailureResponse, CFStringRef _Nonnull username, CFStringRef _Nonnull password, CFStringRef _Nullable authenticationScheme, Boolean forProxy) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPMessageAddAuthentication (CFHTTPMessageRef* request, [NullAllowed] CFHTTPMessageRef* authenticationFailureResponse, CFStringRef* username, CFStringRef* password, [NullAllowed] CFStringRef* authenticationScheme, byte forProxy);

    // extern CFIndex CFHTTPMessageGetResponseStatusCode (CFHTTPMessageRef _Nonnull response) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFHTTPMessageGetResponseStatusCode (CFHTTPMessageRef* response);

    // extern CFStringRef _Nullable CFHTTPMessageCopyResponseStatusLine (CFHTTPMessageRef _Nonnull response) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CFHTTPMessageCopyResponseStatusLine (CFHTTPMessageRef* response);

    // extern CFReadStreamRef _Nonnull CFReadStreamCreateForHTTPRequest (CFAllocatorRef _Nullable alloc, CFHTTPMessageRef _Nonnull request) __attribute__((availability(ios, introduced=2_0, deprecated=9_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
    [Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFReadStreamRef* CFReadStreamCreateForHTTPRequest ([NullAllowed] CFAllocatorRef* alloc, CFHTTPMessageRef* request);

    // extern CFReadStreamRef _Nonnull CFReadStreamCreateForStreamedHTTPRequest (CFAllocatorRef _Nullable alloc, CFHTTPMessageRef _Nonnull requestHeaders, CFReadStreamRef _Nonnull requestBody) __attribute__((availability(ios, introduced=2_0, deprecated=9_0)));
    [Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
    [Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
    [DllImport ("__Internal")]
    
    static extern unsafe CFReadStreamRef* CFReadStreamCreateForStreamedHTTPRequest ([NullAllowed] CFAllocatorRef* alloc, CFHTTPMessageRef* requestHeaders, CFReadStreamRef* requestBody);

    // extern void CFHTTPReadStreamSetRedirectsAutomatically (CFReadStreamRef _Nonnull httpStream, Boolean shouldAutoRedirect) __attribute__((availability(ios, unavailable)));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFHTTPReadStreamSetRedirectsAutomatically (CFReadStreamRef* httpStream, byte shouldAutoRedirect);

    // extern CFTypeID CFHTTPAuthenticationGetTypeID () __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CFHTTPAuthenticationGetTypeID ();

    // extern CFHTTPAuthenticationRef _Nonnull CFHTTPAuthenticationCreateFromResponse (CFAllocatorRef _Nullable alloc, CFHTTPMessageRef _Nonnull response) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFHTTPAuthenticationRef* CFHTTPAuthenticationCreateFromResponse ([NullAllowed] CFAllocatorRef* alloc, CFHTTPMessageRef* response);

    // extern Boolean CFHTTPAuthenticationIsValid (CFHTTPAuthenticationRef _Nonnull auth, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPAuthenticationIsValid (CFHTTPAuthenticationRef* auth, [NullAllowed] CFStreamError* error);

    // extern Boolean CFHTTPAuthenticationAppliesToRequest (CFHTTPAuthenticationRef _Nonnull auth, CFHTTPMessageRef _Nonnull request) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPAuthenticationAppliesToRequest (CFHTTPAuthenticationRef* auth, CFHTTPMessageRef* request);

    // extern Boolean CFHTTPAuthenticationRequiresOrderedRequests (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPAuthenticationRequiresOrderedRequests (CFHTTPAuthenticationRef* auth);

    // extern Boolean CFHTTPMessageApplyCredentials (CFHTTPMessageRef _Nonnull request, CFHTTPAuthenticationRef _Nonnull auth, CFStringRef _Nullable username, CFStringRef _Nullable password, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPMessageApplyCredentials (CFHTTPMessageRef* request, CFHTTPAuthenticationRef* auth, [NullAllowed] CFStringRef* username, [NullAllowed] CFStringRef* password, [NullAllowed] CFStreamError* error);

    // extern Boolean CFHTTPMessageApplyCredentialDictionary (CFHTTPMessageRef _Nonnull request, CFHTTPAuthenticationRef _Nonnull auth, CFDictionaryRef _Nonnull dict, CFStreamError * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPMessageApplyCredentialDictionary (CFHTTPMessageRef* request, CFHTTPAuthenticationRef* auth, CFDictionaryRef* dict, [NullAllowed] CFStreamError* error);

    // extern CFStringRef _Nonnull CFHTTPAuthenticationCopyRealm (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFHTTPAuthenticationCopyRealm (CFHTTPAuthenticationRef* auth);

    // extern CFArrayRef _Nonnull CFHTTPAuthenticationCopyDomains (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFHTTPAuthenticationCopyDomains (CFHTTPAuthenticationRef* auth);

    // extern CFStringRef _Nonnull CFHTTPAuthenticationCopyMethod (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFStringRef* CFHTTPAuthenticationCopyMethod (CFHTTPAuthenticationRef* auth);

    // extern Boolean CFHTTPAuthenticationRequiresUserNameAndPassword (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPAuthenticationRequiresUserNameAndPassword (CFHTTPAuthenticationRef* auth);

    // extern Boolean CFHTTPAuthenticationRequiresAccountDomain (CFHTTPAuthenticationRef _Nonnull auth) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CFHTTPAuthenticationRequiresAccountDomain (CFHTTPAuthenticationRef* auth);

    // extern CFNetDiagnosticRef _Nonnull CFNetDiagnosticCreateWithStreams (CFAllocatorRef _Nullable alloc, CFReadStreamRef _Nullable readStream, CFWriteStreamRef _Nullable writeStream) __attribute__((availability(ios, introduced=2_0, deprecated=11_0)));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 11, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFNetDiagnosticRef* CFNetDiagnosticCreateWithStreams ([NullAllowed] CFAllocatorRef* alloc, [NullAllowed] CFReadStreamRef* readStream, [NullAllowed] CFWriteStreamRef* writeStream);

    // extern CFNetDiagnosticRef _Nonnull CFNetDiagnosticCreateWithURL (CFAllocatorRef _Nonnull alloc, CFURLRef _Nonnull url) __attribute__((availability(ios, introduced=2_0, deprecated=11_0)));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 11, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFNetDiagnosticRef* CFNetDiagnosticCreateWithURL (CFAllocatorRef* alloc, CFURLRef* url);

    // extern void CFNetDiagnosticSetName (CFNetDiagnosticRef _Nonnull details, CFStringRef _Nonnull name) __attribute__((availability(ios, introduced=2_0, deprecated=11_0)));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 11, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CFNetDiagnosticSetName (CFNetDiagnosticRef* details, CFStringRef* name);

    // extern CFNetDiagnosticStatus CFNetDiagnosticDiagnoseProblemInteractively (CFNetDiagnosticRef _Nonnull details) __attribute__((availability(ios, introduced=2_0, deprecated=11_0)));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 11, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFNetDiagnosticDiagnoseProblemInteractively (CFNetDiagnosticRef* details);

    // extern CFNetDiagnosticStatus CFNetDiagnosticCopyNetworkStatusPassively (CFNetDiagnosticRef _Nonnull details, CFStringRef  _Nullable * _Nullable description) __attribute__((availability(ios, introduced=2_0, deprecated=11_0)));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 11, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nint CFNetDiagnosticCopyNetworkStatusPassively (CFNetDiagnosticRef* details, [NullAllowed] CFStringRef** description);

    // extern CFDictionaryRef _Nullable CFNetworkCopySystemProxySettings () __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CFNetworkCopySystemProxySettings ();

    // extern CFArrayRef _Nonnull CFNetworkCopyProxiesForURL (CFURLRef _Nonnull url, CFDictionaryRef _Nonnull proxySettings) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CFNetworkCopyProxiesForURL (CFURLRef* url, CFDictionaryRef* proxySettings);

    // extern CFArrayRef _Nullable CFNetworkCopyProxiesForAutoConfigurationScript (CFStringRef _Nonnull proxyAutoConfigurationScript, CFURLRef _Nonnull targetURL, CFErrorRef  _Nullable * _Nullable error) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CFNetworkCopyProxiesForAutoConfigurationScript (CFStringRef* proxyAutoConfigurationScript, CFURLRef* targetURL, [NullAllowed] CFErrorRef** error);

    // extern CFRunLoopSourceRef _Nonnull CFNetworkExecuteProxyAutoConfigurationScript (CFStringRef _Nonnull proxyAutoConfigurationScript, CFURLRef _Nonnull targetURL, CFProxyAutoConfigurationResultCallback _Nonnull cb, CFStreamClientContext * _Nonnull clientContext) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopSourceRef* CFNetworkExecuteProxyAutoConfigurationScript (CFStringRef* proxyAutoConfigurationScript, CFURLRef* targetURL, CFProxyAutoConfigurationResultCallback* cb, CFStreamClientContext* clientContext);

    // extern CFRunLoopSourceRef _Nonnull CFNetworkExecuteProxyAutoConfigurationURL (CFURLRef _Nonnull proxyAutoConfigURL, CFURLRef _Nonnull targetURL, CFProxyAutoConfigurationResultCallback _Nonnull cb, CFStreamClientContext * _Nonnull clientContext) __attribute__((availability(ios, introduced=2_0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFRunLoopSourceRef* CFNetworkExecuteProxyAutoConfigurationURL (CFURLRef* proxyAutoConfigURL, CFURLRef* targetURL, CFProxyAutoConfigurationResultCallback* cb, CFStreamClientContext* clientContext);

   
    // extern mach_port_name_t audit_session_self ();
    [DllImport ("__Internal")]
    
    static extern uint audit_session_self ();

    // extern au_asid_t audit_session_join (mach_port_name_t port);
    [DllImport ("__Internal")]
    
    static extern int audit_session_join (uint port);

    // extern int audit_session_port (au_asid_t asid, mach_port_name_t *portname);
    [DllImport ("__Internal")]
    
    static extern unsafe int audit_session_port (int asid, uint* portname);

    // extern CFTypeID SSLContextGetTypeID () __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern nuint SSLContextGetTypeID ();

    // extern SSLContextRef _Nullable SSLCreateContext (CFAllocatorRef _Nullable alloc, SSLProtocolSide protocolSide, SSLConnectionType connectionType) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe SSLContextRef* SSLCreateContext ([NullAllowed] CFAllocatorRef* alloc, SSLProtocolSide protocolSide, SSLConnectionType connectionType);

    // extern OSStatus SSLGetSessionState (SSLContextRef _Nonnull context, SSLSessionState * _Nonnull state) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetSessionState (SSLContextRef* context, SSLSessionState* state);

    // extern OSStatus SSLSetSessionOption (SSLContextRef _Nonnull context, SSLSessionOption option, Boolean value) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetSessionOption (SSLContextRef* context, SSLSessionOption option, byte value);

    // extern OSStatus SSLGetSessionOption (SSLContextRef _Nonnull context, SSLSessionOption option, Boolean * _Nonnull value) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetSessionOption (SSLContextRef* context, SSLSessionOption option, byte* value);

    // extern OSStatus SSLSetIOFuncs (SSLContextRef _Nonnull context, SSLReadFunc _Nonnull readFunc, SSLWriteFunc _Nonnull writeFunc) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetIOFuncs (SSLContextRef* context, SSLReadFunc* readFunc, SSLWriteFunc* writeFunc);

    // extern OSStatus SSLSetSessionConfig (SSLContextRef _Nonnull context, CFStringRef _Nonnull config) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetSessionConfig (SSLContextRef* context, CFStringRef* config);

    // extern OSStatus SSLSetProtocolVersionMin (SSLContextRef _Nonnull context, SSLProtocol minVersion) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetProtocolVersionMin (SSLContextRef* context, SSLProtocol minVersion);

    // extern OSStatus SSLGetProtocolVersionMin (SSLContextRef _Nonnull context, SSLProtocol * _Nonnull minVersion) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetProtocolVersionMin (SSLContextRef* context, SSLProtocol* minVersion);

    // extern OSStatus SSLSetProtocolVersionMax (SSLContextRef _Nonnull context, SSLProtocol maxVersion) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetProtocolVersionMax (SSLContextRef* context, SSLProtocol maxVersion);

    // extern OSStatus SSLGetProtocolVersionMax (SSLContextRef _Nonnull context, SSLProtocol * _Nonnull maxVersion) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetProtocolVersionMax (SSLContextRef* context, SSLProtocol* maxVersion);

    // extern OSStatus SSLSetCertificate (SSLContextRef _Nonnull context, CFArrayRef _Nullable certRefs) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetCertificate (SSLContextRef* context, [NullAllowed] CFArrayRef* certRefs);

    // extern OSStatus SSLSetConnection (SSLContextRef _Nonnull context, SSLConnectionRef _Nullable connection) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetConnection (SSLContextRef* context, [NullAllowed] void* connection);

    // extern OSStatus SSLGetConnection (SSLContextRef _Nonnull context, SSLConnectionRef  _Nullable * _Nonnull connection) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetConnection (SSLContextRef* context, [NullAllowed] void** connection);

    // extern OSStatus SSLSetPeerDomainName (SSLContextRef _Nonnull context, const char * _Nullable peerName, size_t peerNameLen) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetPeerDomainName (SSLContextRef* context, [NullAllowed] sbyte* peerName, nuint peerNameLen);

    // extern OSStatus SSLGetPeerDomainNameLength (SSLContextRef _Nonnull context, size_t * _Nonnull peerNameLen) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetPeerDomainNameLength (SSLContextRef* context, nuint* peerNameLen);

    // extern OSStatus SSLGetPeerDomainName (SSLContextRef _Nonnull context, char * _Nonnull peerName, size_t * _Nonnull peerNameLen) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetPeerDomainName (SSLContextRef* context, sbyte* peerName, nuint* peerNameLen);

    // extern OSStatus SSLCopyRequestedPeerName (SSLContextRef _Nonnull context, char * _Nonnull peerName, size_t * _Nonnull peerNameLen) __attribute__((availability(ios, introduced=9.0))) __attribute__((cf_audited_transfer));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLCopyRequestedPeerName (SSLContextRef* context, sbyte* peerName, nuint* peerNameLen);

    // extern OSStatus SSLCopyRequestedPeerNameLength (SSLContextRef _Nonnull ctx, size_t * _Nonnull peerNameLen) __attribute__((availability(ios, introduced=9.0))) __attribute__((cf_audited_transfer));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLCopyRequestedPeerNameLength (SSLContextRef* ctx, nuint* peerNameLen);

    // extern OSStatus SSLSetDatagramHelloCookie (SSLContextRef _Nonnull dtlsContext, const void * _Nullable cookie, size_t cookieLen) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetDatagramHelloCookie (SSLContextRef* dtlsContext, [NullAllowed] void* cookie, nuint cookieLen);

    // extern OSStatus SSLSetMaxDatagramRecordSize (SSLContextRef _Nonnull dtlsContext, size_t maxSize) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetMaxDatagramRecordSize (SSLContextRef* dtlsContext, nuint maxSize);

    // extern OSStatus SSLGetMaxDatagramRecordSize (SSLContextRef _Nonnull dtlsContext, size_t * _Nonnull maxSize) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetMaxDatagramRecordSize (SSLContextRef* dtlsContext, nuint* maxSize);

    // extern OSStatus SSLGetNegotiatedProtocolVersion (SSLContextRef _Nonnull context, SSLProtocol * _Nonnull protocol) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetNegotiatedProtocolVersion (SSLContextRef* context, SSLProtocol* protocol);

    // extern OSStatus SSLGetNumberSupportedCiphers (SSLContextRef _Nonnull context, size_t * _Nonnull numCiphers) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetNumberSupportedCiphers (SSLContextRef* context, nuint* numCiphers);

    // extern OSStatus SSLGetSupportedCiphers (SSLContextRef _Nonnull context, SSLCipherSuite * _Nonnull ciphers, size_t * _Nonnull numCiphers) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetSupportedCiphers (SSLContextRef* context, ushort* ciphers, nuint* numCiphers);

    // extern OSStatus SSLSetEnabledCiphers (SSLContextRef _Nonnull context, const SSLCipherSuite * _Nonnull ciphers, size_t numCiphers) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetEnabledCiphers (SSLContextRef* context, ushort* ciphers, nuint numCiphers);

    // extern OSStatus SSLGetNumberEnabledCiphers (SSLContextRef _Nonnull context, size_t * _Nonnull numCiphers) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetNumberEnabledCiphers (SSLContextRef* context, nuint* numCiphers);

    // extern OSStatus SSLGetEnabledCiphers (SSLContextRef _Nonnull context, SSLCipherSuite * _Nonnull ciphers, size_t * _Nonnull numCiphers) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetEnabledCiphers (SSLContextRef* context, ushort* ciphers, nuint* numCiphers);

    // extern OSStatus SSLSetSessionTicketsEnabled (SSLContextRef _Nonnull context, Boolean enabled) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetSessionTicketsEnabled (SSLContextRef* context, byte enabled);

    // extern OSStatus SSLCopyPeerTrust (SSLContextRef _Nonnull context, SecTrustRef  _Nullable * _Nonnull trust) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLCopyPeerTrust (SSLContextRef* context, [NullAllowed] SecTrustRef** trust);

    // extern OSStatus SSLSetPeerID (SSLContextRef _Nonnull context, const void * _Nullable peerID, size_t peerIDLen) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetPeerID (SSLContextRef* context, [NullAllowed] void* peerID, nuint peerIDLen);

    // extern OSStatus SSLGetPeerID (SSLContextRef _Nonnull context, const void * _Nullable * _Nonnull peerID, size_t * _Nonnull peerIDLen) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetPeerID (SSLContextRef* context, [NullAllowed] void** peerID, nuint* peerIDLen);

    // extern OSStatus SSLGetNegotiatedCipher (SSLContextRef _Nonnull context, SSLCipherSuite * _Nonnull cipherSuite) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetNegotiatedCipher (SSLContextRef* context, ushort* cipherSuite);

    // extern OSStatus SSLSetALPNProtocols (SSLContextRef _Nonnull context, CFArrayRef _Nonnull protocols) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetALPNProtocols (SSLContextRef* context, CFArrayRef* protocols);

    // extern OSStatus SSLCopyALPNProtocols (SSLContextRef _Nonnull context, CFArrayRef  _Nullable * _Nonnull protocols) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLCopyALPNProtocols (SSLContextRef* context, [NullAllowed] CFArrayRef** protocols);

    // extern OSStatus SSLSetOCSPResponse (SSLContextRef _Nonnull context, CFDataRef _Nonnull response) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetOCSPResponse (SSLContextRef* context, CFDataRef* response);

    // extern OSStatus SSLSetEncryptionCertificate (SSLContextRef _Nonnull context, CFArrayRef _Nonnull certRefs) __attribute__((availability(ios, introduced=5.0, deprecated=9.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 5, 0)]
    [Deprecated (PlatformName.iOS, 9, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetEncryptionCertificate (SSLContextRef* context, CFArrayRef* certRefs);

    // extern OSStatus SSLSetClientSideAuthenticate (SSLContextRef _Nonnull context, SSLAuthenticate auth) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetClientSideAuthenticate (SSLContextRef* context, SSLAuthenticate auth);

    // extern OSStatus SSLAddDistinguishedName (SSLContextRef _Nonnull context, const void * _Nullable derDN, size_t derDNLen) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLAddDistinguishedName (SSLContextRef* context, [NullAllowed] void* derDN, nuint derDNLen);

    // extern OSStatus SSLCopyDistinguishedNames (SSLContextRef _Nonnull context, CFArrayRef  _Nullable * _Nonnull names) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLCopyDistinguishedNames (SSLContextRef* context, [NullAllowed] CFArrayRef** names);

    // extern OSStatus SSLGetClientCertificateState (SSLContextRef _Nonnull context, SSLClientCertificateState * _Nonnull clientState) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetClientCertificateState (SSLContextRef* context, SSLClientCertificateState* clientState);

    // extern OSStatus SSLHandshake (SSLContextRef _Nonnull context) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLHandshake (SSLContextRef* context);

    // extern OSStatus SSLReHandshake (SSLContextRef _Nonnull context) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLReHandshake (SSLContextRef* context);

    // extern OSStatus SSLWrite (SSLContextRef _Nonnull context, const void * _Nullable data, size_t dataLength, size_t * _Nonnull processed) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLWrite (SSLContextRef* context, [NullAllowed] void* data, nuint dataLength, nuint* processed);

    // extern OSStatus SSLRead (SSLContextRef _Nonnull context, void * _Nonnull data, size_t dataLength, size_t * _Nonnull processed) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLRead (SSLContextRef* context, void* data, nuint dataLength, nuint* processed);

    // extern OSStatus SSLGetBufferedReadSize (SSLContextRef _Nonnull context, size_t * _Nonnull bufSize) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetBufferedReadSize (SSLContextRef* context, nuint* bufSize);

    // extern OSStatus SSLGetDatagramWriteSize (SSLContextRef _Nonnull dtlsContext, size_t * _Nonnull bufSize) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLGetDatagramWriteSize (SSLContextRef* dtlsContext, nuint* bufSize);

    // extern OSStatus SSLClose (SSLContextRef _Nonnull context) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLClose (SSLContextRef* context);

    // extern OSStatus SSLSetError (SSLContextRef _Nonnull context, OSStatus status) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int SSLSetError (SSLContextRef* context, int status);

    // extern void uuid_clear (unsigned char *uu);
    [DllImport ("__Internal")]
    
    static extern void uuid_clear (byte[] uu);

    // extern int uuid_compare (const unsigned char *uu1, const unsigned char *uu2);
    [DllImport ("__Internal")]
    
    static extern int uuid_compare (byte[] uu1, byte[] uu2);

    // extern void uuid_copy (unsigned char *dst, const unsigned char *src);
    [DllImport ("__Internal")]
    
    static extern void uuid_copy (byte[] dst, byte[] src);

    // extern void uuid_generate (unsigned char *out);
    [DllImport ("__Internal")]
    
    static extern void uuid_generate (byte[] @out);

    // extern void uuid_generate_random (unsigned char *out);
    [DllImport ("__Internal")]
    
    static extern void uuid_generate_random (byte[] @out);

    // extern void uuid_generate_time (unsigned char *out);
    [DllImport ("__Internal")]
    
    static extern void uuid_generate_time (byte[] @out);

    // extern int uuid_is_null (const unsigned char *uu);
    [DllImport ("__Internal")]
    
    static extern int uuid_is_null (byte[] uu);

    // extern int uuid_parse (const char *in, unsigned char *uu);
    [DllImport ("__Internal")]
    
    static extern int uuid_parse (sbyte[] @in, byte[] uu);

    // extern void uuid_unparse (const unsigned char *uu, char *out);
    [DllImport ("__Internal")]
    
    static extern void uuid_unparse (byte[] uu, sbyte[] @out);

    // extern void uuid_unparse_lower (const unsigned char *uu, char *out);
    [DllImport ("__Internal")]
    
    static extern void uuid_unparse_lower (byte[] uu, sbyte[] @out);

    // extern void uuid_unparse_upper (const unsigned char *uu, char *out);
    [DllImport ("__Internal")]
    
    static extern void uuid_unparse_upper (byte[] uu, sbyte[] @out);

    // extern BOOL CLLocationCoordinate2DIsValid (CLLocationCoordinate2D coord) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.0)));
    [Mac (10,7), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern bool CLLocationCoordinate2DIsValid (CLLocationCoordinate2D coord);

    // extern CLLocationCoordinate2D CLLocationCoordinate2DMake (CLLocationDegrees latitude, CLLocationDegrees longitude) __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.0)));
    [Mac (10,7), iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern CLLocationCoordinate2D CLLocationCoordinate2DMake (double latitude, double longitude);

    // CGPoint CGPointMake (CGFloat x, CGFloat y) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGPoint CGPointMake (nfloat x, nfloat y);

    // CGSize CGSizeMake (CGFloat width, CGFloat height) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGSize CGSizeMake (nfloat width, nfloat height);

    // CGVector CGVectorMake (CGFloat dx, CGFloat dy) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGVector CGVectorMake (nfloat dx, nfloat dy);

    // CGRect CGRectMake (CGFloat x, CGFloat y, CGFloat width, CGFloat height) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectMake (nfloat x, nfloat y, nfloat width, nfloat height);

    // extern CGFloat CGRectGetMinX (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nfloat CGRectGetMinX (CGRect rect);

    // extern CGFloat CGRectGetMidX (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nfloat CGRectGetMidX (CGRect rect);

    // extern CGFloat CGRectGetMaxX (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nfloat CGRectGetMaxX (CGRect rect);

    // extern CGFloat CGRectGetMinY (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nfloat CGRectGetMinY (CGRect rect);

    // extern CGFloat CGRectGetMidY (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nfloat CGRectGetMidY (CGRect rect);

    // extern CGFloat CGRectGetMaxY (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nfloat CGRectGetMaxY (CGRect rect);

    // extern CGFloat CGRectGetWidth (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nfloat CGRectGetWidth (CGRect rect);

    // extern CGFloat CGRectGetHeight (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nfloat CGRectGetHeight (CGRect rect);

    // extern _Bool CGPointEqualToPoint (CGPoint point1, CGPoint point2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGPointEqualToPoint (CGPoint point1, CGPoint point2);

    // extern _Bool CGSizeEqualToSize (CGSize size1, CGSize size2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGSizeEqualToSize (CGSize size1, CGSize size2);

    // extern _Bool CGRectEqualToRect (CGRect rect1, CGRect rect2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGRectEqualToRect (CGRect rect1, CGRect rect2);

    // extern CGRect CGRectStandardize (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectStandardize (CGRect rect);

    // extern _Bool CGRectIsEmpty (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGRectIsEmpty (CGRect rect);

    // extern _Bool CGRectIsNull (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGRectIsNull (CGRect rect);

    // extern _Bool CGRectIsInfinite (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGRectIsInfinite (CGRect rect);

    // extern CGRect CGRectInset (CGRect rect, CGFloat dx, CGFloat dy) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectInset (CGRect rect, nfloat dx, nfloat dy);

    // extern CGRect CGRectIntegral (CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectIntegral (CGRect rect);

    // extern CGRect CGRectUnion (CGRect r1, CGRect r2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectUnion (CGRect r1, CGRect r2);

    // extern CGRect CGRectIntersection (CGRect r1, CGRect r2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectIntersection (CGRect r1, CGRect r2);

    // extern CGRect CGRectOffset (CGRect rect, CGFloat dx, CGFloat dy) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectOffset (CGRect rect, nfloat dx, nfloat dy);

    // extern void CGRectDivide (CGRect rect, CGRect * _Nonnull slice, CGRect * _Nonnull remainder, CGFloat amount, CGRectEdge edge) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGRectDivide (CGRect rect, CGRect* slice, CGRect* remainder, nfloat amount, CGRectEdge edge);

    // extern _Bool CGRectContainsPoint (CGRect rect, CGPoint point) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGRectContainsPoint (CGRect rect, CGPoint point);

    // extern _Bool CGRectContainsRect (CGRect rect1, CGRect rect2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGRectContainsRect (CGRect rect1, CGRect rect2);

    // extern _Bool CGRectIntersectsRect (CGRect rect1, CGRect rect2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGRectIntersectsRect (CGRect rect1, CGRect rect2);

    // extern CFDictionaryRef _Nonnull CGPointCreateDictionaryRepresentation (CGPoint point) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CGPointCreateDictionaryRepresentation (CGPoint point);

    // extern _Bool CGPointMakeWithDictionaryRepresentation (CFDictionaryRef _Nullable dict, CGPoint * _Nullable point) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPointMakeWithDictionaryRepresentation ([NullAllowed] CFDictionaryRef* dict, [NullAllowed] CGPoint* point);

    // extern CFDictionaryRef _Nonnull CGSizeCreateDictionaryRepresentation (CGSize size) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFDictionaryRef* CGSizeCreateDictionaryRepresentation (CGSize size);

    // extern _Bool CGSizeMakeWithDictionaryRepresentation (CFDictionaryRef _Nullable dict, CGSize * _Nullable size) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGSizeMakeWithDictionaryRepresentation ([NullAllowed] CFDictionaryRef* dict, [NullAllowed] CGSize* size);

    
    // extern _Bool CGRectMakeWithDictionaryRepresentation (CFDictionaryRef _Nullable dict, CGRect * _Nullable rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGRectMakeWithDictionaryRepresentation ([NullAllowed] CFDictionaryRef* dict, [NullAllowed] CGRect* rect);

    // CGPoint CGPointMake (CGFloat x, CGFloat y) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGPoint CGPointMake (nfloat x, nfloat y);

    // CGSize CGSizeMake (CGFloat width, CGFloat height) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGSize CGSizeMake (nfloat width, nfloat height);

    // CGVector CGVectorMake (CGFloat dx, CGFloat dy) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGVector CGVectorMake (nfloat dx, nfloat dy);

    // CGRect CGRectMake (CGFloat x, CGFloat y, CGFloat width, CGFloat height) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectMake (nfloat x, nfloat y, nfloat width, nfloat height);

    // _Bool __CGPointEqualToPoint (CGPoint point1, CGPoint point2) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern bool __CGPointEqualToPoint (CGPoint point1, CGPoint point2);

    // _Bool __CGSizeEqualToSize (CGSize size1, CGSize size2) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern bool __CGSizeEqualToSize (CGSize size1, CGSize size2);

    // extern CGAffineTransform CGAffineTransformMake (CGFloat a, CGFloat b, CGFloat c, CGFloat d, CGFloat tx, CGFloat ty) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformMake (nfloat a, nfloat b, nfloat c, nfloat d, nfloat tx, nfloat ty);

    // extern CGAffineTransform CGAffineTransformMakeTranslation (CGFloat tx, CGFloat ty) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformMakeTranslation (nfloat tx, nfloat ty);

    // extern CGAffineTransform CGAffineTransformMakeScale (CGFloat sx, CGFloat sy) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformMakeScale (nfloat sx, nfloat sy);

    // extern CGAffineTransform CGAffineTransformMakeRotation (CGFloat angle) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformMakeRotation (nfloat angle);

    // extern _Bool CGAffineTransformIsIdentity (CGAffineTransform t) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGAffineTransformIsIdentity (CGAffineTransform t);

    // extern CGAffineTransform CGAffineTransformTranslate (CGAffineTransform t, CGFloat tx, CGFloat ty) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformTranslate (CGAffineTransform t, nfloat tx, nfloat ty);

    // extern CGAffineTransform CGAffineTransformScale (CGAffineTransform t, CGFloat sx, CGFloat sy) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformScale (CGAffineTransform t, nfloat sx, nfloat sy);

    // extern CGAffineTransform CGAffineTransformRotate (CGAffineTransform t, CGFloat angle) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformRotate (CGAffineTransform t, nfloat angle);

    // extern CGAffineTransform CGAffineTransformInvert (CGAffineTransform t) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformInvert (CGAffineTransform t);

    // extern CGAffineTransform CGAffineTransformConcat (CGAffineTransform t1, CGAffineTransform t2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformConcat (CGAffineTransform t1, CGAffineTransform t2);

    // extern _Bool CGAffineTransformEqualToTransform (CGAffineTransform t1, CGAffineTransform t2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CGAffineTransformEqualToTransform (CGAffineTransform t1, CGAffineTransform t2);

    // extern CGPoint CGPointApplyAffineTransform (CGPoint point, CGAffineTransform t) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGPoint CGPointApplyAffineTransform (CGPoint point, CGAffineTransform t);

    // extern CGSize CGSizeApplyAffineTransform (CGSize size, CGAffineTransform t) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGSize CGSizeApplyAffineTransform (CGSize size, CGAffineTransform t);

    // extern CGRect CGRectApplyAffineTransform (CGRect rect, CGAffineTransform t) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectApplyAffineTransform (CGRect rect, CGAffineTransform t);

    // CGAffineTransform __CGAffineTransformMake (CGFloat a, CGFloat b, CGFloat c, CGFloat d, CGFloat tx, CGFloat ty) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform __CGAffineTransformMake (nfloat a, nfloat b, nfloat c, nfloat d, nfloat tx, nfloat ty);

    // CGPoint __CGPointApplyAffineTransform (CGPoint point, CGAffineTransform t) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGPoint __CGPointApplyAffineTransform (CGPoint point, CGAffineTransform t);

    // CGSize __CGSizeApplyAffineTransform (CGSize size, CGAffineTransform t) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern CGSize __CGSizeApplyAffineTransform (CGSize size, CGAffineTransform t);

    // extern CFTypeID CGDataProviderGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGDataProviderGetTypeID ();

    // extern CGDataProviderRef _Nullable CGDataProviderCreateSequential (void * _Nullable info, const CGDataProviderSequentialCallbacks * _Nullable callbacks) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataProviderRef* CGDataProviderCreateSequential ([NullAllowed] void* info, [NullAllowed] CGDataProviderSequentialCallbacks* callbacks);

    // extern CGDataProviderRef _Nullable CGDataProviderCreateDirect (void * _Nullable info, off_t size, const CGDataProviderDirectCallbacks * _Nullable callbacks) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataProviderRef* CGDataProviderCreateDirect ([NullAllowed] void* info, long size, [NullAllowed] CGDataProviderDirectCallbacks* callbacks);

    // extern CGDataProviderRef _Nullable CGDataProviderCreateWithData (void * _Nullable info, const void * _Nullable data, size_t size, CGDataProviderReleaseDataCallback _Nullable releaseData) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataProviderRef* CGDataProviderCreateWithData ([NullAllowed] void* info, [NullAllowed] void* data, nuint size, [NullAllowed] CGDataProviderReleaseDataCallback* releaseData);

    // extern CGDataProviderRef _Nullable CGDataProviderCreateWithCFData (CFDataRef _Nullable data) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataProviderRef* CGDataProviderCreateWithCFData ([NullAllowed] CFDataRef* data);

    // extern CGDataProviderRef _Nullable CGDataProviderCreateWithURL (CFURLRef _Nullable url) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataProviderRef* CGDataProviderCreateWithURL ([NullAllowed] CFURLRef* url);

    // extern CGDataProviderRef _Nullable CGDataProviderCreateWithFilename (const char * _Nullable filename) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataProviderRef* CGDataProviderCreateWithFilename ([NullAllowed] sbyte* filename);

    // extern CGDataProviderRef _Nullable CGDataProviderRetain (CGDataProviderRef _Nullable provider) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataProviderRef* CGDataProviderRetain ([NullAllowed] CGDataProviderRef* provider);

    // extern void CGDataProviderRelease (CGDataProviderRef _Nullable provider) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGDataProviderRelease ([NullAllowed] CGDataProviderRef* provider);

    // extern CFDataRef _Nullable CGDataProviderCopyData (CGDataProviderRef _Nullable provider) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CGDataProviderCopyData ([NullAllowed] CGDataProviderRef* provider);

    // extern void * _Nullable CGDataProviderGetInfo (CGDataProviderRef _Nullable provider) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CGDataProviderGetInfo ([NullAllowed] CGDataProviderRef* provider);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateDeviceGray () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateDeviceGray ();

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateDeviceRGB () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateDeviceRGB ();

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateDeviceCMYK () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateDeviceCMYK ();

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateCalibratedGray (const CGFloat * _Nonnull whitePoint, const CGFloat * _Nullable blackPoint, CGFloat gamma) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateCalibratedGray (nfloat[] whitePoint, [NullAllowed] nfloat[] blackPoint, nfloat gamma);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateCalibratedRGB (const CGFloat * _Nonnull whitePoint, const CGFloat * _Nullable blackPoint, const CGFloat * _Nullable gamma, const CGFloat * _Nullable matrix) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateCalibratedRGB (nfloat[] whitePoint, [NullAllowed] nfloat[] blackPoint, [NullAllowed] nfloat[] gamma, [NullAllowed] nfloat[] matrix);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateLab (const CGFloat * _Nonnull whitePoint, const CGFloat * _Nullable blackPoint, const CGFloat * _Nullable range) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateLab (nfloat[] whitePoint, [NullAllowed] nfloat[] blackPoint, [NullAllowed] nfloat[] range);

    // extern CGColorSpaceRef _Nonnull CGColorSpaceCreateWithICCData (CFTypeRef _Nullable data) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateWithICCData ([NullAllowed] void* data);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateICCBased (size_t nComponents, const CGFloat * _Nullable range, CGDataProviderRef _Nullable profile, CGColorSpaceRef _Nullable alternate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateICCBased (nuint nComponents, [NullAllowed] nfloat* range, [NullAllowed] CGDataProviderRef* profile, [NullAllowed] CGColorSpaceRef* alternate);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateIndexed (CGColorSpaceRef _Nullable baseSpace, size_t lastIndex, const unsigned char * _Nullable colorTable) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateIndexed ([NullAllowed] CGColorSpaceRef* baseSpace, nuint lastIndex, [NullAllowed] byte* colorTable);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreatePattern (CGColorSpaceRef _Nullable baseSpace) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreatePattern ([NullAllowed] CGColorSpaceRef* baseSpace);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateWithPlatformColorSpace (const void * _Nullable ref) __attribute__((availability(ios, introduced=9.0))) __attribute__((cf_audited_transfer));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateWithPlatformColorSpace ([NullAllowed] void* @ref);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateWithName (CFStringRef _Nullable name) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateWithName ([NullAllowed] CFStringRef* name);

    // extern CGColorSpaceRef _Nullable CGColorSpaceRetain (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceRetain ([NullAllowed] CGColorSpaceRef* space);

    // extern void CGColorSpaceRelease (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGColorSpaceRelease ([NullAllowed] CGColorSpaceRef* space);

    // extern CFStringRef _Nullable CGColorSpaceGetName (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGColorSpaceGetName ([NullAllowed] CGColorSpaceRef* space);

    // extern CFStringRef _Nullable CGColorSpaceCopyName (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGColorSpaceCopyName ([NullAllowed] CGColorSpaceRef* space);

    // extern CFTypeID CGColorSpaceGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGColorSpaceGetTypeID ();

    // extern size_t CGColorSpaceGetNumberOfComponents (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGColorSpaceGetNumberOfComponents ([NullAllowed] CGColorSpaceRef* space);

    // extern CGColorSpaceModel CGColorSpaceGetModel (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGColorSpaceModel CGColorSpaceGetModel ([NullAllowed] CGColorSpaceRef* space);

    // extern CGColorSpaceRef _Nullable CGColorSpaceGetBaseColorSpace (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceGetBaseColorSpace ([NullAllowed] CGColorSpaceRef* space);

    // extern size_t CGColorSpaceGetColorTableCount (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGColorSpaceGetColorTableCount ([NullAllowed] CGColorSpaceRef* space);

    // extern void CGColorSpaceGetColorTable (CGColorSpaceRef _Nullable space, uint8_t * _Nullable table) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGColorSpaceGetColorTable ([NullAllowed] CGColorSpaceRef* space, [NullAllowed] byte* table);

    // extern CFDataRef _Nullable CGColorSpaceCopyICCData (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CGColorSpaceCopyICCData ([NullAllowed] CGColorSpaceRef* space);

    // extern _Bool CGColorSpaceIsWideGamutRGB (CGColorSpaceRef _Nonnull) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGColorSpaceIsWideGamutRGB (CGColorSpaceRef q);

    // extern _Bool CGColorSpaceSupportsOutput (CGColorSpaceRef _Nonnull space) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGColorSpaceSupportsOutput (CGColorSpaceRef* space);

    // extern CGColorSpaceRef _Nullable CGColorSpaceCreateWithICCProfile (CFDataRef _Nullable data) __attribute__((availability(ios, introduced=2.0, deprecated=11.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 11, 0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorSpaceCreateWithICCProfile ([NullAllowed] CFDataRef* data);

    // extern CFDataRef _Nullable CGColorSpaceCopyICCProfile (CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0, deprecated=11.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 11, 0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CGColorSpaceCopyICCProfile ([NullAllowed] CGColorSpaceRef* space);

    // extern CFTypeID CGPatternGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGPatternGetTypeID ();

    // extern CGPatternRef _Nullable CGPatternCreate (void * _Nullable info, CGRect bounds, CGAffineTransform matrix, CGFloat xStep, CGFloat yStep, CGPatternTiling tiling, _Bool isColored, const CGPatternCallbacks * _Nullable callbacks) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPatternRef* CGPatternCreate ([NullAllowed] void* info, CGRect bounds, CGAffineTransform matrix, nfloat xStep, nfloat yStep, CGPatternTiling tiling, bool isColored, [NullAllowed] CGPatternCallbacks* callbacks);

    // extern CGPatternRef _Nullable CGPatternRetain (CGPatternRef _Nullable pattern) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPatternRef* CGPatternRetain ([NullAllowed] CGPatternRef* pattern);

    // extern void CGPatternRelease (CGPatternRef _Nullable pattern) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPatternRelease ([NullAllowed] CGPatternRef* pattern);

    // extern CGColorRef _Nullable CGColorCreate (CGColorSpaceRef _Nullable space, const CGFloat * _Nullable components) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorRef* CGColorCreate ([NullAllowed] CGColorSpaceRef* space, [NullAllowed] nfloat* components);

    // extern CGColorRef _Nonnull CGColorCreateGenericGray (CGFloat gray, CGFloat alpha) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe CGColorRef* CGColorCreateGenericGray (nfloat gray, nfloat alpha);

    // extern CGColorRef _Nonnull CGColorCreateGenericRGB (CGFloat red, CGFloat green, CGFloat blue, CGFloat alpha) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe CGColorRef* CGColorCreateGenericRGB (nfloat red, nfloat green, nfloat blue, nfloat alpha);

    // extern CGColorRef _Nonnull CGColorCreateGenericCMYK (CGFloat cyan, CGFloat magenta, CGFloat yellow, CGFloat black, CGFloat alpha) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe CGColorRef* CGColorCreateGenericCMYK (nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha);

    // extern CGColorRef _Nullable CGColorGetConstantColor (CFStringRef _Nullable colorName) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorRef* CGColorGetConstantColor ([NullAllowed] CFStringRef* colorName);

    // extern CGColorRef _Nullable CGColorCreateWithPattern (CGColorSpaceRef _Nullable space, CGPatternRef _Nullable pattern, const CGFloat * _Nullable components) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorRef* CGColorCreateWithPattern ([NullAllowed] CGColorSpaceRef* space, [NullAllowed] CGPatternRef* pattern, [NullAllowed] nfloat* components);

    // extern CGColorRef _Nullable CGColorCreateCopy (CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorRef* CGColorCreateCopy ([NullAllowed] CGColorRef* color);

    // extern CGColorRef _Nullable CGColorCreateCopyWithAlpha (CGColorRef _Nullable color, CGFloat alpha) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorRef* CGColorCreateCopyWithAlpha ([NullAllowed] CGColorRef* color, nfloat alpha);

    // extern CGColorRef _Nullable CGColorCreateCopyByMatchingToColorSpace (CGColorSpaceRef _Nullable, CGColorRenderingIntent intent, CGColorRef _Nullable color, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=9.0))) __attribute__((cf_audited_transfer));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorRef* CGColorCreateCopyByMatchingToColorSpace ([NullAllowed] CGColorSpaceRef d, CGColorRenderingIntent intent, [NullAllowed] CGColorRef* color, [NullAllowed] CFDictionaryRef* options);

    // extern CGColorRef _Nullable CGColorRetain (CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorRef* CGColorRetain ([NullAllowed] CGColorRef* color);

    // extern void CGColorRelease (CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGColorRelease ([NullAllowed] CGColorRef* color);

    // extern _Bool CGColorEqualToColor (CGColorRef _Nullable color1, CGColorRef _Nullable color2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGColorEqualToColor ([NullAllowed] CGColorRef* color1, [NullAllowed] CGColorRef* color2);

    // extern size_t CGColorGetNumberOfComponents (CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGColorGetNumberOfComponents ([NullAllowed] CGColorRef* color);

    // extern const CGFloat * _Nullable CGColorGetComponents (CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe nfloat* CGColorGetComponents ([NullAllowed] CGColorRef* color);

    // extern CGFloat CGColorGetAlpha (CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nfloat CGColorGetAlpha ([NullAllowed] CGColorRef* color);

    // extern CGColorSpaceRef _Nullable CGColorGetColorSpace (CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGColorGetColorSpace ([NullAllowed] CGColorRef* color);

    // extern CGPatternRef _Nullable CGColorGetPattern (CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPatternRef* CGColorGetPattern ([NullAllowed] CGColorRef* color);

    // extern CFTypeID CGColorGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGColorGetTypeID ();

    // extern CFTypeID CGFontGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGFontGetTypeID ();

    // extern CGFontRef _Nullable CGFontCreateWithPlatformFont (void * _Nullable platformFontReference) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGFontRef* CGFontCreateWithPlatformFont ([NullAllowed] void* platformFontReference);

    // extern CGFontRef _Nullable CGFontCreateWithDataProvider (CGDataProviderRef _Nullable provider) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGFontRef* CGFontCreateWithDataProvider ([NullAllowed] CGDataProviderRef* provider);

    // extern CGFontRef _Nullable CGFontCreateWithFontName (CFStringRef _Nullable name) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGFontRef* CGFontCreateWithFontName ([NullAllowed] CFStringRef* name);

    // extern CGFontRef _Nullable CGFontCreateCopyWithVariations (CGFontRef _Nullable font, CFDictionaryRef _Nullable variations) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGFontRef* CGFontCreateCopyWithVariations ([NullAllowed] CGFontRef* font, [NullAllowed] CFDictionaryRef* variations);

    // extern CGFontRef _Nullable CGFontRetain (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGFontRef* CGFontRetain ([NullAllowed] CGFontRef* font);

    // extern void CGFontRelease (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGFontRelease ([NullAllowed] CGFontRef* font);

    // extern size_t CGFontGetNumberOfGlyphs (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGFontGetNumberOfGlyphs ([NullAllowed] CGFontRef* font);

    // extern int CGFontGetUnitsPerEm (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CGFontGetUnitsPerEm ([NullAllowed] CGFontRef* font);

    // extern CFStringRef _Nullable CGFontCopyPostScriptName (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGFontCopyPostScriptName ([NullAllowed] CGFontRef* font);

    // extern CFStringRef _Nullable CGFontCopyFullName (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGFontCopyFullName ([NullAllowed] CGFontRef* font);

    // extern int CGFontGetAscent (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CGFontGetAscent ([NullAllowed] CGFontRef* font);

    // extern int CGFontGetDescent (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CGFontGetDescent ([NullAllowed] CGFontRef* font);

    // extern int CGFontGetLeading (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CGFontGetLeading ([NullAllowed] CGFontRef* font);

    // extern int CGFontGetCapHeight (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CGFontGetCapHeight ([NullAllowed] CGFontRef* font);

    // extern int CGFontGetXHeight (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CGFontGetXHeight ([NullAllowed] CGFontRef* font);

    // extern CGRect CGFontGetFontBBox (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGFontGetFontBBox ([NullAllowed] CGFontRef* font);

    // extern CGFloat CGFontGetItalicAngle (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nfloat CGFontGetItalicAngle ([NullAllowed] CGFontRef* font);

    // extern CGFloat CGFontGetStemV (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nfloat CGFontGetStemV ([NullAllowed] CGFontRef* font);

    // extern CFArrayRef _Nullable CGFontCopyVariationAxes (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CGFontCopyVariationAxes ([NullAllowed] CGFontRef* font);

    // extern CFDictionaryRef _Nullable CGFontCopyVariations (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CGFontCopyVariations ([NullAllowed] CGFontRef* font);

    // extern _Bool CGFontGetGlyphAdvances (CGFontRef _Nullable font, const CGGlyph * _Nonnull glyphs, size_t count, int * _Nonnull advances) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGFontGetGlyphAdvances ([NullAllowed] CGFontRef* font, ushort* glyphs, nuint count, int* advances);

    // extern _Bool CGFontGetGlyphBBoxes (CGFontRef _Nullable font, const CGGlyph * _Nonnull glyphs, size_t count, CGRect * _Nonnull bboxes) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGFontGetGlyphBBoxes ([NullAllowed] CGFontRef* font, ushort* glyphs, nuint count, CGRect* bboxes);

    // extern CGGlyph CGFontGetGlyphWithGlyphName (CGFontRef _Nullable font, CFStringRef _Nullable name) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe ushort CGFontGetGlyphWithGlyphName ([NullAllowed] CGFontRef* font, [NullAllowed] CFStringRef* name);

    // extern CFStringRef _Nullable CGFontCopyGlyphNameForGlyph (CGFontRef _Nullable font, CGGlyph glyph) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGFontCopyGlyphNameForGlyph ([NullAllowed] CGFontRef* font, ushort glyph);

    // extern _Bool CGFontCanCreatePostScriptSubset (CGFontRef _Nullable font, CGFontPostScriptFormat format) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGFontCanCreatePostScriptSubset ([NullAllowed] CGFontRef* font, CGFontPostScriptFormat format);

    // extern CFDataRef _Nullable CGFontCreatePostScriptSubset (CGFontRef _Nullable font, CFStringRef _Nullable subsetName, CGFontPostScriptFormat format, const CGGlyph * _Nullable glyphs, size_t count, const CGGlyph * _Nonnull encoding) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CGFontCreatePostScriptSubset ([NullAllowed] CGFontRef* font, [NullAllowed] CFStringRef* subsetName, CGFontPostScriptFormat format, [NullAllowed] ushort* glyphs, nuint count, ushort[] encoding);

    // extern CFDataRef _Nullable CGFontCreatePostScriptEncoding (CGFontRef _Nullable font, const CGGlyph * _Nonnull encoding) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CGFontCreatePostScriptEncoding ([NullAllowed] CGFontRef* font, ushort[] encoding);

    // extern CFArrayRef _Nullable CGFontCopyTableTags (CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CGFontCopyTableTags ([NullAllowed] CGFontRef* font);

    // extern CFDataRef _Nullable CGFontCopyTableForTag (CGFontRef _Nullable font, uint32_t tag) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CGFontCopyTableForTag ([NullAllowed] CGFontRef* font, uint tag);

    // extern CFTypeID CGGradientGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGGradientGetTypeID ();

    // extern CGGradientRef _Nullable CGGradientCreateWithColorComponents (CGColorSpaceRef _Nullable space, const CGFloat * _Nullable components, const CGFloat * _Nullable locations, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGGradientRef* CGGradientCreateWithColorComponents ([NullAllowed] CGColorSpaceRef* space, [NullAllowed] nfloat* components, [NullAllowed] nfloat* locations, nuint count);

    // extern CGGradientRef _Nullable CGGradientCreateWithColors (CGColorSpaceRef _Nullable space, CFArrayRef _Nullable colors, const CGFloat * _Nullable locations) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGGradientRef* CGGradientCreateWithColors ([NullAllowed] CGColorSpaceRef* space, [NullAllowed] CFArrayRef* colors, [NullAllowed] nfloat* locations);

    // extern CGGradientRef _Nullable CGGradientRetain (CGGradientRef _Nullable gradient) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGGradientRef* CGGradientRetain ([NullAllowed] CGGradientRef* gradient);

    // extern void CGGradientRelease (CGGradientRef _Nullable gradient) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGGradientRelease ([NullAllowed] CGGradientRef* gradient);

    // extern CFTypeID CGImageGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGImageGetTypeID ();

    // extern CGImageRef _Nullable CGImageCreate (size_t width, size_t height, size_t bitsPerComponent, size_t bitsPerPixel, size_t bytesPerRow, CGColorSpaceRef _Nullable space, CGBitmapInfo bitmapInfo, CGDataProviderRef _Nullable provider, const CGFloat * _Nullable decode, _Bool shouldInterpolate, CGColorRenderingIntent intent) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageCreate (nuint width, nuint height, nuint bitsPerComponent, nuint bitsPerPixel, nuint bytesPerRow, [NullAllowed] CGColorSpaceRef* space, CGBitmapInfo bitmapInfo, [NullAllowed] CGDataProviderRef* provider, [NullAllowed] nfloat* decode, bool shouldInterpolate, CGColorRenderingIntent intent);

    // extern CGImageRef _Nullable CGImageMaskCreate (size_t width, size_t height, size_t bitsPerComponent, size_t bitsPerPixel, size_t bytesPerRow, CGDataProviderRef _Nullable provider, const CGFloat * _Nullable decode, _Bool shouldInterpolate) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageMaskCreate (nuint width, nuint height, nuint bitsPerComponent, nuint bitsPerPixel, nuint bytesPerRow, [NullAllowed] CGDataProviderRef* provider, [NullAllowed] nfloat* decode, bool shouldInterpolate);

    // extern CGImageRef _Nullable CGImageCreateCopy (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageCreateCopy ([NullAllowed] CGImageRef* image);

    // extern CGImageRef _Nullable CGImageCreateWithJPEGDataProvider (CGDataProviderRef _Nullable source, const CGFloat * _Nullable decode, _Bool shouldInterpolate, CGColorRenderingIntent intent) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageCreateWithJPEGDataProvider ([NullAllowed] CGDataProviderRef* source, [NullAllowed] nfloat* decode, bool shouldInterpolate, CGColorRenderingIntent intent);

    // extern CGImageRef _Nullable CGImageCreateWithPNGDataProvider (CGDataProviderRef _Nullable source, const CGFloat * _Nullable decode, _Bool shouldInterpolate, CGColorRenderingIntent intent) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageCreateWithPNGDataProvider ([NullAllowed] CGDataProviderRef* source, [NullAllowed] nfloat* decode, bool shouldInterpolate, CGColorRenderingIntent intent);

    // extern CGImageRef _Nullable CGImageCreateWithImageInRect (CGImageRef _Nullable image, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageCreateWithImageInRect ([NullAllowed] CGImageRef* image, CGRect rect);

    // extern CGImageRef _Nullable CGImageCreateWithMask (CGImageRef _Nullable image, CGImageRef _Nullable mask) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageCreateWithMask ([NullAllowed] CGImageRef* image, [NullAllowed] CGImageRef* mask);

    // extern CGImageRef _Nullable CGImageCreateWithMaskingColors (CGImageRef _Nullable image, const CGFloat * _Nullable components) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageCreateWithMaskingColors ([NullAllowed] CGImageRef* image, [NullAllowed] nfloat* components);

    // extern CGImageRef _Nullable CGImageCreateCopyWithColorSpace (CGImageRef _Nullable image, CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageCreateCopyWithColorSpace ([NullAllowed] CGImageRef* image, [NullAllowed] CGColorSpaceRef* space);

    // extern CGImageRef _Nullable CGImageRetain (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageRetain ([NullAllowed] CGImageRef* image);

    // extern void CGImageRelease (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageRelease ([NullAllowed] CGImageRef* image);

    // extern _Bool CGImageIsMask (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageIsMask ([NullAllowed] CGImageRef* image);

    // extern size_t CGImageGetWidth (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGImageGetWidth ([NullAllowed] CGImageRef* image);

    // extern size_t CGImageGetHeight (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGImageGetHeight ([NullAllowed] CGImageRef* image);

    // extern size_t CGImageGetBitsPerComponent (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGImageGetBitsPerComponent ([NullAllowed] CGImageRef* image);

    // extern size_t CGImageGetBitsPerPixel (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGImageGetBitsPerPixel ([NullAllowed] CGImageRef* image);

    // extern size_t CGImageGetBytesPerRow (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGImageGetBytesPerRow ([NullAllowed] CGImageRef* image);

    // extern CGColorSpaceRef _Nullable CGImageGetColorSpace (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGImageGetColorSpace ([NullAllowed] CGImageRef* image);

    // extern CGImageAlphaInfo CGImageGetAlphaInfo (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGImageAlphaInfo CGImageGetAlphaInfo ([NullAllowed] CGImageRef* image);

    // extern CGDataProviderRef _Nullable CGImageGetDataProvider (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataProviderRef* CGImageGetDataProvider ([NullAllowed] CGImageRef* image);

    // extern const CGFloat * _Nullable CGImageGetDecode (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe nfloat* CGImageGetDecode ([NullAllowed] CGImageRef* image);

    // extern _Bool CGImageGetShouldInterpolate (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageGetShouldInterpolate ([NullAllowed] CGImageRef* image);

    // extern CGColorRenderingIntent CGImageGetRenderingIntent (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGColorRenderingIntent CGImageGetRenderingIntent ([NullAllowed] CGImageRef* image);

    // extern CGBitmapInfo CGImageGetBitmapInfo (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGBitmapInfo CGImageGetBitmapInfo ([NullAllowed] CGImageRef* image);

    // extern CFStringRef _Nullable CGImageGetUTType (CGImageRef _Nullable image) __attribute__((availability(ios, introduced=9.0))) __attribute__((cf_audited_transfer));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGImageGetUTType ([NullAllowed] CGImageRef* image);

    // extern CFTypeID CGPathGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGPathGetTypeID ();

    // extern CGMutablePathRef _Nonnull CGPathCreateMutable () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGMutablePathRef* CGPathCreateMutable ();

    // extern CGPathRef _Nullable CGPathCreateCopy (CGPathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPathRef* CGPathCreateCopy ([NullAllowed] CGPathRef* path);

    // extern CGPathRef _Nullable CGPathCreateCopyByTransformingPath (CGPathRef _Nullable path, const CGAffineTransform * _Nullable transform) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPathRef* CGPathCreateCopyByTransformingPath ([NullAllowed] CGPathRef* path, [NullAllowed] CGAffineTransform* transform);

    // extern CGMutablePathRef _Nullable CGPathCreateMutableCopy (CGPathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGMutablePathRef* CGPathCreateMutableCopy ([NullAllowed] CGPathRef* path);

    // extern CGMutablePathRef _Nullable CGPathCreateMutableCopyByTransformingPath (CGPathRef _Nullable path, const CGAffineTransform * _Nullable transform) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGMutablePathRef* CGPathCreateMutableCopyByTransformingPath ([NullAllowed] CGPathRef* path, [NullAllowed] CGAffineTransform* transform);

    // extern CGPathRef _Nonnull CGPathCreateWithRect (CGRect rect, const CGAffineTransform * _Nullable transform) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPathRef* CGPathCreateWithRect (CGRect rect, [NullAllowed] CGAffineTransform* transform);

    // extern CGPathRef _Nonnull CGPathCreateWithEllipseInRect (CGRect rect, const CGAffineTransform * _Nullable transform) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPathRef* CGPathCreateWithEllipseInRect (CGRect rect, [NullAllowed] CGAffineTransform* transform);

    // extern CGPathRef _Nonnull CGPathCreateWithRoundedRect (CGRect rect, CGFloat cornerWidth, CGFloat cornerHeight, const CGAffineTransform * _Nullable transform) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPathRef* CGPathCreateWithRoundedRect (CGRect rect, nfloat cornerWidth, nfloat cornerHeight, [NullAllowed] CGAffineTransform* transform);

    // extern void CGPathAddRoundedRect (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable transform, CGRect rect, CGFloat cornerWidth, CGFloat cornerHeight) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddRoundedRect ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* transform, CGRect rect, nfloat cornerWidth, nfloat cornerHeight);

    // extern CGPathRef _Nullable CGPathCreateCopyByDashingPath (CGPathRef _Nullable path, const CGAffineTransform * _Nullable transform, CGFloat phase, const CGFloat * _Nullable lengths, size_t count) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPathRef* CGPathCreateCopyByDashingPath ([NullAllowed] CGPathRef* path, [NullAllowed] CGAffineTransform* transform, nfloat phase, [NullAllowed] nfloat* lengths, nuint count);

    // extern CGPathRef _Nullable CGPathCreateCopyByStrokingPath (CGPathRef _Nullable path, const CGAffineTransform * _Nullable transform, CGFloat lineWidth, CGLineCap lineCap, CGLineJoin lineJoin, CGFloat miterLimit) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPathRef* CGPathCreateCopyByStrokingPath ([NullAllowed] CGPathRef* path, [NullAllowed] CGAffineTransform* transform, nfloat lineWidth, CGLineCap lineCap, CGLineJoin lineJoin, nfloat miterLimit);

    // extern CGPathRef _Nullable CGPathRetain (CGPathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPathRef* CGPathRetain ([NullAllowed] CGPathRef* path);

    // extern void CGPathRelease (CGPathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathRelease ([NullAllowed] CGPathRef* path);

    // extern _Bool CGPathEqualToPath (CGPathRef _Nullable path1, CGPathRef _Nullable path2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPathEqualToPath ([NullAllowed] CGPathRef* path1, [NullAllowed] CGPathRef* path2);

    // extern void CGPathMoveToPoint (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathMoveToPoint ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, nfloat x, nfloat y);

    // extern void CGPathAddLineToPoint (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddLineToPoint ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, nfloat x, nfloat y);

    // extern void CGPathAddQuadCurveToPoint (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, CGFloat cpx, CGFloat cpy, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddQuadCurveToPoint ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, nfloat cpx, nfloat cpy, nfloat x, nfloat y);

    // extern void CGPathAddCurveToPoint (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, CGFloat cp1x, CGFloat cp1y, CGFloat cp2x, CGFloat cp2y, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddCurveToPoint ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, nfloat cp1x, nfloat cp1y, nfloat cp2x, nfloat cp2y, nfloat x, nfloat y);

    // extern void CGPathCloseSubpath (CGMutablePathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathCloseSubpath ([NullAllowed] CGMutablePathRef* path);

    // extern void CGPathAddRect (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddRect ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, CGRect rect);

    // extern void CGPathAddRects (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, const CGRect * _Nullable rects, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddRects ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, [NullAllowed] CGRect* rects, nuint count);

    // extern void CGPathAddLines (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, const CGPoint * _Nullable points, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddLines ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, [NullAllowed] CGPoint* points, nuint count);

    // extern void CGPathAddEllipseInRect (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddEllipseInRect ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, CGRect rect);

    // extern void CGPathAddRelativeArc (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable matrix, CGFloat x, CGFloat y, CGFloat radius, CGFloat startAngle, CGFloat delta) __attribute__((availability(ios, introduced=5.0))) __attribute__((cf_audited_transfer));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddRelativeArc ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* matrix, nfloat x, nfloat y, nfloat radius, nfloat startAngle, nfloat delta);

    // extern void CGPathAddArc (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, CGFloat x, CGFloat y, CGFloat radius, CGFloat startAngle, CGFloat endAngle, _Bool clockwise) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddArc ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, nfloat x, nfloat y, nfloat radius, nfloat startAngle, nfloat endAngle, bool clockwise);

    // extern void CGPathAddArcToPoint (CGMutablePathRef _Nullable path, const CGAffineTransform * _Nullable m, CGFloat x1, CGFloat y1, CGFloat x2, CGFloat y2, CGFloat radius) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddArcToPoint ([NullAllowed] CGMutablePathRef* path, [NullAllowed] CGAffineTransform* m, nfloat x1, nfloat y1, nfloat x2, nfloat y2, nfloat radius);

    // extern void CGPathAddPath (CGMutablePathRef _Nullable path1, const CGAffineTransform * _Nullable m, CGPathRef _Nullable path2) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathAddPath ([NullAllowed] CGMutablePathRef* path1, [NullAllowed] CGAffineTransform* m, [NullAllowed] CGPathRef* path2);

    // extern _Bool CGPathIsEmpty (CGPathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPathIsEmpty ([NullAllowed] CGPathRef* path);

    // extern _Bool CGPathIsRect (CGPathRef _Nullable path, CGRect * _Nullable rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPathIsRect ([NullAllowed] CGPathRef* path, [NullAllowed] CGRect* rect);

    // extern CGPoint CGPathGetCurrentPoint (CGPathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPoint CGPathGetCurrentPoint ([NullAllowed] CGPathRef* path);

    // extern CGRect CGPathGetBoundingBox (CGPathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGPathGetBoundingBox ([NullAllowed] CGPathRef* path);

    // extern CGRect CGPathGetPathBoundingBox (CGPathRef _Nullable path) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGPathGetPathBoundingBox ([NullAllowed] CGPathRef* path);

    // extern _Bool CGPathContainsPoint (CGPathRef _Nullable path, const CGAffineTransform * _Nullable m, CGPoint point, _Bool eoFill) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPathContainsPoint ([NullAllowed] CGPathRef* path, [NullAllowed] CGAffineTransform* m, CGPoint point, bool eoFill);

    // extern void CGPathApply (CGPathRef _Nullable path, void * _Nullable info, CGPathApplierFunction _Nullable function) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathApply ([NullAllowed] CGPathRef* path, [NullAllowed] void* info, [NullAllowed] CGPathApplierFunction* function);

    // extern void CGPathApplyWithBlock (CGPathRef _Nonnull path, CGPathApplyBlock _Nonnull block) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPathApplyWithBlock (CGPathRef* path, CGPathApplyBlock block);

    // extern CGPDFObjectType CGPDFObjectGetType (CGPDFObjectRef _Nullable object) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPDFObjectType CGPDFObjectGetType ([NullAllowed] CGPDFObjectRef* @object);

    // extern _Bool CGPDFObjectGetValue (CGPDFObjectRef _Nullable object, CGPDFObjectType type, void * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFObjectGetValue ([NullAllowed] CGPDFObjectRef* @object, CGPDFObjectType type, [NullAllowed] void* value);

    // extern CGPDFDictionaryRef _Nullable CGPDFStreamGetDictionary (CGPDFStreamRef _Nullable stream) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFDictionaryRef* CGPDFStreamGetDictionary ([NullAllowed] CGPDFStreamRef* stream);

    // extern CFDataRef _Nullable CGPDFStreamCopyData (CGPDFStreamRef _Nullable stream, CGPDFDataFormat * _Nullable format) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CGPDFStreamCopyData ([NullAllowed] CGPDFStreamRef* stream, [NullAllowed] CGPDFDataFormat* format);

    // extern size_t CGPDFStringGetLength (CGPDFStringRef _Nullable string) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGPDFStringGetLength ([NullAllowed] CGPDFStringRef* @string);

    // extern const unsigned char * _Nullable CGPDFStringGetBytePtr (CGPDFStringRef _Nullable string) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe byte* CGPDFStringGetBytePtr ([NullAllowed] CGPDFStringRef* @string);

    // extern CFStringRef _Nullable CGPDFStringCopyTextString (CGPDFStringRef _Nullable string) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGPDFStringCopyTextString ([NullAllowed] CGPDFStringRef* @string);

    // extern CFDateRef _Nullable CGPDFStringCopyDate (CGPDFStringRef _Nullable string) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDateRef* CGPDFStringCopyDate ([NullAllowed] CGPDFStringRef* @string);

    // extern size_t CGPDFArrayGetCount (CGPDFArrayRef _Nullable array) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGPDFArrayGetCount ([NullAllowed] CGPDFArrayRef* array);

    // extern _Bool CGPDFArrayGetObject (CGPDFArrayRef _Nullable array, size_t index, CGPDFObjectRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetObject ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] CGPDFObjectRef** value);

    // extern _Bool CGPDFArrayGetNull (CGPDFArrayRef _Nullable array, size_t index) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetNull ([NullAllowed] CGPDFArrayRef* array, nuint index);

    // extern _Bool CGPDFArrayGetBoolean (CGPDFArrayRef _Nullable array, size_t index, CGPDFBoolean * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetBoolean ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] byte* value);

    // extern _Bool CGPDFArrayGetInteger (CGPDFArrayRef _Nullable array, size_t index, CGPDFInteger * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetInteger ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] nint* value);

    // extern _Bool CGPDFArrayGetNumber (CGPDFArrayRef _Nullable array, size_t index, CGPDFReal * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetNumber ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] double* value);

    // extern _Bool CGPDFArrayGetName (CGPDFArrayRef _Nullable array, size_t index, const char * _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetName ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] sbyte** value);

    // extern _Bool CGPDFArrayGetString (CGPDFArrayRef _Nullable array, size_t index, CGPDFStringRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetString ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] CGPDFStringRef** value);

    // extern _Bool CGPDFArrayGetArray (CGPDFArrayRef _Nullable array, size_t index, CGPDFArrayRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetArray ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] CGPDFArrayRef** value);

    // extern _Bool CGPDFArrayGetDictionary (CGPDFArrayRef _Nullable array, size_t index, CGPDFDictionaryRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetDictionary ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] CGPDFDictionaryRef** value);

    // extern _Bool CGPDFArrayGetStream (CGPDFArrayRef _Nullable array, size_t index, CGPDFStreamRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFArrayGetStream ([NullAllowed] CGPDFArrayRef* array, nuint index, [NullAllowed] CGPDFStreamRef** value);

    // extern size_t CGPDFDictionaryGetCount (CGPDFDictionaryRef _Nullable dict) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGPDFDictionaryGetCount ([NullAllowed] CGPDFDictionaryRef* dict);

    // extern _Bool CGPDFDictionaryGetObject (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, CGPDFObjectRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetObject ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] CGPDFObjectRef** value);

    // extern _Bool CGPDFDictionaryGetBoolean (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, CGPDFBoolean * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetBoolean ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] byte* value);

    // extern _Bool CGPDFDictionaryGetInteger (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, CGPDFInteger * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetInteger ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] nint* value);

    // extern _Bool CGPDFDictionaryGetNumber (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, CGPDFReal * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetNumber ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] double* value);

    // extern _Bool CGPDFDictionaryGetName (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, const char * _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetName ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] sbyte** value);

    // extern _Bool CGPDFDictionaryGetString (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, CGPDFStringRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetString ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] CGPDFStringRef** value);

    // extern _Bool CGPDFDictionaryGetArray (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, CGPDFArrayRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetArray ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] CGPDFArrayRef** value);

    // extern _Bool CGPDFDictionaryGetDictionary (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, CGPDFDictionaryRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetDictionary ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] CGPDFDictionaryRef** value);

    // extern _Bool CGPDFDictionaryGetStream (CGPDFDictionaryRef _Nullable dict, const char * _Nonnull key, CGPDFStreamRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDictionaryGetStream ([NullAllowed] CGPDFDictionaryRef* dict, sbyte* key, [NullAllowed] CGPDFStreamRef** value);

    // extern void CGPDFDictionaryApplyFunction (CGPDFDictionaryRef _Nullable dict, CGPDFDictionaryApplierFunction _Nullable function, void * _Nullable info) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFDictionaryApplyFunction ([NullAllowed] CGPDFDictionaryRef* dict, [NullAllowed] CGPDFDictionaryApplierFunction* function, [NullAllowed] void* info);

    // extern CGPDFPageRef _Nullable CGPDFPageRetain (CGPDFPageRef _Nullable page) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFPageRef* CGPDFPageRetain ([NullAllowed] CGPDFPageRef* page);

    // extern void CGPDFPageRelease (CGPDFPageRef _Nullable page) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFPageRelease ([NullAllowed] CGPDFPageRef* page);

    // extern CGPDFDocumentRef _Nullable CGPDFPageGetDocument (CGPDFPageRef _Nullable page) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFDocumentRef* CGPDFPageGetDocument ([NullAllowed] CGPDFPageRef* page);

    // extern size_t CGPDFPageGetPageNumber (CGPDFPageRef _Nullable page) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGPDFPageGetPageNumber ([NullAllowed] CGPDFPageRef* page);

    // extern CGRect CGPDFPageGetBoxRect (CGPDFPageRef _Nullable page, CGPDFBox box) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGPDFPageGetBoxRect ([NullAllowed] CGPDFPageRef* page, CGPDFBox box);

    // extern int CGPDFPageGetRotationAngle (CGPDFPageRef _Nullable page) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CGPDFPageGetRotationAngle ([NullAllowed] CGPDFPageRef* page);

    // extern CGAffineTransform CGPDFPageGetDrawingTransform (CGPDFPageRef _Nullable page, CGPDFBox box, CGRect rect, int rotate, _Bool preserveAspectRatio) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGAffineTransform CGPDFPageGetDrawingTransform ([NullAllowed] CGPDFPageRef* page, CGPDFBox box, CGRect rect, int rotate, bool preserveAspectRatio);

    // extern CGPDFDictionaryRef _Nullable CGPDFPageGetDictionary (CGPDFPageRef _Nullable page) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFDictionaryRef* CGPDFPageGetDictionary ([NullAllowed] CGPDFPageRef* page);

    // extern CFTypeID CGPDFPageGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGPDFPageGetTypeID ();

    // extern CGPDFDocumentRef _Nullable CGPDFDocumentCreateWithProvider (CGDataProviderRef _Nullable provider) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFDocumentRef* CGPDFDocumentCreateWithProvider ([NullAllowed] CGDataProviderRef* provider);

    // extern CGPDFDocumentRef _Nullable CGPDFDocumentCreateWithURL (CFURLRef _Nullable url) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFDocumentRef* CGPDFDocumentCreateWithURL ([NullAllowed] CFURLRef* url);

    // extern CGPDFDocumentRef _Nullable CGPDFDocumentRetain (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFDocumentRef* CGPDFDocumentRetain ([NullAllowed] CGPDFDocumentRef* document);

    // extern void CGPDFDocumentRelease (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFDocumentRelease ([NullAllowed] CGPDFDocumentRef* document);

    // extern void CGPDFDocumentGetVersion (CGPDFDocumentRef _Nullable document, int * _Nonnull majorVersion, int * _Nonnull minorVersion) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFDocumentGetVersion ([NullAllowed] CGPDFDocumentRef* document, int* majorVersion, int* minorVersion);

    // extern _Bool CGPDFDocumentIsEncrypted (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDocumentIsEncrypted ([NullAllowed] CGPDFDocumentRef* document);

    // extern _Bool CGPDFDocumentUnlockWithPassword (CGPDFDocumentRef _Nullable document, const char * _Nonnull password) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDocumentUnlockWithPassword ([NullAllowed] CGPDFDocumentRef* document, sbyte* password);

    // extern _Bool CGPDFDocumentIsUnlocked (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDocumentIsUnlocked ([NullAllowed] CGPDFDocumentRef* document);

    // extern _Bool CGPDFDocumentAllowsPrinting (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDocumentAllowsPrinting ([NullAllowed] CGPDFDocumentRef* document);

    // extern _Bool CGPDFDocumentAllowsCopying (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFDocumentAllowsCopying ([NullAllowed] CGPDFDocumentRef* document);

    // extern size_t CGPDFDocumentGetNumberOfPages (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGPDFDocumentGetNumberOfPages ([NullAllowed] CGPDFDocumentRef* document);

    // extern CGPDFPageRef _Nullable CGPDFDocumentGetPage (CGPDFDocumentRef _Nullable document, size_t pageNumber) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFPageRef* CGPDFDocumentGetPage ([NullAllowed] CGPDFDocumentRef* document, nuint pageNumber);

    // extern CGPDFDictionaryRef _Nullable CGPDFDocumentGetCatalog (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFDictionaryRef* CGPDFDocumentGetCatalog ([NullAllowed] CGPDFDocumentRef* document);

    // extern CGPDFDictionaryRef _Nullable CGPDFDocumentGetInfo (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFDictionaryRef* CGPDFDocumentGetInfo ([NullAllowed] CGPDFDocumentRef* document);

    // extern CGPDFArrayRef _Nullable CGPDFDocumentGetID (CGPDFDocumentRef _Nullable document) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFArrayRef* CGPDFDocumentGetID ([NullAllowed] CGPDFDocumentRef* document);

    // extern CFTypeID CGPDFDocumentGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGPDFDocumentGetTypeID ();

    // extern CFDictionaryRef _Nullable CGPDFDocumentGetOutline (CGPDFDocumentRef _Nonnull document) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CGPDFDocumentGetOutline (CGPDFDocumentRef* document);

    // extern CGPDFAccessPermissions CGPDFDocumentGetAccessPermissions (CGPDFDocumentRef _Nonnull document) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPDFAccessPermissions CGPDFDocumentGetAccessPermissions (CGPDFDocumentRef* document);

    // extern CGRect CGPDFDocumentGetMediaBox (CGPDFDocumentRef _Nullable document, int page) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGPDFDocumentGetMediaBox ([NullAllowed] CGPDFDocumentRef* document, int page);

    // extern CGRect CGPDFDocumentGetCropBox (CGPDFDocumentRef _Nullable document, int page) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGPDFDocumentGetCropBox ([NullAllowed] CGPDFDocumentRef* document, int page);

    // extern CGRect CGPDFDocumentGetBleedBox (CGPDFDocumentRef _Nullable document, int page) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGPDFDocumentGetBleedBox ([NullAllowed] CGPDFDocumentRef* document, int page);

    // extern CGRect CGPDFDocumentGetTrimBox (CGPDFDocumentRef _Nullable document, int page) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGPDFDocumentGetTrimBox ([NullAllowed] CGPDFDocumentRef* document, int page);

    // extern CGRect CGPDFDocumentGetArtBox (CGPDFDocumentRef _Nullable document, int page) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGPDFDocumentGetArtBox ([NullAllowed] CGPDFDocumentRef* document, int page);

    // extern int CGPDFDocumentGetRotationAngle (CGPDFDocumentRef _Nullable document, int page) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe int CGPDFDocumentGetRotationAngle ([NullAllowed] CGPDFDocumentRef* document, int page);

    // extern CFTypeID CGFunctionGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGFunctionGetTypeID ();

    // extern CGFunctionRef _Nullable CGFunctionCreate (void * _Nullable info, size_t domainDimension, const CGFloat * _Nullable domain, size_t rangeDimension, const CGFloat * _Nullable range, const CGFunctionCallbacks * _Nullable callbacks) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGFunctionRef* CGFunctionCreate ([NullAllowed] void* info, nuint domainDimension, [NullAllowed] nfloat* domain, nuint rangeDimension, [NullAllowed] nfloat* range, [NullAllowed] CGFunctionCallbacks* callbacks);

    // extern CGFunctionRef _Nullable CGFunctionRetain (CGFunctionRef _Nullable function) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGFunctionRef* CGFunctionRetain ([NullAllowed] CGFunctionRef* function);

    // extern void CGFunctionRelease (CGFunctionRef _Nullable function) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGFunctionRelease ([NullAllowed] CGFunctionRef* function);

    // extern CFTypeID CGShadingGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGShadingGetTypeID ();

    // extern CGShadingRef _Nullable CGShadingCreateAxial (CGColorSpaceRef _Nullable space, CGPoint start, CGPoint end, CGFunctionRef _Nullable function, _Bool extendStart, _Bool extendEnd) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGShadingRef* CGShadingCreateAxial ([NullAllowed] CGColorSpaceRef* space, CGPoint start, CGPoint end, [NullAllowed] CGFunctionRef* function, bool extendStart, bool extendEnd);

    // extern CGShadingRef _Nullable CGShadingCreateRadial (CGColorSpaceRef _Nullable space, CGPoint start, CGFloat startRadius, CGPoint end, CGFloat endRadius, CGFunctionRef _Nullable function, _Bool extendStart, _Bool extendEnd) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGShadingRef* CGShadingCreateRadial ([NullAllowed] CGColorSpaceRef* space, CGPoint start, nfloat startRadius, CGPoint end, nfloat endRadius, [NullAllowed] CGFunctionRef* function, bool extendStart, bool extendEnd);

    // extern CGShadingRef _Nullable CGShadingRetain (CGShadingRef _Nullable shading) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGShadingRef* CGShadingRetain ([NullAllowed] CGShadingRef* shading);

    // extern void CGShadingRelease (CGShadingRef _Nullable shading) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGShadingRelease ([NullAllowed] CGShadingRef* shading);

    // extern CFTypeID CGContextGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGContextGetTypeID ();

    // extern void CGContextSaveGState (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSaveGState ([NullAllowed] CGContextRef* c);

    // extern void CGContextRestoreGState (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextRestoreGState ([NullAllowed] CGContextRef* c);

    // extern void CGContextScaleCTM (CGContextRef _Nullable c, CGFloat sx, CGFloat sy) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextScaleCTM ([NullAllowed] CGContextRef* c, nfloat sx, nfloat sy);

    // extern void CGContextTranslateCTM (CGContextRef _Nullable c, CGFloat tx, CGFloat ty) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextTranslateCTM ([NullAllowed] CGContextRef* c, nfloat tx, nfloat ty);

    // extern void CGContextRotateCTM (CGContextRef _Nullable c, CGFloat angle) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextRotateCTM ([NullAllowed] CGContextRef* c, nfloat angle);

    // extern void CGContextConcatCTM (CGContextRef _Nullable c, CGAffineTransform transform) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextConcatCTM ([NullAllowed] CGContextRef* c, CGAffineTransform transform);

    // extern CGAffineTransform CGContextGetCTM (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGAffineTransform CGContextGetCTM ([NullAllowed] CGContextRef* c);

    // extern void CGContextSetLineWidth (CGContextRef _Nullable c, CGFloat width) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetLineWidth ([NullAllowed] CGContextRef* c, nfloat width);

    // extern void CGContextSetLineCap (CGContextRef _Nullable c, CGLineCap cap) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetLineCap ([NullAllowed] CGContextRef* c, CGLineCap cap);

    // extern void CGContextSetLineJoin (CGContextRef _Nullable c, CGLineJoin join) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetLineJoin ([NullAllowed] CGContextRef* c, CGLineJoin join);

    // extern void CGContextSetMiterLimit (CGContextRef _Nullable c, CGFloat limit) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetMiterLimit ([NullAllowed] CGContextRef* c, nfloat limit);

    // extern void CGContextSetLineDash (CGContextRef _Nullable c, CGFloat phase, const CGFloat * _Nullable lengths, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetLineDash ([NullAllowed] CGContextRef* c, nfloat phase, [NullAllowed] nfloat* lengths, nuint count);

    // extern void CGContextSetFlatness (CGContextRef _Nullable c, CGFloat flatness) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetFlatness ([NullAllowed] CGContextRef* c, nfloat flatness);

    // extern void CGContextSetAlpha (CGContextRef _Nullable c, CGFloat alpha) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetAlpha ([NullAllowed] CGContextRef* c, nfloat alpha);

    // extern void CGContextSetBlendMode (CGContextRef _Nullable c, CGBlendMode mode) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetBlendMode ([NullAllowed] CGContextRef* c, CGBlendMode mode);

    // extern void CGContextBeginPath (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextBeginPath ([NullAllowed] CGContextRef* c);

    // extern void CGContextMoveToPoint (CGContextRef _Nullable c, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextMoveToPoint ([NullAllowed] CGContextRef* c, nfloat x, nfloat y);

    // extern void CGContextAddLineToPoint (CGContextRef _Nullable c, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddLineToPoint ([NullAllowed] CGContextRef* c, nfloat x, nfloat y);

    // extern void CGContextAddCurveToPoint (CGContextRef _Nullable c, CGFloat cp1x, CGFloat cp1y, CGFloat cp2x, CGFloat cp2y, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddCurveToPoint ([NullAllowed] CGContextRef* c, nfloat cp1x, nfloat cp1y, nfloat cp2x, nfloat cp2y, nfloat x, nfloat y);

    // extern void CGContextAddQuadCurveToPoint (CGContextRef _Nullable c, CGFloat cpx, CGFloat cpy, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddQuadCurveToPoint ([NullAllowed] CGContextRef* c, nfloat cpx, nfloat cpy, nfloat x, nfloat y);

    // extern void CGContextClosePath (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextClosePath ([NullAllowed] CGContextRef* c);

    // extern void CGContextAddRect (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddRect ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextAddRects (CGContextRef _Nullable c, const CGRect * _Nullable rects, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddRects ([NullAllowed] CGContextRef* c, [NullAllowed] CGRect* rects, nuint count);

    // extern void CGContextAddLines (CGContextRef _Nullable c, const CGPoint * _Nullable points, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddLines ([NullAllowed] CGContextRef* c, [NullAllowed] CGPoint* points, nuint count);

    // extern void CGContextAddEllipseInRect (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddEllipseInRect ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextAddArc (CGContextRef _Nullable c, CGFloat x, CGFloat y, CGFloat radius, CGFloat startAngle, CGFloat endAngle, int clockwise) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddArc ([NullAllowed] CGContextRef* c, nfloat x, nfloat y, nfloat radius, nfloat startAngle, nfloat endAngle, int clockwise);

    // extern void CGContextAddArcToPoint (CGContextRef _Nullable c, CGFloat x1, CGFloat y1, CGFloat x2, CGFloat y2, CGFloat radius) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddArcToPoint ([NullAllowed] CGContextRef* c, nfloat x1, nfloat y1, nfloat x2, nfloat y2, nfloat radius);

    // extern void CGContextAddPath (CGContextRef _Nullable c, CGPathRef _Nullable path) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextAddPath ([NullAllowed] CGContextRef* c, [NullAllowed] CGPathRef* path);

    // extern void CGContextReplacePathWithStrokedPath (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextReplacePathWithStrokedPath ([NullAllowed] CGContextRef* c);

    // extern _Bool CGContextIsPathEmpty (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGContextIsPathEmpty ([NullAllowed] CGContextRef* c);

    // extern CGPoint CGContextGetPathCurrentPoint (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPoint CGContextGetPathCurrentPoint ([NullAllowed] CGContextRef* c);

    // extern CGRect CGContextGetPathBoundingBox (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGContextGetPathBoundingBox ([NullAllowed] CGContextRef* c);

    // extern CGPathRef _Nullable CGContextCopyPath (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPathRef* CGContextCopyPath ([NullAllowed] CGContextRef* c);

    // extern _Bool CGContextPathContainsPoint (CGContextRef _Nullable c, CGPoint point, CGPathDrawingMode mode) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGContextPathContainsPoint ([NullAllowed] CGContextRef* c, CGPoint point, CGPathDrawingMode mode);

    // extern void CGContextDrawPath (CGContextRef _Nullable c, CGPathDrawingMode mode) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawPath ([NullAllowed] CGContextRef* c, CGPathDrawingMode mode);

    // extern void CGContextFillPath (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextFillPath ([NullAllowed] CGContextRef* c);

    // extern void CGContextEOFillPath (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextEOFillPath ([NullAllowed] CGContextRef* c);

    // extern void CGContextStrokePath (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextStrokePath ([NullAllowed] CGContextRef* c);

    // extern void CGContextFillRect (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextFillRect ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextFillRects (CGContextRef _Nullable c, const CGRect * _Nullable rects, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextFillRects ([NullAllowed] CGContextRef* c, [NullAllowed] CGRect* rects, nuint count);

    // extern void CGContextStrokeRect (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextStrokeRect ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextStrokeRectWithWidth (CGContextRef _Nullable c, CGRect rect, CGFloat width) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextStrokeRectWithWidth ([NullAllowed] CGContextRef* c, CGRect rect, nfloat width);

    // extern void CGContextClearRect (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextClearRect ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextFillEllipseInRect (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextFillEllipseInRect ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextStrokeEllipseInRect (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextStrokeEllipseInRect ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextStrokeLineSegments (CGContextRef _Nullable c, const CGPoint * _Nullable points, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextStrokeLineSegments ([NullAllowed] CGContextRef* c, [NullAllowed] CGPoint* points, nuint count);

    // extern void CGContextClip (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextClip ([NullAllowed] CGContextRef* c);

    // extern void CGContextEOClip (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextEOClip ([NullAllowed] CGContextRef* c);

    // extern void CGContextResetClip (CGContextRef _Nonnull c) __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextResetClip (CGContextRef* c);

    // extern void CGContextClipToMask (CGContextRef _Nullable c, CGRect rect, CGImageRef _Nullable mask) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextClipToMask ([NullAllowed] CGContextRef* c, CGRect rect, [NullAllowed] CGImageRef* mask);

    // extern CGRect CGContextGetClipBoundingBox (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGContextGetClipBoundingBox ([NullAllowed] CGContextRef* c);

    // extern void CGContextClipToRect (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextClipToRect ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextClipToRects (CGContextRef _Nullable c, const CGRect * _Nonnull rects, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextClipToRects ([NullAllowed] CGContextRef* c, CGRect* rects, nuint count);

    // extern void CGContextSetFillColorWithColor (CGContextRef _Nullable c, CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetFillColorWithColor ([NullAllowed] CGContextRef* c, [NullAllowed] CGColorRef* color);

    // extern void CGContextSetStrokeColorWithColor (CGContextRef _Nullable c, CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetStrokeColorWithColor ([NullAllowed] CGContextRef* c, [NullAllowed] CGColorRef* color);

    // extern void CGContextSetFillColorSpace (CGContextRef _Nullable c, CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetFillColorSpace ([NullAllowed] CGContextRef* c, [NullAllowed] CGColorSpaceRef* space);

    // extern void CGContextSetStrokeColorSpace (CGContextRef _Nullable c, CGColorSpaceRef _Nullable space) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetStrokeColorSpace ([NullAllowed] CGContextRef* c, [NullAllowed] CGColorSpaceRef* space);

    // extern void CGContextSetFillColor (CGContextRef _Nullable c, const CGFloat * _Nullable components) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetFillColor ([NullAllowed] CGContextRef* c, [NullAllowed] nfloat* components);

    // extern void CGContextSetStrokeColor (CGContextRef _Nullable c, const CGFloat * _Nullable components) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetStrokeColor ([NullAllowed] CGContextRef* c, [NullAllowed] nfloat* components);

    // extern void CGContextSetFillPattern (CGContextRef _Nullable c, CGPatternRef _Nullable pattern, const CGFloat * _Nullable components) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetFillPattern ([NullAllowed] CGContextRef* c, [NullAllowed] CGPatternRef* pattern, [NullAllowed] nfloat* components);

    // extern void CGContextSetStrokePattern (CGContextRef _Nullable c, CGPatternRef _Nullable pattern, const CGFloat * _Nullable components) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetStrokePattern ([NullAllowed] CGContextRef* c, [NullAllowed] CGPatternRef* pattern, [NullAllowed] nfloat* components);

    // extern void CGContextSetPatternPhase (CGContextRef _Nullable c, CGSize phase) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetPatternPhase ([NullAllowed] CGContextRef* c, CGSize phase);

    // extern void CGContextSetGrayFillColor (CGContextRef _Nullable c, CGFloat gray, CGFloat alpha) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetGrayFillColor ([NullAllowed] CGContextRef* c, nfloat gray, nfloat alpha);

    // extern void CGContextSetGrayStrokeColor (CGContextRef _Nullable c, CGFloat gray, CGFloat alpha) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetGrayStrokeColor ([NullAllowed] CGContextRef* c, nfloat gray, nfloat alpha);

    // extern void CGContextSetRGBFillColor (CGContextRef _Nullable c, CGFloat red, CGFloat green, CGFloat blue, CGFloat alpha) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetRGBFillColor ([NullAllowed] CGContextRef* c, nfloat red, nfloat green, nfloat blue, nfloat alpha);

    // extern void CGContextSetRGBStrokeColor (CGContextRef _Nullable c, CGFloat red, CGFloat green, CGFloat blue, CGFloat alpha) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetRGBStrokeColor ([NullAllowed] CGContextRef* c, nfloat red, nfloat green, nfloat blue, nfloat alpha);

    // extern void CGContextSetCMYKFillColor (CGContextRef _Nullable c, CGFloat cyan, CGFloat magenta, CGFloat yellow, CGFloat black, CGFloat alpha) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetCMYKFillColor ([NullAllowed] CGContextRef* c, nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha);

    // extern void CGContextSetCMYKStrokeColor (CGContextRef _Nullable c, CGFloat cyan, CGFloat magenta, CGFloat yellow, CGFloat black, CGFloat alpha) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetCMYKStrokeColor ([NullAllowed] CGContextRef* c, nfloat cyan, nfloat magenta, nfloat yellow, nfloat black, nfloat alpha);

    // extern void CGContextSetRenderingIntent (CGContextRef _Nullable c, CGColorRenderingIntent intent) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetRenderingIntent ([NullAllowed] CGContextRef* c, CGColorRenderingIntent intent);

    // extern void CGContextDrawImage (CGContextRef _Nullable c, CGRect rect, CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawImage ([NullAllowed] CGContextRef* c, CGRect rect, [NullAllowed] CGImageRef* image);

    // extern void CGContextDrawTiledImage (CGContextRef _Nullable c, CGRect rect, CGImageRef _Nullable image) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawTiledImage ([NullAllowed] CGContextRef* c, CGRect rect, [NullAllowed] CGImageRef* image);

    // extern CGInterpolationQuality CGContextGetInterpolationQuality (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGInterpolationQuality CGContextGetInterpolationQuality ([NullAllowed] CGContextRef* c);

    // extern void CGContextSetInterpolationQuality (CGContextRef _Nullable c, CGInterpolationQuality quality) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetInterpolationQuality ([NullAllowed] CGContextRef* c, CGInterpolationQuality quality);

    // extern void CGContextSetShadowWithColor (CGContextRef _Nullable c, CGSize offset, CGFloat blur, CGColorRef _Nullable color) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetShadowWithColor ([NullAllowed] CGContextRef* c, CGSize offset, nfloat blur, [NullAllowed] CGColorRef* color);

    // extern void CGContextSetShadow (CGContextRef _Nullable c, CGSize offset, CGFloat blur) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetShadow ([NullAllowed] CGContextRef* c, CGSize offset, nfloat blur);

    // extern void CGContextDrawLinearGradient (CGContextRef _Nullable c, CGGradientRef _Nullable gradient, CGPoint startPoint, CGPoint endPoint, CGGradientDrawingOptions options) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawLinearGradient ([NullAllowed] CGContextRef* c, [NullAllowed] CGGradientRef* gradient, CGPoint startPoint, CGPoint endPoint, CGGradientDrawingOptions options);

    // extern void CGContextDrawRadialGradient (CGContextRef _Nullable c, CGGradientRef _Nullable gradient, CGPoint startCenter, CGFloat startRadius, CGPoint endCenter, CGFloat endRadius, CGGradientDrawingOptions options) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawRadialGradient ([NullAllowed] CGContextRef* c, [NullAllowed] CGGradientRef* gradient, CGPoint startCenter, nfloat startRadius, CGPoint endCenter, nfloat endRadius, CGGradientDrawingOptions options);

    // extern void CGContextDrawShading (CGContextRef _Nullable c, CGShadingRef _Nullable shading) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawShading ([NullAllowed] CGContextRef* c, [NullAllowed] CGShadingRef* shading);

    // extern void CGContextSetCharacterSpacing (CGContextRef _Nullable c, CGFloat spacing) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetCharacterSpacing ([NullAllowed] CGContextRef* c, nfloat spacing);

    // extern void CGContextSetTextPosition (CGContextRef _Nullable c, CGFloat x, CGFloat y) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetTextPosition ([NullAllowed] CGContextRef* c, nfloat x, nfloat y);

    // extern CGPoint CGContextGetTextPosition (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPoint CGContextGetTextPosition ([NullAllowed] CGContextRef* c);

    // extern void CGContextSetTextMatrix (CGContextRef _Nullable c, CGAffineTransform t) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetTextMatrix ([NullAllowed] CGContextRef* c, CGAffineTransform t);

    // extern CGAffineTransform CGContextGetTextMatrix (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGAffineTransform CGContextGetTextMatrix ([NullAllowed] CGContextRef* c);

    // extern void CGContextSetTextDrawingMode (CGContextRef _Nullable c, CGTextDrawingMode mode) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetTextDrawingMode ([NullAllowed] CGContextRef* c, CGTextDrawingMode mode);

    // extern void CGContextSetFont (CGContextRef _Nullable c, CGFontRef _Nullable font) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetFont ([NullAllowed] CGContextRef* c, [NullAllowed] CGFontRef* font);

    // extern void CGContextSetFontSize (CGContextRef _Nullable c, CGFloat size) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetFontSize ([NullAllowed] CGContextRef* c, nfloat size);

    // extern void CGContextShowGlyphsAtPositions (CGContextRef _Nullable c, const CGGlyph * _Nullable glyphs, const CGPoint * _Nullable Lpositions, size_t count) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextShowGlyphsAtPositions ([NullAllowed] CGContextRef* c, [NullAllowed] ushort* glyphs, [NullAllowed] CGPoint* Lpositions, nuint count);

    // extern void CGContextDrawPDFPage (CGContextRef _Nullable c, CGPDFPageRef _Nullable page) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawPDFPage ([NullAllowed] CGContextRef* c, [NullAllowed] CGPDFPageRef* page);

    // extern void CGContextBeginPage (CGContextRef _Nullable c, const CGRect * _Nullable mediaBox) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextBeginPage ([NullAllowed] CGContextRef* c, [NullAllowed] CGRect* mediaBox);

    // extern void CGContextEndPage (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextEndPage ([NullAllowed] CGContextRef* c);

    // extern CGContextRef _Nullable CGContextRetain (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGContextRef* CGContextRetain ([NullAllowed] CGContextRef* c);

    // extern void CGContextRelease (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextRelease ([NullAllowed] CGContextRef* c);

    // extern void CGContextFlush (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextFlush ([NullAllowed] CGContextRef* c);

    // extern void CGContextSynchronize (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSynchronize ([NullAllowed] CGContextRef* c);

    // extern void CGContextSetShouldAntialias (CGContextRef _Nullable c, _Bool shouldAntialias) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetShouldAntialias ([NullAllowed] CGContextRef* c, bool shouldAntialias);

    // extern void CGContextSetAllowsAntialiasing (CGContextRef _Nullable c, _Bool allowsAntialiasing) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetAllowsAntialiasing ([NullAllowed] CGContextRef* c, bool allowsAntialiasing);

    // extern void CGContextSetShouldSmoothFonts (CGContextRef _Nullable c, _Bool shouldSmoothFonts) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetShouldSmoothFonts ([NullAllowed] CGContextRef* c, bool shouldSmoothFonts);

    // extern void CGContextSetAllowsFontSmoothing (CGContextRef _Nullable c, _Bool allowsFontSmoothing) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetAllowsFontSmoothing ([NullAllowed] CGContextRef* c, bool allowsFontSmoothing);

    // extern void CGContextSetShouldSubpixelPositionFonts (CGContextRef _Nullable c, _Bool shouldSubpixelPositionFonts) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetShouldSubpixelPositionFonts ([NullAllowed] CGContextRef* c, bool shouldSubpixelPositionFonts);

    // extern void CGContextSetAllowsFontSubpixelPositioning (CGContextRef _Nullable c, _Bool allowsFontSubpixelPositioning) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetAllowsFontSubpixelPositioning ([NullAllowed] CGContextRef* c, bool allowsFontSubpixelPositioning);

    // extern void CGContextSetShouldSubpixelQuantizeFonts (CGContextRef _Nullable c, _Bool shouldSubpixelQuantizeFonts) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetShouldSubpixelQuantizeFonts ([NullAllowed] CGContextRef* c, bool shouldSubpixelQuantizeFonts);

    // extern void CGContextSetAllowsFontSubpixelQuantization (CGContextRef _Nullable c, _Bool allowsFontSubpixelQuantization) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSetAllowsFontSubpixelQuantization ([NullAllowed] CGContextRef* c, bool allowsFontSubpixelQuantization);

    // extern void CGContextBeginTransparencyLayer (CGContextRef _Nullable c, CFDictionaryRef _Nullable auxiliaryInfo) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextBeginTransparencyLayer ([NullAllowed] CGContextRef* c, [NullAllowed] CFDictionaryRef* auxiliaryInfo);

    // extern void CGContextBeginTransparencyLayerWithRect (CGContextRef _Nullable c, CGRect rect, CFDictionaryRef _Nullable auxInfo) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextBeginTransparencyLayerWithRect ([NullAllowed] CGContextRef* c, CGRect rect, [NullAllowed] CFDictionaryRef* auxInfo);

    // extern void CGContextEndTransparencyLayer (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextEndTransparencyLayer ([NullAllowed] CGContextRef* c);

    // extern CGAffineTransform CGContextGetUserSpaceToDeviceSpaceTransform (CGContextRef _Nullable c) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGAffineTransform CGContextGetUserSpaceToDeviceSpaceTransform ([NullAllowed] CGContextRef* c);

    // extern CGPoint CGContextConvertPointToDeviceSpace (CGContextRef _Nullable c, CGPoint point) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPoint CGContextConvertPointToDeviceSpace ([NullAllowed] CGContextRef* c, CGPoint point);

    // extern CGPoint CGContextConvertPointToUserSpace (CGContextRef _Nullable c, CGPoint point) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPoint CGContextConvertPointToUserSpace ([NullAllowed] CGContextRef* c, CGPoint point);

    // extern CGSize CGContextConvertSizeToDeviceSpace (CGContextRef _Nullable c, CGSize size) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGSize CGContextConvertSizeToDeviceSpace ([NullAllowed] CGContextRef* c, CGSize size);

    // extern CGSize CGContextConvertSizeToUserSpace (CGContextRef _Nullable c, CGSize size) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGSize CGContextConvertSizeToUserSpace ([NullAllowed] CGContextRef* c, CGSize size);

    // extern CGRect CGContextConvertRectToDeviceSpace (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGContextConvertRectToDeviceSpace ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern CGRect CGContextConvertRectToUserSpace (CGContextRef _Nullable c, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CGContextConvertRectToUserSpace ([NullAllowed] CGContextRef* c, CGRect rect);

    // extern void CGContextSelectFont (CGContextRef _Nullable c, const char * _Nullable name, CGFloat size, CGTextEncoding textEncoding) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 7, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextSelectFont ([NullAllowed] CGContextRef* c, [NullAllowed] sbyte* name, nfloat size, CGTextEncoding textEncoding);

    // extern void CGContextShowText (CGContextRef _Nullable c, const char * _Nullable string, size_t length) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 7, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextShowText ([NullAllowed] CGContextRef* c, [NullAllowed] sbyte* @string, nuint length);

    // extern void CGContextShowTextAtPoint (CGContextRef _Nullable c, CGFloat x, CGFloat y, const char * _Nullable string, size_t length) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 7, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextShowTextAtPoint ([NullAllowed] CGContextRef* c, nfloat x, nfloat y, [NullAllowed] sbyte* @string, nuint length);

    // extern void CGContextShowGlyphs (CGContextRef _Nullable c, const CGGlyph * _Nullable g, size_t count) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 7, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextShowGlyphs ([NullAllowed] CGContextRef* c, [NullAllowed] ushort* g, nuint count);

    // extern void CGContextShowGlyphsAtPoint (CGContextRef _Nullable c, CGFloat x, CGFloat y, const CGGlyph * _Nullable glyphs, size_t count) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 7, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextShowGlyphsAtPoint ([NullAllowed] CGContextRef* c, nfloat x, nfloat y, [NullAllowed] ushort* glyphs, nuint count);

    // extern void CGContextShowGlyphsWithAdvances (CGContextRef _Nullable c, const CGGlyph * _Nullable glyphs, const CGSize * _Nullable advances, size_t count) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((cf_audited_transfer));
    [Introduced (PlatformName.iOS, 2, 0)]
    [Deprecated (PlatformName.iOS, 7, 0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextShowGlyphsWithAdvances ([NullAllowed] CGContextRef* c, [NullAllowed] ushort* glyphs, [NullAllowed] CGSize* advances, nuint count);

    // extern void CGContextDrawPDFDocument (CGContextRef _Nullable c, CGRect rect, CGPDFDocumentRef _Nullable document, int page) __attribute__((availability(ios, unavailable))) __attribute__((cf_audited_transfer));
    [NoiOS]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawPDFDocument ([NullAllowed] CGContextRef* c, CGRect rect, [NullAllowed] CGPDFDocumentRef* document, int page);

    // extern CGContextRef _Nullable CGBitmapContextCreateWithData (void * _Nullable data, size_t width, size_t height, size_t bitsPerComponent, size_t bytesPerRow, CGColorSpaceRef _Nullable space, uint32_t bitmapInfo, CGBitmapContextReleaseDataCallback _Nullable releaseCallback, void * _Nullable releaseInfo) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGContextRef* CGBitmapContextCreateWithData ([NullAllowed] void* data, nuint width, nuint height, nuint bitsPerComponent, nuint bytesPerRow, [NullAllowed] CGColorSpaceRef* space, uint bitmapInfo, [NullAllowed] CGBitmapContextReleaseDataCallback* releaseCallback, [NullAllowed] void* releaseInfo);

    // extern CGContextRef _Nullable CGBitmapContextCreate (void * _Nullable data, size_t width, size_t height, size_t bitsPerComponent, size_t bytesPerRow, CGColorSpaceRef _Nullable space, uint32_t bitmapInfo) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGContextRef* CGBitmapContextCreate ([NullAllowed] void* data, nuint width, nuint height, nuint bitsPerComponent, nuint bytesPerRow, [NullAllowed] CGColorSpaceRef* space, uint bitmapInfo);

    // extern void * _Nullable CGBitmapContextGetData (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CGBitmapContextGetData ([NullAllowed] CGContextRef* context);

    // extern size_t CGBitmapContextGetWidth (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGBitmapContextGetWidth ([NullAllowed] CGContextRef* context);

    // extern size_t CGBitmapContextGetHeight (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGBitmapContextGetHeight ([NullAllowed] CGContextRef* context);

    // extern size_t CGBitmapContextGetBitsPerComponent (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGBitmapContextGetBitsPerComponent ([NullAllowed] CGContextRef* context);

    // extern size_t CGBitmapContextGetBitsPerPixel (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGBitmapContextGetBitsPerPixel ([NullAllowed] CGContextRef* context);

    // extern size_t CGBitmapContextGetBytesPerRow (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGBitmapContextGetBytesPerRow ([NullAllowed] CGContextRef* context);

    // extern CGColorSpaceRef _Nullable CGBitmapContextGetColorSpace (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CGBitmapContextGetColorSpace ([NullAllowed] CGContextRef* context);

    // extern CGImageAlphaInfo CGBitmapContextGetAlphaInfo (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGImageAlphaInfo CGBitmapContextGetAlphaInfo ([NullAllowed] CGContextRef* context);

    // extern CGBitmapInfo CGBitmapContextGetBitmapInfo (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGBitmapInfo CGBitmapContextGetBitmapInfo ([NullAllowed] CGContextRef* context);

    // extern CGImageRef _Nullable CGBitmapContextCreateImage (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGBitmapContextCreateImage ([NullAllowed] CGContextRef* context);

    // extern CFTypeID CGColorConversionInfoGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CGColorConversionInfoGetTypeID ();

    // extern CGColorConversionInfoRef _Nullable CGColorConversionInfoCreate (CGColorSpaceRef _Nullable src, CGColorSpaceRef _Nullable dst) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorConversionInfoRef* CGColorConversionInfoCreate ([NullAllowed] CGColorSpaceRef* src, [NullAllowed] CGColorSpaceRef* dst);

    // extern CGColorConversionInfoRef _Nullable CGColorConversionInfoCreateFromList (CFDictionaryRef _Nullable options, CGColorSpaceRef _Nullable, CGColorConversionInfoTransformType, CGColorRenderingIntent, ...) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
   
   
    // extern CFTypeID CGDataConsumerGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGDataConsumerGetTypeID ();

    // extern CGDataConsumerRef _Nullable CGDataConsumerCreate (void * _Nullable info, const CGDataConsumerCallbacks * _Nullable cbks) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataConsumerRef* CGDataConsumerCreate ([NullAllowed] void* info, [NullAllowed] CGDataConsumerCallbacks* cbks);

    // extern CGDataConsumerRef _Nullable CGDataConsumerCreateWithURL (CFURLRef _Nullable url) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataConsumerRef* CGDataConsumerCreateWithURL ([NullAllowed] CFURLRef* url);

    // extern CGDataConsumerRef _Nullable CGDataConsumerCreateWithCFData (CFMutableDataRef _Nullable data) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataConsumerRef* CGDataConsumerCreateWithCFData ([NullAllowed] CFMutableDataRef* data);

    // extern CGDataConsumerRef _Nullable CGDataConsumerRetain (CGDataConsumerRef _Nullable consumer) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGDataConsumerRef* CGDataConsumerRetain ([NullAllowed] CGDataConsumerRef* consumer);

    // extern void CGDataConsumerRelease (CGDataConsumerRef _Nullable consumer) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGDataConsumerRelease ([NullAllowed] CGDataConsumerRef* consumer);

    // extern CGLayerRef _Nullable CGLayerCreateWithContext (CGContextRef _Nullable context, CGSize size, CFDictionaryRef _Nullable auxiliaryInfo) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGLayerRef* CGLayerCreateWithContext ([NullAllowed] CGContextRef* context, CGSize size, [NullAllowed] CFDictionaryRef* auxiliaryInfo);

    // extern CGLayerRef _Nullable CGLayerRetain (CGLayerRef _Nullable layer) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGLayerRef* CGLayerRetain ([NullAllowed] CGLayerRef* layer);

    // extern void CGLayerRelease (CGLayerRef _Nullable layer) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGLayerRelease ([NullAllowed] CGLayerRef* layer);

    // extern CGSize CGLayerGetSize (CGLayerRef _Nullable layer) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGSize CGLayerGetSize ([NullAllowed] CGLayerRef* layer);

    // extern CGContextRef _Nullable CGLayerGetContext (CGLayerRef _Nullable layer) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGContextRef* CGLayerGetContext ([NullAllowed] CGLayerRef* layer);

    // extern void CGContextDrawLayerInRect (CGContextRef _Nullable context, CGRect rect, CGLayerRef _Nullable layer) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawLayerInRect ([NullAllowed] CGContextRef* context, CGRect rect, [NullAllowed] CGLayerRef* layer);

    // extern void CGContextDrawLayerAtPoint (CGContextRef _Nullable context, CGPoint point, CGLayerRef _Nullable layer) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGContextDrawLayerAtPoint ([NullAllowed] CGContextRef* context, CGPoint point, [NullAllowed] CGLayerRef* layer);

    // extern CFTypeID CGLayerGetTypeID () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGLayerGetTypeID ();

    // extern CGPDFContentStreamRef _Nonnull CGPDFContentStreamCreateWithPage (CGPDFPageRef _Nonnull page) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPDFContentStreamRef* CGPDFContentStreamCreateWithPage (CGPDFPageRef* page);

    // extern CGPDFContentStreamRef _Nonnull CGPDFContentStreamCreateWithStream (CGPDFStreamRef _Nonnull stream, CGPDFDictionaryRef _Nonnull streamResources, CGPDFContentStreamRef _Nullable parent) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPDFContentStreamRef* CGPDFContentStreamCreateWithStream (CGPDFStreamRef* stream, CGPDFDictionaryRef* streamResources, [NullAllowed] CGPDFContentStreamRef* parent);

    // extern CGPDFContentStreamRef _Nonnull CGPDFContentStreamRetain (CGPDFContentStreamRef _Nonnull cs) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPDFContentStreamRef* CGPDFContentStreamRetain (CGPDFContentStreamRef* cs);

    // extern void CGPDFContentStreamRelease (CGPDFContentStreamRef _Nonnull cs) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContentStreamRelease (CGPDFContentStreamRef* cs);

    // extern CFArrayRef _Nullable CGPDFContentStreamGetStreams (CGPDFContentStreamRef _Nonnull cs) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CGPDFContentStreamGetStreams (CGPDFContentStreamRef* cs);

    // extern CGPDFObjectRef _Nullable CGPDFContentStreamGetResource (CGPDFContentStreamRef _Nonnull cs, const char * _Nonnull category, const char * _Nonnull name) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFObjectRef* CGPDFContentStreamGetResource (CGPDFContentStreamRef* cs, sbyte* category, sbyte* name);

    // extern CGContextRef _Nullable CGPDFContextCreate (CGDataConsumerRef _Nullable consumer, const CGRect * _Nullable mediaBox, CFDictionaryRef _Nullable auxiliaryInfo) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGContextRef* CGPDFContextCreate ([NullAllowed] CGDataConsumerRef* consumer, [NullAllowed] CGRect* mediaBox, [NullAllowed] CFDictionaryRef* auxiliaryInfo);

    // extern CGContextRef _Nullable CGPDFContextCreateWithURL (CFURLRef _Nullable url, const CGRect * _Nullable mediaBox, CFDictionaryRef _Nullable auxiliaryInfo) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGContextRef* CGPDFContextCreateWithURL ([NullAllowed] CFURLRef* url, [NullAllowed] CGRect* mediaBox, [NullAllowed] CFDictionaryRef* auxiliaryInfo);

    // extern void CGPDFContextClose (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContextClose ([NullAllowed] CGContextRef* context);

    // extern void CGPDFContextBeginPage (CGContextRef _Nullable context, CFDictionaryRef _Nullable pageInfo) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContextBeginPage ([NullAllowed] CGContextRef* context, [NullAllowed] CFDictionaryRef* pageInfo);

    // extern void CGPDFContextEndPage (CGContextRef _Nullable context) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContextEndPage ([NullAllowed] CGContextRef* context);

    // extern void CGPDFContextAddDocumentMetadata (CGContextRef _Nullable context, CFDataRef _Nullable metadata) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContextAddDocumentMetadata ([NullAllowed] CGContextRef* context, [NullAllowed] CFDataRef* metadata);

    // extern void CGPDFContextSetURLForRect (CGContextRef _Nullable context, CFURLRef _Nonnull url, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContextSetURLForRect ([NullAllowed] CGContextRef* context, CFURLRef* url, CGRect rect);

    // extern void CGPDFContextAddDestinationAtPoint (CGContextRef _Nullable context, CFStringRef _Nonnull name, CGPoint point) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContextAddDestinationAtPoint ([NullAllowed] CGContextRef* context, CFStringRef* name, CGPoint point);

    // extern void CGPDFContextSetDestinationForRect (CGContextRef _Nullable context, CFStringRef _Nonnull name, CGRect rect) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContextSetDestinationForRect ([NullAllowed] CGContextRef* context, CFStringRef* name, CGRect rect);

    // extern void CGPDFContextSetOutline (CGContextRef _Nonnull context, CFDictionaryRef _Nullable outline) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFContextSetOutline (CGContextRef* context, [NullAllowed] CFDictionaryRef* outline);

    // extern CGPDFScannerRef _Nonnull CGPDFScannerCreate (CGPDFContentStreamRef _Nonnull cs, CGPDFOperatorTableRef _Nullable table, void * _Nullable info) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPDFScannerRef* CGPDFScannerCreate (CGPDFContentStreamRef* cs, [NullAllowed] CGPDFOperatorTableRef* table, [NullAllowed] void* info);

    // extern CGPDFScannerRef _Nullable CGPDFScannerRetain (CGPDFScannerRef _Nullable scanner) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFScannerRef* CGPDFScannerRetain ([NullAllowed] CGPDFScannerRef* scanner);

    // extern void CGPDFScannerRelease (CGPDFScannerRef _Nullable scanner) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFScannerRelease ([NullAllowed] CGPDFScannerRef* scanner);

    // extern _Bool CGPDFScannerScan (CGPDFScannerRef _Nullable scanner) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerScan ([NullAllowed] CGPDFScannerRef* scanner);

    // extern CGPDFContentStreamRef _Nonnull CGPDFScannerGetContentStream (CGPDFScannerRef _Nonnull scanner) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGPDFContentStreamRef* CGPDFScannerGetContentStream (CGPDFScannerRef* scanner);

    // extern _Bool CGPDFScannerPopObject (CGPDFScannerRef _Nonnull scanner, CGPDFObjectRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopObject (CGPDFScannerRef* scanner, [NullAllowed] CGPDFObjectRef** value);

    // extern _Bool CGPDFScannerPopBoolean (CGPDFScannerRef _Nonnull scanner, CGPDFBoolean * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopBoolean (CGPDFScannerRef* scanner, [NullAllowed] byte* value);

    // extern _Bool CGPDFScannerPopInteger (CGPDFScannerRef _Nonnull scanner, CGPDFInteger * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopInteger (CGPDFScannerRef* scanner, [NullAllowed] nint* value);

    // extern _Bool CGPDFScannerPopNumber (CGPDFScannerRef _Nonnull scanner, CGPDFReal * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopNumber (CGPDFScannerRef* scanner, [NullAllowed] double* value);

    // extern _Bool CGPDFScannerPopName (CGPDFScannerRef _Nonnull scanner, const char * _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopName (CGPDFScannerRef* scanner, [NullAllowed] sbyte** value);

    // extern _Bool CGPDFScannerPopString (CGPDFScannerRef _Nonnull scanner, CGPDFStringRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopString (CGPDFScannerRef* scanner, [NullAllowed] CGPDFStringRef** value);

    // extern _Bool CGPDFScannerPopArray (CGPDFScannerRef _Nonnull scanner, CGPDFArrayRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopArray (CGPDFScannerRef* scanner, [NullAllowed] CGPDFArrayRef** value);

    // extern _Bool CGPDFScannerPopDictionary (CGPDFScannerRef _Nonnull scanner, CGPDFDictionaryRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopDictionary (CGPDFScannerRef* scanner, [NullAllowed] CGPDFDictionaryRef** value);

    // extern _Bool CGPDFScannerPopStream (CGPDFScannerRef _Nonnull scanner, CGPDFStreamRef  _Nullable * _Nullable value) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGPDFScannerPopStream (CGPDFScannerRef* scanner, [NullAllowed] CGPDFStreamRef** value);

    // extern CGPDFOperatorTableRef _Nullable CGPDFOperatorTableCreate () __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFOperatorTableRef* CGPDFOperatorTableCreate ();

    // extern CGPDFOperatorTableRef _Nullable CGPDFOperatorTableRetain (CGPDFOperatorTableRef _Nullable table) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGPDFOperatorTableRef* CGPDFOperatorTableRetain ([NullAllowed] CGPDFOperatorTableRef* table);

    // extern void CGPDFOperatorTableRelease (CGPDFOperatorTableRef _Nullable table) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFOperatorTableRelease ([NullAllowed] CGPDFOperatorTableRef* table);

    // extern void CGPDFOperatorTableSetCallback (CGPDFOperatorTableRef _Nullable table, const char * _Nullable name, CGPDFOperatorCallback _Nullable callback) __attribute__((availability(ios, introduced=2.0))) __attribute__((cf_audited_transfer));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGPDFOperatorTableSetCallback ([NullAllowed] CGPDFOperatorTableRef* table, [NullAllowed] sbyte* name, [NullAllowed] CGPDFOperatorCallback* callback);

    // extern CFTimeInterval CACurrentMediaTime () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=2.0)));
    [iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern double CACurrentMediaTime ();

    // extern _Bool CATransform3DIsIdentity (CATransform3D t) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CATransform3DIsIdentity (CATransform3D t);

    // extern _Bool CATransform3DEqualToTransform (CATransform3D a, CATransform3D b) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CATransform3DEqualToTransform (CATransform3D a, CATransform3D b);

    // extern CATransform3D CATransform3DMakeTranslation (CGFloat tx, CGFloat ty, CGFloat tz) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DMakeTranslation (nfloat tx, nfloat ty, nfloat tz);

    // extern CATransform3D CATransform3DMakeScale (CGFloat sx, CGFloat sy, CGFloat sz) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DMakeScale (nfloat sx, nfloat sy, nfloat sz);

    // extern CATransform3D CATransform3DMakeRotation (CGFloat angle, CGFloat x, CGFloat y, CGFloat z) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DMakeRotation (nfloat angle, nfloat x, nfloat y, nfloat z);

    // extern CATransform3D CATransform3DTranslate (CATransform3D t, CGFloat tx, CGFloat ty, CGFloat tz) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DTranslate (CATransform3D t, nfloat tx, nfloat ty, nfloat tz);

    // extern CATransform3D CATransform3DScale (CATransform3D t, CGFloat sx, CGFloat sy, CGFloat sz) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DScale (CATransform3D t, nfloat sx, nfloat sy, nfloat sz);

    // extern CATransform3D CATransform3DRotate (CATransform3D t, CGFloat angle, CGFloat x, CGFloat y, CGFloat z) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DRotate (CATransform3D t, nfloat angle, nfloat x, nfloat y, nfloat z);

    // extern CATransform3D CATransform3DConcat (CATransform3D a, CATransform3D b) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DConcat (CATransform3D a, CATransform3D b);

    // extern CATransform3D CATransform3DInvert (CATransform3D t) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DInvert (CATransform3D t);

    // extern CATransform3D CATransform3DMakeAffineTransform (CGAffineTransform m) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CATransform3D CATransform3DMakeAffineTransform (CGAffineTransform m);

    // extern _Bool CATransform3DIsAffine (CATransform3D t) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern bool CATransform3DIsAffine (CATransform3D t);

    // extern CGAffineTransform CATransform3DGetAffineTransform (CATransform3D t) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(macos, introduced=10.5)));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CATransform3DGetAffineTransform (CATransform3D t);

    // extern void EAGLGetVersion (unsigned int * _Nonnull major, unsigned int * _Nonnull minor) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern unsafe void EAGLGetVersion (uint* major, uint* minor);

    // extern CVBufferRef _Nullable CVBufferRetain (CVBufferRef _Nullable buffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CVBufferRef* CVBufferRetain ([NullAllowed] CVBufferRef* buffer);

    // extern void CVBufferRelease (CVBufferRef _Nullable buffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVBufferRelease ([NullAllowed] CVBufferRef* buffer);

    // extern void CVBufferSetAttachment (CVBufferRef _Nonnull buffer, CFStringRef _Nonnull key, CFTypeRef _Nonnull value, CVAttachmentMode attachmentMode) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVBufferSetAttachment (CVBufferRef* buffer, CFStringRef* key, void* value, CVAttachmentMode attachmentMode);

    // extern CFTypeRef _Nullable CVBufferGetAttachment (CVBufferRef _Nonnull buffer, CFStringRef _Nonnull key, CVAttachmentMode * _Nullable attachmentMode) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CVBufferGetAttachment (CVBufferRef* buffer, CFStringRef* key, [NullAllowed] CVAttachmentMode* attachmentMode);

    // extern void CVBufferRemoveAttachment (CVBufferRef _Nonnull buffer, CFStringRef _Nonnull key) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVBufferRemoveAttachment (CVBufferRef* buffer, CFStringRef* key);

    // extern void CVBufferRemoveAllAttachments (CVBufferRef _Nonnull buffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVBufferRemoveAllAttachments (CVBufferRef* buffer);

    // extern CFDictionaryRef _Nullable CVBufferGetAttachments (CVBufferRef _Nonnull buffer, CVAttachmentMode attachmentMode) __attribute__((cf_returns_not_retained)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CVBufferGetAttachments (CVBufferRef* buffer, CVAttachmentMode attachmentMode);

    // extern void CVBufferSetAttachments (CVBufferRef _Nonnull buffer, CFDictionaryRef _Nonnull theAttachments, CVAttachmentMode attachmentMode) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVBufferSetAttachments (CVBufferRef* buffer, CFDictionaryRef* theAttachments, CVAttachmentMode attachmentMode);

    // extern void CVBufferPropagateAttachments (CVBufferRef _Nonnull sourceBuffer, CVBufferRef _Nonnull destinationBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVBufferPropagateAttachments (CVBufferRef* sourceBuffer, CVBufferRef* destinationBuffer);

    // extern int CVYCbCrMatrixGetIntegerCodePointForString (CFStringRef _Nullable yCbCrMatrixString) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(macos, introduced=10.13)));
    [Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVYCbCrMatrixGetIntegerCodePointForString ([NullAllowed] CFStringRef* yCbCrMatrixString);

    // extern int CVColorPrimariesGetIntegerCodePointForString (CFStringRef _Nullable colorPrimariesString) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(macos, introduced=10.13)));
    [Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVColorPrimariesGetIntegerCodePointForString ([NullAllowed] CFStringRef* colorPrimariesString);

    // extern int CVTransferFunctionGetIntegerCodePointForString (CFStringRef _Nullable transferFunctionString) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(macos, introduced=10.13)));
    [Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVTransferFunctionGetIntegerCodePointForString ([NullAllowed] CFStringRef* transferFunctionString);

    // extern CFStringRef _Nullable CVYCbCrMatrixGetStringForIntegerCodePoint (int yCbCrMatrixCodePoint) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(macos, introduced=10.13)));
    [Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CVYCbCrMatrixGetStringForIntegerCodePoint (int yCbCrMatrixCodePoint);

    // extern CFStringRef _Nullable CVColorPrimariesGetStringForIntegerCodePoint (int colorPrimariesCodePoint) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(macos, introduced=10.13)));
    [Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CVColorPrimariesGetStringForIntegerCodePoint (int colorPrimariesCodePoint);

    // extern CFStringRef _Nullable CVTransferFunctionGetStringForIntegerCodePoint (int transferFunctionCodePoint) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(macos, introduced=10.13)));
    [Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CVTransferFunctionGetStringForIntegerCodePoint (int transferFunctionCodePoint);

    // extern CGSize CVImageBufferGetEncodedSize (CVImageBufferRef _Nonnull imageBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGSize CVImageBufferGetEncodedSize (CVImageBufferRef* imageBuffer);

    // extern CGSize CVImageBufferGetDisplaySize (CVImageBufferRef _Nonnull imageBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGSize CVImageBufferGetDisplaySize (CVImageBufferRef* imageBuffer);

    // extern CGRect CVImageBufferGetCleanRect (CVImageBufferRef _Nonnull imageBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGRect CVImageBufferGetCleanRect (CVImageBufferRef* imageBuffer);

    // extern Boolean CVImageBufferIsFlipped (CVImageBufferRef _Nonnull imageBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CVImageBufferIsFlipped (CVImageBufferRef* imageBuffer);

    // extern CGColorSpaceRef _Nullable CVImageBufferCreateColorSpaceFromAttachments (CFDictionaryRef _Nonnull attachments) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=10.0)));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGColorSpaceRef* CVImageBufferCreateColorSpaceFromAttachments (CFDictionaryRef* attachments);

    // extern CFTypeID CVPixelBufferGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CVPixelBufferGetTypeID ();

    // extern CVPixelBufferRef _Nullable CVPixelBufferRetain (CVPixelBufferRef _Nullable texture) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CVPixelBufferRef* CVPixelBufferRetain ([NullAllowed] CVPixelBufferRef* texture);

    // extern void CVPixelBufferRelease (CVPixelBufferRef _Nullable texture) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVPixelBufferRelease ([NullAllowed] CVPixelBufferRef* texture);

    // extern CVReturn CVPixelBufferCreateResolvedAttributesDictionary (CFAllocatorRef _Nullable allocator, CFArrayRef _Nullable attributes, CFDictionaryRef  _Nullable * _Nonnull resolvedDictionaryOut) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferCreateResolvedAttributesDictionary ([NullAllowed] CFAllocatorRef* allocator, [NullAllowed] CFArrayRef* attributes, [NullAllowed] CFDictionaryRef** resolvedDictionaryOut);

    // extern CVReturn CVPixelBufferCreate (CFAllocatorRef _Nullable allocator, size_t width, size_t height, OSType pixelFormatType, CFDictionaryRef _Nullable pixelBufferAttributes, CVPixelBufferRef  _Nullable * _Nonnull pixelBufferOut) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferCreate ([NullAllowed] CFAllocatorRef* allocator, nuint width, nuint height, uint pixelFormatType, [NullAllowed] CFDictionaryRef* pixelBufferAttributes, [NullAllowed] CVPixelBufferRef** pixelBufferOut);

    // extern CVReturn CVPixelBufferCreateWithBytes (CFAllocatorRef _Nullable allocator, size_t width, size_t height, OSType pixelFormatType, void * _Nonnull baseAddress, size_t bytesPerRow, CVPixelBufferReleaseBytesCallback _Nullable releaseCallback, void * _Nullable releaseRefCon, CFDictionaryRef _Nullable pixelBufferAttributes, CVPixelBufferRef  _Nullable * _Nonnull pixelBufferOut) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferCreateWithBytes ([NullAllowed] CFAllocatorRef* allocator, nuint width, nuint height, uint pixelFormatType, void* baseAddress, nuint bytesPerRow, [NullAllowed] CVPixelBufferReleaseBytesCallback* releaseCallback, [NullAllowed] void* releaseRefCon, [NullAllowed] CFDictionaryRef* pixelBufferAttributes, [NullAllowed] CVPixelBufferRef** pixelBufferOut);

    // extern CVReturn CVPixelBufferCreateWithPlanarBytes (CFAllocatorRef _Nullable allocator, size_t width, size_t height, OSType pixelFormatType, void * _Nullable dataPtr, size_t dataSize, size_t numberOfPlanes, void * _Nullable *planeBaseAddress, size_t *planeWidth, size_t *planeHeight, size_t *planeBytesPerRow, CVPixelBufferReleasePlanarBytesCallback _Nullable releaseCallback, void * _Nullable releaseRefCon, CFDictionaryRef _Nullable pixelBufferAttributes, CVPixelBufferRef  _Nullable * _Nonnull pixelBufferOut) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferCreateWithPlanarBytes ([NullAllowed] CFAllocatorRef* allocator, nuint width, nuint height, uint pixelFormatType, [NullAllowed] void* dataPtr, nuint dataSize, nuint numberOfPlanes, [NullAllowed] void*[] planeBaseAddress, nuint[] planeWidth, nuint[] planeHeight, nuint[] planeBytesPerRow, [NullAllowed] CVPixelBufferReleasePlanarBytesCallback* releaseCallback, [NullAllowed] void* releaseRefCon, [NullAllowed] CFDictionaryRef* pixelBufferAttributes, [NullAllowed] CVPixelBufferRef** pixelBufferOut);

    // extern CVReturn CVPixelBufferLockBaseAddress (CVPixelBufferRef _Nonnull pixelBuffer, CVPixelBufferLockFlags lockFlags) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferLockBaseAddress (CVPixelBufferRef* pixelBuffer, CVPixelBufferLockFlags lockFlags);

    // extern CVReturn CVPixelBufferUnlockBaseAddress (CVPixelBufferRef _Nonnull pixelBuffer, CVPixelBufferLockFlags unlockFlags) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferUnlockBaseAddress (CVPixelBufferRef* pixelBuffer, CVPixelBufferLockFlags unlockFlags);

    // extern size_t CVPixelBufferGetWidth (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CVPixelBufferGetWidth (CVPixelBufferRef* pixelBuffer);

    // extern size_t CVPixelBufferGetHeight (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CVPixelBufferGetHeight (CVPixelBufferRef* pixelBuffer);

    // extern OSType CVPixelBufferGetPixelFormatType (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe uint CVPixelBufferGetPixelFormatType (CVPixelBufferRef* pixelBuffer);

    // extern void * _Nullable CVPixelBufferGetBaseAddress (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CVPixelBufferGetBaseAddress (CVPixelBufferRef* pixelBuffer);

    // extern size_t CVPixelBufferGetBytesPerRow (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CVPixelBufferGetBytesPerRow (CVPixelBufferRef* pixelBuffer);

    // extern size_t CVPixelBufferGetDataSize (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CVPixelBufferGetDataSize (CVPixelBufferRef* pixelBuffer);

    // extern Boolean CVPixelBufferIsPlanar (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CVPixelBufferIsPlanar (CVPixelBufferRef* pixelBuffer);

    // extern size_t CVPixelBufferGetPlaneCount (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CVPixelBufferGetPlaneCount (CVPixelBufferRef* pixelBuffer);

    // extern size_t CVPixelBufferGetWidthOfPlane (CVPixelBufferRef _Nonnull pixelBuffer, size_t planeIndex) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CVPixelBufferGetWidthOfPlane (CVPixelBufferRef* pixelBuffer, nuint planeIndex);

    // extern size_t CVPixelBufferGetHeightOfPlane (CVPixelBufferRef _Nonnull pixelBuffer, size_t planeIndex) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CVPixelBufferGetHeightOfPlane (CVPixelBufferRef* pixelBuffer, nuint planeIndex);

    // extern void * _Nullable CVPixelBufferGetBaseAddressOfPlane (CVPixelBufferRef _Nonnull pixelBuffer, size_t planeIndex) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CVPixelBufferGetBaseAddressOfPlane (CVPixelBufferRef* pixelBuffer, nuint planeIndex);

    // extern size_t CVPixelBufferGetBytesPerRowOfPlane (CVPixelBufferRef _Nonnull pixelBuffer, size_t planeIndex) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CVPixelBufferGetBytesPerRowOfPlane (CVPixelBufferRef* pixelBuffer, nuint planeIndex);

    // extern void CVPixelBufferGetExtendedPixels (CVPixelBufferRef _Nonnull pixelBuffer, size_t * _Nullable extraColumnsOnLeft, size_t * _Nullable extraColumnsOnRight, size_t * _Nullable extraRowsOnTop, size_t * _Nullable extraRowsOnBottom) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVPixelBufferGetExtendedPixels (CVPixelBufferRef* pixelBuffer, [NullAllowed] nuint* extraColumnsOnLeft, [NullAllowed] nuint* extraColumnsOnRight, [NullAllowed] nuint* extraRowsOnTop, [NullAllowed] nuint* extraRowsOnBottom);

    // extern CVReturn CVPixelBufferFillExtendedPixels (CVPixelBufferRef _Nonnull pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferFillExtendedPixels (CVPixelBufferRef* pixelBuffer);

    // extern CFTypeID IOSurfaceGetTypeID () __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern nuint IOSurfaceGetTypeID ();

    // extern IOSurfaceRef _Nullable IOSurfaceCreate (CFDictionaryRef _Nonnull properties) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe IOSurfaceRef* IOSurfaceCreate (CFDictionaryRef* properties);

    // extern IOSurfaceRef _Nullable IOSurfaceLookup (IOSurfaceID csid) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_returns_retained)) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe IOSurfaceRef* IOSurfaceLookup (uint csid);

    // extern IOSurfaceID IOSurfaceGetID (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe uint IOSurfaceGetID (IOSurfaceRef* buffer);

    // extern kern_return_t IOSurfaceLock (IOSurfaceRef _Nonnull buffer, IOSurfaceLockOptions options, uint32_t * _Nullable seed) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int IOSurfaceLock (IOSurfaceRef* buffer, IOSurfaceLockOptions options, [NullAllowed] uint* seed);

    // extern kern_return_t IOSurfaceUnlock (IOSurfaceRef _Nonnull buffer, IOSurfaceLockOptions options, uint32_t * _Nullable seed) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int IOSurfaceUnlock (IOSurfaceRef* buffer, IOSurfaceLockOptions options, [NullAllowed] uint* seed);

    // extern size_t IOSurfaceGetAllocSize (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetAllocSize (IOSurfaceRef* buffer);

    // extern size_t IOSurfaceGetWidth (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetWidth (IOSurfaceRef* buffer);

    // extern size_t IOSurfaceGetHeight (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetHeight (IOSurfaceRef* buffer);

    // extern size_t IOSurfaceGetBytesPerElement (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetBytesPerElement (IOSurfaceRef* buffer);

    // extern size_t IOSurfaceGetBytesPerRow (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetBytesPerRow (IOSurfaceRef* buffer);

    // extern void * _Nonnull IOSurfaceGetBaseAddress (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void* IOSurfaceGetBaseAddress (IOSurfaceRef* buffer);

    // extern size_t IOSurfaceGetElementWidth (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetElementWidth (IOSurfaceRef* buffer);

    // extern size_t IOSurfaceGetElementHeight (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetElementHeight (IOSurfaceRef* buffer);

    // extern OSType IOSurfaceGetPixelFormat (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe uint IOSurfaceGetPixelFormat (IOSurfaceRef* buffer);

    // extern uint32_t IOSurfaceGetSeed (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe uint IOSurfaceGetSeed (IOSurfaceRef* buffer);

    // extern size_t IOSurfaceGetPlaneCount (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetPlaneCount (IOSurfaceRef* buffer);

    // extern size_t IOSurfaceGetWidthOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetWidthOfPlane (IOSurfaceRef* buffer, nuint planeIndex);

    // extern size_t IOSurfaceGetHeightOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetHeightOfPlane (IOSurfaceRef* buffer, nuint planeIndex);

    // extern size_t IOSurfaceGetBytesPerElementOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetBytesPerElementOfPlane (IOSurfaceRef* buffer, nuint planeIndex);

    // extern size_t IOSurfaceGetBytesPerRowOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetBytesPerRowOfPlane (IOSurfaceRef* buffer, nuint planeIndex);

    // extern void * _Nonnull IOSurfaceGetBaseAddressOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void* IOSurfaceGetBaseAddressOfPlane (IOSurfaceRef* buffer, nuint planeIndex);

    // extern size_t IOSurfaceGetElementWidthOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetElementWidthOfPlane (IOSurfaceRef* buffer, nuint planeIndex);

    // extern size_t IOSurfaceGetElementHeightOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetElementHeightOfPlane (IOSurfaceRef* buffer, nuint planeIndex);

    // extern size_t IOSurfaceGetNumberOfComponentsOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetNumberOfComponentsOfPlane (IOSurfaceRef* buffer, nuint planeIndex);

    // extern IOSurfaceComponentName IOSurfaceGetNameOfComponentOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex, size_t componentIndex) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe IOSurfaceComponentName IOSurfaceGetNameOfComponentOfPlane (IOSurfaceRef* buffer, nuint planeIndex, nuint componentIndex);

    // extern IOSurfaceComponentType IOSurfaceGetTypeOfComponentOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex, size_t componentIndex) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe IOSurfaceComponentType IOSurfaceGetTypeOfComponentOfPlane (IOSurfaceRef* buffer, nuint planeIndex, nuint componentIndex);

    // extern IOSurfaceComponentRange IOSurfaceGetRangeOfComponentOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex, size_t componentIndex) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe IOSurfaceComponentRange IOSurfaceGetRangeOfComponentOfPlane (IOSurfaceRef* buffer, nuint planeIndex, nuint componentIndex);

    // extern size_t IOSurfaceGetBitDepthOfComponentOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex, size_t componentIndex) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetBitDepthOfComponentOfPlane (IOSurfaceRef* buffer, nuint planeIndex, nuint componentIndex);

    // extern size_t IOSurfaceGetBitOffsetOfComponentOfPlane (IOSurfaceRef _Nonnull buffer, size_t planeIndex, size_t componentIndex) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetBitOffsetOfComponentOfPlane (IOSurfaceRef* buffer, nuint planeIndex, nuint componentIndex);

    // extern IOSurfaceSubsampling IOSurfaceGetSubsampling (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe IOSurfaceSubsampling IOSurfaceGetSubsampling (IOSurfaceRef* buffer);

    // extern void IOSurfaceSetValue (IOSurfaceRef _Nonnull buffer, CFStringRef _Nonnull key, CFTypeRef _Nonnull value) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void IOSurfaceSetValue (IOSurfaceRef* buffer, CFStringRef* key, void* value);

    // extern CFTypeRef _Nullable IOSurfaceCopyValue (IOSurfaceRef _Nonnull buffer, CFStringRef _Nonnull key) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* IOSurfaceCopyValue (IOSurfaceRef* buffer, CFStringRef* key);

    // extern void IOSurfaceRemoveValue (IOSurfaceRef _Nonnull buffer, CFStringRef _Nonnull key) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void IOSurfaceRemoveValue (IOSurfaceRef* buffer, CFStringRef* key);

    // extern void IOSurfaceSetValues (IOSurfaceRef _Nonnull buffer, CFDictionaryRef _Nonnull keysAndValues) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void IOSurfaceSetValues (IOSurfaceRef* buffer, CFDictionaryRef* keysAndValues);

    // extern CFDictionaryRef _Nullable IOSurfaceCopyAllValues (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* IOSurfaceCopyAllValues (IOSurfaceRef* buffer);

    // extern void IOSurfaceRemoveAllValues (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void IOSurfaceRemoveAllValues (IOSurfaceRef* buffer);

    // extern mach_port_t IOSurfaceCreateMachPort (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe uint IOSurfaceCreateMachPort (IOSurfaceRef* buffer);

    // extern IOSurfaceRef _Nullable IOSurfaceLookupFromMachPort (mach_port_t port) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_returns_retained)) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe IOSurfaceRef* IOSurfaceLookupFromMachPort (uint port);

    // extern size_t IOSurfaceGetPropertyMaximum (CFStringRef _Nonnull property) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetPropertyMaximum (CFStringRef* property);

    // extern size_t IOSurfaceGetPropertyAlignment (CFStringRef _Nonnull property) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceGetPropertyAlignment (CFStringRef* property);

    // extern size_t IOSurfaceAlignProperty (CFStringRef _Nonnull property, size_t value) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint IOSurfaceAlignProperty (CFStringRef* property, nuint value);

    // extern void IOSurfaceIncrementUseCount (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void IOSurfaceIncrementUseCount (IOSurfaceRef* buffer);

    // extern void IOSurfaceDecrementUseCount (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void IOSurfaceDecrementUseCount (IOSurfaceRef* buffer);

    // extern int32_t IOSurfaceGetUseCount (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int IOSurfaceGetUseCount (IOSurfaceRef* buffer);

    // extern Boolean IOSurfaceIsInUse (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=3.0))) __attribute__((cf_audited_transfer));
    [iOS (3,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte IOSurfaceIsInUse (IOSurfaceRef* buffer);

    // extern Boolean IOSurfaceAllowsPixelSizeCasting (IOSurfaceRef _Nonnull buffer) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte IOSurfaceAllowsPixelSizeCasting (IOSurfaceRef* buffer);

    // extern kern_return_t IOSurfaceSetPurgeable (IOSurfaceRef _Nonnull buffer, uint32_t newState, uint32_t * _Nullable oldState) __attribute__((availability(ios, introduced=10.0))) __attribute__((cf_audited_transfer));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int IOSurfaceSetPurgeable (IOSurfaceRef* buffer, uint newState, [NullAllowed] uint* oldState);

    // extern IOSurfaceRef _Nullable CVPixelBufferGetIOSurface (CVPixelBufferRef _Nullable pixelBuffer) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(macos, introduced=10.6)));
    [Watch (4,0), TV (9,0), Mac (10,6), iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe IOSurfaceRef* CVPixelBufferGetIOSurface ([NullAllowed] CVPixelBufferRef* pixelBuffer);

    // extern CVReturn CVPixelBufferCreateWithIOSurface (CFAllocatorRef _Nullable allocator, IOSurfaceRef _Nonnull surface, CFDictionaryRef _Nullable pixelBufferAttributes, CVPixelBufferRef  _Nullable * _Nonnull pixelBufferOut) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferCreateWithIOSurface ([NullAllowed] CFAllocatorRef* allocator, IOSurfaceRef* surface, [NullAllowed] CFDictionaryRef* pixelBufferAttributes, [NullAllowed] CVPixelBufferRef** pixelBufferOut);

    // extern CFTypeID CVPixelBufferPoolGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CVPixelBufferPoolGetTypeID ();

    // extern CVPixelBufferPoolRef _Nullable CVPixelBufferPoolRetain (CVPixelBufferPoolRef _Nullable pixelBufferPool) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CVPixelBufferPoolRef* CVPixelBufferPoolRetain ([NullAllowed] CVPixelBufferPoolRef* pixelBufferPool);

    // extern void CVPixelBufferPoolRelease (CVPixelBufferPoolRef _Nullable pixelBufferPool) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVPixelBufferPoolRelease ([NullAllowed] CVPixelBufferPoolRef* pixelBufferPool);

    // extern CVReturn CVPixelBufferPoolCreate (CFAllocatorRef _Nullable allocator, CFDictionaryRef _Nullable poolAttributes, CFDictionaryRef _Nullable pixelBufferAttributes, CVPixelBufferPoolRef  _Nullable * _Nonnull poolOut) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferPoolCreate ([NullAllowed] CFAllocatorRef* allocator, [NullAllowed] CFDictionaryRef* poolAttributes, [NullAllowed] CFDictionaryRef* pixelBufferAttributes, [NullAllowed] CVPixelBufferPoolRef** poolOut);

    // extern CFDictionaryRef _Nullable CVPixelBufferPoolGetAttributes (CVPixelBufferPoolRef _Nonnull pool) __attribute__((cf_returns_not_retained)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CVPixelBufferPoolGetAttributes (CVPixelBufferPoolRef* pool);

    // extern CFDictionaryRef _Nullable CVPixelBufferPoolGetPixelBufferAttributes (CVPixelBufferPoolRef _Nonnull pool) __attribute__((cf_returns_not_retained)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CVPixelBufferPoolGetPixelBufferAttributes (CVPixelBufferPoolRef* pool);

    // extern CVReturn CVPixelBufferPoolCreatePixelBuffer (CFAllocatorRef _Nullable allocator, CVPixelBufferPoolRef _Nonnull pixelBufferPool, CVPixelBufferRef  _Nullable * _Nonnull pixelBufferOut) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferPoolCreatePixelBuffer ([NullAllowed] CFAllocatorRef* allocator, CVPixelBufferPoolRef* pixelBufferPool, [NullAllowed] CVPixelBufferRef** pixelBufferOut);

    // extern CVReturn CVPixelBufferPoolCreatePixelBufferWithAuxAttributes (CFAllocatorRef _Nullable allocator, CVPixelBufferPoolRef _Nonnull pixelBufferPool, CFDictionaryRef _Nullable auxAttributes, CVPixelBufferRef  _Nullable * _Nonnull pixelBufferOut) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVPixelBufferPoolCreatePixelBufferWithAuxAttributes ([NullAllowed] CFAllocatorRef* allocator, CVPixelBufferPoolRef* pixelBufferPool, [NullAllowed] CFDictionaryRef* auxAttributes, [NullAllowed] CVPixelBufferRef** pixelBufferOut);

    // extern void CVPixelBufferPoolFlush (CVPixelBufferPoolRef _Nonnull pool, CVPixelBufferPoolFlushFlags options) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern unsafe void CVPixelBufferPoolFlush (CVPixelBufferPoolRef* pool, CVPixelBufferPoolFlushFlags options);

    // extern CFTypeID CVOpenGLESTextureGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CVOpenGLESTextureGetTypeID ();

    // extern GLenum CVOpenGLESTextureGetTarget (CVOpenGLESTextureRef _Nonnull image) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe uint CVOpenGLESTextureGetTarget (CVOpenGLESTextureRef* image);

    // extern GLuint CVOpenGLESTextureGetName (CVOpenGLESTextureRef _Nonnull image) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe uint CVOpenGLESTextureGetName (CVOpenGLESTextureRef* image);

    // extern Boolean CVOpenGLESTextureIsFlipped (CVOpenGLESTextureRef _Nonnull image) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CVOpenGLESTextureIsFlipped (CVOpenGLESTextureRef* image);

    // extern void CVOpenGLESTextureGetCleanTexCoords (CVOpenGLESTextureRef _Nonnull image, GLfloat * _Nonnull lowerLeft, GLfloat * _Nonnull lowerRight, GLfloat * _Nonnull upperRight, GLfloat * _Nonnull upperLeft) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVOpenGLESTextureGetCleanTexCoords (CVOpenGLESTextureRef* image, float[] lowerLeft, float[] lowerRight, float[] upperRight, float[] upperLeft);

    // extern CFTypeID CVOpenGLESTextureCacheGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CVOpenGLESTextureCacheGetTypeID ();

    // extern CVReturn CVOpenGLESTextureCacheCreate (CFAllocatorRef _Nullable allocator, CFDictionaryRef _Nullable cacheAttributes, CVEAGLContext _Nonnull eaglContext, CFDictionaryRef _Nullable textureAttributes, CVOpenGLESTextureCacheRef  _Nullable * _Nonnull cacheOut) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVOpenGLESTextureCacheCreate ([NullAllowed] CFAllocatorRef* allocator, [NullAllowed] CFDictionaryRef* cacheAttributes, EAGLContext eaglContext, [NullAllowed] CFDictionaryRef* textureAttributes, [NullAllowed] CVOpenGLESTextureCacheRef** cacheOut);

    // extern CVReturn CVOpenGLESTextureCacheCreateTextureFromImage (CFAllocatorRef _Nullable allocator, CVOpenGLESTextureCacheRef _Nonnull textureCache, CVImageBufferRef _Nonnull sourceImage, CFDictionaryRef _Nullable textureAttributes, GLenum target, GLint internalFormat, GLsizei width, GLsizei height, GLenum format, GLenum type, size_t planeIndex, CVOpenGLESTextureRef  _Nullable * _Nonnull textureOut) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVOpenGLESTextureCacheCreateTextureFromImage ([NullAllowed] CFAllocatorRef* allocator, CVOpenGLESTextureCacheRef* textureCache, CVImageBufferRef* sourceImage, [NullAllowed] CFDictionaryRef* textureAttributes, uint target, int internalFormat, int width, int height, uint format, uint type, nuint planeIndex, [NullAllowed] CVOpenGLESTextureRef** textureOut);

    // extern void CVOpenGLESTextureCacheFlush (CVOpenGLESTextureCacheRef _Nonnull textureCache, CVOptionFlags options) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=5.0)));
    [TV (9,0), NoWatch, NoMac, iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVOpenGLESTextureCacheFlush (CVOpenGLESTextureCacheRef* textureCache, ulong options);

    // extern CFDictionaryRef _Nullable CVPixelFormatDescriptionCreateWithPixelFormatType (CFAllocatorRef _Nullable allocator, OSType pixelFormat) __attribute__((cf_returns_retained)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CVPixelFormatDescriptionCreateWithPixelFormatType ([NullAllowed] CFAllocatorRef* allocator, uint pixelFormat);

    // extern CFArrayRef _Nullable CVPixelFormatDescriptionArrayCreateWithAllPixelFormatTypes (CFAllocatorRef _Nullable allocator) __attribute__((cf_returns_retained)) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CVPixelFormatDescriptionArrayCreateWithAllPixelFormatTypes ([NullAllowed] CFAllocatorRef* allocator);

    // extern void CVPixelFormatDescriptionRegisterDescriptionWithPixelFormatType (CFDictionaryRef _Nonnull description, OSType pixelFormat) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4.0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVPixelFormatDescriptionRegisterDescriptionWithPixelFormatType (CFDictionaryRef* description, uint pixelFormat);

    // extern CFTypeID CVMetalTextureGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.11)));
    [TV (9,0), NoWatch, Mac (10,11), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CVMetalTextureGetTypeID ();

    // extern id<MTLTexture> _Nullable CVMetalTextureGetTexture (CVMetalTextureRef _Nonnull image) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.11)));
    [TV (9,0), NoWatch, Mac (10,11), iOS (8,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe MTLTexture CVMetalTextureGetTexture (CVMetalTextureRef* image);

    // extern Boolean CVMetalTextureIsFlipped (CVMetalTextureRef _Nonnull image) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.11)));
    [TV (9,0), NoWatch, Mac (10,11), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe byte CVMetalTextureIsFlipped (CVMetalTextureRef* image);

    // extern void CVMetalTextureGetCleanTexCoords (CVMetalTextureRef _Nonnull image, float *lowerLeft, float *lowerRight, float *upperRight, float *upperLeft) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.11)));
    [TV (9,0), NoWatch, Mac (10,11), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVMetalTextureGetCleanTexCoords (CVMetalTextureRef* image, float[] lowerLeft, float[] lowerRight, float[] upperRight, float[] upperLeft);

    // extern CFTypeID CVMetalTextureCacheGetTypeID () __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.11)));
    [TV (9,0), NoWatch, Mac (10,11), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CVMetalTextureCacheGetTypeID ();

    // extern CVReturn CVMetalTextureCacheCreate (CFAllocatorRef _Nullable allocator, CFDictionaryRef _Nullable cacheAttributes, id<MTLDevice> _Nonnull metalDevice, CFDictionaryRef _Nullable textureAttributes, CVMetalTextureCacheRef  _Nullable * _Nonnull cacheOut) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.11)));
    [TV (9,0), NoWatch, Mac (10,11), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVMetalTextureCacheCreate ([NullAllowed] CFAllocatorRef* allocator, [NullAllowed] CFDictionaryRef* cacheAttributes, MTLDevice metalDevice, [NullAllowed] CFDictionaryRef* textureAttributes, [NullAllowed] CVMetalTextureCacheRef** cacheOut);

    // extern CVReturn CVMetalTextureCacheCreateTextureFromImage (CFAllocatorRef _Nullable allocator, CVMetalTextureCacheRef _Nonnull textureCache, CVImageBufferRef _Nonnull sourceImage, CFDictionaryRef _Nullable textureAttributes, MTLPixelFormat pixelFormat, size_t width, size_t height, size_t planeIndex, CVMetalTextureRef  _Nullable * _Nonnull textureOut) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.11)));
    [TV (9,0), NoWatch, Mac (10,11), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe int CVMetalTextureCacheCreateTextureFromImage ([NullAllowed] CFAllocatorRef* allocator, CVMetalTextureCacheRef* textureCache, CVImageBufferRef* sourceImage, [NullAllowed] CFDictionaryRef* textureAttributes, MTLPixelFormat pixelFormat, nuint width, nuint height, nuint planeIndex, [NullAllowed] CVMetalTextureRef** textureOut);

    // extern void CVMetalTextureCacheFlush (CVMetalTextureCacheRef _Nonnull textureCache, CVOptionFlags options) __attribute__((visibility("default"))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, introduced=10.11)));
    [TV (9,0), NoWatch, Mac (10,11), iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CVMetalTextureCacheFlush (CVMetalTextureCacheRef* textureCache, ulong options);

    // extern CFTypeID CGImageMetadataGetTypeID () __attribute__((cf_audited_transfer));
    [DllImport ("__Internal")]
    
    static extern nuint CGImageMetadataGetTypeID ();

    // extern CGMutableImageMetadataRef _Nonnull CGImageMetadataCreateMutable () __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGMutableImageMetadataRef* CGImageMetadataCreateMutable ();

    // extern CGMutableImageMetadataRef _Nullable CGImageMetadataCreateMutableCopy (CGImageMetadataRef _Nonnull metadata) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGMutableImageMetadataRef* CGImageMetadataCreateMutableCopy (CGImageMetadataRef* metadata);

    // extern CFTypeID CGImageMetadataTagGetTypeID () __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGImageMetadataTagGetTypeID ();

    // extern CGImageMetadataTagRef _Nullable CGImageMetadataTagCreate (CFStringRef _Nonnull xmlns, CFStringRef _Nullable prefix, CFStringRef _Nonnull name, CGImageMetadataType type, CFTypeRef _Nonnull value) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageMetadataTagRef* CGImageMetadataTagCreate (CFStringRef* xmlns, [NullAllowed] CFStringRef* prefix, CFStringRef* name, CGImageMetadataType type, void* value);

    // extern CFStringRef _Nullable CGImageMetadataTagCopyNamespace (CGImageMetadataTagRef _Nonnull tag) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGImageMetadataTagCopyNamespace (CGImageMetadataTagRef* tag);

    // extern CFStringRef _Nullable CGImageMetadataTagCopyPrefix (CGImageMetadataTagRef _Nonnull tag) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGImageMetadataTagCopyPrefix (CGImageMetadataTagRef* tag);

    // extern CFStringRef _Nullable CGImageMetadataTagCopyName (CGImageMetadataTagRef _Nonnull tag) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGImageMetadataTagCopyName (CGImageMetadataTagRef* tag);

    // extern CFTypeRef _Nullable CGImageMetadataTagCopyValue (CGImageMetadataTagRef _Nonnull tag) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe void* CGImageMetadataTagCopyValue (CGImageMetadataTagRef* tag);

    // extern CGImageMetadataType CGImageMetadataTagGetType (CGImageMetadataTagRef _Nonnull tag) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGImageMetadataType CGImageMetadataTagGetType (CGImageMetadataTagRef* tag);

    // extern CFArrayRef _Nullable CGImageMetadataTagCopyQualifiers (CGImageMetadataTagRef _Nonnull tag) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CGImageMetadataTagCopyQualifiers (CGImageMetadataTagRef* tag);

    // extern CFArrayRef _Nullable CGImageMetadataCopyTags (CGImageMetadataRef _Nonnull metadata) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFArrayRef* CGImageMetadataCopyTags (CGImageMetadataRef* metadata);

    // extern CGImageMetadataTagRef _Nullable CGImageMetadataCopyTagWithPath (CGImageMetadataRef _Nonnull metadata, CGImageMetadataTagRef _Nullable parent, CFStringRef _Nonnull path) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageMetadataTagRef* CGImageMetadataCopyTagWithPath (CGImageMetadataRef* metadata, [NullAllowed] CGImageMetadataTagRef* parent, CFStringRef* path);

    // extern CFStringRef _Nullable CGImageMetadataCopyStringValueWithPath (CGImageMetadataRef _Nonnull metadata, CGImageMetadataTagRef _Nullable parent, CFStringRef _Nonnull path) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGImageMetadataCopyStringValueWithPath (CGImageMetadataRef* metadata, [NullAllowed] CGImageMetadataTagRef* parent, CFStringRef* path);

    // extern _Bool CGImageMetadataRegisterNamespaceForPrefix (CGMutableImageMetadataRef _Nonnull metadata, CFStringRef _Nonnull xmlns, CFStringRef _Nonnull prefix, CFErrorRef  _Nullable * _Nullable err) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageMetadataRegisterNamespaceForPrefix (CGMutableImageMetadataRef* metadata, CFStringRef* xmlns, CFStringRef* prefix, [NullAllowed] CFErrorRef** err);

    // extern _Bool CGImageMetadataSetTagWithPath (CGMutableImageMetadataRef _Nonnull metadata, CGImageMetadataTagRef _Nullable parent, CFStringRef _Nonnull path, CGImageMetadataTagRef _Nonnull tag) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageMetadataSetTagWithPath (CGMutableImageMetadataRef* metadata, [NullAllowed] CGImageMetadataTagRef* parent, CFStringRef* path, CGImageMetadataTagRef* tag);

    // extern _Bool CGImageMetadataSetValueWithPath (CGMutableImageMetadataRef _Nonnull metadata, CGImageMetadataTagRef _Nullable parent, CFStringRef _Nonnull path, CFTypeRef _Nonnull value) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageMetadataSetValueWithPath (CGMutableImageMetadataRef* metadata, [NullAllowed] CGImageMetadataTagRef* parent, CFStringRef* path, void* value);

    // extern _Bool CGImageMetadataRemoveTagWithPath (CGMutableImageMetadataRef _Nonnull metadata, CGImageMetadataTagRef _Nullable parent, CFStringRef _Nonnull path) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageMetadataRemoveTagWithPath (CGMutableImageMetadataRef* metadata, [NullAllowed] CGImageMetadataTagRef* parent, CFStringRef* path);

    // extern void CGImageMetadataEnumerateTagsUsingBlock (CGImageMetadataRef _Nonnull metadata, CFStringRef _Nullable rootPath, CFDictionaryRef _Nullable options, CGImageMetadataTagBlock _Nonnull block) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageMetadataEnumerateTagsUsingBlock (CGImageMetadataRef* metadata, [NullAllowed] CFStringRef* rootPath, [NullAllowed] CFDictionaryRef* options, CGImageMetadataTagBlock block);

    // extern CGImageMetadataTagRef _Nullable CGImageMetadataCopyTagMatchingImageProperty (CGImageMetadataRef _Nonnull metadata, CFStringRef _Nonnull dictionaryName, CFStringRef _Nonnull propertyName) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageMetadataTagRef* CGImageMetadataCopyTagMatchingImageProperty (CGImageMetadataRef* metadata, CFStringRef* dictionaryName, CFStringRef* propertyName);

    // extern _Bool CGImageMetadataSetValueMatchingImageProperty (CGMutableImageMetadataRef _Nonnull metadata, CFStringRef _Nonnull dictionaryName, CFStringRef _Nonnull propertyName, CFTypeRef _Nonnull value) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageMetadataSetValueMatchingImageProperty (CGMutableImageMetadataRef* metadata, CFStringRef* dictionaryName, CFStringRef* propertyName, void* value);

    // extern CFDataRef _Nullable CGImageMetadataCreateXMPData (CGImageMetadataRef _Nonnull metadata, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDataRef* CGImageMetadataCreateXMPData (CGImageMetadataRef* metadata, [NullAllowed] CFDictionaryRef* options);

    // extern CGImageMetadataRef _Nullable CGImageMetadataCreateFromXMPData (CFDataRef _Nonnull data) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageMetadataRef* CGImageMetadataCreateFromXMPData (CFDataRef* data);

    // extern CFTypeID CGImageSourceGetTypeID () __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGImageSourceGetTypeID ();

    // extern CFArrayRef _Nonnull CGImageSourceCopyTypeIdentifiers () __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CGImageSourceCopyTypeIdentifiers ();

    // extern CGImageSourceRef _Nullable CGImageSourceCreateWithDataProvider (CGDataProviderRef _Nonnull provider, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageSourceRef* CGImageSourceCreateWithDataProvider (CGDataProviderRef* provider, [NullAllowed] CFDictionaryRef* options);

    // extern CGImageSourceRef _Nullable CGImageSourceCreateWithData (CFDataRef _Nonnull data, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageSourceRef* CGImageSourceCreateWithData (CFDataRef* data, [NullAllowed] CFDictionaryRef* options);

    // extern CGImageSourceRef _Nullable CGImageSourceCreateWithURL (CFURLRef _Nonnull url, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageSourceRef* CGImageSourceCreateWithURL (CFURLRef* url, [NullAllowed] CFDictionaryRef* options);

    // extern CFStringRef _Nullable CGImageSourceGetType (CGImageSourceRef _Nonnull isrc) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFStringRef* CGImageSourceGetType (CGImageSourceRef* isrc);

    // extern size_t CGImageSourceGetCount (CGImageSourceRef _Nonnull isrc) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe nuint CGImageSourceGetCount (CGImageSourceRef* isrc);

    // extern CFDictionaryRef _Nullable CGImageSourceCopyProperties (CGImageSourceRef _Nonnull isrc, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CGImageSourceCopyProperties (CGImageSourceRef* isrc, [NullAllowed] CFDictionaryRef* options);

    // extern CFDictionaryRef _Nullable CGImageSourceCopyPropertiesAtIndex (CGImageSourceRef _Nonnull isrc, size_t index, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CGImageSourceCopyPropertiesAtIndex (CGImageSourceRef* isrc, nuint index, [NullAllowed] CFDictionaryRef* options);

    // extern CGImageMetadataRef _Nullable CGImageSourceCopyMetadataAtIndex (CGImageSourceRef _Nonnull isrc, size_t index, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageMetadataRef* CGImageSourceCopyMetadataAtIndex (CGImageSourceRef* isrc, nuint index, [NullAllowed] CFDictionaryRef* options);

    // extern CGImageRef _Nullable CGImageSourceCreateImageAtIndex (CGImageSourceRef _Nonnull isrc, size_t index, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageSourceCreateImageAtIndex (CGImageSourceRef* isrc, nuint index, [NullAllowed] CFDictionaryRef* options);

    // extern void CGImageSourceRemoveCacheAtIndex (CGImageSourceRef _Nonnull isrc, size_t index) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageSourceRemoveCacheAtIndex (CGImageSourceRef* isrc, nuint index);

    // extern CGImageRef _Nullable CGImageSourceCreateThumbnailAtIndex (CGImageSourceRef _Nonnull isrc, size_t index, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageRef* CGImageSourceCreateThumbnailAtIndex (CGImageSourceRef* isrc, nuint index, [NullAllowed] CFDictionaryRef* options);

    // extern CGImageSourceRef _Nonnull CGImageSourceCreateIncremental (CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGImageSourceRef* CGImageSourceCreateIncremental ([NullAllowed] CFDictionaryRef* options);

    // extern void CGImageSourceUpdateData (CGImageSourceRef _Nonnull isrc, CFDataRef _Nonnull data, _Bool final) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageSourceUpdateData (CGImageSourceRef* isrc, CFDataRef* data, bool final);

    // extern void CGImageSourceUpdateDataProvider (CGImageSourceRef _Nonnull isrc, CGDataProviderRef _Nonnull provider, _Bool final) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageSourceUpdateDataProvider (CGImageSourceRef* isrc, CGDataProviderRef* provider, bool final);

    // extern CGImageSourceStatus CGImageSourceGetStatus (CGImageSourceRef _Nonnull isrc) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGImageSourceStatus CGImageSourceGetStatus (CGImageSourceRef* isrc);

    // extern CGImageSourceStatus CGImageSourceGetStatusAtIndex (CGImageSourceRef _Nonnull isrc, size_t index) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CGImageSourceStatus CGImageSourceGetStatusAtIndex (CGImageSourceRef* isrc, nuint index);

    // extern CFDictionaryRef _Nullable CGImageSourceCopyAuxiliaryDataInfoAtIndex (CGImageSourceRef _Nonnull isrc, size_t index, CFStringRef _Nonnull auxiliaryImageDataType) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CFDictionaryRef* CGImageSourceCopyAuxiliaryDataInfoAtIndex (CGImageSourceRef* isrc, nuint index, CFStringRef* auxiliaryImageDataType);

    // extern CFTypeID CGImageDestinationGetTypeID () __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern nuint CGImageDestinationGetTypeID ();

    // extern CFArrayRef _Nonnull CGImageDestinationCopyTypeIdentifiers () __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe CFArrayRef* CGImageDestinationCopyTypeIdentifiers ();

    // extern CGImageDestinationRef _Nullable CGImageDestinationCreateWithDataConsumer (CGDataConsumerRef _Nonnull consumer, CFStringRef _Nonnull type, size_t count, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageDestinationRef* CGImageDestinationCreateWithDataConsumer (CGDataConsumerRef* consumer, CFStringRef* type, nuint count, [NullAllowed] CFDictionaryRef* options);

    // extern CGImageDestinationRef _Nullable CGImageDestinationCreateWithData (CFMutableDataRef _Nonnull data, CFStringRef _Nonnull type, size_t count, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageDestinationRef* CGImageDestinationCreateWithData (CFMutableDataRef* data, CFStringRef* type, nuint count, [NullAllowed] CFDictionaryRef* options);

    // extern CGImageDestinationRef _Nullable CGImageDestinationCreateWithURL (CFURLRef _Nonnull url, CFStringRef _Nonnull type, size_t count, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGImageDestinationRef* CGImageDestinationCreateWithURL (CFURLRef* url, CFStringRef* type, nuint count, [NullAllowed] CFDictionaryRef* options);

    // extern void CGImageDestinationSetProperties (CGImageDestinationRef _Nonnull idst, CFDictionaryRef _Nullable properties) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageDestinationSetProperties (CGImageDestinationRef* idst, [NullAllowed] CFDictionaryRef* properties);

    // extern void CGImageDestinationAddImage (CGImageDestinationRef _Nonnull idst, CGImageRef _Nonnull image, CFDictionaryRef _Nullable properties) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageDestinationAddImage (CGImageDestinationRef* idst, CGImageRef* image, [NullAllowed] CFDictionaryRef* properties);

    // extern void CGImageDestinationAddImageFromSource (CGImageDestinationRef _Nonnull idst, CGImageSourceRef _Nonnull isrc, size_t index, CFDictionaryRef _Nullable properties) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageDestinationAddImageFromSource (CGImageDestinationRef* idst, CGImageSourceRef* isrc, nuint index, [NullAllowed] CFDictionaryRef* properties);

    // extern _Bool CGImageDestinationFinalize (CGImageDestinationRef _Nonnull idst) __attribute__((availability(ios, introduced=4.0))) __attribute__((cf_audited_transfer));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageDestinationFinalize (CGImageDestinationRef* idst);

    // extern void CGImageDestinationAddImageAndMetadata (CGImageDestinationRef _Nonnull idst, CGImageRef _Nonnull image, CGImageMetadataRef _Nullable metadata, CFDictionaryRef _Nullable options) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageDestinationAddImageAndMetadata (CGImageDestinationRef* idst, CGImageRef* image, [NullAllowed] CGImageMetadataRef* metadata, [NullAllowed] CFDictionaryRef* options);

    // extern _Bool CGImageDestinationCopyImageSource (CGImageDestinationRef _Nonnull idst, CGImageSourceRef _Nonnull isrc, CFDictionaryRef _Nullable options, CFErrorRef  _Nullable * _Nullable err) __attribute__((availability(ios, introduced=7.0))) __attribute__((cf_audited_transfer));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CGImageDestinationCopyImageSource (CGImageDestinationRef* idst, CGImageSourceRef* isrc, [NullAllowed] CFDictionaryRef* options, [NullAllowed] CFErrorRef** err);

    // extern void CGImageDestinationAddAuxiliaryDataInfo (CGImageDestinationRef _Nonnull idst, CFStringRef _Nonnull auxiliaryImageDataType, CFDictionaryRef _Nonnull auxiliaryDataInfoDictionary) __attribute__((availability(ios, introduced=11.0))) __attribute__((cf_audited_transfer));
    [iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern unsafe void CGImageDestinationAddAuxiliaryDataInfo (CGImageDestinationRef* idst, CFStringRef* auxiliaryImageDataType, CFDictionaryRef* auxiliaryDataInfoDictionary);

    // UIEdgeInsets UIEdgeInsetsMake (CGFloat top, CGFloat left, CGFloat bottom, CGFloat right);
    [DllImport ("__Internal")]
    
    static extern UIEdgeInsets UIEdgeInsetsMake (nfloat top, nfloat left, nfloat bottom, nfloat right);

    // NSDirectionalEdgeInsets NSDirectionalEdgeInsetsMake (CGFloat top, CGFloat leading, CGFloat bottom, CGFloat trailing) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
    [Watch (4,0), TV (11,0), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern NSDirectionalEdgeInsets NSDirectionalEdgeInsetsMake (nfloat top, nfloat leading, nfloat bottom, nfloat trailing);

    // CGRect UIEdgeInsetsInsetRect (CGRect rect, UIEdgeInsets insets);
    [DllImport ("__Internal")]
    
    static extern CGRect UIEdgeInsetsInsetRect (CGRect rect, UIEdgeInsets insets);

    // UIOffset UIOffsetMake (CGFloat horizontal, CGFloat vertical);
    [DllImport ("__Internal")]
    
    static extern UIOffset UIOffsetMake (nfloat horizontal, nfloat vertical);

    // BOOL UIEdgeInsetsEqualToEdgeInsets (UIEdgeInsets insets1, UIEdgeInsets insets2);
    [DllImport ("__Internal")]
    
    static extern bool UIEdgeInsetsEqualToEdgeInsets (UIEdgeInsets insets1, UIEdgeInsets insets2);

    // BOOL NSDirectionalEdgeInsetsEqualToDirectionalEdgeInsets (NSDirectionalEdgeInsets insets1, NSDirectionalEdgeInsets insets2) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
    [Watch (4,0), TV (11,0), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern bool NSDirectionalEdgeInsetsEqualToDirectionalEdgeInsets (NSDirectionalEdgeInsets insets1, NSDirectionalEdgeInsets insets2);

    // BOOL UIOffsetEqualToOffset (UIOffset offset1, UIOffset offset2);
    [DllImport ("__Internal")]
    
    static extern bool UIOffsetEqualToOffset (UIOffset offset1, UIOffset offset2);

    // extern NSString * _Nonnull NSStringFromCGPoint (CGPoint point) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromCGPoint (CGPoint point);

    // extern NSString * _Nonnull NSStringFromCGVector (CGVector vector) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromCGVector (CGVector vector);

    // extern NSString * _Nonnull NSStringFromCGSize (CGSize size) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromCGSize (CGSize size);

    // extern NSString * _Nonnull NSStringFromCGRect (CGRect rect) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromCGRect (CGRect rect);

    // extern NSString * _Nonnull NSStringFromCGAffineTransform (CGAffineTransform transform) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromCGAffineTransform (CGAffineTransform transform);

    // extern NSString * _Nonnull NSStringFromUIEdgeInsets (UIEdgeInsets insets) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromUIEdgeInsets (UIEdgeInsets insets);

    // extern NSString * _Nonnull NSStringFromDirectionalEdgeInsets (NSDirectionalEdgeInsets insets) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
    [Watch (4,0), TV (11,0), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromDirectionalEdgeInsets (NSDirectionalEdgeInsets insets);

    // extern NSString * _Nonnull NSStringFromUIOffset (UIOffset offset) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern NSString NSStringFromUIOffset (UIOffset offset);

    // extern CGPoint CGPointFromString (NSString * _Nonnull string) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern CGPoint CGPointFromString (NSString @string);

    // extern CGVector CGVectorFromString (NSString * _Nonnull string) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern CGVector CGVectorFromString (NSString @string);

    // extern CGSize CGSizeFromString (NSString * _Nonnull string) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern CGSize CGSizeFromString (NSString @string);

    // extern CGRect CGRectFromString (NSString * _Nonnull string) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern CGRect CGRectFromString (NSString @string);

    // extern CGAffineTransform CGAffineTransformFromString (NSString * _Nonnull string) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern CGAffineTransform CGAffineTransformFromString (NSString @string);

    // extern UIEdgeInsets UIEdgeInsetsFromString (NSString * _Nonnull string) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern UIEdgeInsets UIEdgeInsetsFromString (NSString @string);

    // extern NSDirectionalEdgeInsets NSDirectionalEdgeInsetsFromString (NSString * _Nonnull string) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
    [Watch (4,0), TV (11,0), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern NSDirectionalEdgeInsets NSDirectionalEdgeInsetsFromString (NSString @string);

    // extern UIOffset UIOffsetFromString (NSString * _Nonnull string) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern UIOffset UIOffsetFromString (NSString @string);

    // extern NSDictionary * _Nonnull _NSDictionaryOfVariableBindings (NSString * _Nonnull commaSeparatedKeysString, id _Nullable firstValue, ...) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=6_0)));
    [iOS (6,0)]
    [DllImport ("__Internal")]
    
    static extern NSDictionary _NSDictionaryOfVariableBindings (NSString commaSeparatedKeysString, [NullAllowed] NSObject firstValue, IntPtr varArgs);

    // BOOL UIDeviceOrientationIsPortrait (UIDeviceOrientation orientation) __attribute__((availability(tvos, unavailable)));
    [NoTV]
    [DllImport ("__Internal")]
    
    static extern bool UIDeviceOrientationIsPortrait (UIDeviceOrientation orientation);

    // BOOL UIDeviceOrientationIsLandscape (UIDeviceOrientation orientation) __attribute__((availability(tvos, unavailable)));
    [NoTV]
    [DllImport ("__Internal")]
    
    static extern bool UIDeviceOrientationIsLandscape (UIDeviceOrientation orientation);

    // UIUserInterfaceIdiom UI_USER_INTERFACE_IDIOM ();
    [DllImport ("__Internal")]
    
    static extern UIUserInterfaceIdiom UI_USER_INTERFACE_IDIOM ();

    // extern BOOL UIContentSizeCategoryIsAccessibilityCategory (UIContentSizeCategory _Nonnull category) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
    [Watch (4,0), TV (11,0), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIContentSizeCategoryIsAccessibilityCategory (NSString category);

    // extern NSComparisonResult UIContentSizeCategoryCompareToCategory (UIContentSizeCategory _Nonnull lhs, UIContentSizeCategory _Nonnull rhs) __attribute__((visibility("default"))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
    [Watch (4,0), TV (11,0), iOS (11,0)]
    [DllImport ("__Internal")]
    
    static extern NSComparisonResult UIContentSizeCategoryCompareToCategory (NSString lhs, NSString rhs);

    // extern NSData * _Nullable UIImagePNGRepresentation (UIImage * _Nonnull image) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern NSData UIImagePNGRepresentation (UIImage image);

    // extern NSData * _Nullable UIImageJPEGRepresentation (UIImage * _Nonnull image, CGFloat compressionQuality) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern NSData UIImageJPEGRepresentation (UIImage image, nfloat compressionQuality);

    // extern void UIAccessibilityZoomFocusChanged (UIAccessibilityZoomType type, CGRect frame, UIView * _Nonnull view) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5_0)));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void UIAccessibilityZoomFocusChanged (UIAccessibilityZoomType type, CGRect frame, UIView view);

    // extern void UIAccessibilityRegisterGestureConflictWithZoom () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5_0)));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern void UIAccessibilityRegisterGestureConflictWithZoom ();

    // extern UIGuidedAccessRestrictionState UIGuidedAccessRestrictionStateForIdentifier (NSString * _Nonnull restrictionIdentifier) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=7_0)));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern UIGuidedAccessRestrictionState UIGuidedAccessRestrictionStateForIdentifier (NSString restrictionIdentifier);

    // extern CGRect UIAccessibilityConvertFrameToScreenCoordinates (CGRect rect, UIView * _Nonnull view) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=7_0)));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern CGRect UIAccessibilityConvertFrameToScreenCoordinates (CGRect rect, UIView view);

    // extern UIBezierPath * _Nonnull UIAccessibilityConvertPathToScreenCoordinates (UIBezierPath * _Nonnull path, UIView * _Nonnull view) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=7_0)));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern UIBezierPath UIAccessibilityConvertPathToScreenCoordinates (UIBezierPath path, UIView view);

    // extern id _Nullable UIAccessibilityFocusedElement (NSString * _Nullable assistiveTechnologyIdentifier) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=9_0)));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern NSObject UIAccessibilityFocusedElement ([NullAllowed] NSString assistiveTechnologyIdentifier);

    // extern void UIAccessibilityPostNotification (UIAccessibilityNotifications notification, id _Nullable argument) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIAccessibilityPostNotification (uint notification, [NullAllowed] NSObject argument);

    // extern BOOL UIAccessibilityIsVoiceOverRunning () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4_0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsVoiceOverRunning ();

    // extern BOOL UIAccessibilityIsMonoAudioEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5_0)));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsMonoAudioEnabled ();

    // extern BOOL UIAccessibilityIsClosedCaptioningEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=5_0)));
    [iOS (5,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsClosedCaptioningEnabled ();

    // extern BOOL UIAccessibilityIsInvertColorsEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=6_0)));
    [iOS (6,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsInvertColorsEnabled ();

    // extern BOOL UIAccessibilityIsGuidedAccessEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=6_0)));
    [iOS (6,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsGuidedAccessEnabled ();

    // extern BOOL UIAccessibilityIsBoldTextEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8_0)));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsBoldTextEnabled ();

    // extern BOOL UIAccessibilityIsGrayscaleEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8_0)));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsGrayscaleEnabled ();

    // extern BOOL UIAccessibilityIsReduceTransparencyEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8_0)));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsReduceTransparencyEnabled ();

    // extern BOOL UIAccessibilityIsReduceMotionEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8_0)));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsReduceMotionEnabled ();

    // extern BOOL UIAccessibilityDarkerSystemColorsEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8_0)));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityDarkerSystemColorsEnabled ();

    // extern BOOL UIAccessibilityIsSwitchControlRunning () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8_0)));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsSwitchControlRunning ();

    // extern BOOL UIAccessibilityIsSpeakSelectionEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8_0)));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsSpeakSelectionEnabled ();

    // extern BOOL UIAccessibilityIsSpeakScreenEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=8_0)));
    [iOS (8,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsSpeakScreenEnabled ();

    // extern BOOL UIAccessibilityIsShakeToUndoEnabled () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=9_0)));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsShakeToUndoEnabled ();

    // extern BOOL UIAccessibilityIsAssistiveTouchRunning () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=10_0)));
    [iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIAccessibilityIsAssistiveTouchRunning ();

    // extern void UIAccessibilityRequestGuidedAccessSession (BOOL enable, void (^ _Nonnull)(BOOL) completionHandler) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=7_0)));
    [iOS (7,0)]
    [DllImport ("__Internal")]
    
    static extern void UIAccessibilityRequestGuidedAccessSession (bool enable, Action<bool> completionHandler);

    // extern UIAccessibilityHearingDeviceEar UIAccessibilityHearingDevicePairedEar () __attribute__((visibility("default"))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, introduced=10_0)));
    [NoTV, iOS (10,0)]
    [DllImport ("__Internal")]
    
    static extern UIAccessibilityHearingDeviceEar UIAccessibilityHearingDevicePairedEar ();

    // extern CFTypeID CTParagraphStyleGetTypeID () __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.2))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern nuint CTParagraphStyleGetTypeID ();

    // extern CTParagraphStyleRef _Nonnull CTParagraphStyleCreate (const CTParagraphStyleSetting * _Nullable settings, size_t settingCount) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.2))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern unsafe CTParagraphStyleRef* CTParagraphStyleCreate ([NullAllowed] CTParagraphStyleSetting* settings, nuint settingCount);

    // extern CTParagraphStyleRef _Nonnull CTParagraphStyleCreateCopy (CTParagraphStyleRef _Nonnull paragraphStyle) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.2))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern unsafe CTParagraphStyleRef* CTParagraphStyleCreateCopy (CTParagraphStyleRef* paragraphStyle);

    // extern _Bool CTParagraphStyleGetValueForSpecifier (CTParagraphStyleRef _Nonnull paragraphStyle, CTParagraphStyleSpecifier spec, size_t valueBufferSize, void * _Nonnull valueBuffer) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(ios, introduced=3.2))) __attribute__((availability(macos, introduced=10.5))) __attribute__((cf_audited_transfer));
    [Watch (2,0), TV (9,0), Mac (10,5), iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern unsafe bool CTParagraphStyleGetValueForSpecifier (CTParagraphStyleRef* paragraphStyle, CTParagraphStyleSpecifier spec, nuint valueBufferSize, void* valueBuffer);

    // extern CTTextAlignment NSTextAlignmentToCTTextAlignment (NSTextAlignment nsTextAlignment) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=6_0)));
    [iOS (6,0)]
    [DllImport ("__Internal")]
    
    static extern CTTextAlignment NSTextAlignmentToCTTextAlignment (NSTextAlignment nsTextAlignment);

    // extern NSTextAlignment NSTextAlignmentFromCTTextAlignment (CTTextAlignment ctTextAlignment) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=6_0)));
    [iOS (6,0)]
    [DllImport ("__Internal")]
    
    static extern NSTextAlignment NSTextAlignmentFromCTTextAlignment (CTTextAlignment ctTextAlignment);

    // BOOL UIInterfaceOrientationIsPortrait (UIInterfaceOrientation orientation) __attribute__((availability(tvos, unavailable)));
    [NoTV]
    [DllImport ("__Internal")]
    
    static extern bool UIInterfaceOrientationIsPortrait (UIInterfaceOrientation orientation);

    // BOOL UIInterfaceOrientationIsLandscape (UIInterfaceOrientation orientation) __attribute__((availability(tvos, unavailable)));
    [NoTV]
    [DllImport ("__Internal")]
    
    static extern bool UIInterfaceOrientationIsLandscape (UIInterfaceOrientation orientation);

    // extern int UIApplicationMain (int argc, char * _Nonnull * _Null_unspecified argv, NSString * _Nullable principalClassName, NSString * _Nullable delegateClassName) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern unsafe int UIApplicationMain (int argc, sbyte** argv, [NullAllowed] NSString principalClassName, [NullAllowed] NSString delegateClassName);

    // extern CGContextRef _Nullable UIGraphicsGetCurrentContext () __attribute__((visibility("default"))) __attribute__((cf_returns_not_retained));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern unsafe CGContextRef* UIGraphicsGetCurrentContext ();

    // extern void UIGraphicsPushContext (CGContextRef _Nonnull context) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern unsafe void UIGraphicsPushContext (CGContextRef* context);

    // extern void UIGraphicsPopContext () __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsPopContext ();

    // extern void UIRectFillUsingBlendMode (CGRect rect, CGBlendMode blendMode) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIRectFillUsingBlendMode (CGRect rect, CGBlendMode blendMode);

    // extern void UIRectFill (CGRect rect) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIRectFill (CGRect rect);

    // extern void UIRectFrameUsingBlendMode (CGRect rect, CGBlendMode blendMode) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIRectFrameUsingBlendMode (CGRect rect, CGBlendMode blendMode);

    // extern void UIRectFrame (CGRect rect) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIRectFrame (CGRect rect);

    // extern void UIRectClip (CGRect rect) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIRectClip (CGRect rect);

    // extern void UIGraphicsBeginImageContext (CGSize size) __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsBeginImageContext (CGSize size);

    // extern void UIGraphicsBeginImageContextWithOptions (CGSize size, BOOL opaque, CGFloat scale) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=4_0)));
    [iOS (4,0)]
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsBeginImageContextWithOptions (CGSize size, bool opaque, nfloat scale);

    // extern UIImage * _Nullable UIGraphicsGetImageFromCurrentImageContext () __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    [return: NullAllowed]
    static extern UIImage UIGraphicsGetImageFromCurrentImageContext ();

    // extern void UIGraphicsEndImageContext () __attribute__((visibility("default")));
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsEndImageContext ();

    // extern BOOL UIGraphicsBeginPDFContextToFile (NSString * _Nonnull path, CGRect bounds, NSDictionary * _Nullable documentInfo) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern bool UIGraphicsBeginPDFContextToFile (NSString path, CGRect bounds, [NullAllowed] NSDictionary documentInfo);

    // extern void UIGraphicsBeginPDFContextToData (NSMutableData * _Nonnull data, CGRect bounds, NSDictionary * _Nullable documentInfo) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsBeginPDFContextToData (NSMutableData data, CGRect bounds, [NullAllowed] NSDictionary documentInfo);

    // extern void UIGraphicsEndPDFContext () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsEndPDFContext ();

    // extern void UIGraphicsBeginPDFPage () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsBeginPDFPage ();

    // extern void UIGraphicsBeginPDFPageWithInfo (CGRect bounds, NSDictionary * _Nullable pageInfo) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsBeginPDFPageWithInfo (CGRect bounds, [NullAllowed] NSDictionary pageInfo);

    // extern CGRect UIGraphicsGetPDFContextBounds () __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern CGRect UIGraphicsGetPDFContextBounds ();

    // extern void UIGraphicsSetPDFContextURLForRect (NSURL * _Nonnull url, CGRect rect) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsSetPDFContextURLForRect (NSUrl url, CGRect rect);

    // extern void UIGraphicsAddPDFContextDestinationAtPoint (NSString * _Nonnull name, CGPoint point) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsAddPDFContextDestinationAtPoint (NSString name, CGPoint point);

    // extern void UIGraphicsSetPDFContextDestinationForRect (NSString * _Nonnull name, CGRect rect) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=3_2)));
    [iOS (3,2)]
    [DllImport ("__Internal")]
    
    static extern void UIGraphicsSetPDFContextDestinationForRect (NSString name, CGRect rect);

    // extern void UIImageWriteToSavedPhotosAlbum (UIImage * _Nonnull image, id _Nullable completionTarget, SEL _Nullable completionSelector, void * _Nullable contextInfo) __attribute__((visibility("default"))) __attribute__((availability(tvos, unavailable)));
    [NoTV]
    [DllImport ("__Internal")]
    
    static extern unsafe void UIImageWriteToSavedPhotosAlbum (UIImage image, [NullAllowed] NSObject completionTarget, [NullAllowed] Selector completionSelector, [NullAllowed] void* contextInfo);

    // extern BOOL UIVideoAtPathIsCompatibleWithSavedPhotosAlbum (NSString * _Nonnull videoPath) __attribute__((visibility("default"))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, introduced=3_1)));
    [NoTV, iOS (3,1)]
    [DllImport ("__Internal")]
    
    static extern bool UIVideoAtPathIsCompatibleWithSavedPhotosAlbum (NSString videoPath);

    // extern void UISaveVideoAtPathToSavedPhotosAlbum (NSString * _Nonnull videoPath, id _Nullable completionTarget, SEL _Nullable completionSelector, void * _Nullable contextInfo) __attribute__((visibility("default"))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, introduced=3_1)));
    [NoTV, iOS (3,1)]
    [DllImport ("__Internal")]
    
    static extern unsafe void UISaveVideoAtPathToSavedPhotosAlbum (NSString videoPath, [NullAllowed] NSObject completionTarget, [NullAllowed] Selector completionSelector, [NullAllowed] void* contextInfo);

    // extern BOOL UIFloatRangeIsInfinite (UIFloatRange range) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=9_0)));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIFloatRangeIsInfinite (UIFloatRange range);

    // extern BOOL UIFloatRangeIsEqualToRange (UIFloatRange range, UIFloatRange otherRange) __attribute__((visibility("default"))) __attribute__((availability(ios, introduced=9_0)));
    [iOS (9,0)]
    [DllImport ("__Internal")]
    
    static extern bool UIFloatRangeIsEqualToRange (UIFloatRange range, UIFloatRange otherRange);

    // UIFloatRange UIFloatRangeMake (CGFloat minimum, CGFloat maximum);
    [DllImport ("__Internal")]
    
    static extern UIFloatRange UIFloatRangeMake (nfloat minimum, nfloat maximum);
}

[StructLayout (LayoutKind.Explicit)]
public struct ullc
{
    [FieldOffset (0)]
    public ulong ull;

    [FieldOffset (0)]
    public uint[] ul;
}

[StructLayout (LayoutKind.Sequential)]
public struct fd_set
{
    public int[] fds_bits;
}

[StructLayout (LayoutKind.Sequential)]
public struct _RuneEntry
{
    public int __min;

    public int __max;

    public int __map;

    public unsafe uint* __types;
}

[StructLayout (LayoutKind.Sequential)]
public struct _RuneRange
{
    public int __nranges;

    public unsafe _RuneEntry* __ranges;
}

[StructLayout (LayoutKind.Sequential)]
public struct _RuneCharClass
{
    public sbyte[] __name;

    public uint __mask;
}

[StructLayout (LayoutKind.Sequential)]
public struct _RuneLocale
{
    public sbyte[] __magic;

    public sbyte[] __encoding;

    public unsafe Func<sbyte*, nuint, sbyte**, int>* __sgetrune;

    public unsafe Func<int, sbyte*, nuint, sbyte**, int>* __sputrune;

    public int __invalid_rune;

    public uint[] __runetype;

    public int[] __maplower;

    public int[] __mapupper;

    public _RuneRange __runetype_ext;

    public _RuneRange __maplower_ext;

    public _RuneRange __mapupper_ext;

    public unsafe void* __variable;

    public int __variable_len;

    public int __ncharclasses;

    public unsafe _RuneCharClass* __charclasses;
}

[StructLayout (LayoutKind.Sequential)]
public struct lconv
{
    public unsafe sbyte* decimal_point;

    public unsafe sbyte* thousands_sep;

    public unsafe sbyte* grouping;

    public unsafe sbyte* int_curr_symbol;

    public unsafe sbyte* currency_symbol;

    public unsafe sbyte* mon_decimal_point;

    public unsafe sbyte* mon_thousands_sep;

    public unsafe sbyte* mon_grouping;

    public unsafe sbyte* positive_sign;

    public unsafe sbyte* negative_sign;

    public sbyte int_frac_digits;

    public sbyte frac_digits;

    public sbyte p_cs_precedes;

    public sbyte p_sep_by_space;

    public sbyte n_cs_precedes;

    public sbyte n_sep_by_space;

    public sbyte p_sign_posn;

    public sbyte n_sign_posn;

    public sbyte int_p_cs_precedes;

    public sbyte int_n_cs_precedes;

    public sbyte int_p_sep_by_space;

    public sbyte int_n_sep_by_space;

    public sbyte int_p_sign_posn;

    public sbyte int_n_sign_posn;
}

[StructLayout (LayoutKind.Explicit)]
public struct a
{
    [FieldOffset (0)]
    public float __f;

    [FieldOffset (0)]
    public uint __u;
}

[StructLayout (LayoutKind.Explicit)]
public struct b
{
    [FieldOffset (0)]
    public double __f;

    [FieldOffset (0)]
    public ulong __u;
}


[StructLayout (LayoutKind.Sequential)]
public struct __float2
{
    public float __sinval;

    public float __cosval;
}

[StructLayout (LayoutKind.Sequential)]
public struct __double2
{
    public double __sinval;

    public double __cosval;
}

[StructLayout (LayoutKind.Sequential)]
public struct exception
{
    public int type;

    public unsafe sbyte* name;

    public double arg1;

    public double arg2;

    public double retval;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_arm_exception_state
{
    public uint __exception;

    public uint __fsr;

    public uint __far;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_arm_exception_state64
{
    public ulong __far;

    public uint __esr;

    public uint __exception;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_arm_thread_state
{
    public uint[] __r;

    public uint __sp;

    public uint __lr;

    public uint __pc;

    public uint __cpsr;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_arm_thread_state64
{
    public ulong[] __x;

    public ulong __fp;

    public ulong __lr;

    public ulong __sp;

    public ulong __pc;

    public uint __cpsr;

    public uint __pad;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_arm_vfp_state
{
    public uint[] __r;

    public uint __fpscr;
}



[StructLayout (LayoutKind.Sequential)]
public struct arm_legacy_debug_state
{
    public uint[] __bvr;

    public uint[] __bcr;

    public uint[] __wvr;

    public uint[] __wcr;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_arm_debug_state32
{
    public uint[] __bvr;

    public uint[] __bcr;

    public uint[] __wvr;

    public uint[] __wcr;

    public ulong __mdscr_el1;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_arm_debug_state64
{
    public ulong[] __bvr;

    public ulong[] __bcr;

    public ulong[] __wvr;

    public ulong[] __wcr;

    public ulong __mdscr_el1;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_arm_cpmu_state64
{
    public ulong[] __ctrs;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_mcontext32
{
    public __darwin_arm_exception_state __es;

    public __darwin_arm_thread_state __ss;

    public __darwin_arm_vfp_state __fs;
}

[StructLayout (LayoutKind.Sequential)]
public struct __darwin_mcontext64
{
    public __darwin_arm_exception_state64 __es;

    public __darwin_arm_thread_state64 __ss;

    public __darwin_arm_neon_state64 __ns;
}

[StructLayout (LayoutKind.Sequential)]
public struct stack_t
{
    public unsafe void* ss_sp;

    public nuint ss_size;

    public int ss_flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct ucontext_t
{
    public int uc_onstack;

    public uint uc_sigmask;

    public __darwin_sigaltstack uc_stack;

    public unsafe __darwin_ucontext* uc_link;

    public nuint uc_mcsize;

    public unsafe __darwin_mcontext64* uc_mcontext;
}

[StructLayout (LayoutKind.Explicit)]
public struct sigval
{
    [FieldOffset (0)]
    public int sival_int;

    [FieldOffset (0)]
    public unsafe void* sival_ptr;
}

[StructLayout (LayoutKind.Sequential)]
public struct sigevent
{
    public int sigev_notify;

    public int sigev_signo;

    public sigval sigev_value;

    public unsafe Action<sigval>* sigev_notify_function;

    public unsafe pthread_attr_t* sigev_notify_attributes;
}

[StructLayout (LayoutKind.Sequential)]
public struct siginfo_t
{
    public int si_signo;

    public int si_errno;

    public int si_code;

    public int si_pid;

    public uint si_uid;

    public int si_status;

    public unsafe void* si_addr;

    public sigval si_value;

    public nint si_band;

    public nuint[] __pad;
}

[StructLayout (LayoutKind.Explicit)]
public struct __sigaction_u
{
    [FieldOffset (0)]
    public unsafe Action<int>* __sa_handler;

    [FieldOffset (0)]
    public unsafe Action<int, __siginfo*, void*>* __sa_sigaction;
}

[StructLayout (LayoutKind.Sequential)]
public struct __sigaction
{
    public __sigaction_u __sigaction_u;

    public unsafe Action<void*, int, int, siginfo_t*, void*>* sa_tramp;

    public uint sa_mask;

    public int sa_flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct sigaction
{
    public __sigaction_u __sigaction_u;

    public uint sa_mask;

    public int sa_flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct sigvec
{
    public unsafe Action<int>* sv_handler;

    public int sv_mask;

    public int sv_flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct sigstack
{
    public unsafe sbyte* ss_sp;

    public int ss_onstack;
}

[StructLayout (LayoutKind.Sequential)]
public struct __sbuf
{
    public unsafe byte* _base;

    public int _size;
}

[StructLayout (LayoutKind.Sequential)]
public struct FILE
{
    public unsafe byte* _p;

    public int _r;

    public int _w;

    public short _flags;

    public short _file;

    public __sbuf _bf;

    public int _lbfsize;

    public unsafe void* _cookie;

    public unsafe Func<void*, int>* _close;

    public unsafe Func<void*, sbyte*, int, int>* _read;

    public unsafe Func<void*, long, int, long>* _seek;

    public unsafe Func<void*, sbyte*, int, int>* _write;

    public __sbuf _ub;

    public unsafe __sFILEX* _extra;

    public int _ur;

    public byte[] _ubuf;

    public byte[] _nbuf;

    public __sbuf _lb;

    public int _blksize;

    public long _offset;
}

public enum idtype_t : uint
{
    All,
    Pid,
    Pgid
}

[StructLayout (LayoutKind.Sequential)]
public struct timeval
{
    public nint tv_sec;

    public int tv_usec;
}

[StructLayout (LayoutKind.Sequential)]
public struct rusage
{
    public timeval ru_utime;

    public timeval ru_stime;

    public nint ru_maxrss;

    public nint ru_ixrss;

    public nint ru_idrss;

    public nint ru_isrss;

    public nint ru_minflt;

    public nint ru_majflt;

    public nint ru_nswap;

    public nint ru_inblock;

    public nint ru_oublock;

    public nint ru_msgsnd;

    public nint ru_msgrcv;

    public nint ru_nsignals;

    public nint ru_nvcsw;

    public nint ru_nivcsw;
}

[StructLayout (LayoutKind.Sequential)]
public struct rusage_info_v0
{
    public byte[] ri_uuid;

    public ulong ri_user_time;

    public ulong ri_system_time;

    public ulong ri_pkg_idle_wkups;

    public ulong ri_interrupt_wkups;

    public ulong ri_pageins;

    public ulong ri_wired_size;

    public ulong ri_resident_size;

    public ulong ri_phys_footprint;

    public ulong ri_proc_start_abstime;

    public ulong ri_proc_exit_abstime;
}

[StructLayout (LayoutKind.Sequential)]
public struct rusage_info_v1
{
    public byte[] ri_uuid;

    public ulong ri_user_time;

    public ulong ri_system_time;

    public ulong ri_pkg_idle_wkups;

    public ulong ri_interrupt_wkups;

    public ulong ri_pageins;

    public ulong ri_wired_size;

    public ulong ri_resident_size;

    public ulong ri_phys_footprint;

    public ulong ri_proc_start_abstime;

    public ulong ri_proc_exit_abstime;

    public ulong ri_child_user_time;

    public ulong ri_child_system_time;

    public ulong ri_child_pkg_idle_wkups;

    public ulong ri_child_interrupt_wkups;

    public ulong ri_child_pageins;

    public ulong ri_child_elapsed_abstime;
}

[StructLayout (LayoutKind.Sequential)]
public struct rusage_info_v2
{
    public byte[] ri_uuid;

    public ulong ri_user_time;

    public ulong ri_system_time;

    public ulong ri_pkg_idle_wkups;

    public ulong ri_interrupt_wkups;

    public ulong ri_pageins;

    public ulong ri_wired_size;

    public ulong ri_resident_size;

    public ulong ri_phys_footprint;

    public ulong ri_proc_start_abstime;

    public ulong ri_proc_exit_abstime;

    public ulong ri_child_user_time;

    public ulong ri_child_system_time;

    public ulong ri_child_pkg_idle_wkups;

    public ulong ri_child_interrupt_wkups;

    public ulong ri_child_pageins;

    public ulong ri_child_elapsed_abstime;

    public ulong ri_diskio_bytesread;

    public ulong ri_diskio_byteswritten;
}

[StructLayout (LayoutKind.Sequential)]
public struct rusage_info_v3
{
    public byte[] ri_uuid;

    public ulong ri_user_time;

    public ulong ri_system_time;

    public ulong ri_pkg_idle_wkups;

    public ulong ri_interrupt_wkups;

    public ulong ri_pageins;

    public ulong ri_wired_size;

    public ulong ri_resident_size;

    public ulong ri_phys_footprint;

    public ulong ri_proc_start_abstime;

    public ulong ri_proc_exit_abstime;

    public ulong ri_child_user_time;

    public ulong ri_child_system_time;

    public ulong ri_child_pkg_idle_wkups;

    public ulong ri_child_interrupt_wkups;

    public ulong ri_child_pageins;

    public ulong ri_child_elapsed_abstime;

    public ulong ri_diskio_bytesread;

    public ulong ri_diskio_byteswritten;

    public ulong ri_cpu_time_qos_default;

    public ulong ri_cpu_time_qos_maintenance;

    public ulong ri_cpu_time_qos_background;

    public ulong ri_cpu_time_qos_utility;

    public ulong ri_cpu_time_qos_legacy;

    public ulong ri_cpu_time_qos_user_initiated;

    public ulong ri_cpu_time_qos_user_interactive;

    public ulong ri_billed_system_time;

    public ulong ri_serviced_system_time;
}

[StructLayout (LayoutKind.Sequential)]
public struct rusage_info_current
{
    public byte[] ri_uuid;

    public ulong ri_user_time;

    public ulong ri_system_time;

    public ulong ri_pkg_idle_wkups;

    public ulong ri_interrupt_wkups;

    public ulong ri_pageins;

    public ulong ri_wired_size;

    public ulong ri_resident_size;

    public ulong ri_phys_footprint;

    public ulong ri_proc_start_abstime;

    public ulong ri_proc_exit_abstime;

    public ulong ri_child_user_time;

    public ulong ri_child_system_time;

    public ulong ri_child_pkg_idle_wkups;

    public ulong ri_child_interrupt_wkups;

    public ulong ri_child_pageins;

    public ulong ri_child_elapsed_abstime;

    public ulong ri_diskio_bytesread;

    public ulong ri_diskio_byteswritten;

    public ulong ri_cpu_time_qos_default;

    public ulong ri_cpu_time_qos_maintenance;

    public ulong ri_cpu_time_qos_background;

    public ulong ri_cpu_time_qos_utility;

    public ulong ri_cpu_time_qos_legacy;

    public ulong ri_cpu_time_qos_user_initiated;

    public ulong ri_cpu_time_qos_user_interactive;

    public ulong ri_billed_system_time;

    public ulong ri_serviced_system_time;

    public ulong ri_logical_writes;

    public ulong ri_lifetime_max_phys_footprint;

    public ulong ri_instructions;

    public ulong ri_cycles;

    public ulong ri_billed_energy;

    public ulong ri_serviced_energy;

    public ulong[] ri_unused;
}

[StructLayout (LayoutKind.Sequential)]
public struct rlimit
{
    public ulong rlim_cur;

    public ulong rlim_max;
}

[StructLayout (LayoutKind.Sequential)]
public struct proc_rlimit_control_wakeupmon
{
    public uint wm_flags;

    public int wm_rate;
}

[StructLayout (LayoutKind.Explicit)]
public struct wait
{
    [FieldOffset (0)]
    public int w_status;

    [StructLayout (LayoutKind.Sequential)]
    public struct W_T
    {
        public uint w_Termsig;

        public uint w_Coredump;

        public uint w_Retcode;

        public uint w_Filler;
    }


    [FieldOffset (0)]
    public W_T w_T;

    [StructLayout (LayoutKind.Sequential)]
    public struct W_S
    {
        public uint w_Stopval;

        public uint w_Stopsig;

        public uint w_Filler;
    }


    [FieldOffset (0)]
    public W_S w_S;
}

[StructLayout (LayoutKind.Sequential)]
public struct div_t
{
    public int quot;

    public int rem;
}

[StructLayout (LayoutKind.Sequential)]
public struct ldiv_t
{
    public nint quot;

    public nint rem;
}

[StructLayout (LayoutKind.Sequential)]
public struct lldiv_t
{
    public long quot;

    public long rem;
}

[StructLayout (LayoutKind.Sequential)]
public struct timespec
{
    public nint tv_sec;

    public nint tv_nsec;
}

[StructLayout (LayoutKind.Sequential)]
public struct tm
{
    public int tm_sec;

    public int tm_min;

    public int tm_hour;

    public int tm_mday;

    public int tm_mon;

    public int tm_year;

    public int tm_wday;

    public int tm_yday;

    public int tm_isdst;

    public nint tm_gmtoff;

    public unsafe sbyte* tm_zone;
}

public enum clockid_t : uint
{
    Realtime = 0,
    Monotonic = 6,
    MonotonicRaw = 4,
    MonotonicRawApprox = 5,
    UptimeRaw = 8,
    UptimeRawApprox = 9,
    ProcessCputimeId = 12,
    ThreadCputimeId = 16
}

[StructLayout (LayoutKind.Sequential)]
public struct imaxdiv_t
{
    public nint quot;

    public nint rem;
}

[StructLayout (LayoutKind.Sequential)]
public struct CompTimeValue
{
    public uint lo;

    public int hi;
}

[StructLayout (LayoutKind.Sequential)]
public struct AbsoluteTime
{
    public uint lo;

    public uint hi;
}

[StructLayout (LayoutKind.Sequential)]
public struct extended80
{
    public short exp;

    public ushort[] man;
}

[StructLayout (LayoutKind.Sequential)]
public struct extended96
{
    public short[] exp;

    public ushort[] man;
}

[StructLayout (LayoutKind.Sequential)]
public struct Float32Point
{
    public float x;

    public float y;
}


[StructLayout (LayoutKind.Sequential)]
public struct ProcessSerialNumber
{
    public uint highLongOfPSN;

    public uint lowLongOfPSN;
}

[StructLayout (LayoutKind.Sequential)]
public struct Point
{
    public short v;

    public short h;
}

[StructLayout (LayoutKind.Sequential)]
public struct Rect
{
    public short top;

    public short left;

    public short bottom;

    public short right;
}

[StructLayout (LayoutKind.Sequential)]
public struct FixedPoint
{
    public int x;

    public int y;
}

[StructLayout (LayoutKind.Sequential)]
public struct FixedRect
{
    public int left;

    public int top;

    public int right;

    public int bottom;
}


[StructLayout (LayoutKind.Sequential)]
public struct TimeRecord
{
    public CompTimeValue value;

    public int scale;

    public unsafe TimeBase* @base;
}

[StructLayout (LayoutKind.Sequential)]
public struct NumVersion
{
    public byte nonRelRev;

    public byte stage;

    public byte minorAndBugRev;

    public byte majorRev;
}


[StructLayout (LayoutKind.Explicit)]
public struct NumVersionVariant
{
    [FieldOffset (0)]
    public NumVersion parts;

    [FieldOffset (0)]
    public uint whole;
}

[StructLayout (LayoutKind.Sequential)]
public struct VersRec
{
    public NumVersion numericVersion;

    public short countryCode;

    public byte[] shortVersion;

    public byte[] reserved;
}

[Native]
public enum CFComparisonResult : nint
{
    LessThan = -1,
    EqualTo = 0,
    GreaterThan = 1
}

[StructLayout (LayoutKind.Sequential)]
public struct CFRange
{
    public nint location;

    public nint length;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFAllocatorContext
{
    public nint version;

    public unsafe void* info;

    public unsafe CFAllocatorRetainCallBack* retain;

    public unsafe CFAllocatorReleaseCallBack* release;

    public unsafe CFAllocatorCopyDescriptionCallBack* copyDescription;

    public unsafe CFAllocatorAllocateCallBack* allocate;

    public unsafe CFAllocatorReallocateCallBack* reallocate;

    public unsafe CFAllocatorDeallocateCallBack* deallocate;

    public unsafe CFAllocatorPreferredSizeCallBack* preferredSize;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFArrayCallBacks
{
    public nint version;

    public unsafe CFArrayRetainCallBack* retain;

    public unsafe CFArrayReleaseCallBack* release;

    public unsafe CFArrayCopyDescriptionCallBack* copyDescription;

    public unsafe CFArrayEqualCallBack* equal;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFBagCallBacks
{
    public nint version;

    public unsafe CFBagRetainCallBack* retain;

    public unsafe CFBagReleaseCallBack* release;

    public unsafe CFBagCopyDescriptionCallBack* copyDescription;

    public unsafe CFBagEqualCallBack* equal;

    public unsafe CFBagHashCallBack* hash;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFBinaryHeapCompareContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFBinaryHeapCallBacks
{
    public nint version;

    public unsafe Func<CoreFoundation.CFAllocatorRef*, void*, void*>* retain;

    public unsafe Action<CoreFoundation.CFAllocatorRef*, void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;

    public unsafe Func<void*, void*, void*, CFComparisonResult>* compare;
}

[Verify (InferredFromMemberPrefix)]
public enum Os : uint
{
    UnknownByteOrder,
    LittleEndian,
    BigEndian
}

public enum __CFByteOrder : uint
{
    Unknown,
    LittleEndian,
    BigEndian
}

[StructLayout (LayoutKind.Sequential)]
public struct CFSwappedFloat32
{
    public uint v;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFSwappedFloat64
{
    public ulong v;
}

[StructLayout (LayoutKind.Explicit)]
public struct CFSwap
{
    [FieldOffset (0)]
    public float v;

    [FieldOffset (0)]
    public CFSwappedFloat32 sv;
}

[StructLayout (LayoutKind.Explicit)]
public struct CFSwap
{
    [FieldOffset (0)]
    public float v;

    [FieldOffset (0)]
    public CFSwappedFloat32 sv;
}

[StructLayout (LayoutKind.Explicit)]
public struct CFSwap
{
    [FieldOffset (0)]
    public double v;

    [FieldOffset (0)]
    public CFSwappedFloat64 sv;
}

[StructLayout (LayoutKind.Explicit)]
public struct CFSwap
{
    [FieldOffset (0)]
    public double v;

    [FieldOffset (0)]
    public CFSwappedFloat64 sv;
}

[StructLayout (LayoutKind.Explicit)]
public struct CFSwap
{
    [FieldOffset (0)]
    public float v;

    [FieldOffset (0)]
    public CFSwappedFloat32 sv;
}

[StructLayout (LayoutKind.Explicit)]
public struct CFSwap
{
    [FieldOffset (0)]
    public float v;

    [FieldOffset (0)]
    public CFSwappedFloat32 sv;
}

[StructLayout (LayoutKind.Explicit)]
public struct CFSwap
{
    [FieldOffset (0)]
    public double v;

    [FieldOffset (0)]
    public CFSwappedFloat64 sv;
}

[StructLayout (LayoutKind.Explicit)]
public struct CFSwap
{
    [FieldOffset (0)]
    public double v;

    [FieldOffset (0)]
    public CFSwappedFloat64 sv;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFDictionaryKeyCallBacks
{
    public nint version;

    public unsafe CFDictionaryRetainCallBack* retain;

    public unsafe CFDictionaryReleaseCallBack* release;

    public unsafe CFDictionaryCopyDescriptionCallBack* copyDescription;

    public unsafe CFDictionaryEqualCallBack* equal;

    public unsafe CFDictionaryHashCallBack* hash;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFDictionaryValueCallBacks
{
    public nint version;

    public unsafe CFDictionaryRetainCallBack* retain;

    public unsafe CFDictionaryReleaseCallBack* release;

    public unsafe CFDictionaryCopyDescriptionCallBack* copyDescription;

    public unsafe CFDictionaryEqualCallBack* equal;
}

[Native]
public enum CFNotificationSuspensionBehavior : nint
{
    Drop = 1,
    Coalesce = 2,
    Hold = 3,
    DeliverImmediately = 4
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum kCFNotification : nuint
{
    DeliverImmediately = (1 << 0),
    PostToAllSessions = (1 << 1)
}

[Native]
public enum CFLocaleLanguageDirection : nint
{
    Unknown = 0,
    LeftToRight = 1,
    RightToLeft = 2,
    TopToBottom = 3,
    BottomToTop = 4
}

[StructLayout (LayoutKind.Sequential)]
public struct CFGregorianDate
{
    public int year;

    public sbyte month;

    public sbyte day;

    public sbyte hour;

    public sbyte minute;

    public double second;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFGregorianUnits
{
    public int years;

    public int months;

    public int days;

    public int hours;

    public int minutes;

    public double seconds;
}

[Native]
public enum CFGregorianUnitFlags : nuint
{
    UnitsYears = (1 << 0),
    UnitsMonths = (1 << 1),
    UnitsDays = (1 << 2),
    UnitsHours = (1 << 3),
    UnitsMinutes = (1 << 4),
    UnitsSeconds = (1 << 5),
    AllUnits = 16777215
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum CFDataSearchFlags : nuint
{
    Backwards = 1 << 0,
    Anchored = 1 << 1
}

[Native]
public enum CFCharacterSetPredefinedSet : nint
{
    Control = 1,
    Whitespace,
    WhitespaceAndNewline,
    DecimalDigit,
    Letter,
    LowercaseLetter,
    UppercaseLetter,
    NonBase,
    Decomposable,
    AlphaNumeric,
    Punctuation,
    CapitalizedLetter = 13,
    Symbol = 14,
    Newline = 15,
    Illegal = 12
}

public enum CFStringBuiltInEncodings : uint
{
    MacRoman = 0,
    WindowsLatin1 = 1280,
    ISOLatin1 = 513,
    NextStepLatin = 2817,
    Ascii = 1536,
    Unicode = 256,
    Utf8 = 134217984,
    NonLossyASCII = 3071,
    Utf16 = 256,
    Utf16be = 268435712,
    Utf16le = 335544576,
    Utf32 = 201326848,
    Utf32be = 402653440,
    Utf32le = 469762304
}

[Native]
public enum CFStringCompareFlags : nuint
{
    CaseInsensitive = 1,
    Backwards = 4,
    Anchored = 8,
    Nonliteral = 16,
    Localized = 32,
    Numerically = 64,
    DiacriticInsensitive = 128,
    WidthInsensitive = 256,
    ForcedOrdering = 512
}

[Native]
public enum CFStringNormalizationForm : nint
{
    D = 0,
    Kd,
    C,
    Kc
}

[StructLayout (LayoutKind.Sequential)]
public struct CFStringInlineBuffer
{
    public ushort[] buffer;

    public unsafe CFStringRef* theString;

    public unsafe ushort* directUniCharBuffer;

    public unsafe sbyte* directCStringBuffer;

    public CFRange rangeToBuffer;

    public nint bufferedRangeStart;

    public nint bufferedRangeEnd;
}

[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
[Native]
public enum CFTimeZoneNameStyle : nint
{
    Standard,
    ShortStandard,
    DaylightSaving,
    ShortDaylightSaving,
    Generic,
    ShortGeneric
}

[Native]
public enum CFCalendarUnit : nuint
{
    Era = (1 << 1),
    Year = (1 << 2),
    Month = (1 << 3),
    Day = (1 << 4),
    Hour = (1 << 5),
    Minute = (1 << 6),
    Second = (1 << 7),
    Week = (1 << 8),
    Weekday = (1 << 9),
    WeekdayOrdinal = (1 << 10),
    Quarter = (1 << 11),
    WeekOfMonth = (1 << 12),
    WeekOfYear = (1 << 13),
    YearForWeekOfYear = (1 << 14)
}


[Native]
public enum CFDateFormatterStyle : nint
{
    NoStyle = 0,
    ShortStyle = 1,
    MediumStyle = 2,
    LongStyle = 3,
    FullStyle = 4
}

[Native]
public enum CFISO8601DateFormatOptions : nuint
{
    Year = (1 << 0),
    Month = (1 << 1),
    WeekOfYear = (1 << 2),
    Day = (1 << 4),
    Time = (1 << 5),
    TimeZone = (1 << 6),
    SpaceBetweenDateAndTime = (1 << 7),
    DashSeparatorInDate = (1 << 8),
    ColonSeparatorInTime = (1 << 9),
    ColonSeparatorInTimeZone = (1 << 10),
    FractionalSeconds = (1 << 11),
    FullDate = Year | Month | Day | DashSeparatorInDate,
    FullTime = Time | ColonSeparatorInTime | TimeZone | ColonSeparatorInTimeZone,
    InternetDateTime = FullDate | FullTime
}

[Native]
public enum CFNumberType : nint
{
    SInt8Type = 1,
    SInt16Type = 2,
    SInt32Type = 3,
    SInt64Type = 4,
    Float32Type = 5,
    Float64Type = 6,
    CharType = 7,
    ShortType = 8,
    IntType = 9,
    LongType = 10,
    LongLongType = 11,
    FloatType = 12,
    DoubleType = 13,
    CFIndexType = 14,
    NSIntegerType = 15,
    CGFloatType = 16,
    MaxType = 16
}

[Native]
public enum CFNumberFormatterStyle : nint
{
    NoStyle = 0,
    DecimalStyle = 1,
    CurrencyStyle = 2,
    PercentStyle = 3,
    ScientificStyle = 4,
    SpellOutStyle = 5,
    OrdinalStyle = 6,
    CurrencyISOCodeStyle = 8,
    CurrencyPluralStyle = 9,
    CurrencyAccountingStyle = 10
}

[Native]
public enum CFNumberFormatterOptionFlags : nuint
{
    CFNumberFormatterParseIntegersOnly = 1
}

[Native]
public enum CFNumberFormatterRoundingMode : nint
{
    Ceiling = 0,
    Floor = 1,
    Down = 2,
    Up = 3,
    HalfEven = 4,
    HalfDown = 5,
    HalfUp = 6
}

[Native]
public enum CFNumberFormatterPadPosition : nint
{
    BeforePrefix = 0,
    AfterPrefix = 1,
    BeforeSuffix = 2,
    AfterSuffix = 3
}

[Native]
public enum CFURLPathStyle : nint
{
    POSIXPathStyle = 0,
    HFSPathStyle,
    WindowsPathStyle
}

[Native]
public enum CFURLComponentType : nint
{
    Scheme = 1,
    NetLocation = 2,
    Path = 3,
    ResourceSpecifier = 4,
    User = 5,
    Password = 6,
    UserInfo = 7,
    Host = 8,
    Port = 9,
    ParameterString = 10,
    Query = 11,
    Fragment = 12
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum CFURLBookmarkCreationOptions : nuint
{
    MinimalBookmarkMask = (1 << 9),
    SuitableForBookmarkFile = (1 << 10),
    WithSecurityScope = (1 << 11),
    SecurityScopeAllowOnlyReadAccess = (1 << 12),
    PreferFileIDResolutionMask = (1 << 8)
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum CFURLBookmarkResolutionOptions : nuint
{
    URLBookmarkResolutionWithoutUIMask = (1 << 8),
    URLBookmarkResolutionWithoutMountingMask = (1 << 9),
    URLBookmarkResolutionWithSecurityScope = (1 << 10),
    BookmarkResolutionWithoutUIMask = URLBookmarkResolutionWithoutUIMask,
    BookmarkResolutionWithoutMountingMask = URLBookmarkResolutionWithoutMountingMask
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_port_status_t
{
    public uint mps_pset;

    public uint mps_seqno;

    public uint mps_mscount;

    public uint mps_qlimit;

    public uint mps_msgcount;

    public uint mps_sorights;

    public int mps_srights;

    public int mps_pdrequest;

    public int mps_nsrequest;

    public uint mps_flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_port_limits_t
{
    public uint mpl_qlimit;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_port_info_ext_t
{
    public mach_port_status_t mpie_status;

    public uint mpie_boost_cnt;

    public uint[] reserved;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_port_qos_t
{
    public uint name;

    public uint prealloc;

    public int pad1;

    public uint len;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_port_options_t
{
    public uint flags;

    public mach_port_limits_t mpl;

    public ulong[] reserved;
}

public enum mach_port_guard_exception_codes : uint
{
    Destroy = 1 << 0,
    ModRefs = 1 << 1,
    SetContext = 1 << 2,
    Unguarded = 1 << 3,
    IncorrectGuard = 1 << 4
}

public enum CFRunLoopRunResult
{
    Finished = 1,
    Stopped = 2,
    TimedOut = 3,
    HandledSource = 4
}

[Native]
public enum CFRunLoopActivity : nuint
{
    Entry = (1 << 0),
    BeforeTimers = (1 << 1),
    BeforeSources = (1 << 2),
    BeforeWaiting = (1 << 5),
    AfterWaiting = (1 << 6),
    Exit = (1 << 7),
    AllActivities = 268435455
}

[StructLayout (LayoutKind.Sequential)]
public struct CFRunLoopSourceContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;

    public unsafe Func<void*, void*, byte>* equal;

    public unsafe Func<void*, nuint>* hash;

    public unsafe Action<void*, CoreFoundation.CFRunLoopRef*, CoreFoundation.CFRunLoopMode*>* schedule;

    public unsafe Action<void*, CoreFoundation.CFRunLoopRef*, CoreFoundation.CFRunLoopMode*>* cancel;

    public unsafe Action<void*>* perform;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFRunLoopSourceContext1
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;

    public unsafe Func<void*, void*, byte>* equal;

    public unsafe Func<void*, nuint>* hash;

    public unsafe Func<void*, uint>* getPort;

    public unsafe Func<void*, nint, CoreFoundation.CFAllocatorRef*, void*, void*>* perform;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFRunLoopObserverContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFRunLoopTimerContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
}

[Native]
public enum CFSocketError : nint
{
    Success = 0,
    Error = -1,
    Timeout = -2
}

[StructLayout (LayoutKind.Sequential)]
public struct CFSocketSignature
{
    public int protocolFamily;

    public int socketType;

    public int protocol;

    public unsafe CFDataRef* address;
}

[Native]
public enum CFSocketCallBackType : nuint
{
    NoCallBack = 0,
    ReadCallBack = 1,
    AcceptCallBack = 2,
    DataCallBack = 3,
    ConnectCallBack = 4,
    WriteCallBack = 8
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum kCFSocket : nuint
{
    AutomaticallyReenableReadCallBack = 1,
    AutomaticallyReenableAcceptCallBack = 2,
    AutomaticallyReenableDataCallBack = 3,
    AutomaticallyReenableWriteCallBack = 8,
    LeaveErrors = 64,
    CloseOnInvalidate = 128
}

[StructLayout (LayoutKind.Sequential)]
public struct CFSocketContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
}

[StructLayout (LayoutKind.Sequential)]
public struct accessx_descriptor
{
    public uint ad_name_offset;

    public int ad_flags;

    public int[] ad_pad;
}

[StructLayout (LayoutKind.Sequential)]
public struct flock
{
    public long l_start;

    public long l_len;

    public int l_pid;

    public short l_type;

    public short l_whence;
}

[StructLayout (LayoutKind.Sequential)]
public struct flocktimeout
{
    public flock fl;

    public timespec timeout;
}

[StructLayout (LayoutKind.Sequential)]
public struct radvisory
{
    public long ra_offset;

    public int ra_count;
}

[StructLayout (LayoutKind.Sequential)]
public struct fcodeblobs_t
{
    public unsafe void* f_cd_hash;

    public nuint f_hash_size;

    public unsafe void* f_cd_buffer;

    public nuint f_cd_size;

    public unsafe uint* f_out_size;

    public int f_arch;

    public int __padding;
}

[StructLayout (LayoutKind.Sequential)]
public struct fsignatures_t
{
    public long fs_file_start;

    public unsafe void* fs_blob_start;

    public nuint fs_blob_size;
}

[StructLayout (LayoutKind.Sequential)]
public struct fchecklv_t
{
    public long lv_file_start;

    public nuint lv_error_message_size;

    public unsafe void* lv_error_message;
}

[StructLayout (LayoutKind.Sequential)]
public struct fstore_t
{
    public uint fst_flags;

    public int fst_posmode;

    public long fst_offset;

    public long fst_length;

    public long fst_bytesalloc;
}

[StructLayout (LayoutKind.Sequential)]
public struct fpunchhole_t
{
    public uint fp_flags;

    public uint reserved;

    public long fp_offset;

    public long fp_length;
}

[StructLayout (LayoutKind.Sequential)]
public struct ftrimactivefile_t
{
    public long fta_offset;

    public long fta_length;
}

[StructLayout (LayoutKind.Sequential)]
public struct fbootstraptransfer_t
{
    public long fbt_offset;

    public nuint fbt_length;

    public unsafe void* fbt_buffer;
}

[StructLayout (LayoutKind.Sequential)]
public struct log2phys
{
    public uint l2p_flags;

    public long l2p_contigbytes;

    public long l2p_devoffset;
}

public enum filesec_property_t : uint
{
    Owner = 1,
    Group = 2,
    Uuid = 3,
    Mode = 4,
    Acl = 5,
    Grpuuid = 6,
    AclRaw = 100,
    AclAllocsize = 101
}

[StructLayout (LayoutKind.Sequential)]
public struct objc_object
{
    public Class isa;
}

[StructLayout (LayoutKind.Sequential)]
public struct time_value_t
{
    public int seconds;

    public int microseconds;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_timespec_t
{
    public uint tv_sec;

    public int tv_nsec;
}

public enum dispatch_qos_class_t : uint
{
    UserInteractive = 33,
    UserInitiated = 25,
    Default = 21,
    Utility = 17,
    Background = 9,
    Unspecified = 0
}

[Native]
public enum dispatch_autorelease_frequency_t : nuint
{
    Inherit = 0,
    WorkItem = 1,
    Never = 2
}

[Native]
public enum dispatch_block_flags_t : nuint
{
    Barrier = 1,
    Detached = 2,
    AssignCurrent = 4,
    NoQosClass = 8,
    InheritQosClass = 16,
    EnforceQosClass = 32
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_type_descriptor_t
{
    public uint pad1;

    public uint pad2;

    public uint pad3;

    public uint type;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_port_descriptor_t
{
    public uint name;

    public uint pad1;

    public uint pad2;

    public uint disposition;

    public uint type;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_ool_descriptor32_t
{
    public uint address;

    public uint size;

    public int deallocate;

    public uint copy;

    public uint pad1;

    public uint type;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_ool_descriptor64_t
{
    public ulong address;

    public int deallocate;

    public uint copy;

    public uint pad1;

    public uint type;

    public uint size;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_ool_descriptor_t
{
    public unsafe void* address;

    public int deallocate;

    public uint copy;

    public uint pad1;

    public uint type;

    public uint size;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_ool_ports_descriptor32_t
{
    public uint address;

    public uint count;

    public int deallocate;

    public uint copy;

    public uint disposition;

    public uint type;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_ool_ports_descriptor64_t
{
    public ulong address;

    public int deallocate;

    public uint copy;

    public uint disposition;

    public uint type;

    public uint count;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_ool_ports_descriptor_t
{
    public unsafe void* address;

    public int deallocate;

    public uint copy;

    public uint disposition;

    public uint type;

    public uint count;
}

[StructLayout (LayoutKind.Explicit)]
public struct mach_msg_descriptor_t
{
    [FieldOffset (0)]
    public mach_msg_port_descriptor_t port;

    [FieldOffset (0)]
    public mach_msg_ool_descriptor_t out_of_line;

    [FieldOffset (0)]
    public mach_msg_ool_ports_descriptor_t ool_ports;

    [FieldOffset (0)]
    public mach_msg_type_descriptor_t type;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_body_t
{
    public uint msgh_descriptor_count;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_header_t
{
    public uint msgh_bits;

    public uint msgh_size;

    public uint msgh_remote_port;

    public uint msgh_local_port;

    public uint msgh_voucher_port;

    public int msgh_id;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_base_t
{
    public mach_msg_header_t header;

    public mach_msg_body_t body;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_trailer_t
{
    public uint msgh_trailer_type;

    public uint msgh_trailer_size;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_seqno_trailer_t
{
    public uint msgh_trailer_type;

    public uint msgh_trailer_size;

    public uint msgh_seqno;
}

[StructLayout (LayoutKind.Sequential)]
public struct security_token_t
{
    public uint[] val;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_format_0_trailer_t
{
    public uint msgh_trailer_type;

    public uint msgh_trailer_size;

    public uint msgh_seqno;

    public security_token_t msgh_sender;
}

[StructLayout (LayoutKind.Sequential)]
public struct audit_token_t
{
    public uint[] val;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_audit_trailer_t
{
    public uint msgh_trailer_type;

    public uint msgh_trailer_size;

    public uint msgh_seqno;

    public security_token_t msgh_sender;

    public audit_token_t msgh_audit;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_context_trailer_t
{
    public uint msgh_trailer_type;

    public uint msgh_trailer_size;

    public uint msgh_seqno;

    public security_token_t msgh_sender;

    public audit_token_t msgh_audit;

    public UIntPtr msgh_context;
}

[StructLayout (LayoutKind.Sequential)]
public struct msg_labels_t
{
    public uint sender;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_max_trailer_t
{
    public uint msgh_trailer_type;

    public uint msgh_trailer_size;

    public uint msgh_seqno;

    public security_token_t msgh_sender;

    public audit_token_t msgh_audit;

    public UIntPtr msgh_context;

    public int msgh_ad;

    public msg_labels_t msgh_labels;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_empty_send_t
{
    public mach_msg_header_t header;
}

[StructLayout (LayoutKind.Sequential)]
public struct mach_msg_empty_rcv_t
{
    public mach_msg_header_t header;

    public mach_msg_trailer_t trailer;
}

[StructLayout (LayoutKind.Explicit)]
public struct mach_msg_empty_t
{
    [FieldOffset (0)]
    public mach_msg_empty_send_t send;

    [FieldOffset (0)]
    public mach_msg_empty_rcv_t rcv;
}

[Native]
public enum CFStreamStatus : nint
{
    NotOpen = 0,
    Opening,
    Open,
    Reading,
    Writing,
    AtEnd,
    Closed,
    Error
}

[Native]
public enum CFStreamEventType : nuint
{
    None = 0,
    OpenCompleted = 1,
    HasBytesAvailable = 2,
    CanAcceptBytes = 4,
    ErrorOccurred = 8,
    EndEncountered = 16
}

[StructLayout (LayoutKind.Sequential)]
public struct CFStreamClientContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
}

[Native]
public enum CFStreamErrorDomain : nint
{
    Custom = -1,
    Posix = 1,
    MacOSStatus
}

[StructLayout (LayoutKind.Sequential)]
public struct CFStreamError
{
    public nint domain;

    public int error;
}

[Native]
public enum CFPropertyListMutabilityOptions : nuint
{
    Immutable = 0,
    MutableContainers = 1 << 0,
    MutableContainersAndLeaves = 1 << 1
}

[Native]
public enum CFPropertyListFormat : nint
{
    OpenStepFormat = 1,
    XMLFormat_v1_0 = 100,
    BinaryFormat_v1_0 = 200
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
[Verify (InferredFromMemberPrefix)]
public enum kCFPropertyList : nint
{
    ReadCorruptError = 3840,
    ReadUnknownVersionError = 3841,
    ReadStreamError = 3842,
    WriteStreamError = 3851
}

[StructLayout (LayoutKind.Sequential)]
public struct CFSetCallBacks
{
    public nint version;

    public unsafe CFSetRetainCallBack* retain;

    public unsafe CFSetReleaseCallBack* release;

    public unsafe CFSetCopyDescriptionCallBack* copyDescription;

    public unsafe CFSetEqualCallBack* equal;

    public unsafe CFSetHashCallBack* hash;
}

[Native]
public enum CFStringEncodings : nint
{
    MacJapanese = 1,
    MacChineseTrad = 2,
    MacKorean = 3,
    MacArabic = 4,
    MacHebrew = 5,
    MacGreek = 6,
    MacCyrillic = 7,
    MacDevanagari = 9,
    MacGurmukhi = 10,
    MacGujarati = 11,
    MacOriya = 12,
    MacBengali = 13,
    MacTamil = 14,
    MacTelugu = 15,
    MacKannada = 16,
    MacMalayalam = 17,
    MacSinhalese = 18,
    MacBurmese = 19,
    MacKhmer = 20,
    MacThai = 21,
    MacLaotian = 22,
    MacGeorgian = 23,
    MacArmenian = 24,
    MacChineseSimp = 25,
    MacTibetan = 26,
    MacMongolian = 27,
    MacEthiopic = 28,
    MacCentralEurRoman = 29,
    MacVietnamese = 30,
    MacExtArabic = 31,
    MacSymbol = 33,
    MacDingbats = 34,
    MacTurkish = 35,
    MacCroatian = 36,
    MacIcelandic = 37,
    MacRomanian = 38,
    MacCeltic = 39,
    MacGaelic = 40,
    MacFarsi = 140,
    MacUkrainian = 152,
    MacInuit = 236,
    MacVT100 = 252,
    MacHFS = 255,
    ISOLatin2 = 514,
    ISOLatin3 = 515,
    ISOLatin4 = 516,
    ISOLatinCyrillic = 517,
    ISOLatinArabic = 518,
    ISOLatinGreek = 519,
    ISOLatinHebrew = 520,
    ISOLatin5 = 521,
    ISOLatin6 = 522,
    ISOLatinThai = 523,
    ISOLatin7 = 525,
    ISOLatin8 = 526,
    ISOLatin9 = 527,
    ISOLatin10 = 528,
    DOSLatinUS = 1024,
    DOSGreek = 1029,
    DOSBalticRim = 1030,
    DOSLatin1 = 1040,
    DOSGreek1 = 1041,
    DOSLatin2 = 1042,
    DOSCyrillic = 1043,
    DOSTurkish = 1044,
    DOSPortuguese = 1045,
    DOSIcelandic = 1046,
    DOSHebrew = 1047,
    DOSCanadianFrench = 1048,
    DOSArabic = 1049,
    DOSNordic = 1050,
    DOSRussian = 1051,
    DOSGreek2 = 1052,
    DOSThai = 1053,
    DOSJapanese = 1056,
    DOSChineseSimplif = 1057,
    DOSKorean = 1058,
    DOSChineseTrad = 1059,
    WindowsLatin2 = 1281,
    WindowsCyrillic = 1282,
    WindowsGreek = 1283,
    WindowsLatin5 = 1284,
    WindowsHebrew = 1285,
    WindowsArabic = 1286,
    WindowsBalticRim = 1287,
    WindowsVietnamese = 1288,
    WindowsKoreanJohab = 1296,
    Ansel = 1537,
    JisX020176 = 1568,
    JisX020883 = 1569,
    JisX020890 = 1570,
    JisX021290 = 1571,
    JisC622678 = 1572,
    ShiftJIS_X0213 = 1576,
    ShiftJIS_X0213_MenKuTen = 1577,
    Gb231280 = 1584,
    Gbk95 = 1585,
    Gb180302000 = 1586,
    Ksc560187 = 1600,
    KSC_5601_92_Johab = 1601,
    Cns1164392P1 = 1617,
    Cns1164392P2 = 1618,
    Cns1164392P3 = 1619,
    Iso2022Jp = 2080,
    Iso2022Jp2 = 2081,
    Iso2022Jp1 = 2082,
    Iso2022Jp3 = 2083,
    Iso2022Cn = 2096,
    Iso2022CnExt = 2097,
    Iso2022Kr = 2112,
    EucJp = 2336,
    EucCn = 2352,
    EucTw = 2353,
    EucKr = 2368,
    ShiftJIS = 2561,
    Koi8R = 2562,
    Big5 = 2563,
    MacRomanLatin1 = 2564,
    HzGb2312 = 2565,
    Big5_HKSCS_1999 = 2566,
    Viscii = 2567,
    Koi8U = 2568,
    Big5_E = 2569,
    NextStepJapanese = 2818,
    EbcdicUs = 3073,
    EbcdicCp037 = 3074,
    Utf7 = 67109120,
    Utf7Imap = 2576,
    ShiftJIS_X0213_00 = 1576
}

[StructLayout (LayoutKind.Sequential)]
public struct CFTreeContext
{
    public nint version;

    public unsafe void* info;

    public unsafe CFTreeRetainCallBack* retain;

    public unsafe CFTreeReleaseCallBack* release;

    public unsafe CFTreeCopyDescriptionCallBack* copyDescription;
}

[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFError codes instead")]
[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFError codes instead")]
[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFError codes instead")]
[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFError codes instead")]
[Introduced (PlatformName.iOS, 2, 0, message: "Use CFError codes instead")]
[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFError codes instead")]
[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFError codes instead")]
[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFError codes instead")]
[Native]
public enum CFURLError : nint
{
    UnknownError = -10,
    UnknownSchemeError = -11,
    ResourceNotFoundError = -12,
    ResourceAccessViolationError = -13,
    RemoteHostUnavailableError = -14,
    ImproperArgumentsError = -15,
    UnknownPropertyKeyError = -16,
    PropertyKeyUnavailableError = -17,
    TimeoutError = -18
}

[StructLayout (LayoutKind.Sequential)]
public struct CFUUIDBytes
{
    public byte byte0;

    public byte byte1;

    public byte byte2;

    public byte byte3;

    public byte byte4;

    public byte byte5;

    public byte byte6;

    public byte byte7;

    public byte byte8;

    public byte byte9;

    public byte byte10;

    public byte byte11;

    public byte byte12;

    public byte byte13;

    public byte byte14;

    public byte byte15;
}

[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
[Verify (InferredFromMemberPrefix)]
public enum kCFBundleExecutableArchitecture : uint
{
    I386 = 7,
    Ppc = 18,
    X8664 = 16777223,
    Ppc64 = 16777234
}

[Verify (InferredFromMemberPrefix)]
public enum kCFMessagePort
{
    Success = 0,
    SendTimeout = -1,
    ReceiveTimeout = -2,
    IsInvalid = -3,
    TransportError = -4,
    BecameInvalidError = -5
}

[StructLayout (LayoutKind.Sequential)]
public struct CFMessagePortContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
}

[StructLayout (LayoutKind.Sequential)]
public struct CFMachPortContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
}

[Native]
public enum CFURLEnumeratorOptions : nuint
{
    DefaultBehavior = 0,
    DescendRecursively = 1 << 0,
    SkipInvisibles = 1 << 1,
    GenerateFileReferenceURLs = 1 << 2,
    SkipPackageContents = 1 << 3,
    IncludeDirectoriesPreOrder = 1 << 4,
    IncludeDirectoriesPostOrder = 1 << 5
}

[Native]
public enum CFURLEnumeratorResult : nint
{
    Success = 1,
    End = 2,
    Error = 3,
    DirectoryPostOrderSuccess = 4
}

[StructLayout (LayoutKind.Sequential)]
public struct guid_t
{
    public byte[] g_guid;
}

[StructLayout (LayoutKind.Sequential)]
public struct ntsid_t
{
    public byte sid_kind;

    public byte sid_authcount;

    public byte[] sid_authority;

    public uint[] sid_authorities;
}

[StructLayout (LayoutKind.Sequential)]
public struct kauth_identity_extlookup
{
    public uint el_seqno;

    public uint el_result;

    public uint el_flags;

    public int el_info_pid;

    public ulong el_extend;

    public uint el_info_reserved_1;

    public uint el_uid;

    public guid_t el_uguid;

    public uint el_uguid_valid;

    public ntsid_t el_usid;

    public uint el_usid_valid;

    public uint el_gid;

    public guid_t el_gguid;

    public uint el_gguid_valid;

    public ntsid_t el_gsid;

    public uint el_gsid_valid;

    public uint el_member_valid;

    public uint el_sup_grp_cnt;

    public uint[] el_sup_groups;
}

[StructLayout (LayoutKind.Sequential)]
public struct kauth_cache_sizes
{
    public uint kcs_group_size;

    public uint kcs_id_size;
}

[StructLayout (LayoutKind.Sequential)]
public struct kauth_ace
{
    public guid_t ace_applicable;

    public uint ace_flags;

    public uint ace_rights;
}

[StructLayout (LayoutKind.Sequential)]
public struct kauth_acl
{
    public uint acl_entrycount;

    public uint acl_flags;

    public kauth_ace[] acl_ace;
}

[StructLayout (LayoutKind.Sequential)]
public struct kauth_filesec
{
    public uint fsec_magic;

    public guid_t fsec_owner;

    public guid_t fsec_group;

    public kauth_acl fsec_acl;
}

public enum acl_perm_t : uint
{
    ReadData = (1 << 1),
    ListDirectory = (1 << 1),
    WriteData = (1 << 2),
    AddFile = (1 << 2),
    Execute = (1 << 3),
    Search = (1 << 3),
    Delete = (1 << 4),
    AppendData = (1 << 5),
    AddSubdirectory = (1 << 5),
    DeleteChild = (1 << 6),
    ReadAttributes = (1 << 7),
    WriteAttributes = (1 << 8),
    ReadExtattributes = (1 << 9),
    WriteExtattributes = (1 << 10),
    ReadSecurity = (1 << 11),
    WriteSecurity = (1 << 12),
    ChangeOwner = (1 << 13),
    Synchronize = (1 << 20)
}

public enum acl_tag_t : uint
{
    UndefinedTag = 0,
    ExtendedAllow = 1,
    ExtendedDeny = 2
}

public enum acl_type_t : uint
{
    Extended = 256,
    Access = 0,
    Default = 1,
    Afs = 2,
    Coda = 3,
    Ntfs = 4,
    Nwfs = 5
}

public enum acl_entry_id_t
{
    FirstEntry = 0,
    NextEntry = -1,
    LastEntry = -2
}

public enum acl_flag_t : uint
{
    FlagDeferInherit = (1 << 0),
    FlagNoInherit = (1 << 17),
    EntryInherited = (1 << 4),
    EntryFileInherit = (1 << 5),
    EntryDirectoryInherit = (1 << 6),
    EntryLimitInherit = (1 << 7),
    EntryOnlyInherit = (1 << 8)
}

[Watch (2,0), TV (9,0), Mac (10,8), iOS (6,0)]
[Native]
public enum CFFileSecurityClearOptions : nuint
{
    Owner = 1 << 0,
    Group = 1 << 1,
    Mode = 1 << 2,
    OwnerUUID = 1 << 3,
    GroupUUID = 1 << 4,
    AccessControlList = 1 << 5
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum kCFStringTokenizer : nuint
{
    UnitWord = 0,
    UnitSentence = 1,
    UnitParagraph = 2,
    UnitLineBreak = 3,
    UnitWordBoundary = 4,
    AttributeLatinTranscription = 1 << 16,
    AttributeLanguage = 1 << 17
}

[Native]
public enum CFStringTokenizerTokenType : nuint
{
    None = 0,
    Normal = 1 << 0,
    HasSubTokensMask = 1 << 1,
    HasDerivedSubTokensMask = 1 << 2,
    HasHasNumbersMask = 1 << 3,
    HasNonLettersMask = 1 << 4,
    IsCJWordMask = 1 << 5
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum kCFFileDescriptor : nuint
{
    ReadCallBack = 1 << 0,
    WriteCallBack = 1 << 1
}

[StructLayout (LayoutKind.Sequential)]
public struct CFFileDescriptorContext
{
    public nint version;

    public unsafe void* info;

    public unsafe Func<void*, void*>* retain;

    public unsafe Action<void*>* release;

    public unsafe Func<void*, CoreFoundation.CFStringRef*>* copyDescription;
}

[Native]
public enum NSComparisonResult : nint
{
    Ascending = -1,
    Same,
    Descending
}

[Native]
public enum NSEnumerationOptions : nuint
{
    Concurrent = (1 << 0),
    Reverse = (1 << 1)
}

[Native]
public enum NSSortOptions : nuint
{
    Concurrent = (1 << 0),
    Stable = (1 << 4)
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSQualityOfService : nint
{
    UserInteractive = 33,
    UserInitiated = 25,
    Utility = 17,
    Background = 9,
    Default = -1
}

[StructLayout (LayoutKind.Sequential)]
public struct NSFastEnumerationState
{
    public nuint state;

    public unsafe NSObject* itemsPtr;

    public unsafe nuint* mutationsPtr;

    public nuint[] extra;
}

[StructLayout (LayoutKind.Sequential)]
public struct NSRange
{
    public nuint location;

    public nuint length;
}

[Native]
public enum NSBinarySearchingOptions : nuint
{
    FirstEqual = (1 << 8),
    LastEqual = (1 << 9),
    InsertionIndex = (1 << 10)
}

[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
[Native]
public enum NSItemProviderRepresentationVisibility : nint
{
    All = 0,
    Team = 1,
    Group = 2,
    OwnProcess = 3
}

[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
[Native]
public enum NSItemProviderFileOptions : nint
{
    NSItemProviderFileOptionOpenInPlace = 1
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSItemProviderErrorCode : nint
{
    UnknownError = -1,
    ItemUnavailableError = -1000,
    UnexpectedValueClassError = -1100,
    UnavailableCoercionError = -1200
}

[Native]
public enum NSStringCompareOptions : nuint
{
    CaseInsensitiveSearch = 1,
    LiteralSearch = 2,
    BackwardsSearch = 4,
    AnchoredSearch = 8,
    NumericSearch = 64,
    DiacriticInsensitiveSearch = 128,
    WidthInsensitiveSearch = 256,
    ForcedOrderingSearch = 512,
    RegularExpressionSearch = 1024
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum Ns : nuint
{
    ASCIIStringEncoding = 1,
    NEXTSTEPStringEncoding = 2,
    JapaneseEUCStringEncoding = 3,
    UTF8StringEncoding = 4,
    ISOLatin1StringEncoding = 5,
    SymbolStringEncoding = 6,
    NonLossyASCIIStringEncoding = 7,
    ShiftJISStringEncoding = 8,
    ISOLatin2StringEncoding = 9,
    UnicodeStringEncoding = 10,
    WindowsCP1251StringEncoding = 11,
    WindowsCP1252StringEncoding = 12,
    WindowsCP1253StringEncoding = 13,
    WindowsCP1254StringEncoding = 14,
    WindowsCP1250StringEncoding = 15,
    ISO2022JPStringEncoding = 21,
    MacOSRomanStringEncoding = 30,
    UTF16StringEncoding = UnicodeStringEncoding,
    UTF16BigEndianStringEncoding = 2415919360L,
    UTF16LittleEndianStringEncoding = 2483028224L,
    UTF32StringEncoding = 2348810496L,
    UTF32BigEndianStringEncoding = 2550137088L,
    UTF32LittleEndianStringEncoding = 2617245952L
}

[Native]
public enum NSStringEncodingConversionOptions : nuint
{
    AllowLossy = 1,
    ExternalRepresentation = 2
}

[Native]
public enum NSStringEnumerationOptions : nuint
{
    ByLines = 0,
    ByParagraphs = 1,
    ByComposedCharacterSequences = 2,
    ByWords = 3,
    BySentences = 4,
    Reverse = 1 << 8,
    SubstringNotRequired = 1 << 9,
    Localized = 1 << 10
}



[Verify (InferredFromMemberPrefix)]
public enum NSBundleExecutableArchitecture : uint
{
    I386 = 7,
    Ppc = 18,
    X8664 = 16777223,
    Ppc64 = 16777234
}

[Verify (InferredFromMemberPrefix)]
public enum Ns : uint
{
    UnknownByteOrder = CFByteOrderUnknown,
    LittleEndian = CFByteOrderLittleEndian,
    BigEndian = CFByteOrderBigEndian
}

[StructLayout (LayoutKind.Sequential)]
public struct NSSwappedFloat
{
    public uint v;
}

[StructLayout (LayoutKind.Sequential)]
public struct NSSwappedDouble
{
    public ulong v;
}

[StructLayout (LayoutKind.Explicit)]
public struct fconv
{
    [FieldOffset (0)]
    public float number;

    [FieldOffset (0)]
    public NSSwappedFloat sf;
}

[StructLayout (LayoutKind.Explicit)]
public struct fconv
{
    [FieldOffset (0)]
    public float number;

    [FieldOffset (0)]
    public NSSwappedFloat sf;
}

[StructLayout (LayoutKind.Explicit)]
public struct dconv
{
    [FieldOffset (0)]
    public double number;

    [FieldOffset (0)]
    public NSSwappedDouble sd;
}

[StructLayout (LayoutKind.Explicit)]
public struct dconv
{
    [FieldOffset (0)]
    public double number;

    [FieldOffset (0)]
    public NSSwappedDouble sd;
}

[Native]
public enum NSCalendarUnit : nuint
{
    CalendarUnitEra = kCFCalendarUnitEra,
    CalendarUnitYear = kCFCalendarUnitYear,
    CalendarUnitMonth = kCFCalendarUnitMonth,
    CalendarUnitDay = kCFCalendarUnitDay,
    CalendarUnitHour = kCFCalendarUnitHour,
    CalendarUnitMinute = kCFCalendarUnitMinute,
    CalendarUnitSecond = kCFCalendarUnitSecond,
    CalendarUnitWeekday = kCFCalendarUnitWeekday,
    CalendarUnitWeekdayOrdinal = kCFCalendarUnitWeekdayOrdinal,
    CalendarUnitQuarter = kCFCalendarUnitQuarter,
    CalendarUnitWeekOfMonth = kCFCalendarUnitWeekOfMonth,
    CalendarUnitWeekOfYear = kCFCalendarUnitWeekOfYear,
    CalendarUnitYearForWeekOfYear = kCFCalendarUnitYearForWeekOfYear,
    CalendarUnitNanosecond = (1 << 15),
    CalendarUnitCalendar = (1 << 20),
    CalendarUnitTimeZone = (1 << 21),
    EraCalendarUnit = CalendarUnitEra,
    YearCalendarUnit = CalendarUnitYear,
    MonthCalendarUnit = CalendarUnitMonth,
    DayCalendarUnit = CalendarUnitDay,
    HourCalendarUnit = CalendarUnitHour,
    MinuteCalendarUnit = CalendarUnitMinute,
    SecondCalendarUnit = CalendarUnitSecond,
    WeekCalendarUnit = kCFCalendarUnitWeek,
    WeekdayCalendarUnit = CalendarUnitWeekday,
    WeekdayOrdinalCalendarUnit = CalendarUnitWeekdayOrdinal,
    QuarterCalendarUnit = CalendarUnitQuarter,
    WeekOfMonthCalendarUnit = CalendarUnitWeekOfMonth,
    WeekOfYearCalendarUnit = CalendarUnitWeekOfYear,
    YearForWeekOfYearCalendarUnit = CalendarUnitYearForWeekOfYear,
    CalendarCalendarUnit = CalendarUnitCalendar,
    TimeZoneCalendarUnit = CalendarUnitTimeZone
}

[Native]
public enum NSCalendarOptions : nuint
{
    WrapComponents = (1 << 0),
    MatchStrictly = (1 << 1),
    SearchBackwards = (1 << 2),
    MatchPreviousTimePreservingSmallerUnits = (1 << 8),
    MatchNextTimePreservingSmallerUnits = (1 << 9),
    MatchNextTime = (1 << 10),
    MatchFirst = (1 << 12),
    MatchLast = (1 << 13)
}



[Native]
[Verify (InferredFromMemberPrefix)]
public enum Ns : nint
{
    DateComponentUndefined = 9223372036854775807L,
    UndefinedDateComponent = DateComponentUndefined
}


[Watch (2,0), TV (9,0), Mac (10,11), iOS (9,0)]
[Native]
public enum NSDecodingFailurePolicy : nint
{
    RaiseException,
    SetErrorAndReturn
}

[Native]
public enum NSDataReadingOptions : nuint
{
    DataReadingMappedIfSafe = 1 << 0,
    DataReadingUncached = 1 << 1,
    DataReadingMappedAlways = 1 << 3,
    DataReadingMapped = DataReadingMappedIfSafe,
    MappedRead = DataReadingMapped,
    UncachedRead = DataReadingUncached
}

[Native]
public enum NSDataWritingOptions : nuint
{
    DataWritingAtomic = 1 << 0,
    DataWritingWithoutOverwriting = 1 << 1,
    DataWritingFileProtectionNone = 268435456,
    DataWritingFileProtectionComplete = 536870912,
    DataWritingFileProtectionCompleteUnlessOpen = 805306368,
    DataWritingFileProtectionCompleteUntilFirstUserAuthentication = 1073741824,
    DataWritingFileProtectionMask = 4026531840L,
    AtomicWrite = DataWritingAtomic
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum NSDataSearchOptions : nuint
{
    Backwards = 1 << 0,
    Anchored = 1 << 1
}

[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
[Native]
public enum NSDataBase64EncodingOptions : nuint
{
    NSDataBase64Encoding64CharacterLineLength = 1 << 0,
    NSDataBase64Encoding76CharacterLineLength = 1 << 1,
    EndLineWithCarriageReturn = 1 << 4,
    EndLineWithLineFeed = 1 << 5
}

[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
[Native]
public enum NSDataBase64DecodingOptions : nuint
{
    NSDataBase64DecodingIgnoreUnknownCharacters = 1 << 0
}

[Native]
public enum NSAttributedStringEnumerationOptions : nuint
{
    Reverse = (1 << 1),
    LongestEffectiveRangeNotRequired = (1 << 20)
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSFormattingContext : nint
{
    Unknown = 0,
    Dynamic = 1,
    Standalone = 2,
    ListItem = 3,
    BeginningOfSentence = 4,
    MiddleOfSentence = 5
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSFormattingUnitStyle : nint
{
    Short = 1,
    Medium,
    Long
}

[Native]
public enum NSDateFormatterStyle : nuint
{
    NoStyle = kCFDateFormatterNoStyle,
    ShortStyle = kCFDateFormatterShortStyle,
    MediumStyle = kCFDateFormatterMediumStyle,
    LongStyle = kCFDateFormatterLongStyle,
    FullStyle = kCFDateFormatterFullStyle
}

[Native]
public enum NSDateFormatterBehavior : nuint
{
    Default = 0,
    NSDateFormatterBehavior10_4 = 1040
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSDateIntervalFormatterStyle : nuint
{
    NoStyle = 0,
    ShortStyle = 1,
    MediumStyle = 2,
    LongStyle = 3,
    FullStyle = 4
}

[Native]
public enum NSISO8601DateFormatOptions : nuint
{
    Year = kCFISO8601DateFormatWithYear,
    Month = kCFISO8601DateFormatWithMonth,
    WeekOfYear = kCFISO8601DateFormatWithWeekOfYear,
    Day = kCFISO8601DateFormatWithDay,
    Time = kCFISO8601DateFormatWithTime,
    TimeZone = kCFISO8601DateFormatWithTimeZone,
    SpaceBetweenDateAndTime = kCFISO8601DateFormatWithSpaceBetweenDateAndTime,
    DashSeparatorInDate = kCFISO8601DateFormatWithDashSeparatorInDate,
    ColonSeparatorInTime = kCFISO8601DateFormatWithColonSeparatorInTime,
    ColonSeparatorInTimeZone = kCFISO8601DateFormatWithColonSeparatorInTimeZone,
    FractionalSeconds = kCFISO8601DateFormatWithFractionalSeconds,
    FullDate = kCFISO8601DateFormatWithFullDate,
    FullTime = kCFISO8601DateFormatWithFullTime,
    InternetDateTime = kCFISO8601DateFormatWithInternetDateTime
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSMassFormatterUnit : nint
{
    Gram = 11,
    Kilogram = 14,
    Ounce = (6 << 8) + 1,
    Pound = (6 << 8) + 2,
    Stone = (6 << 8) + 3
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSLengthFormatterUnit : nint
{
    Millimeter = 8,
    Centimeter = 9,
    Meter = 11,
    Kilometer = 14,
    Inch = (5 << 8) + 1,
    Foot = (5 << 8) + 2,
    Yard = (5 << 8) + 3,
    Mile = (5 << 8) + 4
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSEnergyFormatterUnit : nint
{
    Joule = 11,
    Kilojoule = 14,
    Calorie = (7 << 8) + 1,
    Kilocalorie = (7 << 8) + 2
}

[Native]
public enum NSNumberFormatterBehavior : nuint
{
    Default = 0,
    NSNumberFormatterBehavior10_4 = 1040
}

[Native]
public enum NSNumberFormatterStyle : nuint
{
    NoStyle = kCFNumberFormatterNoStyle,
    DecimalStyle = kCFNumberFormatterDecimalStyle,
    CurrencyStyle = kCFNumberFormatterCurrencyStyle,
    PercentStyle = kCFNumberFormatterPercentStyle,
    ScientificStyle = kCFNumberFormatterScientificStyle,
    SpellOutStyle = kCFNumberFormatterSpellOutStyle,
    OrdinalStyle = kCFNumberFormatterOrdinalStyle,
    CurrencyISOCodeStyle = kCFNumberFormatterCurrencyISOCodeStyle,
    CurrencyPluralStyle = kCFNumberFormatterCurrencyPluralStyle,
    CurrencyAccountingStyle = kCFNumberFormatterCurrencyAccountingStyle
}

[Native]
public enum NSNumberFormatterPadPosition : nuint
{
    BeforePrefix = kCFNumberFormatterPadBeforePrefix,
    AfterPrefix = kCFNumberFormatterPadAfterPrefix,
    BeforeSuffix = kCFNumberFormatterPadBeforeSuffix,
    AfterSuffix = kCFNumberFormatterPadAfterSuffix
}

[Native]
public enum NSNumberFormatterRoundingMode : nuint
{
    Ceiling = kCFNumberFormatterRoundCeiling,
    Floor = kCFNumberFormatterRoundFloor,
    Down = kCFNumberFormatterRoundDown,
    Up = kCFNumberFormatterRoundUp,
    HalfEven = kCFNumberFormatterRoundHalfEven,
    HalfDown = kCFNumberFormatterRoundHalfDown,
    HalfUp = kCFNumberFormatterRoundHalfUp
}

[Native]
public enum NSLocaleLanguageDirection : nuint
{
    Unknown = kCFLocaleLanguageDirectionUnknown,
    LeftToRight = kCFLocaleLanguageDirectionLeftToRight,
    RightToLeft = kCFLocaleLanguageDirectionRightToLeft,
    TopToBottom = kCFLocaleLanguageDirectionTopToBottom,
    BottomToTop = kCFLocaleLanguageDirectionBottomToTop
}

[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
[Native]
public enum NSMeasurementFormatterUnitOptions : nuint
{
    ProvidedUnit = (1 << 0),
    NaturalScale = (1 << 1),
    TemperatureWithoutUnit = (1 << 2)
}

[Watch (2,0), TV (9,0), Mac (10,11), iOS (9,0)]
[Native]
public enum NSPersonNameComponentsFormatterStyle : nint
{
    Default = 0,
    Short,
    Medium,
    Long,
    Abbreviated
}

[Watch (2,0), TV (9,0), Mac (10,11), iOS (9,0)]
[Native]
public enum NSPersonNameComponentsFormatterOptions : nuint
{
    NSPersonNameComponentsFormatterPhonetic = (1 << 1)
}

[Native]
public enum NSRoundingMode : nuint
{
    Plain,
    Down,
    Up,
    Bankers
}

[Native]
public enum NSCalculationError : nuint
{
    NoError = 0,
    LossOfPrecision,
    Underflow,
    Overflow,
    DivideByZero
}

[StructLayout (LayoutKind.Sequential)]
public struct NSDecimal
{
    public int _exponent;

    public uint _length;

    public uint _isNegative;

    public uint _isCompact;

    public uint _reserved;

    public ushort[] _mantissa;
}

[Native]
public enum NSSearchPathDirectory : nuint
{
    ApplicationDirectory = 1,
    DemoApplicationDirectory,
    DeveloperApplicationDirectory,
    AdminApplicationDirectory,
    LibraryDirectory,
    DeveloperDirectory,
    UserDirectory,
    DocumentationDirectory,
    DocumentDirectory,
    CoreServiceDirectory,
    AutosavedInformationDirectory = 11,
    DesktopDirectory = 12,
    CachesDirectory = 13,
    ApplicationSupportDirectory = 14,
    DownloadsDirectory = 15,
    InputMethodsDirectory = 16,
    MoviesDirectory = 17,
    MusicDirectory = 18,
    PicturesDirectory = 19,
    PrinterDescriptionDirectory = 20,
    SharedPublicDirectory = 21,
    PreferencePanesDirectory = 22,
    ApplicationScriptsDirectory = 23,
    ItemReplacementDirectory = 99,
    AllApplicationsDirectory = 100,
    AllLibrariesDirectory = 101,
    TrashDirectory = 102
}

[Native]
public enum NSSearchPathDomainMask : nuint
{
    UserDomainMask = 1,
    LocalDomainMask = 2,
    NetworkDomainMask = 4,
    SystemDomainMask = 8,
    AllDomainsMask = 65535
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum NSURLBookmarkCreationOptions : nuint
{
    PreferFileIDResolution = (1 << 8),
    MinimalBookmark = (1 << 9),
    SuitableForBookmarkFile = (1 << 10),
    WithSecurityScope = (1 << 11),
    SecurityScopeAllowOnlyReadAccess = (1 << 12)
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum NSURLBookmarkResolutionOptions : nuint
{
    outUI = (1 << 8),
    outMounting = (1 << 9),
    SecurityScope = (1 << 10)
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum NSVolumeEnumerationOptions : nuint
{
    SkipHiddenVolumes = 1 << 1,
    ProduceFileReferenceURLs = 1 << 2
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum NSDirectoryEnumerationOptions : nuint
{
    SubdirectoryDescendants = 1 << 0,
    PackageDescendants = 1 << 1,
    HiddenFiles = 1 << 2
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum NSFileManagerItemReplacementOptions : nuint
{
    UsingNewMetadataOnly = 1 << 0,
    WithoutDeletingBackupItem = 1 << 1
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (8,0)]
[Native]
public enum NSURLRelationship : nint
{
    Contains,
    Same,
    Other
}

[NoiOS]
[Native]
public enum NSFileManagerUnmountOptions : nuint
{
    AllPartitionsAndEjectDisk = 1 << 0,
    WithoutUI = 1 << 1
}

[Native]
public enum NSPointerFunctionsOptions : nuint
{
    StrongMemory = (0 << 0),
    OpaqueMemory = (2 << 0),
    MallocMemory = (3 << 0),
    MachVirtualMemory = (4 << 0),
    WeakMemory = (5 << 0),
    ObjectPersonality = (0 << 8),
    OpaquePersonality = (1 << 8),
    ObjectPointerPersonality = (2 << 8),
    CStringPersonality = (3 << 8),
    StructPersonality = (4 << 8),
    IntegerPersonality = (5 << 8),
    CopyIn = (1 << 16)
}

[Native]
public enum NSHTTPCookieAcceptPolicy : nuint
{
    Always,
    Never,
    OnlyFromMainDocumentDomain
}





    [FieldOffset (0)]
    public __singleRange _singleRange;

    [StructLayout (LayoutKind.Sequential)]
    public struct __multipleRanges
    {
        public unsafe void* _data;

        public unsafe void* _reserved;
    }


    
[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
[Native]
public enum NSJSONReadingOptions : nuint
{
    MutableContainers = (1 << 0),
    MutableLeaves = (1 << 1),
    AllowFragments = (1 << 2)
}

[Watch (2,0), TV (9,0), Mac (10,7), iOS (5,0)]
[Native]
public enum NSJSONWritingOptions : nuint
{
    PrettyPrinted = (1 << 0),
    SortedKeys = (1 << 1)
}

[Native]
public enum NSKeyValueObservingOptions : nuint
{
    New = 1,
    Old = 2,
    Initial = 4,
    Prior = 8
}

[Native]
public enum NSKeyValueChange : nuint
{
    Setting = 1,
    Insertion = 2,
    Removal = 3,
    Replacement = 4
}

[Native]
public enum NSKeyValueSetMutationKind : nuint
{
    UnionSetMutation = 1,
    MinusSetMutation = 2,
    IntersectSetMutation = 3,
    SetSetMutation = 4
}

[Native]
public enum NSPropertyListReadOptions : nuint
{
    Immutable = kCFPropertyListImmutable,
    MutableContainers = kCFPropertyListMutableContainers,
    MutableContainersAndLeaves = kCFPropertyListMutableContainersAndLeaves
}

[Native]
public enum NSPropertyListFormat : nuint
{
    OpenStepFormat = kCFPropertyListOpenStepFormat,
    XMLFormat_v1_0 = kCFPropertyListXMLFormat_v1_0,
    BinaryFormat_v1_0 = kCFPropertyListBinaryFormat_v1_0
}

[Native]
public enum NSPostingStyle : nuint
{
    WhenIdle = 1,
    Asap = 2,
    Now = 3
}

[Native]
public enum NSNotificationCoalescing : nuint
{
    NoCoalescing = 0,
    CoalescingOnName = 1,
    CoalescingOnSender = 2
}

[Native]
public enum NSOperationQueuePriority : nint
{
    VeryLow = -8,
    Low = -4,
    Normal = 0,
    High = 4,
    VeryHigh = 8
}

[Watch (2,0), TV (9,0), Mac (10,5), iOS (2,0)]
[Native]
public enum NSMachPortOptions : nuint
{
    None = 0,
    SendRight = (1 << 0),
    ReceiveRight = (1 << 1)
}

[Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
[Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
[Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
[Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
[Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
[Deprecated (PlatformName.iOS, 8, 0, message: "Not supported")]
[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
[Deprecated (PlatformName.MacOSX, 10, 10, message: "Not supported")]
[Verify (InferredFromMemberPrefix)]
public enum Ns : uint
{
    WindowsNTOperatingSystem = 1,
    Windows95OperatingSystem,
    SolarisOperatingSystem,
    HPUXOperatingSystem,
    MACHOperatingSystem,
    SunOSOperatingSystem,
    OSF1OperatingSystem
}

[StructLayout (LayoutKind.Sequential)]
public struct NSOperatingSystemVersion
{
    public nint majorVersion;

    public nint minorVersion;

    public nint patchVersion;
}

[Watch (2,0), TV (9,0), Mac (10,9), iOS (7,0)]
public enum NSActivityOptions : ulong
{
    IdleDisplaySleepDisabled = (1 << 40),
    IdleSystemSleepDisabled = (1 << 20),
    SuddenTerminationDisabled = (1 << 14),
    AutomaticTerminationDisabled = (1 << 15),
    UserInitiated = (16777215 | IdleSystemSleepDisabled),
    UserInitiatedAllowingIdleSystemSleep = (UserInitiated & ~IdleSystemSleepDisabled),
    Background = 255,
    LatencyCritical = 1095216660480L
}

[Watch (4,0), TV (11,0), Mac (10,10,3), iOS (11,0)]
[Native]
public enum NSProcessInfoThermalState : nint
{
    Nominal,
    Fair,
    Serious,
    Critical
}

public enum NSTextCheckingType : ulong
{
    Orthography = 1 << 0,
    Spelling = 1 << 1,
    Grammar = 1 << 2,
    Date = 1 << 3,
    Address = 1 << 4,
    Link = 1 << 5,
    Quote = 1 << 6,
    Dash = 1 << 7,
    Replacement = 1 << 8,
    Correction = 1 << 9,
    RegularExpression = 1 << 10,
    PhoneNumber = 1 << 11,
    TransitInformation = 1 << 12
}

[Verify (InferredFromMemberPrefix)]
public enum NSTextCheckingAll : ulong
{
    SystemTypes = 4294967295L,
    CustomTypes = 4294967295L << 32,
    Types = (SystemTypes | CustomTypes)
}

[Native]
public enum NSRegularExpressionOptions : nuint
{
    CaseInsensitive = 1 << 0,
    AllowCommentsAndWhitespace = 1 << 1,
    IgnoreMetacharacters = 1 << 2,
    DotMatchesLineSeparators = 1 << 3,
    AnchorsMatchLines = 1 << 4,
    UseUnixLineSeparators = 1 << 5,
    UseUnicodeWordBoundaries = 1 << 6
}

[Native]
public enum NSMatchingOptions : nuint
{
    ReportProgress = 1 << 0,
    ReportCompletion = 1 << 1,
    Anchored = 1 << 2,
    WithTransparentBounds = 1 << 3,
    WithoutAnchoringBounds = 1 << 4
}

[Native]
public enum NSMatchingFlags : nuint
{
    Progress = 1 << 0,
    Completed = 1 << 1,
    HitEnd = 1 << 2,
    RequiredEnd = 1 << 3,
    InternalError = 1 << 4
}

[Native]
public enum NSStreamStatus : nuint
{
    NotOpen = 0,
    Opening = 1,
    Open = 2,
    Reading = 3,
    Writing = 4,
    AtEnd = 5,
    Closed = 6,
    Error = 7
}

[Native]
public enum NSStreamEvent : nuint
{
    None = 0,
    OpenCompleted = 1 << 0,
    HasBytesAvailable = 1 << 1,
    HasSpaceAvailable = 1 << 2,
    ErrorOccurred = 1 << 3,
    EndEncountered = 1 << 4
}

[Native]
public enum NSTimeZoneNameStyle : nint
{
    Standard,
    ShortStandard,
    DaylightSaving,
    ShortDaylightSaving,
    Generic,
    ShortGeneric
}

[Native]
public enum NSURLCacheStoragePolicy : nuint
{
    Allowed,
    AllowedInMemoryOnly,
    NotAllowed
}

[Verify (InferredFromMemberPrefix)]
public enum errSec
{
    Success = 0,
    Unimplemented = -4,
    DskFull = -34,
    Io = -36,
    OpWr = -49,
    Param = -50,
    WrPerm = -61,
    Allocate = -108,
    UserCanceled = -128,
    BadReq = -909,
    InternalComponent = -2070,
    CoreFoundationUnknown = -4960,
    MissingEntitlement = -34018,
    NotAvailable = -25291,
    ReadOnly = -25292,
    AuthFailed = -25293,
    NoSuchKeychain = -25294,
    InvalidKeychain = -25295,
    DuplicateKeychain = -25296,
    DuplicateCallback = -25297,
    InvalidCallback = -25298,
    DuplicateItem = -25299,
    ItemNotFound = -25300,
    BufferTooSmall = -25301,
    DataTooLarge = -25302,
    NoSuchAttr = -25303,
    InvalidItemRef = -25304,
    InvalidSearchRef = -25305,
    NoSuchClass = -25306,
    NoDefaultKeychain = -25307,
    InteractionNotAllowed = -25308,
    ReadOnlyAttr = -25309,
    WrongSecVersion = -25310,
    KeySizeNotAllowed = -25311,
    NoStorageModule = -25312,
    NoCertificateModule = -25313,
    NoPolicyModule = -25314,
    InteractionRequired = -25315,
    DataNotAvailable = -25316,
    DataNotModifiable = -25317,
    CreateChainFailed = -25318,
    InvalidPrefsDomain = -25319,
    InDarkWake = -25320,
    ACLNotSimple = -25240,
    PolicyNotFound = -25241,
    InvalidTrustSetting = -25242,
    NoAccessForItem = -25243,
    InvalidOwnerEdit = -25244,
    TrustNotAvailable = -25245,
    UnsupportedFormat = -25256,
    UnknownFormat = -25257,
    KeyIsSensitive = -25258,
    MultiplePrivKeys = -25259,
    PassphraseRequired = -25260,
    InvalidPasswordRef = -25261,
    InvalidTrustSettings = -25262,
    NoTrustSettings = -25263,
    Pkcs12VerifyFailure = -25264,
    NotSigner = -26267,
    Decode = -26275,
    ServiceNotAvailable = -67585,
    InsufficientClientID = -67586,
    DeviceReset = -67587,
    DeviceFailed = -67588,
    AppleAddAppACLSubject = -67589,
    ApplePublicKeyIncomplete = -67590,
    AppleSignatureMismatch = -67591,
    AppleInvalidKeyStartDate = -67592,
    AppleInvalidKeyEndDate = -67593,
    ConversionError = -67594,
    AppleSSLv2Rollback = -67595,
    DiskFull = -34,
    QuotaExceeded = -67596,
    FileTooBig = -67597,
    InvalidDatabaseBlob = -67598,
    InvalidKeyBlob = -67599,
    IncompatibleDatabaseBlob = -67600,
    IncompatibleKeyBlob = -67601,
    HostNameMismatch = -67602,
    UnknownCriticalExtensionFlag = -67603,
    NoBasicConstraints = -67604,
    NoBasicConstraintsCA = -67605,
    InvalidAuthorityKeyID = -67606,
    InvalidSubjectKeyID = -67607,
    InvalidKeyUsageForPolicy = -67608,
    InvalidExtendedKeyUsage = -67609,
    InvalidIDLinkage = -67610,
    PathLengthConstraintExceeded = -67611,
    InvalidRoot = -67612,
    CRLExpired = -67613,
    CRLNotValidYet = -67614,
    CRLNotFound = -67615,
    CRLServerDown = -67616,
    CRLBadURI = -67617,
    UnknownCertExtension = -67618,
    UnknownCRLExtension = -67619,
    CRLNotTrusted = -67620,
    CRLPolicyFailed = -67621,
    IDPFailure = -67622,
    SMIMEEmailAddressesNotFound = -67623,
    SMIMEBadExtendedKeyUsage = -67624,
    SMIMEBadKeyUsage = -67625,
    SMIMEKeyUsageNotCritical = -67626,
    SMIMENoEmailAddress = -67627,
    SMIMESubjAltNameNotCritical = -67628,
    SSLBadExtendedKeyUsage = -67629,
    OCSPBadResponse = -67630,
    OCSPBadRequest = -67631,
    OCSPUnavailable = -67632,
    OCSPStatusUnrecognized = -67633,
    EndOfData = -67634,
    IncompleteCertRevocationCheck = -67635,
    NetworkFailure = -67636,
    OCSPNotTrustedToAnchor = -67637,
    RecordModified = -67638,
    OCSPSignatureError = -67639,
    OCSPNoSigner = -67640,
    OCSPResponderMalformedReq = -67641,
    OCSPResponderInternalError = -67642,
    OCSPResponderTryLater = -67643,
    OCSPResponderSignatureRequired = -67644,
    OCSPResponderUnauthorized = -67645,
    OCSPResponseNonceMismatch = -67646,
    CodeSigningBadCertChainLength = -67647,
    CodeSigningNoBasicConstraints = -67648,
    CodeSigningBadPathLengthConstraint = -67649,
    CodeSigningNoExtendedKeyUsage = -67650,
    CodeSigningDevelopment = -67651,
    ResourceSignBadCertChainLength = -67652,
    ResourceSignBadExtKeyUsage = -67653,
    TrustSettingDeny = -67654,
    InvalidSubjectName = -67655,
    UnknownQualifiedCertStatement = -67656,
    MobileMeRequestQueued = -67657,
    MobileMeRequestRedirected = -67658,
    MobileMeServerError = -67659,
    MobileMeServerNotAvailable = -67660,
    MobileMeServerAlreadyExists = -67661,
    MobileMeServerServiceErr = -67662,
    MobileMeRequestAlreadyPending = -67663,
    MobileMeNoRequestPending = -67664,
    MobileMeCSRVerifyFailure = -67665,
    MobileMeFailedConsistencyCheck = -67666,
    NotInitialized = -67667,
    InvalidHandleUsage = -67668,
    PVCReferentNotFound = -67669,
    FunctionIntegrityFail = -67670,
    InternalError = -67671,
    MemoryError = -67672,
    InvalidData = -67673,
    MDSError = -67674,
    InvalidPointer = -67675,
    SelfCheckFailed = -67676,
    FunctionFailed = -67677,
    ModuleManifestVerifyFailed = -67678,
    InvalidGUID = -67679,
    InvalidHandle = -67680,
    InvalidDBList = -67681,
    InvalidPassthroughID = -67682,
    InvalidNetworkAddress = -67683,
    CRLAlreadySigned = -67684,
    InvalidNumberOfFields = -67685,
    VerificationFailure = -67686,
    UnknownTag = -67687,
    InvalidSignature = -67688,
    InvalidName = -67689,
    InvalidCertificateRef = -67690,
    InvalidCertificateGroup = -67691,
    TagNotFound = -67692,
    InvalidQuery = -67693,
    InvalidValue = -67694,
    CallbackFailed = -67695,
    ACLDeleteFailed = -67696,
    ACLReplaceFailed = -67697,
    ACLAddFailed = -67698,
    ACLChangeFailed = -67699,
    InvalidAccessCredentials = -67700,
    InvalidRecord = -67701,
    InvalidACL = -67702,
    InvalidSampleValue = -67703,
    IncompatibleVersion = -67704,
    PrivilegeNotGranted = -67705,
    InvalidScope = -67706,
    PVCAlreadyConfigured = -67707,
    InvalidPVC = -67708,
    EMMLoadFailed = -67709,
    EMMUnloadFailed = -67710,
    AddinLoadFailed = -67711,
    InvalidKeyRef = -67712,
    InvalidKeyHierarchy = -67713,
    AddinUnloadFailed = -67714,
    LibraryReferenceNotFound = -67715,
    InvalidAddinFunctionTable = -67716,
    InvalidServiceMask = -67717,
    ModuleNotLoaded = -67718,
    InvalidSubServiceID = -67719,
    AttributeNotInContext = -67720,
    ModuleManagerInitializeFailed = -67721,
    ModuleManagerNotFound = -67722,
    EventNotificationCallbackNotFound = -67723,
    InputLengthError = -67724,
    OutputLengthError = -67725,
    PrivilegeNotSupported = -67726,
    DeviceError = -67727,
    AttachHandleBusy = -67728,
    NotLoggedIn = -67729,
    AlgorithmMismatch = -67730,
    KeyUsageIncorrect = -67731,
    KeyBlobTypeIncorrect = -67732,
    KeyHeaderInconsistent = -67733,
    UnsupportedKeyFormat = -67734,
    UnsupportedKeySize = -67735,
    InvalidKeyUsageMask = -67736,
    UnsupportedKeyUsageMask = -67737,
    InvalidKeyAttributeMask = -67738,
    UnsupportedKeyAttributeMask = -67739,
    InvalidKeyLabel = -67740,
    UnsupportedKeyLabel = -67741,
    InvalidKeyFormat = -67742,
    UnsupportedVectorOfBuffers = -67743,
    InvalidInputVector = -67744,
    InvalidOutputVector = -67745,
    InvalidContext = -67746,
    InvalidAlgorithm = -67747,
    InvalidAttributeKey = -67748,
    MissingAttributeKey = -67749,
    InvalidAttributeInitVector = -67750,
    MissingAttributeInitVector = -67751,
    InvalidAttributeSalt = -67752,
    MissingAttributeSalt = -67753,
    InvalidAttributePadding = -67754,
    MissingAttributePadding = -67755,
    InvalidAttributeRandom = -67756,
    MissingAttributeRandom = -67757,
    InvalidAttributeSeed = -67758,
    MissingAttributeSeed = -67759,
    InvalidAttributePassphrase = -67760,
    MissingAttributePassphrase = -67761,
    InvalidAttributeKeyLength = -67762,
    MissingAttributeKeyLength = -67763,
    InvalidAttributeBlockSize = -67764,
    MissingAttributeBlockSize = -67765,
    InvalidAttributeOutputSize = -67766,
    MissingAttributeOutputSize = -67767,
    InvalidAttributeRounds = -67768,
    MissingAttributeRounds = -67769,
    InvalidAlgorithmParms = -67770,
    MissingAlgorithmParms = -67771,
    InvalidAttributeLabel = -67772,
    MissingAttributeLabel = -67773,
    InvalidAttributeKeyType = -67774,
    MissingAttributeKeyType = -67775,
    InvalidAttributeMode = -67776,
    MissingAttributeMode = -67777,
    InvalidAttributeEffectiveBits = -67778,
    MissingAttributeEffectiveBits = -67779,
    InvalidAttributeStartDate = -67780,
    MissingAttributeStartDate = -67781,
    InvalidAttributeEndDate = -67782,
    MissingAttributeEndDate = -67783,
    InvalidAttributeVersion = -67784,
    MissingAttributeVersion = -67785,
    InvalidAttributePrime = -67786,
    MissingAttributePrime = -67787,
    InvalidAttributeBase = -67788,
    MissingAttributeBase = -67789,
    InvalidAttributeSubprime = -67790,
    MissingAttributeSubprime = -67791,
    InvalidAttributeIterationCount = -67792,
    MissingAttributeIterationCount = -67793,
    InvalidAttributeDLDBHandle = -67794,
    MissingAttributeDLDBHandle = -67795,
    InvalidAttributeAccessCredentials = -67796,
    MissingAttributeAccessCredentials = -67797,
    InvalidAttributePublicKeyFormat = -67798,
    MissingAttributePublicKeyFormat = -67799,
    InvalidAttributePrivateKeyFormat = -67800,
    MissingAttributePrivateKeyFormat = -67801,
    InvalidAttributeSymmetricKeyFormat = -67802,
    MissingAttributeSymmetricKeyFormat = -67803,
    InvalidAttributeWrappedKeyFormat = -67804,
    MissingAttributeWrappedKeyFormat = -67805,
    StagedOperationInProgress = -67806,
    StagedOperationNotStarted = -67807,
    VerifyFailed = -67808,
    QuerySizeUnknown = -67809,
    BlockSizeMismatch = -67810,
    PublicKeyInconsistent = -67811,
    DeviceVerifyFailed = -67812,
    InvalidLoginName = -67813,
    AlreadyLoggedIn = -67814,
    InvalidDigestAlgorithm = -67815,
    InvalidCRLGroup = -67816,
    CertificateCannotOperate = -67817,
    CertificateExpired = -67818,
    CertificateNotValidYet = -67819,
    CertificateRevoked = -67820,
    CertificateSuspended = -67821,
    InsufficientCredentials = -67822,
    InvalidAction = -67823,
    InvalidAuthority = -67824,
    VerifyActionFailed = -67825,
    InvalidCertAuthority = -67826,
    InvaldCRLAuthority = -67827,
    InvalidCRLEncoding = -67828,
    InvalidCRLType = -67829,
    InvalidCRL = -67830,
    InvalidFormType = -67831,
    InvalidID = -67832,
    InvalidIdentifier = -67833,
    InvalidIndex = -67834,
    InvalidPolicyIdentifiers = -67835,
    InvalidTimeString = -67836,
    InvalidReason = -67837,
    InvalidRequestInputs = -67838,
    InvalidResponseVector = -67839,
    InvalidStopOnPolicy = -67840,
    InvalidTuple = -67841,
    MultipleValuesUnsupported = -67842,
    NotTrusted = -67843,
    NoDefaultAuthority = -67844,
    RejectedForm = -67845,
    RequestLost = -67846,
    RequestRejected = -67847,
    UnsupportedAddressType = -67848,
    UnsupportedService = -67849,
    InvalidTupleGroup = -67850,
    InvalidBaseACLs = -67851,
    InvalidTupleCredendtials = -67852,
    InvalidEncoding = -67853,
    InvalidValidityPeriod = -67854,
    InvalidRequestor = -67855,
    RequestDescriptor = -67856,
    InvalidBundleInfo = -67857,
    InvalidCRLIndex = -67858,
    NoFieldValues = -67859,
    UnsupportedFieldFormat = -67860,
    UnsupportedIndexInfo = -67861,
    UnsupportedLocality = -67862,
    UnsupportedNumAttributes = -67863,
    UnsupportedNumIndexes = -67864,
    UnsupportedNumRecordTypes = -67865,
    FieldSpecifiedMultiple = -67866,
    IncompatibleFieldFormat = -67867,
    InvalidParsingModule = -67868,
    DatabaseLocked = -67869,
    DatastoreIsOpen = -67870,
    MissingValue = -67871,
    UnsupportedQueryLimits = -67872,
    UnsupportedNumSelectionPreds = -67873,
    UnsupportedOperator = -67874,
    InvalidDBLocation = -67875,
    InvalidAccessRequest = -67876,
    InvalidIndexInfo = -67877,
    InvalidNewOwner = -67878,
    InvalidModifyMode = -67879,
    MissingRequiredExtension = -67880,
    ExtendedKeyUsageNotCritical = -67881,
    TimestampMissing = -67882,
    TimestampInvalid = -67883,
    TimestampNotTrusted = -67884,
    TimestampServiceNotAvailable = -67885,
    TimestampBadAlg = -67886,
    TimestampBadRequest = -67887,
    TimestampBadDataFormat = -67888,
    TimestampTimeNotAvailable = -67889,
    TimestampUnacceptedPolicy = -67890,
    TimestampUnacceptedExtension = -67891,
    TimestampAddInfoNotAvailable = -67892,
    TimestampSystemFailure = -67893,
    SigningTimeMissing = -67894,
    TimestampRejection = -67895,
    TimestampWaiting = -67896,
    TimestampRevocationWarning = -67897,
    TimestampRevocationNotification = -67898
}

[iOS (8,0)]
[Native]
public enum SecAccessControlCreateFlags : nuint
{
    UserPresence = 1 << 0,
    TouchIDAny = 1 << 1,
    TouchIDCurrentSet = 1 << 3,
    DevicePasscode = 1 << 4,
    Or = 1 << 14,
    And = 1 << 15,
    PrivateKeyUsage = 1 << 30,
    ApplicationPassword = 1 << 31
}

public enum SecPadding : uint
{
    None = 0,
    Pkcs1 = 1,
    Oaep = 2,
    SigRaw = 16384,
    Pkcs1md2 = 32768,
    Pkcs1md5 = 32769,
    Pkcs1sha1 = 32770,
    Pkcs1sha224 = 32771,
    Pkcs1sha256 = 32772,
    Pkcs1sha384 = 32773,
    Pkcs1sha512 = 32774
}

[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
[Native]
public enum SecKeyOperationType : nint
{
    Sign = 0,
    Verify = 1,
    Encrypt = 2,
    Decrypt = 3,
    KeyExchange = 4
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum kSecRevocation : nuint
{
    OCSPMethod = (1 << 0),
    CRLMethod = (1 << 1),
    PreferCRL = (1 << 2),
    RequirePositiveResponse = (1 << 3),
    NetworkAccessDisabled = (1 << 4),
    UseAnyAvailableMethod = (OCSPMethod | CRLMethod)
}

public enum SecTrustResultType : uint
{
    Invalid = 0,
    Proceed = 1,
    Confirm = 2,
    Deny = 3,
    Unspecified = 4,
    RecoverableTrustFailure = 5,
    FatalTrustFailure = 6,
    OtherError = 7
}

[Native]
public enum NSURLCredentialPersistence : nuint
{
    None,
    ForSession,
    Permanent,
    Synchronizable
}

public enum CFNetworkErrors
{
    HostErrorHostNotFound = 1,
    HostErrorUnknown = 2,
    SOCKSErrorUnknownClientVersion = 100,
    SOCKSErrorUnsupportedServerVersion = 101,
    SOCKS4ErrorRequestFailed = 110,
    SOCKS4ErrorIdentdFailed = 111,
    SOCKS4ErrorIdConflict = 112,
    SOCKS4ErrorUnknownStatusCode = 113,
    SOCKS5ErrorBadState = 120,
    SOCKS5ErrorBadResponseAddr = 121,
    SOCKS5ErrorBadCredentials = 122,
    SOCKS5ErrorUnsupportedNegotiationMethod = 123,
    SOCKS5ErrorNoAcceptableMethod = 124,
    FTPErrorUnexpectedStatusCode = 200,
    ErrorHTTPAuthenticationTypeUnsupported = 300,
    ErrorHTTPBadCredentials = 301,
    ErrorHTTPConnectionLost = 302,
    ErrorHTTPParseFailure = 303,
    ErrorHTTPRedirectionLoopDetected = 304,
    ErrorHTTPBadURL = 305,
    ErrorHTTPProxyConnectionFailure = 306,
    ErrorHTTPBadProxyCredentials = 307,
    ErrorPACFileError = 308,
    ErrorPACFileAuth = 309,
    ErrorHTTPSProxyConnectionFailure = 310,
    StreamErrorHTTPSProxyFailureUnexpectedResponseToCONNECTMethod = 311,
    URLErrorBackgroundSessionInUseByAnotherProcess = -996,
    URLErrorBackgroundSessionWasDisconnected = -997,
    URLErrorUnknown = -998,
    URLErrorCancelled = -999,
    URLErrorBadURL = -1000,
    URLErrorTimedOut = -1001,
    URLErrorUnsupportedURL = -1002,
    URLErrorCannotFindHost = -1003,
    URLErrorCannotConnectToHost = -1004,
    URLErrorNetworkConnectionLost = -1005,
    URLErrorDNSLookupFailed = -1006,
    URLErrorHTTPTooManyRedirects = -1007,
    URLErrorResourceUnavailable = -1008,
    URLErrorNotConnectedToInternet = -1009,
    URLErrorRedirectToNonExistentLocation = -1010,
    URLErrorBadServerResponse = -1011,
    URLErrorUserCancelledAuthentication = -1012,
    URLErrorUserAuthenticationRequired = -1013,
    URLErrorZeroByteResource = -1014,
    URLErrorCannotDecodeRawData = -1015,
    URLErrorCannotDecodeContentData = -1016,
    URLErrorCannotParseResponse = -1017,
    URLErrorInternationalRoamingOff = -1018,
    URLErrorCallIsActive = -1019,
    URLErrorDataNotAllowed = -1020,
    URLErrorRequestBodyStreamExhausted = -1021,
    URLErrorAppTransportSecurityRequiresSecureConnection = -1022,
    URLErrorFileDoesNotExist = -1100,
    URLErrorFileIsDirectory = -1101,
    URLErrorNoPermissionsToReadFile = -1102,
    URLErrorDataLengthExceedsMaximum = -1103,
    URLErrorFileOutsideSafeArea = -1104,
    URLErrorSecureConnectionFailed = -1200,
    URLErrorServerCertificateHasBadDate = -1201,
    URLErrorServerCertificateUntrusted = -1202,
    URLErrorServerCertificateHasUnknownRoot = -1203,
    URLErrorServerCertificateNotYetValid = -1204,
    URLErrorClientCertificateRejected = -1205,
    URLErrorClientCertificateRequired = -1206,
    URLErrorCannotLoadFromNetwork = -2000,
    URLErrorCannotCreateFile = -3000,
    URLErrorCannotOpenFile = -3001,
    URLErrorCannotCloseFile = -3002,
    URLErrorCannotWriteToFile = -3003,
    URLErrorCannotRemoveFile = -3004,
    URLErrorCannotMoveFile = -3005,
    URLErrorDownloadDecodingFailedMidStream = -3006,
    URLErrorDownloadDecodingFailedToComplete = -3007,
    HTTPCookieCannotParseCookieFile = -4000,
    NetServiceErrorUnknown = -72000,
    NetServiceErrorCollision = -72001,
    NetServiceErrorNotFound = -72002,
    NetServiceErrorInProgress = -72003,
    NetServiceErrorBadArgument = -72004,
    NetServiceErrorCancel = -72005,
    NetServiceErrorInvalid = -72006,
    NetServiceErrorTimeout = -72007,
    NetServiceErrorDNSServiceFailure = -73000
}

public enum CFHostInfoType
{
    Addresses = 0,
    Names = 1,
    Reachability = 2
}

[StructLayout (LayoutKind.Sequential)]
public struct CFHostClientContext
{
    public nint version;

    public unsafe void* info;

    public unsafe CFAllocatorRetainCallBack* retain;

    public unsafe CFAllocatorReleaseCallBack* release;

    public unsafe CFAllocatorCopyDescriptionCallBack* copyDescription;
}

public enum CFNetServicesError
{
    Unknown = -72000,
    Collision = -72001,
    NotFound = -72002,
    InProgress = -72003,
    BadArgument = -72004,
    Cancel = -72005,
    Invalid = -72006,
    Timeout = -72007
}

public enum CFNetServiceMonitorType
{
    CFNetServiceMonitorTXT = 1
}

[Native]
public enum CFNetServiceRegisterFlags : nuint
{
    CFNetServiceFlagNoAutoRename = 1
}

[Native]
public enum CFNetServiceBrowserFlags : nuint
{
    MoreComing = 1,
    IsDomain = 2,
    IsDefault = 4,
    IsRegistrationDomain = 4,
    Remove = 8
}

[StructLayout (LayoutKind.Sequential)]
public struct CFNetServiceClientContext
{
    public nint version;

    public unsafe void* info;

    public unsafe CFAllocatorRetainCallBack* retain;

    public unsafe CFAllocatorReleaseCallBack* release;

    public unsafe CFAllocatorCopyDescriptionCallBack* copyDescription;
}

[Verify (InferredFromMemberPrefix)]
public enum kCFStreamErrorSOCKS : uint
{
    SubDomainNone = 0,
    SubDomainVersionCode = 1,
    kCFStreamErrorSOCKS4SubDomainResponse = 2,
    kCFStreamErrorSOCKS5SubDomainUserPass = 3,
    kCFStreamErrorSOCKS5SubDomainMethod = 4,
    kCFStreamErrorSOCKS5SubDomainResponse = 5
}

[Verify (InferredFromMemberPrefix)]
public enum kCFStreamErrorSOCKS : uint
{
    kCFStreamErrorSOCKS5BadResponseAddr = 1,
    kCFStreamErrorSOCKS5BadState = 2,
    UnknownClientVersion = 3
}

[Verify (InferredFromMemberPrefix)]
public enum kCFStreamErrorSOCKS4 : uint
{
    RequestFailed = 91,
    IdentdFailed = 92,
    IdConflict = 93
}


public enum CFStreamErrorHTTP
{
    ParseFailure = -1,
    RedirectionLoop = -2,
    BadURL = -3
}

public enum CFStreamErrorHTTPAuthentication
{
    TypeUnsupported = -1000,
    BadUserName = -1001,
    BadPassword = -1002
}

[Introduced (PlatformName.iOS, 2, 0)]
[Deprecated (PlatformName.iOS, 11, 0)]
public enum CFNetDiagnosticStatusValues
{
    NoErr = 0,
    Err = -66560,
    ConnectionUp = -66559,
    ConnectionIndeterminate = -66558,
    ConnectionDown = -66557
}

[Watch (2,0), TV (9,0), Mac (10,10), iOS (7,0)]
[Native]
[Verify (InferredFromMemberPrefix)]
public enum NSURLErrorCancelledReason : nint
{
    UserForceQuitApplication = 0,
    BackgroundUpdatesDisabled = 1,
    InsufficientSystemResources = 2
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum NSURLError : nint
{
    Unknown = -1,
    Cancelled = -999,
    BadURL = -1000,
    TimedOut = -1001,
    UnsupportedURL = -1002,
    CannotFindHost = -1003,
    CannotConnectToHost = -1004,
    NetworkConnectionLost = -1005,
    DNSLookupFailed = -1006,
    HTTPTooManyRedirects = -1007,
    ResourceUnavailable = -1008,
    NotConnectedToInternet = -1009,
    RedirectToNonExistentLocation = -1010,
    BadServerResponse = -1011,
    UserCancelledAuthentication = -1012,
    UserAuthenticationRequired = -1013,
    ZeroByteResource = -1014,
    CannotDecodeRawData = -1015,
    CannotDecodeContentData = -1016,
    CannotParseResponse = -1017,
    AppTransportSecurityRequiresSecureConnection = -1022,
    FileDoesNotExist = -1100,
    FileIsDirectory = -1101,
    NoPermissionsToReadFile = -1102,
    DataLengthExceedsMaximum = -1103,
    FileOutsideSafeArea = -1104,
    SecureConnectionFailed = -1200,
    ServerCertificateHasBadDate = -1201,
    ServerCertificateUntrusted = -1202,
    ServerCertificateHasUnknownRoot = -1203,
    ServerCertificateNotYetValid = -1204,
    ClientCertificateRejected = -1205,
    ClientCertificateRequired = -1206,
    CannotLoadFromNetwork = -2000,
    CannotCreateFile = -3000,
    CannotOpenFile = -3001,
    CannotCloseFile = -3002,
    CannotWriteToFile = -3003,
    CannotRemoveFile = -3004,
    CannotMoveFile = -3005,
    DownloadDecodingFailedMidStream = -3006,
    DownloadDecodingFailedToComplete = -3007,
    InternationalRoamingOff = -1018,
    CallIsActive = -1019,
    DataNotAllowed = -1020,
    RequestBodyStreamExhausted = -1021,
    BackgroundSessionRequiresSharedContainer = -995,
    BackgroundSessionInUseByAnotherProcess = -996,
    BackgroundSessionWasDisconnected = -997
}

[Native]
public enum NSURLRequestCachePolicy : nuint
{
    UseProtocolCachePolicy = 0,
    ReloadIgnoringLocalCacheData = 1,
    ReloadIgnoringLocalAndRemoteCacheData = 4,
    ReloadIgnoringCacheData = ReloadIgnoringLocalCacheData,
    ReturnCacheDataElseLoad = 2,
    ReturnCacheDataDontLoad = 3,
    ReloadRevalidatingCacheData = 5
}

[Native]
public enum NSURLRequestNetworkServiceType : nuint
{
    Default = 0,
    VoIP = 1,
    Video = 2,
    Background = 3,
    Voice = 4,
    CallSignaling = 11
}

[Native]
public enum NSXMLParserExternalEntityResolvingPolicy : nuint
{
    Never = 0,
    NoNetwork,
    SameOriginOnly,
    Always
}

[Native]
public enum NSXMLParserError : nint
{
    InternalError = 1,
    OutOfMemoryError = 2,
    DocumentStartError = 3,
    EmptyDocumentError = 4,
    PrematureDocumentEndError = 5,
    InvalidHexCharacterRefError = 6,
    InvalidDecimalCharacterRefError = 7,
    InvalidCharacterRefError = 8,
    InvalidCharacterError = 9,
    CharacterRefAtEOFError = 10,
    CharacterRefInPrologError = 11,
    CharacterRefInEpilogError = 12,
    CharacterRefInDTDError = 13,
    EntityRefAtEOFError = 14,
    EntityRefInPrologError = 15,
    EntityRefInEpilogError = 16,
    EntityRefInDTDError = 17,
    ParsedEntityRefAtEOFError = 18,
    ParsedEntityRefInPrologError = 19,
    ParsedEntityRefInEpilogError = 20,
    ParsedEntityRefInInternalSubsetError = 21,
    EntityReferenceWithoutNameError = 22,
    EntityReferenceMissingSemiError = 23,
    ParsedEntityRefNoNameError = 24,
    ParsedEntityRefMissingSemiError = 25,
    UndeclaredEntityError = 26,
    UnparsedEntityError = 28,
    EntityIsExternalError = 29,
    EntityIsParameterError = 30,
    UnknownEncodingError = 31,
    EncodingNotSupportedError = 32,
    StringNotStartedError = 33,
    StringNotClosedError = 34,
    NamespaceDeclarationError = 35,
    EntityNotStartedError = 36,
    EntityNotFinishedError = 37,
    LessThanSymbolInAttributeError = 38,
    AttributeNotStartedError = 39,
    AttributeNotFinishedError = 40,
    AttributeHasNoValueError = 41,
    AttributeRedefinedError = 42,
    LiteralNotStartedError = 43,
    LiteralNotFinishedError = 44,
    CommentNotFinishedError = 45,
    ProcessingInstructionNotStartedError = 46,
    ProcessingInstructionNotFinishedError = 47,
    NotationNotStartedError = 48,
    NotationNotFinishedError = 49,
    AttributeListNotStartedError = 50,
    AttributeListNotFinishedError = 51,
    MixedContentDeclNotStartedError = 52,
    MixedContentDeclNotFinishedError = 53,
    ElementContentDeclNotStartedError = 54,
    ElementContentDeclNotFinishedError = 55,
    XMLDeclNotStartedError = 56,
    XMLDeclNotFinishedError = 57,
    ConditionalSectionNotStartedError = 58,
    ConditionalSectionNotFinishedError = 59,
    ExternalSubsetNotFinishedError = 60,
    DOCTYPEDeclNotFinishedError = 61,
    MisplacedCDATAEndStringError = 62,
    CDATANotFinishedError = 63,
    MisplacedXMLDeclarationError = 64,
    SpaceRequiredError = 65,
    SeparatorRequiredError = 66,
    NMTOKENRequiredError = 67,
    NAMERequiredError = 68,
    PCDATARequiredError = 69,
    URIRequiredError = 70,
    PublicIdentifierRequiredError = 71,
    LTRequiredError = 72,
    GTRequiredError = 73,
    LTSlashRequiredError = 74,
    EqualExpectedError = 75,
    TagNameMismatchError = 76,
    UnfinishedTagError = 77,
    StandaloneValueError = 78,
    InvalidEncodingNameError = 79,
    CommentContainsDoubleHyphenError = 80,
    InvalidEncodingError = 81,
    ExternalStandaloneEntityError = 82,
    InvalidConditionalSectionError = 83,
    EntityValueRequiredError = 84,
    NotWellBalancedError = 85,
    ExtraContentError = 86,
    InvalidCharacterInEntityError = 87,
    ParsedEntityRefInInternalError = 88,
    EntityRefLoopError = 89,
    EntityBoundaryError = 90,
    InvalidURIError = 91,
    URIFragmentError = 92,
    NoDTDError = 94,
    DelegateAbortedParseError = 512
}

[StructLayout (LayoutKind.Sequential)]
public struct au_tid_t
{
    public int port;

    public uint machine;
}

[StructLayout (LayoutKind.Sequential)]
public struct au_tid_addr_t
{
    public int at_port;

    public uint at_type;

    public uint[] at_addr;
}

[StructLayout (LayoutKind.Sequential)]
public struct au_mask_t
{
    public uint am_success;

    public uint am_failure;
}

[StructLayout (LayoutKind.Sequential)]
public struct auditinfo_t
{
    public uint ai_auid;

    public au_mask_t ai_mask;

    public au_tid_t ai_termid;

    public int ai_asid;
}

[StructLayout (LayoutKind.Sequential)]
public struct auditinfo_addr_t
{
    public uint ai_auid;

    public au_mask_t ai_mask;

    public au_tid_addr_t ai_termid;

    public int ai_asid;

    public ulong ai_flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct auditpinfo_t
{
    public int ap_pid;

    public uint ap_auid;

    public au_mask_t ap_mask;

    public au_tid_t ap_termid;

    public int ap_asid;
}

[StructLayout (LayoutKind.Sequential)]
public struct auditpinfo_addr_t
{
    public int ap_pid;

    public uint ap_auid;

    public au_mask_t ap_mask;

    public au_tid_addr_t ap_termid;

    public int ap_asid;

    public ulong ap_flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct au_session_t
{
    public unsafe auditinfo_addr_t* as_aia_p;

    public au_mask_t as_mask;
}

[StructLayout (LayoutKind.Sequential)]
public struct au_qctrl_t
{
    public int aq_hiwater;

    public int aq_lowater;

    public int aq_bufsz;

    public int aq_delay;

    public int aq_minfree;
}

[StructLayout (LayoutKind.Sequential)]
public struct au_stat_t
{
    public uint as_version;

    public uint as_numevent;

    public int as_generated;

    public int as_nonattrib;

    public int as_kernel;

    public int as_audit;

    public int as_auditctl;

    public int as_enqueue;

    public int as_written;

    public int as_wblocked;

    public int as_rblocked;

    public int as_dropped;

    public int as_totalsize;

    public uint as_memused;
}

[StructLayout (LayoutKind.Sequential)]
public struct au_fstat_t
{
    public ulong af_filesz;

    public ulong af_currsz;
}

[StructLayout (LayoutKind.Sequential)]
public struct au_evclass_map_t
{
    public ushort ec_number;

    public uint ec_class;
}

[Watch (2,0), TV (9,0), Mac (10,8), iOS (6,0)]
[Native]
public enum NSXPCConnectionOptions : nuint
{
    NSXPCConnectionPrivileged = (1 << 12)
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum Ns : nint
{
    FileNoSuchFileError = 4,
    FileLockingError = 255,
    FileReadUnknownError = 256,
    FileReadNoPermissionError = 257,
    FileReadInvalidFileNameError = 258,
    FileReadCorruptFileError = 259,
    FileReadNoSuchFileError = 260,
    FileReadInapplicableStringEncodingError = 261,
    FileReadUnsupportedSchemeError = 262,
    FileReadTooLargeError = 263,
    FileReadUnknownStringEncodingError = 264,
    FileWriteUnknownError = 512,
    FileWriteNoPermissionError = 513,
    FileWriteInvalidFileNameError = 514,
    FileWriteFileExistsError = 516,
    FileWriteInapplicableStringEncodingError = 517,
    FileWriteUnsupportedSchemeError = 518,
    FileWriteOutOfSpaceError = 640,
    FileWriteVolumeReadOnlyError = 642,
    FileManagerUnmountUnknownError = 768,
    FileManagerUnmountBusyError = 769,
    KeyValueValidationError = 1024,
    FormattingError = 2048,
    UserCancelledError = 3072,
    FeatureUnsupportedError = 3328,
    ExecutableNotLoadableError = 3584,
    ExecutableArchitectureMismatchError = 3585,
    ExecutableRuntimeMismatchError = 3586,
    ExecutableLoadError = 3587,
    ExecutableLinkError = 3588,
    FileErrorMinimum = 0,
    FileErrorMaximum = 1023,
    ValidationErrorMinimum = 1024,
    ValidationErrorMaximum = 2047,
    ExecutableErrorMinimum = 3584,
    ExecutableErrorMaximum = 3839,
    FormattingErrorMinimum = 2048,
    FormattingErrorMaximum = 2559,
    PropertyListReadCorruptError = 3840,
    PropertyListReadUnknownVersionError = 3841,
    PropertyListReadStreamError = 3842,
    PropertyListWriteStreamError = 3851,
    PropertyListWriteInvalidError = 3852,
    PropertyListErrorMinimum = 3840,
    PropertyListErrorMaximum = 4095,
    XPCConnectionInterrupted = 4097,
    XPCConnectionInvalid = 4099,
    XPCConnectionReplyInvalid = 4101,
    XPCConnectionErrorMinimum = 4096,
    XPCConnectionErrorMaximum = 4224,
    UbiquitousFileUnavailableError = 4353,
    UbiquitousFileNotUploadedDueToQuotaError = 4354,
    UbiquitousFileUbiquityServerNotAvailable = 4355,
    UbiquitousFileErrorMinimum = 4352,
    UbiquitousFileErrorMaximum = 4607,
    UserActivityHandoffFailedError = 4608,
    UserActivityConnectionUnavailableError = 4609,
    UserActivityRemoteApplicationTimedOutError = 4610,
    UserActivityHandoffUserInfoTooLargeError = 4611,
    UserActivityErrorMinimum = 4608,
    UserActivityErrorMaximum = 4863,
    CoderReadCorruptError = 4864,
    CoderValueNotFoundError = 4865,
    CoderInvalidValueError = 4866,
    CoderErrorMinimum = 4864,
    CoderErrorMaximum = 4991,
    BundleErrorMinimum = 4992,
    BundleErrorMaximum = 5119,
    BundleOnDemandResourceOutOfSpaceError = 4992,
    BundleOnDemandResourceExceededMaximumSizeError = 4993,
    BundleOnDemandResourceInvalidTagError = 4994,
    CloudSharingNetworkFailureError = 5120,
    CloudSharingQuotaExceededError = 5121,
    CloudSharingTooManyParticipantsError = 5122,
    CloudSharingConflictError = 5123,
    CloudSharingNoPermissionError = 5124,
    CloudSharingOtherError = 5375,
    CloudSharingErrorMinimum = 5120,
    CloudSharingErrorMaximum = 5375
}

[Native]
public enum NSByteCountFormatterUnits : nuint
{
    Default = 0,
    Bytes = 1 << 0,
    Kb = 1 << 1,
    Mb = 1 << 2,
    Gb = 1 << 3,
    Tb = 1 << 4,
    Pb = 1 << 5,
    Eb = 1 << 6,
    Zb = 1 << 7,
    YBOrHigher = 255 << 8,
    All = 65535
}

[Native]
public enum NSByteCountFormatterCountStyle : nint
{
    File = 0,
    Memory = 1,
    Decimal = 2,
    Binary = 3
}

[StructLayout (LayoutKind.Sequential)]
public struct _predicateFlags
{
    public uint _evaluationBlocked;

    public uint _reservedPredicateFlags;
}

[Native]
public enum NSComparisonPredicateOptions : nuint
{
    CaseInsensitivePredicateOption = 1,
    DiacriticInsensitivePredicateOption = 2,
    NormalizedPredicateOption = 4
}

[Native]
public enum NSComparisonPredicateModifier : nuint
{
    DirectPredicateModifier = 0,
    AllPredicateModifier,
    AnyPredicateModifier
}

[Native]
public enum NSPredicateOperatorType : nuint
{
    LessThanPredicateOperatorType = 0,
    LessThanOrEqualToPredicateOperatorType,
    GreaterThanPredicateOperatorType,
    GreaterThanOrEqualToPredicateOperatorType,
    EqualToPredicateOperatorType,
    NotEqualToPredicateOperatorType,
    MatchesPredicateOperatorType,
    LikePredicateOperatorType,
    BeginsWithPredicateOperatorType,
    EndsWithPredicateOperatorType,
    InPredicateOperatorType,
    CustomSelectorPredicateOperatorType,
    ContainsPredicateOperatorType = 99,
    BetweenPredicateOperatorType
}

[Native]
public enum NSCompoundPredicateType : nuint
{
    NotPredicateType = 0,
    AndPredicateType,
    OrPredicateType
}

[Native]
public enum NSDateComponentsFormatterUnitsStyle : nint
{
    Positional = 0,
    Abbreviated,
    Short,
    Full,
    SpellOut,
    Brief
}

[Native]
public enum NSDateComponentsFormatterZeroFormattingBehavior : nuint
{
    None = (0),
    Default = (1 << 0),
    DropLeading = (1 << 1),
    DropMiddle = (1 << 2),
    DropTrailing = (1 << 3),
    DropAll = (DropLeading | DropMiddle | DropTrailing),
    Pad = (1 << 16)
}

[Native]
public enum NSExpressionType : nuint
{
    ConstantValueExpressionType = 0,
    EvaluatedObjectExpressionType,
    VariableExpressionType,
    KeyPathExpressionType,
    FunctionExpressionType,
    UnionSetExpressionType,
    IntersectSetExpressionType,
    MinusSetExpressionType,
    SubqueryExpressionType = 13,
    AggregateExpressionType = 14,
    AnyKeyExpressionType = 15,
    BlockExpressionType = 19,
    ConditionalExpressionType = 20
}

[StructLayout (LayoutKind.Sequential)]
public struct _expressionFlags
{
    public uint _evaluationBlocked;

    public uint _reservedExpressionFlags;
}

[Native]
public enum NSFileCoordinatorReadingOptions : nuint
{
    WithoutChanges = 1 << 0,
    ResolvesSymbolicLink = 1 << 1,
    ImmediatelyAvailableMetadataOnly = 1 << 2,
    ForUploading = 1 << 3
}

[Native]
public enum NSFileCoordinatorWritingOptions : nuint
{
    ForDeleting = 1 << 0,
    ForMoving = 1 << 1,
    ForMerging = 1 << 2,
    ForReplacing = 1 << 3,
    ContentIndependentMetadataOnly = 1 << 4
}

[Native]
public enum NSFileVersionAddingOptions : nuint
{
    NSFileVersionAddingByMoving = 1 << 0
}

[Native]
public enum NSFileVersionReplacingOptions : nuint
{
    NSFileVersionReplacingByMoving = 1 << 0
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum NSFileWrapperReadingOptions : nuint
{
    Immediate = 1 << 0,
    WithoutMapping = 1 << 1
}

[Watch (2,0), TV (9,0), Mac (10,6), iOS (4,0)]
[Native]
public enum NSFileWrapperWritingOptions : nuint
{
    Atomic = 1 << 0,
    WithNameUpdating = 1 << 1
}

[Native]
public enum NSLinguisticTaggerUnit : nint
{
    Word,
    Sentence,
    Paragraph,
    Document
}

[Native]
public enum NSLinguisticTaggerOptions : nuint
{
    OmitWords = 1 << 0,
    OmitPunctuation = 1 << 1,
    OmitWhitespace = 1 << 2,
    OmitOther = 1 << 3,
    JoinNames = 1 << 4
}

[Native]
public enum NSNetServicesError : nint
{
    UnknownError = -72000,
    CollisionError = -72001,
    NotFoundError = -72002,
    ActivityInProgress = -72003,
    BadArgumentError = -72004,
    CancelledError = -72005,
    InvalidError = -72006,
    TimeoutError = -72007
}

[Native]
public enum NSNetServiceOptions : nuint
{
    NoAutoRename = 1 << 0,
    ListenForConnections = 1 << 1
}

[Native]
[Verify (InferredFromMemberPrefix)]
public enum NSUbiquitousKeyValueStore : nint
{
    ServerChange,
    InitialSyncChange,
    QuotaViolationChange,
    AccountChange
}


public enum SSLProtocol
{
    SSLProtocolUnknown = 0,
    SSLProtocol3 = 2,
    TLSProtocol1 = 4,
    TLSProtocol11 = 7,
    TLSProtocol12 = 8,
    DTLSProtocol1 = 9,
    TLSProtocol13 = 10,
    TLSProtocolMaxSupported = 999,
    SSLProtocol2 = 1,
    SSLProtocol3Only = 3,
    TLSProtocol1Only = 5,
    SSLProtocolAll = 6
}

public enum SSLSessionOption
{
    BreakOnServerAuth = 0,
    BreakOnCertRequested = 1,
    BreakOnClientAuth = 2,
    FalseStart = 3,
    SendOneByteRecord = 4,
    AllowServerIdentityChange = 5,
    Fallback = 6,
    BreakOnClientHello = 7,
    AllowRenegotiation = 8,
    EnableSessionTickets = 9
}

public enum SSLSessionState
{
    Idle,
    Handshake,
    Connected,
    Closed,
    Aborted
}

public enum SSLClientCertificateState
{
    None,
    Requested,
    Sent,
    Rejected
}

[Verify (InferredFromMemberPrefix)]
public enum errSSL
{
    Protocol = -9800,
    Negotiation = -9801,
    FatalAlert = -9802,
    WouldBlock = -9803,
    SessionNotFound = -9804,
    ClosedGraceful = -9805,
    ClosedAbort = -9806,
    XCertChainInvalid = -9807,
    BadCert = -9808,
    Crypto = -9809,
    Internal = -9810,
    ModuleAttach = -9811,
    UnknownRootCert = -9812,
    NoRootCert = -9813,
    CertExpired = -9814,
    CertNotYetValid = -9815,
    ClosedNoNotify = -9816,
    BufferOverflow = -9817,
    BadCipherSuite = -9818,
    PeerUnexpectedMsg = -9819,
    PeerBadRecordMac = -9820,
    PeerDecryptionFail = -9821,
    PeerRecordOverflow = -9822,
    PeerDecompressFail = -9823,
    PeerHandshakeFail = -9824,
    PeerBadCert = -9825,
    PeerUnsupportedCert = -9826,
    PeerCertRevoked = -9827,
    PeerCertExpired = -9828,
    PeerCertUnknown = -9829,
    IllegalParam = -9830,
    PeerUnknownCA = -9831,
    PeerAccessDenied = -9832,
    PeerDecodeError = -9833,
    PeerDecryptError = -9834,
    PeerExportRestriction = -9835,
    PeerProtocolVersion = -9836,
    PeerInsufficientSecurity = -9837,
    PeerInternalError = -9838,
    PeerUserCancelled = -9839,
    PeerNoRenegotiation = -9840,
    PeerAuthCompleted = -9841,
    ClientCertRequested = -9842,
    HostNameMismatch = -9843,
    ConnectionRefused = -9844,
    DecryptionFail = -9845,
    BadRecordMac = -9846,
    RecordOverflow = -9847,
    BadConfiguration = -9848,
    UnexpectedRecord = -9849,
    WeakPeerEphemeralDHKey = -9850,
    ClientHelloReceived = -9851
}

public enum SSLProtocolSide
{
    ServerSide,
    ClientSide
}

public enum SSLConnectionType
{
    StreamType,
    DatagramType
}

public enum SSLAuthenticate
{
    NeverAuthenticate,
    AlwaysAuthenticate,
    TryAuthenticate
}

[iOS (7,0)]
[Native]
public enum NSURLSessionTaskState : nint
{
    Running = 0,
    Suspended = 1,
    Canceling = 2,
    Completed = 3
}

[NoWatch, NoTV, NoMac, iOS (11,0)]
[Native]
public enum NSURLSessionMultipathServiceType : nint
{
    None = 0,
    Handover = 1,
    Interactive = 2,
    Aggregate = 3
}

[Watch (4,0), TV (11,0), Mac (10,13), iOS (11,0)]
[Native]
public enum NSURLSessionDelayedRequestDisposition : nint
{
    ContinueLoading = 0,
    UseNewRequest = 1,
    Cancel = 2
}

[iOS (7,0)]
[Native]
public enum NSURLSessionAuthChallengeDisposition : nint
{
    UseCredential = 0,
    PerformDefaultHandling = 1,
    CancelAuthenticationChallenge = 2,
    RejectProtectionSpace = 3
}

[iOS (7,0)]
[Native]
public enum NSURLSessionResponseDisposition : nint
{
    Cancel = 0,
    Allow = 1,
    BecomeDownload = 2,
    BecomeStream = 3
}

[Watch (3,0), TV (10,0), Mac (10,12), iOS (10,0)]
[Native]
public enum NSURLSessionTaskMetricsResourceFetchType : nint
{
    Unknown,
    NetworkLoad,
    ServerPush,
    LocalCache
}

[Native]
public enum pushOriginationState : nuint
{
    firstPushOriginationStateIndex = 0,
    PushOriginationStateBackground = firstPushOriginationStateIndex,
    PushOriginationStateForeground,
    PushOriginationStateUnknown = 999,
    lastPushOriginationStateIndex = PushOriginationStateUnknown
}

[Native]
public enum configureSDKWithAppIDError : nuint
{
    firstconfigureSDKWithAppIDIndex = 0,
    configureSDKWithAppIDNoError = firstconfigureSDKWithAppIDIndex,
    configureSDKWithAppIDInvalidAppIDError,
    configureSDKWithAppIDInvalidAccessTokenError,
    configureSDKWithAppIDUnableToReadRandomError,
    configureSDKWithAppIDDatabaseAccessError,
    configureSDKWithAppIDUnableToKeyDatabaseError,
    configureSDKWithAppIDCCKeyDerivationPBKDFError,
    configureSDKWithAppIDCCSymmetricKeyWrapError,
    configureSDKWithAppIDCCSymmetricKeyUnwrapError,
    configureSDKWithAppIDKeyChainError,
    configureSDKWithAppIDUnableToReadCertificateError,
    configureSDKWithAppIDRunOnceSimultaneouslyError,
    configureSDKWithAppIDRunOnceError,
    configureSDKWithAppIDInvalidLocationAndProximityError,
    configureSDKWithAppIDSimulatorBlobError,
    configureSDKWithAppIDKeyChainInvalidError,
    lastconfigureSDKWithAppIDIndex = configureSDKWithAppIDKeyChainInvalidError
}

[Native]
public enum requestPIRecommendationsError : nuint
{
    firstrequestPIRecommendationsInvalidIndex = 0,
    requestPIRecommendationsNoError = firstrequestPIRecommendationsInvalidIndex,
    requestPIRecommendationsInvalidMidParameterError = 1024,
    requestPIRecommendationsInvalidRetailerParameterError,
    requestPIRecommendationsInvalidPageParameterError,
    requestPIRecommendationsInvalidCompletionHandlerError,
    lastrequestPIRecommendationsInvalidIndex = requestPIRecommendationsInvalidCompletionHandlerError
}

[Native]
public enum MobilePushMessageType : nuint
{
    firstMobilePushMessageTypeIndex = 0,
    MobilePushMessageTypeUnknown = firstMobilePushMessageTypeIndex,
    MobilePushMessageTypeBasic,
    MobilePushMessageTypeFenceEntry = 3,
    MobilePushMessageTypeFenceExit,
    MobilePushMessageTypeProximity,
    MobilePushMessageTypeSilentPush,
    MobilePushMessageTypeInbox = 8,
    lastMobilePushMessageTypeIndex = MobilePushMessageTypeInbox
}

[Native]
public enum MobilePushGeofenceType : nuint
{
    firstMobilePushGeofenceTypeIndex = 0,
    MobilePushGeofenceTypeNone = firstMobilePushGeofenceTypeIndex,
    MobilePushGeofenceTypeCircle,
    MobilePushGeofenceTypeProximity = 3,
    lastMobilePushGeofenceTypeIndex = MobilePushGeofenceTypeProximity
}

[Native]
public enum ETRegionRequestType : nuint
{
    firstETRegionRequestTypeProximityIndex = 0,
    ETRegionRequestTypeUnknown = firstETRegionRequestTypeProximityIndex,
    ETRegionRequestTypeGeofence,
    ETRegionRequestTypeProximity,
    lastETRegionRequestTypeProximityIndex = ETRegionRequestTypeProximity
}

[Native]
public enum MobilePushContentType : nuint
{
    None = 0,
    AlertMessage = 1 << 0,
    Page = 1 << 1,
    Ecp = 1 << 31
}

[Native]
public enum MobilePushMessageFrequencyUnit : nuint
{
    firstMobilePushMessageFrequencyIndex = 0,
    MobilePushMessageFrequencyUnitNone = firstMobilePushMessageFrequencyIndex,
    MobilePushMessageFrequencyUnitYear,
    MobilePushMessageFrequencyUnitMonth,
    MobilePushMessageFrequencyUnitWeek,
    MobilePushMessageFrequencyUnitDay,
    MobilePushMessageFrequencyUnitHour,
    lastMobilePushMessageFrequencyIndex = MobilePushMessageFrequencyUnitHour
}

[Native]
public enum CLError : nint
{
    LocationUnknown = 0,
    Denied,
    Network,
    HeadingFailure,
    RegionMonitoringDenied,
    RegionMonitoringFailure,
    RegionMonitoringSetupDelayed,
    RegionMonitoringResponseDelayed,
    GeocodeFoundNoResult,
    GeocodeFoundPartialResult,
    GeocodeCanceled,
    DeferredFailed,
    DeferredNotUpdatingLocation,
    DeferredAccuracyTooLow,
    DeferredDistanceFiltered,
    DeferredCanceled,
    RangingUnavailable,
    RangingFailure
}

[StructLayout (LayoutKind.Sequential)]
public struct CLLocationCoordinate2D
{
    public double latitude;

    public double longitude;
}

[NoWatch, NoTV, iOS (7,0)]
[Native]
public enum CLRegionState : nint
{
    Unknown,
    Inside,
    Outside
}

[NoWatch, NoTV, iOS (7,0)]
[Native]
public enum CLProximity : nint
{
    Unknown,
    Immediate,
    Near,
    Far
}

public enum CLDeviceOrientation
{
    Unknown = 0,
    Portrait,
    PortraitUpsideDown,
    LandscapeLeft,
    LandscapeRight,
    FaceUp,
    FaceDown
}

public enum CLAuthorizationStatus
{
    NotDetermined = 0,
    Restricted,
    Denied,
    AuthorizedAlways,
    AuthorizedWhenInUse,
    Authorized = AuthorizedAlways
}

[Native]
public enum CLActivityType : nint
{
    Other = 1,
    AutomotiveNavigation,
    Fitness,
    OtherNavigation
}

[StructLayout (LayoutKind.Sequential)]
public struct CGPoint
{
    public nfloat x;

    public nfloat y;
}

[StructLayout (LayoutKind.Sequential)]
public struct CGSize
{
    public nfloat width;

    public nfloat height;
}

[StructLayout (LayoutKind.Sequential)]
public struct CGVector
{
    public nfloat dx;

    public nfloat dy;
}

[StructLayout (LayoutKind.Sequential)]
public struct CGRect
{
    public CGPoint origin;

    public CGSize size;
}

public enum CGRectEdge : uint
{
    inXEdge,
    inYEdge,
    axXEdge,
    axYEdge
}

[StructLayout (LayoutKind.Sequential)]
public struct CGAffineTransform
{
    public nfloat a;

    public nfloat b;

    public nfloat c;

    public nfloat d;

    public nfloat tx;

    public nfloat ty;
}

[StructLayout (LayoutKind.Sequential)]
public struct CGDataProviderSequentialCallbacks
{
    public uint version;

    public unsafe CGDataProviderGetBytesCallback* getBytes;

    public unsafe CGDataProviderSkipForwardCallback* skipForward;

    public unsafe CGDataProviderRewindCallback* rewind;

    public unsafe CGDataProviderReleaseInfoCallback* releaseInfo;
}

[StructLayout (LayoutKind.Sequential)]
public struct CGDataProviderDirectCallbacks
{
    public uint version;

    public unsafe CGDataProviderGetBytePointerCallback* getBytePointer;

    public unsafe CGDataProviderReleaseBytePointerCallback* releaseBytePointer;

    public unsafe CGDataProviderGetBytesAtPositionCallback* getBytesAtPosition;

    public unsafe CGDataProviderReleaseInfoCallback* releaseInfo;
}

public enum CGColorRenderingIntent
{
    Default,
    AbsoluteColorimetric,
    RelativeColorimetric,
    Perceptual,
    Saturation
}

public enum CGColorSpaceModel
{
    Unknown = -1,
    Monochrome,
    Rgb,
    Cmyk,
    Lab,
    DeviceN,
    Indexed,
    Pattern
}

public enum CGPatternTiling
{
    NoDistortion,
    ConstantSpacingMinimalDistortion,
    ConstantSpacing
}

[StructLayout (LayoutKind.Sequential)]
public struct CGPatternCallbacks
{
    public uint version;

    public unsafe CGPatternDrawPatternCallback* drawPattern;

    public unsafe CGPatternReleaseInfoCallback* releaseInfo;
}

public enum CGFontPostScriptFormat
{
    kCGFontPostScriptFormatType1 = 1,
    kCGFontPostScriptFormatType3 = 3,
    kCGFontPostScriptFormatType42 = 42
}

public enum CGGlyphDeprecatedEnum
{
    @in,
    ax
}

public enum CGGradientDrawingOptions : uint
{
    BeforeStartLocation = (1 << 0),
    AfterEndLocation = (1 << 1)
}

public enum CGImageAlphaInfo : uint
{
    None,
    PremultipliedLast,
    PremultipliedFirst,
    Last,
    First,
    NoneSkipLast,
    NoneSkipFirst,
    Only
}

[iOS (2,0)]
public enum CGImageByteOrderInfo : uint
{
    Mask = 28672,
    kCGImageByteOrder16Little = (1 << 12),
    kCGImageByteOrder32Little = (2 << 12),
    kCGImageByteOrder16Big = (3 << 12),
    kCGImageByteOrder32Big = (4 << 12)
}

[iOS (2,0)]
public enum CGBitmapInfo : uint
{
    AlphaInfoMask = 31,
    FloatInfoMask = 3840,
    FloatComponents = (1 << 8),
    ByteOrderMask = kCGImageByteOrderMask,
    ByteOrderDefault = (0 << 12),
    ByteOrder16Little = kCGImageByteOrder16Little,
    ByteOrder32Little = kCGImageByteOrder32Little,
    ByteOrder16Big = kCGImageByteOrder16Big,
    ByteOrder32Big = kCGImageByteOrder32Big
}

public enum CGLineJoin
{
    Miter,
    Round,
    Bevel
}

public enum CGLineCap
{
    Butt,
    Round,
    Square
}

public enum CGPathElementType
{
    MoveToPoint,
    AddLineToPoint,
    AddQuadCurveToPoint,
    AddCurveToPoint,
    CloseSubpath
}

[StructLayout (LayoutKind.Sequential)]
public struct CGPathElement
{
    public CGPathElementType type;

    public unsafe CGPoint* points;
}

public enum CGPDFObjectType
{
    Null = 1,
    Boolean,
    Integer,
    Real,
    Name,
    String,
    Array,
    Dictionary,
    Stream
}

public enum CGPDFDataFormat
{
    Raw,
    JPEGEncoded,
    Jpeg2000
}

public enum CGPDFBox
{
    MediaBox = 0,
    CropBox = 1,
    BleedBox = 2,
    TrimBox = 3,
    ArtBox = 4
}

public enum CGPDFAccessPermissions : uint
{
    LowQualityPrinting = (1 << 0),
    HighQualityPrinting = (1 << 1),
    DocumentChanges = (1 << 2),
    DocumentAssembly = (1 << 3),
    ContentCopying = (1 << 4),
    ContentAccessibility = (1 << 5),
    Commenting = (1 << 6),
    FormFieldEntry = (1 << 7)
}

[StructLayout (LayoutKind.Sequential)]
public struct CGFunctionCallbacks
{
    public uint version;

    public unsafe CGFunctionEvaluateCallback* evaluate;

    public unsafe CGFunctionReleaseInfoCallback* releaseInfo;
}

public enum CGPathDrawingMode
{
    Fill,
    EOFill,
    Stroke,
    FillStroke,
    EOFillStroke
}

public enum CGTextDrawingMode
{
    Fill,
    Stroke,
    FillStroke,
    Invisible,
    FillClip,
    StrokeClip,
    FillStrokeClip,
    Clip
}

[Introduced (PlatformName.iOS, 2, 0)]
[Deprecated (PlatformName.iOS, 7, 0)]
public enum CGTextEncoding
{
    FontSpecific,
    MacRoman
}

public enum CGInterpolationQuality
{
    Default = 0,
    None = 1,
    Low = 2,
    Medium = 4,
    High = 3
}

public enum CGBlendMode
{
    Normal,
    Multiply,
    Screen,
    Overlay,
    Darken,
    Lighten,
    ColorDodge,
    ColorBurn,
    SoftLight,
    HardLight,
    Difference,
    Exclusion,
    Hue,
    Saturation,
    Color,
    Luminosity,
    Clear,
    Copy,
    SourceIn,
    SourceOut,
    SourceAtop,
    DestinationOver,
    DestinationIn,
    DestinationOut,
    DestinationAtop,
    Xor,
    PlusDarker,
    PlusLighter
}

public enum CGColorConversionInfoTransformType : uint
{
    FromSpace = 0,
    ToSpace,
    ApplySpace
}

[StructLayout (LayoutKind.Sequential)]
public struct CGDataConsumerCallbacks
{
    public unsafe CGDataConsumerPutBytesCallback* putBytes;

    public unsafe CGDataConsumerReleaseInfoCallback* releaseConsumer;
}

public enum CGError
{
    Success = 0,
    Failure = 1000,
    IllegalArgument = 1001,
    InvalidConnection = 1002,
    InvalidContext = 1003,
    CannotComplete = 1004,
    NotImplemented = 1006,
    RangeCheck = 1007,
    TypeCheck = 1008,
    InvalidOperation = 1010,
    NoneAvailable = 1011
}

[Native]
public enum UIRectCorner : nuint
{
    TopLeft = 1 << 0,
    TopRight = 1 << 1,
    BottomLeft = 1 << 2,
    BottomRight = 1 << 3,
    AllCorners = ~0
}

[StructLayout (LayoutKind.Sequential)]
public struct CATransform3D
{
    public nfloat m11;

    public nfloat m12;

    public nfloat m13;

    public nfloat m14;

    public nfloat m21;

    public nfloat m22;

    public nfloat m23;

    public nfloat m24;

    public nfloat m31;

    public nfloat m32;

    public nfloat m33;

    public nfloat m34;

    public nfloat m41;

    public nfloat m42;

    public nfloat m43;

    public nfloat m44;
}

public enum CAEdgeAntialiasingMask : uint
{
    LeftEdge = 1 << 0,
    RightEdge = 1 << 1,
    BottomEdge = 1 << 2,
    TopEdge = 1 << 3
}

[Native]
public enum CACornerMask : nuint
{
    inXMinYCorner = 1 << 0,
    axXMinYCorner = 1 << 1,
    inXMaxYCorner = 1 << 2,
    axXMaxYCorner = 1 << 3
}

[StructLayout (LayoutKind.Sequential)]
public struct _CALayerIvars
{
    public int refcount;

    public uint magic;

    public unsafe void* layer;
}

[Native]
public enum EAGLRenderingAPI : nuint
{
    kEAGLRenderingAPIOpenGLES1 = 1,
    kEAGLRenderingAPIOpenGLES2 = 2,
    kEAGLRenderingAPIOpenGLES3 = 3
}

[iOS (8,0)]
[Native]
public enum MTLPixelFormat : nuint
{
    Invalid = 0,
    A8Unorm = 1,
    R8Unorm = 10,
    R8Unorm_sRGB = 11,
    R8Snorm = 12,
    R8Uint = 13,
    R8Sint = 14,
    R16Unorm = 20,
    R16Snorm = 22,
    R16Uint = 23,
    R16Sint = 24,
    R16Float = 25,
    RG8Unorm = 30,
    RG8Unorm_sRGB = 31,
    RG8Snorm = 32,
    RG8Uint = 33,
    RG8Sint = 34,
    B5G6R5Unorm = 40,
    A1BGR5Unorm = 41,
    ABGR4Unorm = 42,
    BGR5A1Unorm = 43,
    R32Uint = 53,
    R32Sint = 54,
    R32Float = 55,
    RG16Unorm = 60,
    RG16Snorm = 62,
    RG16Uint = 63,
    RG16Sint = 64,
    RG16Float = 65,
    RGBA8Unorm = 70,
    RGBA8Unorm_sRGB = 71,
    RGBA8Snorm = 72,
    RGBA8Uint = 73,
    RGBA8Sint = 74,
    BGRA8Unorm = 80,
    BGRA8Unorm_sRGB = 81,
    RGB10A2Unorm = 90,
    RGB10A2Uint = 91,
    RG11B10Float = 92,
    RGB9E5Float = 93,
    BGR10A2Unorm = 94,
    Bgr10Xr = 554,
    BGR10_XR_sRGB = 555,
    RG32Uint = 103,
    RG32Sint = 104,
    RG32Float = 105,
    RGBA16Unorm = 110,
    RGBA16Snorm = 112,
    RGBA16Uint = 113,
    RGBA16Sint = 114,
    RGBA16Float = 115,
    Bgra10Xr = 552,
    BGRA10_XR_sRGB = 553,
    RGBA32Uint = 123,
    RGBA32Sint = 124,
    RGBA32Float = 125,
    Bc1Rgba = 130,
    BC1_RGBA_sRGB = 131,
    Bc2Rgba = 132,
    BC2_RGBA_sRGB = 133,
    Bc3Rgba = 134,
    BC3_RGBA_sRGB = 135,
    BC4_RUnorm = 140,
    BC4_RSnorm = 141,
    BC5_RGUnorm = 142,
    BC5_RGSnorm = 143,
    BC6H_RGBFloat = 150,
    BC6H_RGBUfloat = 151,
    BC7_RGBAUnorm = 152,
    BC7_RGBAUnorm_sRGB = 153,
    PvrtcRgb2bpp = 160,
    PVRTC_RGB_2BPP_sRGB = 161,
    PvrtcRgb4bpp = 162,
    PVRTC_RGB_4BPP_sRGB = 163,
    PvrtcRgba2bpp = 164,
    PVRTC_RGBA_2BPP_sRGB = 165,
    PvrtcRgba4bpp = 166,
    PVRTC_RGBA_4BPP_sRGB = 167,
    EAC_R11Unorm = 170,
    EAC_R11Snorm = 172,
    EAC_RG11Unorm = 174,
    EAC_RG11Snorm = 176,
    EacRgba8 = 178,
    EAC_RGBA8_sRGB = 179,
    Etc2Rgb8 = 180,
    ETC2_RGB8_sRGB = 181,
    Etc2Rgb8a1 = 182,
    ETC2_RGB8A1_sRGB = 183,
    ASTC_4x4_sRGB = 186,
    ASTC_5x4_sRGB = 187,
    ASTC_5x5_sRGB = 188,
    ASTC_6x5_sRGB = 189,
    ASTC_6x6_sRGB = 190,
    ASTC_8x5_sRGB = 192,
    ASTC_8x6_sRGB = 193,
    ASTC_8x8_sRGB = 194,
    ASTC_10x5_sRGB = 195,
    ASTC_10x6_sRGB = 196,
    ASTC_10x8_sRGB = 197,
    ASTC_10x10_sRGB = 198,
    ASTC_12x10_sRGB = 199,
    ASTC_12x12_sRGB = 200,
    ASTC_4x4_LDR = 204,
    ASTC_5x4_LDR = 205,
    ASTC_5x5_LDR = 206,
    ASTC_6x5_LDR = 207,
    ASTC_6x6_LDR = 208,
    ASTC_8x5_LDR = 210,
    ASTC_8x6_LDR = 211,
    ASTC_8x8_LDR = 212,
    ASTC_10x5_LDR = 213,
    ASTC_10x6_LDR = 214,
    ASTC_10x8_LDR = 215,
    ASTC_10x10_LDR = 216,
    ASTC_12x10_LDR = 217,
    ASTC_12x12_LDR = 218,
    Gbgr422 = 240,
    Bgrg422 = 241,
    Depth16Unorm = 250,
    Depth32Float = 252,
    Stencil8 = 253,
    Depth24Unorm_Stencil8 = 255,
    Depth32Float_Stencil8 = 260,
    X32_Stencil8 = 261,
    X24_Stencil8 = 262
}

[Native]
public enum UIEventType : nint
{
    Touches,
    Motion,
    RemoteControl,
    Presses
}

[Native]
public enum UIEventSubtype : nint
{
    None = 0,
    MotionShake = 1,
    RemoteControlPlay = 100,
    RemoteControlPause = 101,
    RemoteControlStop = 102,
    RemoteControlTogglePlayPause = 103,
    RemoteControlNextTrack = 104,
    RemoteControlPreviousTrack = 105,
    RemoteControlBeginSeekingBackward = 106,
    RemoteControlEndSeekingBackward = 107,
    RemoteControlBeginSeekingForward = 108,
    RemoteControlEndSeekingForward = 109
}

[iOS (7,0)]
[Native]
public enum UIKeyModifierFlags : nint
{
    AlphaShift = 1 << 16,
    Shift = 1 << 17,
    Control = 1 << 18,
    Alternate = 1 << 19,
    Command = 1 << 20,
    NumericPad = 1 << 21
}


[StructLayout (LayoutKind.Sequential)]
public struct CVSMPTETime
{
    public short subframes;

    public short subframeDivisor;

    public uint counter;

    public uint type;

    public uint flags;

    public short hours;

    public short minutes;

    public short seconds;

    public short frames;
}

public enum CVSMPTETimeType : uint
{
    kCVSMPTETimeType24 = 0,
    kCVSMPTETimeType25 = 1,
    kCVSMPTETimeType30Drop = 2,
    kCVSMPTETimeType30 = 3,
    kCVSMPTETimeType2997 = 4,
    kCVSMPTETimeType2997Drop = 5,
    kCVSMPTETimeType60 = 6,
    kCVSMPTETimeType5994 = 7
}

public enum CVSMPTETimeFlags : uint
{
    Valid = (1 << 0),
    Running = (1 << 1)
}

public enum CVTimeFlags
{
    CVTimeIsIndefinite = 1 << 0
}

[StructLayout (LayoutKind.Sequential)]
public struct CVTime
{
    public long timeValue;

    public int timeScale;

    public int flags;
}

[StructLayout (LayoutKind.Sequential)]
public struct CVTimeStamp
{
    public uint version;

    public int videoTimeScale;

    public long videoTime;

    public ulong hostTime;

    public double rateScalar;

    public long videoRefreshPeriod;

    public CVSMPTETime smpteTime;

    public ulong flags;

    public ulong reserved;
}

public enum CVTimeStampFlags : ulong
{
    VideoTimeValid = (1 << 0),
    HostTimeValid = (1 << 1),
    SMPTETimeValid = (1 << 2),
    VideoRefreshPeriodValid = (1 << 3),
    RateScalarValid = (1 << 4),
    TopField = (1 << 16),
    BottomField = (1 << 17),
    VideoHostTimeValid = (VideoTimeValid | HostTimeValid),
    IsInterlaced = (TopField | BottomField)
}

[Verify (InferredFromMemberPrefix)]
public enum kCVReturn
{
    Success = 0,
    First = -6660,
    Error = First,
    InvalidArgument = -6661,
    AllocationFailed = -6662,
    Unsupported = -6663,
    InvalidDisplay = -6670,
    DisplayLinkAlreadyRunning = -6671,
    DisplayLinkNotRunning = -6672,
    DisplayLinkCallbacksNotSet = -6673,
    InvalidPixelFormat = -6680,
    InvalidSize = -6681,
    InvalidPixelBufferAttributes = -6682,
    PixelBufferNotOpenGLCompatible = -6683,
    PixelBufferNotMetalCompatible = -6684,
    WouldExceedAllocationThreshold = -6689,
    PoolAllocationFailed = -6690,
    InvalidPoolAttributes = -6691,
    Retry = -6692,
    Last = -6699
}

public enum CVAttachmentMode : uint
{
    NotPropagate = 0,
    Propagate = 1
}

[Verify (InferredFromMemberPrefix)]
public enum kCVPixelFormatType_ : uint
{
    kCVPixelFormatType_1Monochrome = 1,
    kCVPixelFormatType_2Indexed = 2,
    kCVPixelFormatType_4Indexed = 4,
    kCVPixelFormatType_8Indexed = 8,
    kCVPixelFormatType_1IndexedGray_WhiteIsZero = 33,
    kCVPixelFormatType_2IndexedGray_WhiteIsZero = 34,
    kCVPixelFormatType_4IndexedGray_WhiteIsZero = 36,
    kCVPixelFormatType_8IndexedGray_WhiteIsZero = 40,
    kCVPixelFormatType_16BE555 = 16,
    kCVPixelFormatType_16LE555 = 1278555445,
    kCVPixelFormatType_16LE5551 = 892679473,
    kCVPixelFormatType_16BE565 = 1110783541,
    kCVPixelFormatType_16LE565 = 1278555701,
    kCVPixelFormatType_24RGB = 24,
    kCVPixelFormatType_24BGR = 842285639,
    kCVPixelFormatType_32ARGB = 32,
    kCVPixelFormatType_32BGRA = 1111970369,
    kCVPixelFormatType_32ABGR = 1094862674,
    kCVPixelFormatType_32RGBA = 1380401729,
    kCVPixelFormatType_64ARGB = 1647719521,
    kCVPixelFormatType_48RGB = 1647589490,
    kCVPixelFormatType_32AlphaGray = 1647522401,
    kCVPixelFormatType_16Gray = 1647392359,
    kCVPixelFormatType_30RGB = 1378955371,
    kCVPixelFormatType_422YpCbCr8 = 846624121,
    kCVPixelFormatType_4444YpCbCrA8 = 1983131704,
    kCVPixelFormatType_4444YpCbCrA8R = 1916022840,
    kCVPixelFormatType_4444AYpCbCr8 = 2033463352,
    kCVPixelFormatType_4444AYpCbCr16 = 2033463606,
    kCVPixelFormatType_444YpCbCr8 = 1983066168,
    kCVPixelFormatType_422YpCbCr16 = 1983000886,
    kCVPixelFormatType_422YpCbCr10 = 1983000880,
    kCVPixelFormatType_444YpCbCr10 = 1983131952,
    kCVPixelFormatType_420YpCbCr8Planar = 2033463856,
    kCVPixelFormatType_420YpCbCr8PlanarFullRange = 1714696752,
    kCVPixelFormatType_422YpCbCr_4A_8BiPlanar = 1630697081,
    kCVPixelFormatType_420YpCbCr8BiPlanarVideoRange = 875704438,
    kCVPixelFormatType_420YpCbCr8BiPlanarFullRange = 875704422,
    kCVPixelFormatType_422YpCbCr8_yuvs = 2037741171,
    kCVPixelFormatType_422YpCbCr8FullRange = 2037741158,
    OneComponent8 = 1278226488,
    TwoComponent8 = 843264056,
    kCVPixelFormatType_30RGBLEPackedWideGamut = 1999843442,
    ARGB2101010LEPacked = 1815162994,
    OneComponent16Half = 1278226536,
    OneComponent32Float = 1278226534,
    TwoComponent16Half = 843264104,
    TwoComponent32Float = 843264102,
    kCVPixelFormatType_64RGBAHalf = 1380411457,
    kCVPixelFormatType_128RGBAFloat = 1380410945,
    kCVPixelFormatType_14Bayer_GRBG = 1735549492,
    kCVPixelFormatType_14Bayer_RGGB = 1919379252,
    kCVPixelFormatType_14Bayer_BGGR = 1650943796,
    kCVPixelFormatType_14Bayer_GBRG = 1734505012,
    DisparityFloat16 = 1751411059,
    DisparityFloat32 = 1717856627,
    DepthFloat16 = 1751410032,
    DepthFloat32 = 1717855600,
    kCVPixelFormatType_420YpCbCr10BiPlanarVideoRange = 2016686640,
    kCVPixelFormatType_422YpCbCr10BiPlanarVideoRange = 2016686642,
    kCVPixelFormatType_444YpCbCr10BiPlanarVideoRange = 2016687156,
    kCVPixelFormatType_420YpCbCr10BiPlanarFullRange = 2019963440,
    kCVPixelFormatType_422YpCbCr10BiPlanarFullRange = 2019963442,
    kCVPixelFormatType_444YpCbCr10BiPlanarFullRange = 2019963956
}

public enum CVPixelBufferLockFlags : ulong
{
    CVPixelBufferLock_ReadOnly = 1
}

[StructLayout (LayoutKind.Sequential)]
public struct CVPlanarComponentInfo
{
    public int offset;

    public uint rowBytes;
}

[StructLayout (LayoutKind.Sequential)]
public struct CVPlanarPixelBufferInfo
{
    public CVPlanarComponentInfo[] componentInfo;
}

[StructLayout (LayoutKind.Sequential)]
public struct CVPlanarPixelBufferInfo_YCbCrPlanar
{
    public CVPlanarComponentInfo componentInfoY;

    public CVPlanarComponentInfo componentInfoCb;

    public CVPlanarComponentInfo componentInfoCr;
}

[StructLayout (LayoutKind.Sequential)]
public struct CVPlanarPixelBufferInfo_YCbCrBiPlanar
{
    public CVPlanarComponentInfo componentInfoY;

    public CVPlanarComponentInfo componentInfoCbCr;
}

public enum IOSurfaceLockOptions : uint
{
    ReadOnly = 1,
    AvoidSync = 2
}

public enum IOSurfacePurgeabilityState : uint
{
    NonVolatile = 0,
    Volatile = 1,
    Empty = 2,
    KeepCurrent = 3
}

[Verify (InferredFromMemberPrefix)]
public enum kIOSurface : uint
{
    DefaultCache = 0,
    InhibitCache = 1,
    WriteThruCache = 2,
    CopybackCache = 3,
    WriteCombineCache = 4,
    CopybackInnerCache = 5
}

[Verify (InferredFromMemberPrefix)]
public enum kIOSurfaceMap : uint
{
    CacheShift = 8,
    DefaultCache = kIOSurfaceDefaultCache << CacheShift,
    InhibitCache = kIOSurfaceInhibitCache << CacheShift,
    WriteThruCache = kIOSurfaceWriteThruCache << CacheShift,
    CopybackCache = kIOSurfaceCopybackCache << CacheShift,
    WriteCombineCache = kIOSurfaceWriteCombineCache << CacheShift,
    CopybackInnerCache = kIOSurfaceCopybackInnerCache << CacheShift
}

public enum IOSurfaceComponentName
{
    Unknown = 0,
    Alpha = 1,
    Red = 2,
    Green = 3,
    Blue = 4,
    Luma = 5,
    ChromaRed = 6,
    ChromaBlue = 7
}

public enum IOSurfaceComponentType
{
    Unknown = 0,
    UnsignedInteger = 1,
    SignedInteger = 2,
    Float = 3
}

public enum IOSurfaceComponentRange
{
    Unknown = 0,
    FullRange = 1,
    VideoRange = 2,
    WideRange = 3
}

public enum IOSurfaceSubsampling
{
    Unknown = 0,
    None = 1,
    kIOSurfaceSubsampling422 = 2,
    kIOSurfaceSubsampling420 = 3,
    kIOSurfaceSubsampling411 = 4
}

public enum CVPixelBufferPoolFlushFlags : ulong
{
    CVPixelBufferPoolFlushExcessBuffers = 1
}

[StructLayout (LayoutKind.Sequential)]
public struct CVFillExtendedPixelsCallBackData
{
    public nint version;

    public unsafe CVFillExtendedPixelsCallBack* fillCallBack;

    public unsafe void* refCon;
}

public enum CGImageMetadataType
{
    Invalid = -1,
    Default = 0,
    String = 1,
    ArrayUnordered = 2,
    ArrayOrdered = 3,
    AlternateArray = 4,
    AlternateText = 5,
    Structure = 6
}

public enum CGImageMetadataErrors
{
    Unknown = 0,
    UnsupportedFormat = 1,
    BadArgument = 2,
    ConflictingArguments = 3,
    PrefixConflict = 4
}

public enum CGImageSourceStatus
{
    UnexpectedEOF = -5,
    InvalidData = -4,
    UnknownType = -3,
    ReadingHeader = -2,
    Incomplete = -1,
    Complete = 0
}

public enum CGImagePropertyOrientation : uint
{
    Up = 1,
    UpMirrored,
    Down,
    DownMirrored,
    LeftMirrored,
    Right,
    RightMirrored,
    Left
}

[Native]
public enum CIRenderDestinationAlphaMode : nuint
{
    None = 0,
    Premultiplied = 1,
    Unpremultiplied = 2
}

[Native]
public enum CIQRCodeErrorCorrectionLevel : nint
{
    L = 76,
    M = 77,
    Q = 81,
    H = 72
}

[Native]
public enum CIDataMatrixCodeECCVersion : nint
{
    CIDataMatrixCodeECCVersion000 = 0,
    CIDataMatrixCodeECCVersion050 = 50,
    CIDataMatrixCodeECCVersion080 = 80,
    CIDataMatrixCodeECCVersion100 = 100,
    CIDataMatrixCodeECCVersion140 = 140,
    CIDataMatrixCodeECCVersion200 = 200
}

[iOS (7,0)]
public enum UIFontDescriptorSymbolicTraits : uint
{
    TraitItalic = 1 << 0,
    TraitBold = 1 << 1,
    TraitExpanded = 1 << 5,
    TraitCondensed = 1 << 6,
    TraitMonoSpace = 1 << 10,
    TraitVertical = 1 << 11,
    TraitUIOptimized = 1 << 12,
    TraitTightLeading = 1 << 15,
    TraitLooseLeading = 1 << 16,
    ClassMask = 4026531840u,
    ClassUnknown = 0 << 28,
    ClassOldStyleSerifs = 1 << 28,
    ClassTransitionalSerifs = 2 << 28,
    ClassModernSerifs = 3 << 28,
    ClassClarendonSerifs = 4 << 28,
    ClassSlabSerifs = 5 << 28,
    ClassFreeformSerifs = 7 << 28,
    ClassSansSerif = 8 << 28,
    ClassOrnamentals = 9 << 28,
    ClassScripts = 10 << 28,
    ClassSymbolic = 12 << 28
}

[NoTV]
[Native]
public enum UIBarStyle : nint
{
    Default = 0,
    Black = 1,
    BlackOpaque = 1,
    BlackTranslucent = 2
}

[iOS (8,0)]
[Native]
public enum UIUserInterfaceSizeClass : nint
{
    Unspecified = 0,
    Compact = 1,
    Regular = 2
}

[TV (10,0), NoWatch, NoiOS]
[Native]
public enum UIUserInterfaceStyle : nint
{
    Unspecified,
    Light,
    Dark
}

[iOS (5,0)]
[Native]
public enum UIUserInterfaceLayoutDirection : nint
{
    LeftToRight,
    RightToLeft
}

[iOS (10,0)]
[Native]
public enum UITraitEnvironmentLayoutDirection : nint
{
    Unspecified = -1,
    LeftToRight = UIUserInterfaceLayoutDirectionLeftToRight,
    RightToLeft = UIUserInterfaceLayoutDirectionRightToLeft
}

[iOS (10,0)]
[Native]
public enum UIDisplayGamut : nint
{
    Unspecified = -1,
    Srgb,
    P3
}

[StructLayout (LayoutKind.Sequential)]
public struct UIEdgeInsets
{
    public nfloat top;

    public nfloat left;

    public nfloat bottom;

    public nfloat right;
}

[StructLayout (LayoutKind.Sequential)]
public struct NSDirectionalEdgeInsets
{
    public nfloat top;

    public nfloat leading;

    public nfloat bottom;

    public nfloat trailing;
}

[StructLayout (LayoutKind.Sequential)]
public struct UIOffset
{
    public nfloat horizontal;

    public nfloat vertical;
}

[iOS (7,0)]
[Native]
public enum UIRectEdge : nuint
{
    None = 0,
    Top = 1 << 0,
    Left = 1 << 1,
    Bottom = 1 << 2,
    Right = 1 << 3,
    All = Top | Left | Bottom | Right
}

[iOS (9,0)]
[Native]
public enum UIDynamicItemCollisionBoundsType : nuint
{
    Rectangle,
    Ellipse,
    Path
}

[Native]
public enum NSLayoutRelation : nint
{
    LessThanOrEqual = -1,
    Equal = 0,
    GreaterThanOrEqual = 1
}

[Native]
public enum NSLayoutAttribute : nint
{
    Left = 1,
    Right,
    Top,
    Bottom,
    Leading,
    Trailing,
    Width,
    Height,
    CenterX,
    CenterY,
    LastBaseline,
    Baseline = LastBaseline,
    FirstBaseline,
    LeftMargin,
    RightMargin,
    TopMargin,
    BottomMargin,
    LeadingMargin,
    TrailingMargin,
    CenterXWithinMargins,
    CenterYWithinMargins,
    NotAnAttribute = 0
}

[Native]
public enum NSLayoutFormatOptions : nuint
{
    AlignAllLeft = (1 << NSLayoutAttributeLeft),
    AlignAllRight = (1 << NSLayoutAttributeRight),
    AlignAllTop = (1 << NSLayoutAttributeTop),
    AlignAllBottom = (1 << NSLayoutAttributeBottom),
    AlignAllLeading = (1 << NSLayoutAttributeLeading),
    AlignAllTrailing = (1 << NSLayoutAttributeTrailing),
    AlignAllCenterX = (1 << NSLayoutAttributeCenterX),
    AlignAllCenterY = (1 << NSLayoutAttributeCenterY),
    AlignAllLastBaseline = (1 << NSLayoutAttributeLastBaseline),
    AlignAllBaseline = AlignAllLastBaseline,
    AlignAllFirstBaseline = (1 << NSLayoutAttributeFirstBaseline),
    AlignmentMask = 65535,
    DirectionLeadingToTrailing = 0 << 16,
    DirectionLeftToRight = 1 << 16,
    DirectionRightToLeft = 2 << 16,
    DirectionMask = 3 << 16,
    SpacingEdgeToEdge = 0 << 19,
    SpacingBaselineToBaseline = 1 << 19,
    SpacingMask = 1 << 19
}

[NoTV]
[Native]
public enum UIDeviceOrientation : nint
{
    Unknown,
    Portrait,
    PortraitUpsideDown,
    LandscapeLeft,
    LandscapeRight,
    FaceUp,
    FaceDown
}

[NoTV]
[Native]
public enum UIDeviceBatteryState : nint
{
    Unknown,
    Unplugged,
    Charging,
    Full
}

[Native]
public enum UIUserInterfaceIdiom : nint
{
    Unspecified = -1,
    Phone,
    Pad,
    Tv,
    CarPlay
}

[Native]
public enum UITouchPhase : nint
{
    Began,
    Moved,
    Stationary,
    Ended,
    Cancelled
}

[Native]
public enum UIForceTouchCapability : nint
{
    Unknown = 0,
    Unavailable = 1,
    Available = 2
}

[iOS (9,0)]
[Native]
public enum UITouchType : nint
{
    Direct,
    Indirect,
    Stylus
}

[iOS (9,1)]
[Native]
public enum UITouchProperties : nint
{
    Force = (1 << 0),
    Azimuth = (1 << 1),
    Altitude = (1 << 2),
    Location = (1 << 3)
}

[iOS (9,0)]
[Native]
public enum UIFocusHeading : nuint
{
    None = 0,
    Up = 1 << 0,
    Down = 1 << 1,
    Left = 1 << 2,
    Right = 1 << 3,
    Next = 1 << 4,
    Previous = 1 << 5
}

[Native]
public enum UIViewAnimationCurve : nint
{
    EaseInOut,
    EaseIn,
    EaseOut,
    Linear
}

[Native]
public enum UIViewContentMode : nint
{
    ScaleToFill,
    ScaleAspectFit,
    ScaleAspectFill,
    Redraw,
    Center,
    Top,
    Bottom,
    Left,
    Right,
    TopLeft,
    TopRight,
    BottomLeft,
    BottomRight
}

[Native]
public enum UIViewAnimationTransition : nint
{
    None,
    FlipFromLeft,
    FlipFromRight,
    CurlUp,
    CurlDown
}

[Native]
public enum UIViewAutoresizing : nuint
{
    None = 0,
    FlexibleLeftMargin = 1 << 0,
    FlexibleWidth = 1 << 1,
    FlexibleRightMargin = 1 << 2,
    FlexibleTopMargin = 1 << 3,
    FlexibleHeight = 1 << 4,
    FlexibleBottomMargin = 1 << 5
}

[iOS (4,0)]
[Native]
public enum UIViewAnimationOptions : nuint
{
    LayoutSubviews = 1 << 0,
    AllowUserInteraction = 1 << 1,
    BeginFromCurrentState = 1 << 2,
    Repeat = 1 << 3,
    Autoreverse = 1 << 4,
    OverrideInheritedDuration = 1 << 5,
    OverrideInheritedCurve = 1 << 6,
    AllowAnimatedContent = 1 << 7,
    ShowHideTransitionViews = 1 << 8,
    OverrideInheritedOptions = 1 << 9,
    CurveEaseInOut = 0 << 16,
    CurveEaseIn = 1 << 16,
    CurveEaseOut = 2 << 16,
    CurveLinear = 3 << 16,
    TransitionNone = 0 << 20,
    TransitionFlipFromLeft = 1 << 20,
    TransitionFlipFromRight = 2 << 20,
    TransitionCurlUp = 3 << 20,
    TransitionCurlDown = 4 << 20,
    TransitionCrossDissolve = 5 << 20,
    TransitionFlipFromTop = 6 << 20,
    TransitionFlipFromBottom = 7 << 20,
    PreferredFramesPerSecondDefault = 0 << 24,
    PreferredFramesPerSecond60 = 3 << 24,
    PreferredFramesPerSecond30 = 7 << 24
}

[iOS (7,0)]
[Native]
public enum UIViewKeyframeAnimationOptions : nuint
{
    LayoutSubviews = UIViewAnimationOptionLayoutSubviews,
    AllowUserInteraction = UIViewAnimationOptionAllowUserInteraction,
    BeginFromCurrentState = UIViewAnimationOptionBeginFromCurrentState,
    Repeat = UIViewAnimationOptionRepeat,
    Autoreverse = UIViewAnimationOptionAutoreverse,
    OverrideInheritedDuration = UIViewAnimationOptionOverrideInheritedDuration,
    OverrideInheritedOptions = UIViewAnimationOptionOverrideInheritedOptions,
    CalculationModeLinear = 0 << 10,
    CalculationModeDiscrete = 1 << 10,
    CalculationModePaced = 2 << 10,
    CalculationModeCubic = 3 << 10,
    CalculationModeCubicPaced = 4 << 10
}

[iOS (7,0)]
[Native]
public enum UISystemAnimation : nuint
{
    UISystemAnimationDelete
}

[iOS (7,0)]
[Native]
public enum UIViewTintAdjustmentMode : nint
{
    Automatic,
    Normal,
    Dimmed
}

[iOS (9,0)]
[Native]
public enum UISemanticContentAttribute : nint
{
    Unspecified = 0,
    Playback,
    Spatial,
    ForceLeftToRight,
    ForceRightToLeft
}

[Native]
public enum UILayoutConstraintAxis : nint
{
    Horizontal = 0,
    Vertical = 1
}

[Native]
public enum UIControlEvents : nuint
{
    TouchDown = 1 << 0,
    TouchDownRepeat = 1 << 1,
    TouchDragInside = 1 << 2,
    TouchDragOutside = 1 << 3,
    TouchDragEnter = 1 << 4,
    TouchDragExit = 1 << 5,
    TouchUpInside = 1 << 6,
    TouchUpOutside = 1 << 7,
    TouchCancel = 1 << 8,
    ValueChanged = 1 << 12,
    PrimaryActionTriggered = 1 << 13,
    EditingDidBegin = 1 << 16,
    EditingChanged = 1 << 17,
    EditingDidEnd = 1 << 18,
    EditingDidEndOnExit = 1 << 19,
    AllTouchEvents = 4095,
    AllEditingEvents = 983040,
    ApplicationReserved = 251658240,
    SystemReserved = 4026531840L,
    AllEvents = 4294967295L
}

[Native]
public enum UIControlContentVerticalAlignment : nint
{
    Center = 0,
    Top = 1,
    Bottom = 2,
    Fill = 3
}

[Native]
public enum UIControlContentHorizontalAlignment : nint
{
    Center = 0,
    Left = 1,
    Right = 2,
    Fill = 3,
    Leading = 4,
    Trailing = 5
}

[Native]
public enum UIControlState : nuint
{
    Normal = 0,
    Highlighted = 1 << 0,
    Disabled = 1 << 1,
    Selected = 1 << 2,
    Focused = 1 << 3,
    Application = 16711680,
    Reserved = 4278190080L
}

[Native]
public enum UIScrollViewIndicatorStyle : nint
{
    Default,
    Black,
    White
}

[iOS (7,0)]
[Native]
public enum UIScrollViewKeyboardDismissMode : nint
{
    None,
    OnDrag,
    Interactive
}

[TV (10,2)]
[Native]
public enum UIScrollViewIndexDisplayMode : nint
{
    utomatic,
    lwaysHidden
}

[TV (11,0), iOS (11,0)]
[Native]
public enum UIScrollViewContentInsetAdjustmentBehavior : nint
{
    Automatic,
    ScrollableAxes,
    Never,
    Always
}

[iOS (8,0)]
[Native]
public enum UIAccessibilityNavigationStyle : nint
{
    Automatic = 0,
    Separate = 1,
    Combined = 2
}

[iOS (11,0)]
[Native]
public enum UIAccessibilityContainerType : nint
{
    None = 0,
    DataTable,
    List,
    Landmark
}

[Native]
public enum UITextAutocapitalizationType : nint
{
    None,
    Words,
    Sentences,
    AllCharacters
}

[Native]
public enum UITextAutocorrectionType : nint
{
    Default,
    No,
    Yes
}

[iOS (5,0)]
[Native]
public enum UITextSpellCheckingType : nint
{
    Default,
    No,
    Yes
}

[iOS (11,0)]
[Native]
public enum UITextSmartQuotesType : nint
{
    Default,
    No,
    Yes
}

[iOS (11,0)]
[Native]
public enum UITextSmartDashesType : nint
{
    Default,
    No,
    Yes
}

[iOS (11,0)]
[Native]
public enum UITextSmartInsertDeleteType : nint
{
    Default,
    No,
    Yes
}

[Native]
public enum UIKeyboardType : nint
{
    Default,
    ASCIICapable,
    NumbersAndPunctuation,
    Url,
    NumberPad,
    PhonePad,
    NamePhonePad,
    EmailAddress,
    DecimalPad,
    Twitter,
    WebSearch,
    ASCIICapableNumberPad,
    Alphabet = ASCIICapable
}

[Native]
public enum UIKeyboardAppearance : nint
{
    Default,
    Dark,
    Light,
    Alert = Dark
}

[Native]
public enum UIReturnKeyType : nint
{
    Default,
    Go,
    Google,
    Join,
    Next,
    Route,
    Search,
    Send,
    Yahoo,
    Done,
    EmergencyCall,
    Continue
}

[Native]
public enum UITextStorageDirection : nint
{
    Forward = 0,
    Backward
}

[Native]
public enum UITextLayoutDirection : nint
{
    Right = 2,
    Left,
    Up,
    Down
}

[Native]
public enum UITextWritingDirection : nint
{
    Natural = -1,
    LeftToRight = 0,
    RightToLeft
}

[Native]
public enum UITextGranularity : nint
{
    Character,
    Word,
    Sentence,
    Paragraph,
    Line,
    Document
}

[Native]
public enum UIAccessibilityCustomRotorDirection : nint
{
    Previous,
    Next
}

[iOS (11,0)]
[Native]
public enum UIAccessibilityCustomSystemRotorType : nint
{
    None = 0,
    Link,
    VisitedLink,
    Heading,
    HeadingLevel1,
    HeadingLevel2,
    HeadingLevel3,
    HeadingLevel4,
    HeadingLevel5,
    HeadingLevel6,
    BoldText,
    ItalicText,
    UnderlineText,
    MisspelledWord,
    Image,
    TextField,
    Table,
    List,
    Landmark
}

[Native]
public enum UIPreferredPresentationStyle : nint
{
    Unspecified = 0,
    Inline,
    Attachment
}

[Native]
public enum UIImageOrientation : nint
{
    Up,
    Down,
    Left,
    Right,
    UpMirrored,
    DownMirrored,
    LeftMirrored,
    RightMirrored
}

[Native]
public enum UIImageResizingMode : nint
{
    Tile,
    Stretch
}

[iOS (7,0)]
[Native]
public enum UIImageRenderingMode : nint
{
    utomatic,
    lwaysOriginal,
    lwaysTemplate
}

[iOS (5,0)]
[Native]
public enum UIAccessibilityZoomType : nint
{
    UIAccessibilityZoomTypeInsertionPoint
}

[Native]
public enum UIGuidedAccessRestrictionState : nint
{
    Allow,
    Deny
}

[Native]
public enum UIAccessibilityScrollDirection : nint
{
    Right = 1,
    Left,
    Up,
    Down,
    Next,
    Previous
}

[NoTV, iOS (10,0)]
[Native]
public enum UIAccessibilityHearingDeviceEar : nuint
{
    None = 0,
    Left = 1 << 1,
    Right = 1 << 2,
    Both = Left | Right
}

public enum CTTextAlignment : byte
{
    TextAlignmentLeft = 0,
    TextAlignmentRight = 1,
    TextAlignmentCenter = 2,
    TextAlignmentJustified = 3,
    TextAlignmentNatural = 4,
    LeftTextAlignment = TextAlignmentLeft,
    RightTextAlignment = TextAlignmentRight,
    CenterTextAlignment = TextAlignmentCenter,
    JustifiedTextAlignment = TextAlignmentJustified,
    NaturalTextAlignment = TextAlignmentNatural
}

public enum CTLineBreakMode : byte
{
    WordWrapping = 0,
    CharWrapping = 1,
    Clipping = 2,
    TruncatingHead = 3,
    TruncatingTail = 4,
    TruncatingMiddle = 5
}

public enum CTWritingDirection : sbyte
{
    Natural = -1,
    LeftToRight = 0,
    RightToLeft = 1
}

public enum CTParagraphStyleSpecifier : uint
{
    Alignment = 0,
    FirstLineHeadIndent = 1,
    HeadIndent = 2,
    TailIndent = 3,
    TabStops = 4,
    DefaultTabInterval = 5,
    LineBreakMode = 6,
    LineHeightMultiple = 7,
    MaximumLineHeight = 8,
    MinimumLineHeight = 9,
    LineSpacing = 10,
    ParagraphSpacing = 11,
    ParagraphSpacingBefore = 12,
    BaseWritingDirection = 13,
    MaximumLineSpacing = 14,
    MinimumLineSpacing = 15,
    LineSpacingAdjustment = 16,
    LineBoundsOptions = 17,
    Count
}

[StructLayout (LayoutKind.Sequential)]
public struct CTParagraphStyleSetting
{
    public CTParagraphStyleSpecifier spec;

    public nuint valueSize;

    public unsafe void* value;
}

[iOS (6,0)]
[Native]
public enum NSTextAlignment : nint
{
    Left = 0,
    Center = 1,
    Right = 2,
    Justified = 3,
    Natural = 4
}

[iOS (6,0)]
[Native]
public enum NSWritingDirection : nint
{
    Natural = -1,
    LeftToRight = 0,
    RightToLeft = 1
}

[iOS (6,0)]
[Native]
public enum NSLineBreakMode : nint
{
    WordWrapping = 0,
    CharWrapping,
    Clipping,
    TruncatingHead,
    TruncatingTail,
    TruncatingMiddle
}

[Introduced (PlatformName.iOS, 2, 0)]
[Deprecated (PlatformName.iOS, 6, 0)]
[NoTV]
[Native]
public enum UILineBreakMode : nint
{
    WordWrap = 0,
    CharacterWrap,
    Clip,
    HeadTruncation,
    TailTruncation,
    MiddleTruncation
}

[Introduced (PlatformName.iOS, 2, 0)]
[Deprecated (PlatformName.iOS, 6, 0)]
[NoTV]
[Native]
public enum UITextAlignment : nint
{
    Left = 0,
    Center,
    Right
}

[Native]
public enum UIBaselineAdjustment : nint
{
    AlignBaselines = 0,
    AlignCenters,
    None
}

[Native]
public enum UIButtonType : nint
{
    Custom = 0,
    System,
    DetailDisclosure,
    InfoLight,
    InfoDark,
    ContactAdd,
    Plain,
    RoundedRect = System
}



[Native]
public enum UIActivityIndicatorViewStyle : nint
{
    WhiteLarge,
    White,
    Gray
}

[NoTV, iOS (7,0)]
[Native]
public enum UIActivityCategory : nint
{
    Action,
    Share
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UIDropOperation : nuint
{
    Cancel = 0,
    Forbidden = 1,
    Copy = 2,
    Move = 3
}

[iOS (10,0)]
[Native]
public enum UIViewAnimatingState : nint
{
    Inactive,
    Active,
    Stopped
}

[iOS (10,0)]
[Native]
public enum UIViewAnimatingPosition : nint
{
    End,
    Start,
    Current
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UITextDragOptions : nint
{
    sNone = 0,
    StripTextColorFromPreviews = (1 << 0)
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UITextDropAction : nuint
{
    Insert = 0,
    ReplaceSelection,
    ReplaceAll
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UITextDropProgressMode : nuint
{
    System = 0,
    Custom
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UITextDropPerformer : nuint
{
    View = 0,
    Delegate
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UITextDropEditability : nuint
{
    No = 0,
    Temporary,
    Yes
}

[Native]
public enum UITextBorderStyle : nint
{
    None,
    Line,
    Bezel,
    RoundedRect
}

[Native]
public enum UITextFieldViewMode : nint
{
    Never,
    WhileEditing,
    UnlessEditing,
    Always
}

[iOS (10,0)]
[Native]
public enum UITextFieldDidEndEditingReason : nint
{
    ommitted,
    ancelled
}

[NoTV]
[Native]
public enum UIActionSheetStyle : nint
{
    Automatic = -1,
    Default = UIBarStyleDefault,
    BlackTranslucent = UIBarStyleBlackTranslucent,
    BlackOpaque = UIBarStyleBlackOpaque
}

[NoTV]
[Native]
public enum UIAlertViewStyle : nint
{
    Default = 0,
    SecureTextInput,
    PlainTextInput,
    LoginAndPasswordInput
}

[NoTV]
[Native]
public enum UIStatusBarStyle : nint
{
    Default = 0,
    LightContent = 1,
    BlackTranslucent = 1,
    BlackOpaque = 2
}

[NoTV]
[Native]
public enum UIStatusBarAnimation : nint
{
    None,
    Fade,
    Slide
}

[NoTV]
[Native]
public enum UIInterfaceOrientation : nint
{
    Unknown = UIDeviceOrientationUnknown,
    Portrait = UIDeviceOrientationPortrait,
    PortraitUpsideDown = UIDeviceOrientationPortraitUpsideDown,
    LandscapeLeft = UIDeviceOrientationLandscapeRight,
    LandscapeRight = UIDeviceOrientationLandscapeLeft
}

[NoTV]
[Native]
public enum UIInterfaceOrientationMask : nuint
{
    Portrait = (1 << UIInterfaceOrientationPortrait),
    LandscapeLeft = (1 << UIInterfaceOrientationLandscapeLeft),
    LandscapeRight = (1 << UIInterfaceOrientationLandscapeRight),
    PortraitUpsideDown = (1 << UIInterfaceOrientationPortraitUpsideDown),
    Landscape = (LandscapeLeft | LandscapeRight),
    All = (Portrait | LandscapeLeft | LandscapeRight | PortraitUpsideDown),
    AllButUpsideDown = (Portrait | LandscapeLeft | LandscapeRight)
}

[Introduced (PlatformName.iOS, 3, 0, message: "Use UserNotifications Framework's UNAuthorizationOptions for user notifications and registerForRemoteNotifications for receiving remote notifications instead.")]
[Deprecated (PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's UNAuthorizationOptions for user notifications and registerForRemoteNotifications for receiving remote notifications instead.")]
[NoTV]
[Native]
public enum UIRemoteNotificationType : nuint
{
    None = 0,
    Badge = 1 << 0,
    Sound = 1 << 1,
    Alert = 1 << 2,
    NewsstandContentAvailability = 1 << 3
}

[iOS (7,0)]
[Native]
public enum UIBackgroundFetchResult : nuint
{
    NewData,
    NoData,
    Failed
}

[TV (11,0), iOS (7,0)]
[Native]
public enum UIBackgroundRefreshStatus : nint
{
    Restricted,
    Denied,
    Available
}

[iOS (4,0)]
[Native]
public enum UIApplicationState : nint
{
    Active,
    Inactive,
    Background
}

[Native]
public enum UIModalTransitionStyle : nint
{
    CoverVertical = 0,
    FlipHorizontal,
    CrossDissolve,
    PartialCurl
}

[Native]
public enum UIModalPresentationStyle : nint
{
    FullScreen = 0,
    PageSheet,
    FormSheet,
    CurrentContext,
    Custom,
    OverFullScreen,
    OverCurrentContext,
    Popover,
    BlurOverFullScreen,
    None = -1
}

[iOS (9,0)]
[Native]
public enum UIPreviewActionStyle : nint
{
    Default = 0,
    Selected,
    Destructive
}

[iOS (8,0)]
[Native]
public enum UIAlertActionStyle : nint
{
    Default = 0,
    Cancel,
    Destructive
}

[iOS (8,0)]
[Native]
public enum UIAlertControllerStyle : nint
{
    ctionSheet = 0,
    lert
}

[Native]
public enum UIBarMetrics : nint
{
    Default,
    Compact,
    DefaultPrompt = 101,
    CompactPrompt,
    LandscapePhone = Compact,
    LandscapePhonePrompt = CompactPrompt
}

[iOS (7,0)]
[Native]
public enum UIBarPosition : nint
{
    Any = 0,
    Bottom = 1,
    Top = 2,
    TopAttached = 3
}

[Native]
public enum UIBarButtonItemStyle : nint
{
    Plain,
    Bordered,
    Done
}

[Native]
public enum UIBarButtonSystemItem : nint
{
    Done,
    Cancel,
    Edit,
    Save,
    Add,
    FlexibleSpace,
    FixedSpace,
    Compose,
    Reply,
    Action,
    Organize,
    Bookmarks,
    Search,
    Refresh,
    Stop,
    Camera,
    Trash,
    Play,
    Pause,
    Rewind,
    FastForward,
    Undo,
    Redo,
    PageCurl
}

[Native]
public enum UICollectionViewScrollPosition : nuint
{
    None = 0,
    Top = 1 << 0,
    CenteredVertically = 1 << 1,
    Bottom = 1 << 2,
    Left = 1 << 3,
    CenteredHorizontally = 1 << 4,
    Right = 1 << 5
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UICollectionViewReorderingCadence : nint
{
    Immediate,
    Fast,
    Slow
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UICollectionViewDropIntent : nint
{
    Unspecified,
    InsertAtDestinationIndexPath,
    InsertIntoDestinationIndexPath
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UICollectionViewCellDragState : nint
{
    None,
    Lifting,
    Dragging
}

[Native]
public enum UICollectionElementCategory : nuint
{
    Cell,
    SupplementaryView,
    DecorationView
}

[Native]
public enum UICollectionUpdateAction : nint
{
    Insert,
    Delete,
    Reload,
    Move,
    None
}

[Native]
public enum UICollectionViewScrollDirection : nint
{
    Vertical,
    Horizontal
}

[TV (11,0), NoWatch, iOS (11,0)]
[Native]
public enum UICollectionViewFlowLayoutSectionInsetReference : nint
{
    ContentInset,
    SafeArea,
    LayoutMargins
}

[NoTV]
[Native]
public enum UIDataDetectorTypes : nuint
{
    PhoneNumber = 1 << 0,
    Link = 1 << 1,
    Address = 1 << 2,
    CalendarEvent = 1 << 3,
    ShipmentTrackingNumber = 1 << 4,
    FlightNumber = 1 << 5,
    LookupSuggestion = 1 << 6,
    None = 0,
    All = (9223372036854775807L * 2 + 1)
}

[NoTV]
[Native]
public enum UIDatePickerMode : nint
{
    Time,
    Date,
    DateAndTime,
    CountDownTimer
}

[NoTV]
[Native]
public enum UIDocumentChangeKind : nint
{
    Done,
    Undone,
    Redone,
    Cleared
}

[NoTV]
[Native]
public enum UIDocumentSaveOperation : nint
{
    Creating,
    Overwriting
}

[NoTV]
[Native]
public enum UIDocumentState : nuint
{
    Normal = 0,
    Closed = 1 << 0,
    InConflict = 1 << 1,
    SavingError = 1 << 2,
    EditingDisabled = 1 << 3,
    ProgressAvailable = 1 << 4
}

[NoTV, iOS (8,0)]
[Native]
public enum UIDocumentPickerMode : nuint
{
    Import,
    Open,
    ExportToService,
    MoveToService
}

[Introduced (PlatformName.iOS, 8, 0)]
[Deprecated (PlatformName.iOS, 11, 0)]
[NoTV]
[Native]
public enum UIDocumentMenuOrder : nuint
{
    First,
    Last
}

[NoWatch, NoTV, iOS (10,0)]
[Native]
public enum UICloudSharingPermissionOptions : nuint
{
    Standard = 0,
    AllowPublic = 1 << 0,
    AllowPrivate = 1 << 1,
    AllowReadOnly = 1 << 2,
    AllowReadWrite = 1 << 3
}

[Native]
public enum NSFileProviderItemCapabilities : nuint
{
    Reading = 1 << 0,
    Writing = 1 << 1,
    Reparenting = 1 << 2,
    Renaming = 1 << 3,
    Trashing = 1 << 4,
    Deleting = 1 << 5,
    AddingSubItems = Writing,
    ContentEnumerating = Reading,
    All = Reading | Writing | Reparenting | Renaming | Trashing | Deleting
}

[iOS (8,0)]
[Native]
public enum UIBlurEffectStyle : nint
{
    ExtraLight,
    Light,
    Dark,
    ExtraDark,
    Regular,
    Prominent
}

[Native]
public enum UIGestureRecognizerState : nint
{
    Possible,
    Began,
    Changed,
    Ended,
    Cancelled,
    Failed,
    Recognized = Ended
}

[Native]
public enum UINavigationControllerOperation : nint
{
    None,
    Push,
    Pop
}

[NoTV]
[Native]
public enum UIImagePickerControllerSourceType : nint
{
    PhotoLibrary,
    Camera,
    SavedPhotosAlbum
}

[NoTV]
[Native]
public enum UIImagePickerControllerQualityType : nint
{
    High = 0,
    Medium = 1,
    Low = 2,
    UIImagePickerControllerQualityType640x480 = 3,
    IFrame1280x720 = 4,
    IFrame960x540 = 5
}

[NoTV]
[Native]
public enum UIImagePickerControllerCameraCaptureMode : nint
{
    Photo,
    Video
}

[NoTV]
[Native]
public enum UIImagePickerControllerCameraDevice : nint
{
    Rear,
    Front
}

[NoTV]
[Native]
public enum UIImagePickerControllerCameraFlashMode : nint
{
    Off = -1,
    Auto = 0,
    On = 1
}

[NoTV, iOS (11,0)]
[Native]
public enum UIImagePickerControllerImageURLExportPreset : nint
{
    ompatible = 0,
    urrent
}

[iOS (7,0)]
[Native]
public enum UIInputViewStyle : nint
{
    Default,
    Keyboard
}

[NoTV, iOS (9,0)]
[Native]
public enum UIApplicationShortcutIconType : nint
{
    Compose,
    Play,
    Pause,
    Add,
    Location,
    Search,
    Share,
    Prohibit,
    Contact,
    Home,
    MarkLocation,
    Favorite,
    Love,
    Cloud,
    Invitation,
    Confirmation,
    Mail,
    Message,
    Date,
    Time,
    CapturePhoto,
    CaptureVideo,
    Task,
    TaskCompleted,
    Alarm,
    Bookmark,
    Shuffle,
    Audio,
    Update
}

[Introduced (PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's UNAuthorizationOptions")]
[Deprecated (PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's UNAuthorizationOptions")]
[NoTV]
[Native]
public enum UIUserNotificationType : nuint
{
    None = 0,
    Badge = 1 << 0,
    Sound = 1 << 1,
    Alert = 1 << 2
}

[Introduced (PlatformName.iOS, 9, 0, message: "Use UserNotifications Framework's UNNotificationAction or UNTextInputNotificationAction")]
[Deprecated (PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's UNNotificationAction or UNTextInputNotificationAction")]
[NoTV]
[Native]
public enum UIUserNotificationActionBehavior : nuint
{
    Default,
    TextInput
}

[Introduced (PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's UNNotificationActionOptions")]
[Deprecated (PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's UNNotificationActionOptions")]
[NoTV]
[Native]
public enum UIUserNotificationActivationMode : nuint
{
    Foreground,
    Background
}

[Introduced (PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's -[UNNotificationCategory actions] or -[UNNotificationCategory minimalActions]")]
[Deprecated (PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's -[UNNotificationCategory actions] or -[UNNotificationCategory minimalActions]")]
[NoTV]
[Native]
public enum UIUserNotificationActionContext : nuint
{
    Default,
    Minimal
}

[NoTV]
[Native]
public enum UIMenuControllerArrowDirection : nint
{
    Default,
    Up,
    Down,
    Left,
    Right
}

[Native]
public enum UIInterpolatingMotionEffectType : nint
{
    HorizontalAxis,
    VerticalAxis
}

[Native]
public enum UINavigationItemLargeTitleDisplayMode : nint
{
    Automatic,
    Always,
    Never
}

[Native]
public enum UIPageViewControllerNavigationOrientation : nint
{
    Horizontal = 0,
    Vertical = 1
}

[Native]
public enum UIPageViewControllerSpineLocation : nint
{
    None = 0,
    Min = 1,
    Mid = 2,
    Max = 3
}

[Native]
public enum UIPageViewControllerNavigationDirection : nint
{
    Forward,
    Reverse
}

[Native]
public enum UIPageViewControllerTransitionStyle : nint
{
    PageCurl = 0,
    Scroll = 1
}

[Native]
public enum UIPopoverArrowDirection : nuint
{
    Up = 1 << 0,
    Down = 1 << 1,
    Left = 1 << 2,
    Right = 1 << 3,
    Any = Up | Down | Left | Right,
    Unknown = (9223372036854775807L * 2 + 1)
}

[Native]
public enum UIPressPhase : nint
{
    Began,
    Changed,
    Stationary,
    Ended,
    Cancelled
}

[Native]
public enum UIPressType : nint
{
    UpArrow,
    DownArrow,
    LeftArrow,
    RightArrow,
    Select,
    Menu,
    PlayPause
}

[NoTV, iOS (8,0)]
[Native]
public enum UIPrinterJobTypes : nint
{
    Unknown = 0,
    Document = 1 << 0,
    Envelope = 1 << 1,
    Label = 1 << 2,
    Photo = 1 << 3,
    Receipt = 1 << 4,
    Roll = 1 << 5,
    LargeFormat = 1 << 6,
    Postcard = 1 << 7
}

[NoTV]
[Verify (InferredFromMemberPrefix)]
public enum UIPrint : uint
{
    ingNotAvailableError = 1,
    NoContentError,
    UnknownImageFormatError,
    JobFailedError
}

[NoTV]
[Native]
public enum UIPrintInfoOutputType : nint
{
    General,
    Photo,
    Grayscale,
    PhotoGrayscale
}

[NoTV]
[Native]
public enum UIPrintInfoOrientation : nint
{
    Portrait,
    Landscape
}

[NoTV]
[Native]
public enum UIPrintInfoDuplex : nint
{
    None,
    LongEdge,
    ShortEdge
}

[NoTV]
[Native]
public enum UIPrinterCutterBehavior : nint
{
    NoCut,
    PrinterDefault,
    CutAfterEachPage,
    CutAfterEachCopy,
    CutAfterEachJob
}

[Native]
public enum UIProgressViewStyle : nint
{
    Default,
    Bar
}

[Native]
public enum UIScreenOverscanCompensation : nint
{
    Scale,
    InsetBounds,
    None,
    InsetApplicationFrame = 2
}

[Native]
public enum UISearchBarIcon : nint
{
    Search,
    Clear,
    Bookmark,
    ResultsList
}

[iOS (7,0)]
[Native]
public enum UISearchBarStyle : nuint
{
    Default,
    Prominent,
    Minimal
}

[iOS (10,0)]
[Native]
public enum UITimingCurveType : nint
{
    Builtin,
    Cubic,
    Spring,
    Composed
}

[Native]
public enum UISwipeGestureRecognizerDirection : nuint
{
    Right = 1 << 0,
    Left = 1 << 1,
    Up = 1 << 2,
    Down = 1 << 3
}

[NoTV, iOS (11,0)]
[Native]
public enum UIContextualActionStyle : nint
{
    Normal,
    Destructive
}

[Native]
public enum UITableViewCellStyle : nint
{
    Default,
    Value1,
    Value2,
    Subtitle
}

[NoTV]
[Native]
public enum UITableViewCellSeparatorStyle : nint
{
    None,
    SingleLine,
    SingleLineEtched
}

[Native]
public enum UITableViewCellSelectionStyle : nint
{
    None,
    Blue,
    Gray,
    Default
}

[iOS (9,0)]
[Native]
public enum UITableViewCellFocusStyle : nint
{
    Default,
    Custom
}

[Native]
public enum UITableViewCellEditingStyle : nint
{
    None,
    Delete,
    Insert
}

[Native]
public enum UITableViewCellAccessoryType : nint
{
    None,
    DisclosureIndicator,
    DetailDisclosureButton,
    Checkmark,
    DetailButton
}

[Native]
public enum UITableViewCellStateMask : nuint
{
    DefaultMask = 0,
    ShowingEditControlMask = 1 << 0,
    ShowingDeleteConfirmationMask = 1 << 1
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UITableViewCellDragState : nint
{
    None,
    Lifting,
    Dragging
}

[Native]
public enum UITableViewStyle : nint
{
    Plain,
    Grouped
}

[Native]
public enum UITableViewScrollPosition : nint
{
    None,
    Top,
    Middle,
    Bottom
}

[Native]
public enum UITableViewRowAnimation : nint
{
    Fade,
    Right,
    Left,
    Top,
    Bottom,
    None,
    Middle,
    Automatic = 100
}

[NoTV, iOS (8,0)]
[Native]
public enum UITableViewRowActionStyle : nint
{
    Default = 0,
    Destructive = Default,
    Normal
}

[TV (11,0), iOS (11,0)]
[Native]
public enum UITableViewSeparatorInsetReference : nint
{
    CellEdges,
    AutomaticInsets
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UITableViewDropIntent : nint
{
    Unspecified,
    InsertAtDestinationIndexPath,
    InsertIntoDestinationIndexPath,
    Automatic
}

[Introduced (PlatformName.iOS, 2, 0, message: "The segmentedControlStyle property no longer has any effect")]
[Deprecated (PlatformName.iOS, 7, 0, message: "The segmentedControlStyle property no longer has any effect")]
[NoTV]
[Native]
public enum UISegmentedControlStyle : nint
{
    Plain,
    Bordered,
    Bar,
    Bezeled
}



[Native]
public enum UISegmentedControlSegment : nint
{
    Any = 0,
    Left = 1,
    Center = 2,
    Right = 3,
    Alone = 4
}

[iOS (8,0)]
[Native]
public enum UISplitViewControllerDisplayMode : nint
{
    Automatic,
    PrimaryHidden,
    AllVisible,
    PrimaryOverlay
}

[TV (11,0), iOS (11,0)]
[Native]
public enum UISplitViewControllerPrimaryEdge : nint
{
    Leading,
    Trailing
}

[iOS (7,0)]
[Native]
public enum UITabBarItemPositioning : nint
{
    Automatic,
    Fill,
    Centered
}

[Native]
public enum UITabBarSystemItem : nint
{
    More,
    Favorites,
    Featured,
    TopRated,
    Recents,
    Contacts,
    History,
    Bookmarks,
    Search,
    Downloads,
    MostRecent,
    MostViewed
}

[iOS (10,0)]
[Native]
public enum UITextItemInteraction : nint
{
    InvokeDefaultAction,
    PresentActions,
    Preview
}

[NoTV]
[Native]
public enum UIWebViewNavigationType : nint
{
    LinkClicked,
    FormSubmitted,
    BackForward,
    Reload,
    FormResubmitted,
    Other
}

[NoTV]
[Native]
public enum UIWebPaginationMode : nint
{
    Unpaginated,
    LeftToRight,
    TopToBottom,
    BottomToTop,
    RightToLeft
}

[NoTV]
[Native]
public enum UIWebPaginationBreakingMode : nint
{
    Page,
    Column
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UIDropSessionProgressIndicatorStyle : nuint
{
    None,
    Default
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UISpringLoadedInteractionEffectState : nint
{
    Inactive,
    Possible,
    Activating,
    Activated
}

[iOS (6,0)]
[Native]
public enum NSUnderlineStyle : nint
{
    StyleNone = 0,
    StyleSingle = 1,
    StyleThick = 2,
    StyleDouble = 9,
    PatternSolid = 0,
    PatternDot = 256,
    PatternDash = 512,
    PatternDashDot = 768,
    PatternDashDotDot = 1024,
    ByWord = 32768
}

[iOS (9,0)]
[Native]
public enum NSWritingDirectionFormatType : nint
{
    Embedding = (0 << 1),
    Override = (1 << 1)
}

[Introduced (PlatformName.iOS, 7, 0, message: "Use NSWritingDirectionFormatType instead")]
[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSWritingDirectionFormatType instead")]
[NoTV]
[Native]
public enum NSTextWritingDirection : nint
{
    Embedding = (0 << 1),
    Override = (1 << 1)
}

[iOS (9,0)]
[Native]
public enum UIStackViewDistribution : nint
{
    Fill = 0,
    FillEqually,
    FillProportionally,
    EqualSpacing,
    EqualCentering
}

[iOS (9,0)]
[Native]
public enum UIStackViewAlignment : nint
{
    Fill,
    Leading,
    Top = Leading,
    FirstBaseline,
    Center,
    Trailing,
    Bottom = Trailing,
    LastBaseline
}

[iOS (7,0)]
[Native]
public enum NSTextStorageEditActions : nuint
{
    Attributes = (1 << 0),
    Characters = (1 << 1)
}

[iOS (7,0)]
[Native]
public enum NSTextLayoutOrientation : nint
{
    Horizontal = 0,
    Vertical = 1
}

[iOS (7,0)]
[Native]
public enum NSGlyphProperty : nint
{
    Null = (1 << 0),
    ControlCharacter = (1 << 1),
    Elastic = (1 << 2),
    NonBaseCharacter = (1 << 3)
}

[iOS (7,0)]
[Native]
public enum NSControlCharacterAction : nint
{
    ZeroAdvancement = (1 << 0),
    Whitespace = (1 << 1),
    HorizontalTab = (1 << 2),
    LineBreak = (1 << 3),
    ParagraphBreak = (1 << 4),
    ContainerBreak = (1 << 5)
}

[Verify (InferredFromMemberPrefix)]
public enum NSControlCharacter : uint
{
    ZeroAdvancementAction = NSControlCharacterActionZeroAdvancement,
    WhitespaceAction = NSControlCharacterActionWhitespace,
    HorizontalTabAction = NSControlCharacterActionHorizontalTab,
    LineBreakAction = NSControlCharacterActionLineBreak,
    ParagraphBreakAction = NSControlCharacterActionParagraphBreak,
    ContainerBreakAction = NSControlCharacterActionContainerBreak
}

[iOS (6,0)]
[Native]
public enum NSStringDrawingOptions : nint
{
    UsesLineFragmentOrigin = 1 << 0,
    UsesFontLeading = 1 << 1,
    UsesDeviceMetrics = 1 << 3,
    TruncatesLastVisibleLine = 1 << 5
}

[iOS (7,0)]
[Native]
public enum UIPushBehaviorMode : nint
{
    Continuous,
    Instantaneous
}

[iOS (7,0)]
[Native]
public enum UIAttachmentBehaviorType : nint
{
    Items,
    Anchor
}

[StructLayout (LayoutKind.Sequential)]
public struct UIFloatRange
{
    public nfloat minimum;

    public nfloat maximum;
}

[iOS (7,0)]
[Native]
public enum UICollisionBehaviorMode : nuint
{
    Items = 1 << 0,
    Boundaries = 1 << 1,
    Everything = (9223372036854775807L * 2 + 1)
}

[Native]
public enum UIImpactFeedbackStyle : nint
{
    Light,
    Medium,
    Heavy
}

[Native]
public enum UINotificationFeedbackType : nint
{
    Success,
    Warning,
    Error
}

[NoWatch, NoTV, NoMac, iOS (11,0)]
[Native]
public enum UIDocumentBrowserErrorCode : nint
{
    UIDocumentBrowserErrorGeneric = 1
}

[NoTV, iOS (11,0)]
[Native]
public enum UIDocumentBrowserImportMode : nuint
{
    None,
    Copy,
    Move
}

[NoTV, iOS (11,0)]
[Native]
public enum UIDocumentBrowserUserInterfaceStyle : nuint
{
    White = 0,
    Light,
    Dark
}

[NoTV, iOS (11,0)]
[Native]
public enum UIDocumentBrowserActionAvailability : nint
{
    Menu = 1,
    NavigationBar = 1 << 1
}

[Native]
public enum GenericUpdateSendMethod : nint
{
    firstGenericUpdateSendMethodDeleteIndex = 0,
    GenericUpdateSendMethodGet = firstGenericUpdateSendMethodDeleteIndex,
    GenericUpdateSendMethodPost,
    GenericUpdateSendMethodPut,
    GenericUpdateSendMethodDelete,
    lastGenericUpdateSendMethodDeleteIndex = GenericUpdateSendMethodDelete
}

[Native]
public enum LocationUpdateAppState : nint
{
    firstLocationUpdateAppStateIndex = 0,
    LocationUpdateAppStateBackground = firstLocationUpdateAppStateIndex,
    LocationUpdateAppStateForeground,
    lastLocationUpdateAppStateIndex = LocationUpdateAppStateForeground
}

[Watch (3,0), TV (10,0), iOS (10,0)]
[Native]
public enum UNErrorCode : nint
{
    NotificationsNotAllowed = 1,
    AttachmentInvalidURL = 100,
    AttachmentUnrecognizedType,
    AttachmentInvalidFileSize,
    AttachmentNotInDataStore,
    AttachmentMoveIntoDataStoreFailed,
    AttachmentCorrupt,
    NotificationInvalidNoDate = 1400,
    NotificationInvalidNoContent
}

[Watch (3,0), NoTV, iOS (10,0)]
[Native]
public enum UNNotificationActionOptions : nuint
{
    AuthenticationRequired = (1 << 0),
    Destructive = (1 << 1),
    Foreground = (1 << 2)
}

[Watch (3,0), NoTV, iOS (10,0)]
[Native]
public enum UNNotificationCategoryOptions : nuint
{
    CustomDismissAction = (1 << 0),
    AllowInCarPlay = (1 << 1),
    HiddenPreviewsShowTitle = (1 << 2),
    HiddenPreviewsShowSubtitle = (1 << 3)
}

[Watch (3,0), TV (10,0), iOS (10,0)]
[Native]
public enum UNAuthorizationStatus : nint
{
    NotDetermined = 0,
    Denied,
    Authorized
}

[NoWatch, NoTV, iOS (11,0)]
[Native]
public enum UNShowPreviewsSetting : nint
{
    Always,
    WhenAuthenticated,
    Never
}

[Watch (3,0), TV (10,0), iOS (10,0)]
[Native]
public enum UNNotificationSetting : nint
{
    NotSupported = 0,
    Disabled,
    Enabled
}

[NoWatch, NoTV, iOS (10,0)]
[Native]
public enum UNAlertStyle : nint
{
    None = 0,
    Banner,
    Alert
}

[Watch (3,0), TV (10,0), iOS (10,0)]
[Native]
public enum UNAuthorizationOptions : nuint
{
    Badge = (1 << 0),
    Sound = (1 << 1),
    Alert = (1 << 2),
    CarPlay = (1 << 3)
}

[Watch (3,0), TV (10,0), iOS (10,0)]
[Native]
public enum UNNotificationPresentationOptions : nuint
{
    Badge = (1 << 0),
    Sound = (1 << 1),
    Alert = (1 << 2)
}

[Mac (10,10), iOS (8,0)]
[Native]
public enum WKErrorCode : nint
{
    Unknown = 1,
    WebContentProcessTerminated,
    WebViewInvalidated,
    JavaScriptExceptionOccurred,
    JavaScriptResultTypeIsUnsupported,
    ContentRuleListStoreCompileFailed,
    ContentRuleListStoreLookUpFailed,
    ContentRuleListStoreRemoveFailed,
    ContentRuleListStoreVersionMismatch
}

[Mac (10,10), iOS (8,0)]
[Native]
public enum WKNavigationType : nint
{
    LinkActivated,
    FormSubmitted,
    BackForward,
    Reload,
    FormResubmitted,
    Other = -1
}

[Mac (10,10), iOS (8,0)]
[Native]
public enum WKNavigationActionPolicy : nint
{
    Cancel,
    Allow
}

[Mac (10,10), iOS (8,0)]
[Native]
public enum WKNavigationResponsePolicy : nint
{
    Cancel,
    Allow
}

[Mac (10,10), iOS (8,0)]
[Native]
public enum WKUserScriptInjectionTime : nint
{
    Start,
    End
}

[iOS (10,0)]
[Native]
public enum WKDataDetectorTypes : nuint
{
    None = 0,
    PhoneNumber = 1 << 0,
    Link = 1 << 1,
    Address = 1 << 2,
    CalendarEvent = 1 << 3,
    TrackingNumber = 1 << 4,
    FlightNumber = 1 << 5,
    LookupSuggestion = 1 << 6,
    All = (9223372036854775807L * 2 + 1),
    SpotlightSuggestion = LookupSuggestion
}

[iOS (8,0)]
[Native]
public enum WKSelectionGranularity : nint
{
    Dynamic,
    Character
}

[Mac (10,12), iOS (10,0)]
[Native]
public enum WKAudiovisualMediaTypes : nuint
{
    None = 0,
    Audio = 1 << 0,
    Video = 1 << 1,
    All = (9223372036854775807L * 2 + 1)
}
