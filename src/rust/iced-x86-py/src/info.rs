/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

use crate::iced_constants::IcedConstants;
use crate::instruction::Instruction;
use core::hash::{Hash, Hasher};
use pyo3::class::basic::CompareOp;
use pyo3::exceptions::PyValueError;
use pyo3::prelude::*;
use pyo3::PyObjectProtocol;
use std::collections::hash_map::DefaultHasher;

/// A register used by an instruction
#[pyclass(module = "_iced_x86_py")]
#[derive(Copy, Clone)]
pub(crate) struct UsedRegister {
	info: iced_x86::UsedRegister,
}

#[pymethods]
impl UsedRegister {
	/// :class:`Register`: Gets the register
	#[getter]
	pub fn register(&self) -> u32 {
		self.info.register() as u32
	}

	/// :class:`OpAccess`: Gets the register access
	#[getter]
	pub fn access(&self) -> u32 {
		self.info.access() as u32
	}

	/// Returns a copy of this instance.
	///
	/// Returns:
	///     UsedRegister: A copy of this instance
	///
	/// This is identical to :class:`UsedRegister.clone`
	#[text_signature = "($self, /)"]
	fn __copy__(&self) -> Self {
		*self
	}

	/// Returns a copy of this instance.
	///
	/// Returns:
	///     UsedRegister: A copy of this instance
	///
	/// This is identical to :class:`UsedRegister.clone`
	#[text_signature = "($self, memo, /)"]
	fn __deepcopy__(&self, _memo: &PyAny) -> Self {
		*self
	}

	/// Returns a copy of this instance.
	///
	/// Returns:
	///     UsedRegister: A copy of this instance
	#[text_signature = "($self, /)"]
	fn clone(&self) -> Self {
		*self
	}
}

#[pyproto]
impl PyObjectProtocol for UsedRegister {
	fn __richcmp__(&self, other: PyRef<UsedRegister>, op: CompareOp) -> PyObject {
		match op {
			CompareOp::Eq => (self.info == other.info).into_py(other.py()),
			CompareOp::Ne => (self.info != other.info).into_py(other.py()),
			_ => other.py().NotImplemented(),
		}
	}

	fn __hash__(&self) -> u64 {
		let mut hasher = DefaultHasher::new();
		self.info.hash(&mut hasher);
		hasher.finish()
	}
}

/// A memory location used by an instruction
#[pyclass(module = "_iced_x86_py")]
#[derive(Copy, Clone)]
pub(crate) struct UsedMemory {
	info: iced_x86::UsedMemory,
}

#[pymethods]
impl UsedMemory {
	/// :class:`Register`: Effective segment register or :class:`Register.NONE` if the segment register is ignored
	#[getter]
	pub fn segment(&self) -> u32 {
		self.info.segment() as u32
	}

	/// :class:`Register`: Base register or :class:`Register.NONE` if none
	#[getter]
	pub fn base(&self) -> u32 {
		self.info.base() as u32
	}

	/// :class:`Register`: Index register or :class:`Register.NONE` if none
	#[getter]
	pub fn index(&self) -> u32 {
		self.info.index() as u32
	}

	/// int: Index scale (1, 2, 4 or 8)
	#[getter]
	pub fn scale(&self) -> u32 {
		self.info.scale()
	}

	/// int: (``u64``) Displacement
	#[getter]
	pub fn displacement(&self) -> u64 {
		self.info.displacement()
	}

	/// int: (``i64``) Displacement
	#[getter]
	pub fn displacement_i64(&self) -> i64 {
		self.info.displacement() as i64
	}

	/// :class:`MemorySize`: Size of location (enum value)
	#[getter]
	pub fn memory_size(&self) -> u32 {
		self.info.memory_size() as u32
	}

	/// :class:`OpAccess`: Memory access
	#[getter]
	pub fn access(&self) -> u32 {
		self.info.access() as u32
	}

	/// :class:`CodeSize`: Address size
	#[getter]
	pub fn address_size(&self) -> u32 {
		self.info.address_size() as u32
	}

	/// int: VSIB size (`0`, `4` or `8`)
	#[getter]
	pub fn vsib_size(&self) -> u32 {
		self.info.vsib_size()
	}

	/// Returns a copy of this instance.
	///
	/// Returns:
	///     UsedMemory: A copy of this instance
	///
	/// This is identical to :class:`UsedMemory.clone`
	#[text_signature = "($self, /)"]
	fn __copy__(&self) -> Self {
		*self
	}

	/// Returns a copy of this instance.
	///
	/// Returns:
	///     UsedMemory: A copy of this instance
	///
	/// This is identical to :class:`UsedMemory.clone`
	#[text_signature = "($self, memo, /)"]
	fn __deepcopy__(&self, _memo: &PyAny) -> Self {
		*self
	}

	/// Returns a copy of this instance.
	///
	/// Returns:
	///     UsedMemory: A copy of this instance
	#[text_signature = "($self, /)"]
	fn clone(&self) -> Self {
		*self
	}
}

#[pyproto]
impl PyObjectProtocol for UsedMemory {
	fn __richcmp__(&self, other: PyRef<UsedMemory>, op: CompareOp) -> PyObject {
		match op {
			CompareOp::Eq => (self.info == other.info).into_py(other.py()),
			CompareOp::Ne => (self.info != other.info).into_py(other.py()),
			_ => other.py().NotImplemented(),
		}
	}

	fn __hash__(&self) -> u64 {
		let mut hasher = DefaultHasher::new();
		self.info.hash(&mut hasher);
		hasher.finish()
	}
}

/// Contains accessed registers and memory locations
#[pyclass(module = "_iced_x86_py")]
pub(crate) struct InstructionInfo {
	info: iced_x86::InstructionInfo,
}

#[pymethods]
impl InstructionInfo {
	/// Gets all accessed registers.
	///
	/// This method doesn't return all accessed registers if :class:`Instruction.is_save_restore_instruction` is ``True``.
	///
	/// Some instructions have a ``r16``/``r32`` operand but only use the low 8 bits of the register. In that case
	/// this method returns the 8-bit register even if it's ``SPL``, ``BPL``, ``SIL``, ``DIL`` and the
	/// instruction was decoded in 16 or 32-bit mode. This is more accurate than returning the ``r16``/``r32``
	/// register. Example instructions that do this: ``PINSRB``, ``ARPL``
	#[text_signature = "($self, /)"]
	pub fn used_registers(&self) -> Vec<UsedRegister> {
		self.info.used_registers().iter().map(|a| UsedRegister { info: *a }).collect()
	}

	/// Gets all accessed memory locations
	#[text_signature = "($self, /)"]
	pub fn used_memory(&self) -> Vec<UsedMemory> {
		self.info.used_memory().iter().map(|a| UsedMemory { info: *a }).collect()
	}

	/// :class:`OpAccess`: Operand #0 access
	#[getter]
	pub fn op0_access(&self) -> u32 {
		self.info.op0_access() as u32
	}

	/// :class:`OpAccess`: Operand #1 access
	#[getter]
	pub fn op1_access(&self) -> u32 {
		self.info.op1_access() as u32
	}

	/// :class:`OpAccess`: Operand #2 access
	#[getter]
	pub fn op2_access(&self) -> u32 {
		self.info.op2_access() as u32
	}

	/// :class:`OpAccess`: Operand #3 access
	#[getter]
	pub fn op3_access(&self) -> u32 {
		self.info.op3_access() as u32
	}

	/// :class:`OpAccess`: Operand #4 access
	#[getter]
	pub fn op4_access(&self) -> u32 {
		self.info.op4_access() as u32
	}

	/// Gets operand access
	///
	/// Args:
	///     `operand` (int): Operand number, 0-4
	///
	/// Returns:
	///     :class:`OpAccess`: Operand access
	///
	/// Raises:
	///     ValueError: If `operand` is invalid
	#[text_signature = "($self, operand, /)"]
	pub fn op_access(&self, operand: u32) -> PyResult<u32> {
		if operand >= IcedConstants::MAX_OP_COUNT as u32 {
			Err(PyValueError::new_err("Invalid operand"))
		} else {
			Ok(self.info.op_access(operand) as u32)
		}
	}
}

/// Returns used registers and memory locations
///
/// Examples:
///
/// .. testcode::
///
///     from iced_x86 import *
///
///     # add [rdi+r12*8-5AA5EDCCh],esi
///     data = b"\x42\x01\xB4\xE7\x34\x12\x5A\xA5"
///     decoder = Decoder(64, data)
///
///     info_factory = InstructionInfoFactory()
///     for instr in decoder:
///         print(f"Instruction: {instr}")
///
///         info = info_factory.info(instr)
///
///         for mem_info in info.used_memory():
///             # Register and OpAccess enum values
///             print(f"Used memory:")
///             print(f"  seg: {mem_info.segment} (Register enum)")
///             print(f"  base: {mem_info.base} (Register enum)")
///             print(f"  index: {mem_info.index} (Register enum)")
///             print(f"  scale: {mem_info.scale}")
///             print(f"  displacement: 0x{mem_info.displacement:X}")
///             print(f"  MemorySize enum: {mem_info.memory_size}")
///             print(f"  OpAccess enum: {mem_info.access}")
///
///         for reg_info in info.used_registers():
///             print(f"Used register: reg={reg_info.register} (Register enum) access={reg_info.access} (OpAccess enum)")
///
/// Output:
///
/// .. testoutput::
///
///     Instruction: add [rdi+r12*8-5AA5EDCCh],esi
///     Used memory:
///       seg: 74 (Register enum)
///       base: 60 (Register enum)
///       index: 65 (Register enum)
///       scale: 8
///       displacement: 0xFFFFFFFFA55A1234
///       MemorySize enum: 3
///       OpAccess enum: 5
///     Used register: reg=60 (Register enum) access=1 (OpAccess enum)
///     Used register: reg=65 (Register enum) access=1 (OpAccess enum)
///     Used register: reg=43 (Register enum) access=1 (OpAccess enum)
#[pyclass(module = "_iced_x86_py")]
#[text_signature = "(/)"]
pub(crate) struct InstructionInfoFactory {
	info: iced_x86::InstructionInfoFactory,
}

#[pymethods]
impl InstructionInfoFactory {
	#[new]
	fn new() -> Self {
		Self { info: iced_x86::InstructionInfoFactory::new() }
	}

	/// Gets all accessed registers and memory locations
	///
	/// Args:
	///     `instruction` (Instruction): The instruction that should be analyzed
	///
	/// Returns:
	///     InstructionInfo: Accessed registers and memory locations
	///
	/// Examples:
	///
	/// .. testcode::
	///
	///     from iced_x86 import *
	///
	///     # add [rdi+r12*8-5AA5EDCCh],esi
	///     data = b"\x42\x01\xB4\xE7\x34\x12\x5A\xA5"
	///     decoder = Decoder(64, data)
	///     info_factory = InstructionInfoFactory()
	///
	///     instr = decoder.decode()
	///     info = info_factory.info(instr)
	///
	///     mem_list = info.used_memory()
	///     assert len(mem_list) == 1
	///     mem = mem_list[0]
	///     assert mem.segment == Register.DS
	///     assert mem.base == Register.RDI
	///     assert mem.index == Register.R12
	///     assert mem.scale == 8
	///     assert mem.displacement == 0xFFFFFFFFA55A1234
	///     assert mem.memory_size == MemorySize.UINT32
	///     assert mem.access == OpAccess.READ_WRITE
	///
	///     regs = info.used_registers()
	///     assert len(regs) == 3
	///     assert regs[0].register == Register.RDI
	///     assert regs[0].access == OpAccess.READ
	///     assert regs[1].register == Register.R12
	///     assert regs[1].access == OpAccess.READ
	///     assert regs[2].register == Register.ESI
	///     assert regs[2].access == OpAccess.READ
	#[text_signature = "($self, instruction, /)"]
	pub fn info(&mut self, instruction: &Instruction) -> InstructionInfo {
		InstructionInfo { info: self.info.info(&instruction.instr).clone() }
	}
}
