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

#if !NO_DECODER
using Generator.Enums;

namespace Generator.Decoder {
	static class OpCodeHandlersTables_XOP {
		public const string XOP8 = nameof(XOP8);
		public const string XOP9 = nameof(XOP9);
		public const string XOPA = nameof(XOPA);

		public static object[] GetHandlers() {
			var vexEnum = VexOpCodeHandlerKindEnum.Instance;
			var codeEnum = CodeEnum.Instance;
			var registerEnum = RegisterEnum.Instance;

			var invalid = new object[] { vexEnum["Invalid"] };
			var handlers = new object[] {
				"grp_XOP9_01",
				new object[8] {
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_Blcfill_r32_rm32"], codeEnum["XOP_Blcfill_r64_rm64"] },
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_Blsfill_r32_rm32"], codeEnum["XOP_Blsfill_r64_rm64"] },
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_Blcs_r32_rm32"], codeEnum["XOP_Blcs_r64_rm64"] },
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_Tzmsk_r32_rm32"], codeEnum["XOP_Tzmsk_r64_rm64"] },
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_Blcic_r32_rm32"], codeEnum["XOP_Blcic_r64_rm64"] },
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_Blsic_r32_rm32"], codeEnum["XOP_Blsic_r64_rm64"] },
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_T1mskc_r32_rm32"], codeEnum["XOP_T1mskc_r64_rm64"] },
							invalid,
						}
					},
				},

				"grp_XOP9_02",
				new object[8] {
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_Blcmsk_r32_rm32"], codeEnum["XOP_Blcmsk_r64_rm64"] },
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ev"], codeEnum["XOP_Blci_r32_rm32"], codeEnum["XOP_Blci_r64_rm64"] },
							invalid,
						}
					},
					invalid,
				},

				"grp_XOP9_12",
				new object[8] {
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["RdRq"], codeEnum["XOP_Llwpcb_r32"], codeEnum["XOP_Llwpcb_r64"] },
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["RdRq"], codeEnum["XOP_Slwpcb_r32"], codeEnum["XOP_Slwpcb_r64"] },
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
				},

				"grp_XOPA_12",
				new object[8] {
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ed_Id"], codeEnum["XOP_Lwpins_r32_rm32_imm32"], codeEnum["XOP_Lwpins_r64_rm32_imm32"] },
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Hv_Ed_Id"], codeEnum["XOP_Lwpval_r32_rm32_imm32"], codeEnum["XOP_Lwpval_r64_rm32_imm32"] },
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
				},

				XOP8,
				new object[0x100] {
					// 00
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 08
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 10
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 18
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 20
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 28
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 30
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 38
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 40
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 48
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 50
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 58
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 60
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 68
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 70
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 78
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 80
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacssww_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacsswd_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacssdql_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},

					// 88
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacssdd_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacssdqh_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},

					// 90
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacsww_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacswd_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacsdql_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},

					// 98
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacsdd_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmacsdqh_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},

					// A0
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["W"],
							new object[] { vexEnum["VectorLength"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpcmov_xmm_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHWIs4"], registerEnum["YMM0"], codeEnum["XOP_Vpcmov_ymm_ymm_ymmm256_ymm"] },
							},
							new object[] { vexEnum["VectorLength"],
								new object[] { vexEnum["VHIs4W"], registerEnum["XMM0"], codeEnum["XOP_Vpcmov_xmm_xmm_xmm_xmmm128"] },
								new object[] { vexEnum["VHIs4W"], registerEnum["YMM0"], codeEnum["XOP_Vpcmov_ymm_ymm_ymm_ymmm256"] },
							}
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["W"],
							new object[] { vexEnum["VectorLength"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpperm_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							new object[] { vexEnum["VectorLength"],
								new object[] { vexEnum["VHIs4W"], registerEnum["XMM0"], codeEnum["XOP_Vpperm_xmm_xmm_xmm_xmmm128"] },
								invalid,
							}
						}
					},
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmadcsswd_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,

					// A8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// B0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIs4"], registerEnum["XMM0"], codeEnum["XOP_Vpmadcswd_xmm_xmm_xmmm128_xmm"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,

					// B8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// C0
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vprotb_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vprotw_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vprotd_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vprotq_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,

					// C8
					invalid,
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vpcomb_xmm_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vpcomw_xmm_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vpcomd_xmm_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vpcomq_xmm_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},

					// D0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// D8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// E0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// E8
					invalid,
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vpcomub_xmm_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vpcomuw_xmm_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vpcomud_xmm_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VHWIb_2"], registerEnum["XMM0"], codeEnum["XOP_Vpcomuq_xmm_xmm_xmmm128_imm8"] },
								invalid,
							},
							invalid,
						}
					},

					// F0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// F8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
				},

				XOP9,
				new object[0x100] {
					// 00
					invalid,
					new object[] { vexEnum["Group"], "grp_XOP9_01" },
					new object[] { vexEnum["Group"], "grp_XOP9_02" },
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 08
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 10
					invalid,
					invalid,
					new object[] { vexEnum["Group"], "grp_XOP9_12" },
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 18
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 20
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 28
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 30
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 38
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 40
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 48
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 50
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 58
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 60
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 68
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 70
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 78
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 80
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vfrczps_xmm_xmmm128"] },
								invalid,
							},
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["YMM0"], codeEnum["XOP_Vfrczps_ymm_ymmm256"] },
								invalid,
							}
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vfrczpd_xmm_xmmm128"] },
								invalid,
							},
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["YMM0"], codeEnum["XOP_Vfrczpd_ymm_ymmm256"] },
								invalid,
							}
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vfrczss_xmm_xmmm32"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vfrczsd_xmm_xmmm64"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,

					// 88
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 90
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vprotb_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vprotb_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vprotw_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vprotw_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vprotd_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vprotd_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vprotq_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vprotq_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vpshlb_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vpshlb_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vpshlw_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vpshlw_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vpshld_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vpshld_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vpshlq_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vpshlq_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},

					// 98
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vpshab_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vpshab_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vpshaw_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vpshaw_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vpshad_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vpshad_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VWH"], registerEnum["XMM0"], codeEnum["XOP_Vpshaq_xmm_xmmm128_xmm"] },
								new object[] { vexEnum["VHW_2"], registerEnum["XMM0"], codeEnum["XOP_Vpshaq_xmm_xmm_xmmm128"] },
							},
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,

					// A0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// A8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// B0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// B8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// C0
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddbw_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddbd_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddbq_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddwd_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddwq_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},

					// C8
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphadddq_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,

					// D0
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddubw_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddubd_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddubq_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphadduwd_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphadduwq_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},

					// D8
					invalid,
					invalid,
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphaddudq_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,

					// E0
					invalid,
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphsubbw_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphsubwd_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["W"],
								new object[] { vexEnum["VW_2"], registerEnum["XMM0"], codeEnum["XOP_Vphsubdq_xmm_xmmm128"] },
								invalid,
							},
							invalid,
						}
					},
					invalid,
					invalid,
					invalid,
					invalid,

					// E8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// F0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// F8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
				},

				XOPA,
				new object[0x100] {
					// 00
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 08
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 10
					new object[] { vexEnum["MandatoryPrefix2_1"],
						new object[] { vexEnum["VectorLength"],
							new object[] { vexEnum["Gv_Ev_Id"], codeEnum["XOP_Bextr_r32_rm32_imm32"], codeEnum["XOP_Bextr_r64_rm64_imm32"] },
							invalid,
						}
					},
					invalid,
					new object[] { vexEnum["Group"], "grp_XOPA_12" },
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 18
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 20
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 28
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 30
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 38
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 40
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 48
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 50
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 58
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 60
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 68
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 70
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 78
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 80
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 88
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 90
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// 98
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// A0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// A8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// B0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// B8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// C0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// C8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// D0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// D8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// E0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// E8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// F0
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,

					// F8
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
					invalid,
				},
			};
			return handlers;
		}
	}
}
#endif
