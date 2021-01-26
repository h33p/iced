// SPDX-License-Identifier: MIT
// Copyright wtfsckgh@gmail.com
// Copyright iced contributors

use core::fmt;

// GENERATOR-BEGIN: SymbolFlags
// ⚠️This was generated by GENERATOR!🦹‍♂️
/// Symbol flags
#[allow(missing_copy_implementations)]
#[allow(missing_debug_implementations)]
pub struct SymbolFlags;
impl SymbolFlags {
	/// No bit is set
	pub const NONE: u32 = 0x0000_0000;
	/// It's a symbol relative to a register, eg. a struct offset `[ebx+some_struct.field1]`. If this is cleared, it's the address of a symbol.
	pub const RELATIVE: u32 = 0x0000_0001;
	/// It's a signed symbol and it should be displayed as `-symbol` or `reg-symbol` instead of `symbol` or `reg+symbol`
	pub const SIGNED: u32 = 0x0000_0002;
}
// GENERATOR-END: SymbolFlags

// GENERATOR-BEGIN: FormatterTextKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
/// Formatter text kind
#[derive(Copy, Clone, Eq, PartialEq, Ord, PartialOrd, Hash)]
#[cfg_attr(not(feature = "exhaustive_enums"), non_exhaustive)]
pub enum FormatterTextKind {
	/// Normal text
	Text = 0,
	/// Assembler directive
	Directive = 1,
	/// Any prefix
	Prefix = 2,
	/// Any mnemonic
	Mnemonic = 3,
	/// Any keyword
	Keyword = 4,
	/// Any operator
	Operator = 5,
	/// Any punctuation
	Punctuation = 6,
	/// Number
	Number = 7,
	/// Any register
	Register = 8,
	/// A decorator, eg. `sae` in `{sae}`
	Decorator = 9,
	/// Selector value (eg. far `JMP`/`CALL`)
	SelectorValue = 10,
	/// Label address (eg. `JE XXXXXX`)
	LabelAddress = 11,
	/// Function address (eg. `CALL XXXXXX`)
	FunctionAddress = 12,
	/// Data symbol
	Data = 13,
	/// Label symbol
	Label = 14,
	/// Function symbol
	Function = 15,
}
#[rustfmt::skip]
static GEN_DEBUG_FORMATTER_TEXT_KIND: [&str; 16] = [
	"Text",
	"Directive",
	"Prefix",
	"Mnemonic",
	"Keyword",
	"Operator",
	"Punctuation",
	"Number",
	"Register",
	"Decorator",
	"SelectorValue",
	"LabelAddress",
	"FunctionAddress",
	"Data",
	"Label",
	"Function",
];
impl fmt::Debug for FormatterTextKind {
	#[inline]
	fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_FORMATTER_TEXT_KIND[*self as usize])?;
		Ok(())
	}
}
impl Default for FormatterTextKind {
	#[must_use]
	#[inline]
	fn default() -> Self {
		FormatterTextKind::Text
	}
}
// GENERATOR-END: FormatterTextKind

// GENERATOR-BEGIN: PseudoOpsKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
#[derive(Copy, Clone, Eq, PartialEq)]
#[allow(non_camel_case_types)]
#[allow(dead_code)]
pub(crate) enum PseudoOpsKind {
	cmpps,
	vcmpps,
	cmppd,
	vcmppd,
	cmpss,
	vcmpss,
	cmpsd,
	vcmpsd,
	pclmulqdq,
	vpclmulqdq,
	vpcomb,
	vpcomw,
	vpcomd,
	vpcomq,
	vpcomub,
	vpcomuw,
	vpcomud,
	vpcomuq,
}
#[rustfmt::skip]
static GEN_DEBUG_PSEUDO_OPS_KIND: [&str; 18] = [
	"cmpps",
	"vcmpps",
	"cmppd",
	"vcmppd",
	"cmpss",
	"vcmpss",
	"cmpsd",
	"vcmpsd",
	"pclmulqdq",
	"vpclmulqdq",
	"vpcomb",
	"vpcomw",
	"vpcomd",
	"vpcomq",
	"vpcomub",
	"vpcomuw",
	"vpcomud",
	"vpcomuq",
];
impl fmt::Debug for PseudoOpsKind {
	#[inline]
	fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_PSEUDO_OPS_KIND[*self as usize])?;
		Ok(())
	}
}
impl Default for PseudoOpsKind {
	#[must_use]
	#[inline]
	fn default() -> Self {
		PseudoOpsKind::cmpps
	}
}
// GENERATOR-END: PseudoOpsKind

// GENERATOR-BEGIN: MemorySizeOptions
// ⚠️This was generated by GENERATOR!🦹‍♂️
/// Memory size options used by the formatters
#[derive(Copy, Clone, Eq, PartialEq, Ord, PartialOrd, Hash)]
pub enum MemorySizeOptions {
	/// Show memory size if the assembler requires it, else don't show anything
	Default = 0,
	/// Always show the memory size, even if the assembler doesn't need it
	Always = 1,
	/// Show memory size if a human can't figure out the size of the operand
	Minimal = 2,
	/// Never show memory size
	Never = 3,
}
#[rustfmt::skip]
static GEN_DEBUG_MEMORY_SIZE_OPTIONS: [&str; 4] = [
	"Default",
	"Always",
	"Minimal",
	"Never",
];
impl fmt::Debug for MemorySizeOptions {
	#[inline]
	fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_MEMORY_SIZE_OPTIONS[*self as usize])?;
		Ok(())
	}
}
impl Default for MemorySizeOptions {
	#[must_use]
	#[inline]
	fn default() -> Self {
		MemorySizeOptions::Default
	}
}
// GENERATOR-END: MemorySizeOptions
