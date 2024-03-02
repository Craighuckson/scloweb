using System;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace U2Drawx64
{
	// Token: 0x02000028 RID: 40
	[StandardModule]
	internal sealed class modGV
	{
		// Token: 0x040001E6 RID: 486
		public static bool LoginSucceeded;

		// Token: 0x040001E7 RID: 487
		public static int UserID;

		// Token: 0x040001E8 RID: 488
		public static string UserCategoryID;

		// Token: 0x040001E9 RID: 489
		public static string UserName;

		// Token: 0x040001EA RID: 490
		public static short VehicleNum;

		// Token: 0x040001EB RID: 491
		public static short UnassignedUserID = 0;

		// Token: 0x040001EC RID: 492
		public static Color EmergColour = Color.Yellow;

		// Token: 0x040001ED RID: 493
		public static Color LateColour = Color.Red;

		// Token: 0x040001EE RID: 494
		public static Color DoneColour = Color.RoyalBlue;

		// Token: 0x040001EF RID: 495
		public static Color PriorityCallColour = Color.Orange;

		// Token: 0x040001F0 RID: 496
		public static Color MeetReqColour = Color.Green;

		// Token: 0x040001F1 RID: 497
		public static Color ReadyForDispatchingColour = Color.LightSeaGreen;

		// Token: 0x040001F2 RID: 498
		public static Color CancelledColour = Color.DeepPink;

		// Token: 0x040001F3 RID: 499
		public static Color AssistanceNeededColour = Color.DarkMagenta;

		// Token: 0x040001F4 RID: 500
		public static Color ArchivedColour = Color.Gold;

		// Token: 0x040001F5 RID: 501
		public static Color PrintedColour = Color.YellowGreen;

		// Token: 0x040001F6 RID: 502
		public static int maxAllowedUserID = 30000;

		// Token: 0x02000029 RID: 41
		public enum DownloadStatus
		{
			// Token: 0x040001F8 RID: 504
			VerifyDatabase,
			// Token: 0x040001F9 RID: 505
			RefreshAdminTables,
			// Token: 0x040001FA RID: 506
			DownloadAssigments,
			// Token: 0x040001FB RID: 507
			DownloadPrimarySheets,
			// Token: 0x040001FC RID: 508
			DownloadAuxiliaryDetails,
			// Token: 0x040001FD RID: 509
			DownloadBilling,
			// Token: 0x040001FE RID: 510
			DownloadDocuments,
			// Token: 0x040001FF RID: 511
			UpdateTicketStatus,
			// Token: 0x04000200 RID: 512
			DownloadComplete,
			// Token: 0x04000201 RID: 513
			SpecialMesg
		}

		// Token: 0x0200002A RID: 42
		public enum DrawingType
		{
			// Token: 0x04000203 RID: 515
			ELCONPrimary = 1,
			// Token: 0x04000204 RID: 516
			ELCONSecondary,
			// Token: 0x04000205 RID: 517
			ELCONBaseMap,
			// Token: 0x04000206 RID: 518
			OakvillePrimary,
			// Token: 0x04000207 RID: 519
			OakvilleSecondary
		}

		// Token: 0x0200002B RID: 43
		public enum UtilityType
		{
			// Token: 0x04000209 RID: 521
			Gas = 1,
			// Token: 0x0400020A RID: 522
			Bell,
			// Token: 0x0400020B RID: 523
			Fibre,
			// Token: 0x0400020C RID: 524
			Catv,
			// Token: 0x0400020D RID: 525
			Water,
			// Token: 0x0400020E RID: 526
			hydro
		}

		// Token: 0x0200002C RID: 44
		public enum RequestTypes
		{
			// Token: 0x04000210 RID: 528
			CONTRACTOR = 1,
			// Token: 0x04000211 RID: 529
			HOMEOWNER,
			// Token: 0x04000212 RID: 530
			MUNICIPALITY,
			// Token: 0x04000213 RID: 531
			OTHER,
			// Token: 0x04000214 RID: 532
			UTILITY,
			// Token: 0x04000215 RID: 533
			UNKNOWN
		}

		// Token: 0x0200002D RID: 45
		public enum AssignmentTypes
		{
			// Token: 0x04000217 RID: 535
			OntarioOneCall = 1,
			// Token: 0x04000218 RID: 536
			PrivateLocate
		}

		// Token: 0x0200002E RID: 46
		public enum BillingCategories
		{
			// Token: 0x0400021A RID: 538
			NotApplicable,
			// Token: 0x0400021B RID: 539
			M,
			// Token: 0x0400021C RID: 540
			S,
			// Token: 0x0400021D RID: 541
			FC,
			// Token: 0x0400021E RID: 542
			OC,
			// Token: 0x0400021F RID: 543
			V,
			// Token: 0x04000220 RID: 544
			CB,
			// Token: 0x04000221 RID: 545
			PreviouslyCharged = 12,
			// Token: 0x04000222 RID: 546
			P,
			// Token: 0x04000223 RID: 547
			MARKED,
			// Token: 0x04000224 RID: 548
			STREET,
			// Token: 0x04000225 RID: 549
			CLEARED,
			// Token: 0x04000226 RID: 550
			PRIVATELOCATE = 16
		}

		// Token: 0x0200002F RID: 47
		public enum PrimaryDetailType
		{
			// Token: 0x04000228 RID: 552
			Low = 1,
			// Token: 0x04000229 RID: 553
			Intermediate,
			// Token: 0x0400022A RID: 554
			High,
			// Token: 0x0400022B RID: 555
			ExtraHigh,
			// Token: 0x0400022C RID: 556
			MainDiameter,
			// Token: 0x0400022D RID: 557
			CastIron,
			// Token: 0x0400022E RID: 558
			Steel,
			// Token: 0x0400022F RID: 559
			Plastic,
			// Token: 0x04000230 RID: 560
			EndThrust,
			// Token: 0x04000231 RID: 561
			Valve,
			// Token: 0x04000232 RID: 562
			VitalMain,
			// Token: 0x04000233 RID: 563
			Cable,
			// Token: 0x04000234 RID: 564
			Conduit,
			// Token: 0x04000235 RID: 565
			TVFibre,
			// Token: 0x04000236 RID: 566
			TelephoneFiber,
			// Token: 0x04000237 RID: 567
			HighPriorityCable,
			// Token: 0x04000238 RID: 568
			CentralOfficeVicinity,
			// Token: 0x04000239 RID: 569
			Primary,
			// Token: 0x0400023A RID: 570
			DirectBuried,
			// Token: 0x0400023B RID: 571
			Secondary,
			// Token: 0x0400023C RID: 572
			Duct,
			// Token: 0x0400023D RID: 573
			Streetlighting,
			// Token: 0x0400023E RID: 574
			LocateNonMetallicPipe,
			// Token: 0x0400023F RID: 575
			NEBExcavation,
			// Token: 0x04000240 RID: 576
			GasExcavation,
			// Token: 0x04000241 RID: 577
			SupportSpecificiations,
			// Token: 0x04000242 RID: 578
			HydroElectricExcavation,
			// Token: 0x04000243 RID: 579
			PileDriving,
			// Token: 0x04000244 RID: 580
			Blasting,
			// Token: 0x04000245 RID: 581
			Map,
			// Token: 0x04000246 RID: 582
			NetworkX,
			// Token: 0x04000247 RID: 583
			AltasPlate,
			// Token: 0x04000248 RID: 584
			FieldNote,
			// Token: 0x04000249 RID: 585
			Paint,
			// Token: 0x0400024A RID: 586
			Stakes,
			// Token: 0x0400024B RID: 587
			Flags,
			// Token: 0x0400024C RID: 588
			Offset,
			// Token: 0x0400024D RID: 589
			Chalk,
			// Token: 0x0400024E RID: 590
			Other,
			// Token: 0x0400024F RID: 591
			BellGuidelines,
			// Token: 0x04000250 RID: 592
			None,
			// Token: 0x04000251 RID: 593
			Byers
		}

		// Token: 0x02000030 RID: 48
		public enum Utilities
		{
			// Token: 0x04000253 RID: 595
			EnbridgeGas = 1,
			// Token: 0x04000254 RID: 596
			StCatharinesHydroElectricCommission,
			// Token: 0x04000255 RID: 597
			StCatharinesCityWatersDepartment,
			// Token: 0x04000256 RID: 598
			BellCanada,
			// Token: 0x04000257 RID: 599
			Cogeco,
			// Token: 0x04000258 RID: 600
			PelhamWater = 8,
			// Token: 0x04000259 RID: 601
			NiagaraFallsHydro,
			// Token: 0x0400025A RID: 602
			EnbridgePipeline,
			// Token: 0x0400025B RID: 603
			UnionGas,
			// Token: 0x0400025C RID: 604
			MiltonHydro,
			// Token: 0x0400025D RID: 605
			HydroNOTL,
			// Token: 0x0400025E RID: 606
			UGBell,
			// Token: 0x0400025F RID: 607
			HamiltonHydro,
			// Token: 0x04000260 RID: 608
			MountainCable,
			// Token: 0x04000261 RID: 609
			NRBN,
			// Token: 0x04000262 RID: 610
			BURLINGTONHYDRO,
			// Token: 0x04000263 RID: 611
			NiagaraWasteWaterManagement,
			// Token: 0x04000264 RID: 612
			BellAliant,
			// Token: 0x04000265 RID: 613
			BlinkCommunications
		}

		// Token: 0x02000031 RID: 49
		public enum LocateStatusType
		{
			// Token: 0x04000267 RID: 615
			NotAssigned = -1,
			// Token: 0x04000268 RID: 616
			NoShow = 12,
			// Token: 0x04000269 RID: 617
			NotStarted = 14,
			// Token: 0x0400026A RID: 618
			ReadyForDispatching,
			// Token: 0x0400026B RID: 619
			DispatchedToLeadHand,
			// Token: 0x0400026C RID: 620
			DispatchedToLocator,
			// Token: 0x0400026D RID: 621
			DigCompleted,
			// Token: 0x0400026E RID: 622
			ProjectFinished,
			// Token: 0x0400026F RID: 623
			LocateCompleted,
			// Token: 0x04000270 RID: 624
			OnHold,
			// Token: 0x04000271 RID: 625
			InTheField,
			// Token: 0x04000272 RID: 626
			ProjectOnGoing,
			// Token: 0x04000273 RID: 627
			LocateOnGoing,
			// Token: 0x04000274 RID: 628
			OfficeCancelled,
			// Token: 0x04000275 RID: 629
			AssistanceNeeded,
			// Token: 0x04000276 RID: 630
			Archived
		}

		// Token: 0x02000032 RID: 50
		public enum UserCategoryType
		{
			// Token: 0x04000278 RID: 632
			NoOne,
			// Token: 0x04000279 RID: 633
			Locator,
			// Token: 0x0400027A RID: 634
			LeadHand,
			// Token: 0x0400027B RID: 635
			OfficeDispatch,
			// Token: 0x0400027C RID: 636
			Manager,
			// Token: 0x0400027D RID: 637
			SysAdmin,
			// Token: 0x0400027E RID: 638
			Billing = 7
		}

		// Token: 0x02000033 RID: 51
		public enum SupplementalDocType
		{
			// Token: 0x04000280 RID: 640
			OOC = 1,
			// Token: 0x04000281 RID: 641
			Added,
			// Token: 0x04000282 RID: 642
			AutoGenerated,
			// Token: 0x04000283 RID: 643
			Uploaded
		}

		// Token: 0x02000034 RID: 52
		public enum ExcavatorStatusCopyStatus
		{
			// Token: 0x04000285 RID: 645
			MarkAndFax = 1,
			// Token: 0x04000286 RID: 646
			LeftOnSite,
			// Token: 0x04000287 RID: 647
			Other
		}

		// Token: 0x02000035 RID: 53
		public enum CallType
		{
			// Token: 0x04000289 RID: 649
			Emergency = 1,
			// Token: 0x0400028A RID: 650
			Planning = 10,
			// Token: 0x0400028B RID: 651
			Priority0 = 2,
			// Token: 0x0400028C RID: 652
			Priority1,
			// Token: 0x0400028D RID: 653
			Priority2,
			// Token: 0x0400028E RID: 654
			Priority3,
			// Token: 0x0400028F RID: 655
			Priority4,
			// Token: 0x04000290 RID: 656
			PrivateCall = 9,
			// Token: 0x04000291 RID: 657
			ProjectWork = 8,
			// Token: 0x04000292 RID: 658
			Standard = 7,
			// Token: 0x04000293 RID: 659
			DamageReport = 11,
			// Token: 0x04000294 RID: 660
			SewerLateral,
			// Token: 0x04000295 RID: 661
			OakvilleHydro
		}

		// Token: 0x02000036 RID: 54
		public enum LocateType
		{
			// Token: 0x04000297 RID: 663
			NORMAL = 12,
			// Token: 0x04000298 RID: 664
			RELOCATE,
			// Token: 0x04000299 RID: 665
			UPDATE,
			// Token: 0x0400029A RID: 666
			CANCELLED,
			// Token: 0x0400029B RID: 667
			CORRECTION,
			// Token: 0x0400029C RID: 668
			REMARK
		}

		// Token: 0x02000037 RID: 55
		public enum AutologDesc
		{
			// Token: 0x0400029E RID: 670
			ExcavationDateChange = 1,
			// Token: 0x0400029F RID: 671
			AddNewUtility,
			// Token: 0x040002A0 RID: 672
			AppointmentCancelled,
			// Token: 0x040002A1 RID: 673
			AddedDoc,
			// Token: 0x040002A2 RID: 674
			RemovedDoc,
			// Token: 0x040002A3 RID: 675
			ReassignedLocate,
			// Token: 0x040002A4 RID: 676
			LocateStatusToNoShow,
			// Token: 0x040002A5 RID: 677
			MarkedReadyForDispatching,
			// Token: 0x040002A6 RID: 678
			ChangedLocateStatus,
			// Token: 0x040002A7 RID: 679
			TransTypeChange,
			// Token: 0x040002A8 RID: 680
			ChangedCallType,
			// Token: 0x040002A9 RID: 681
			MarkAssistenceRequired,
			// Token: 0x040002AA RID: 682
			LocateFinished,
			// Token: 0x040002AB RID: 683
			LocateOngoing,
			// Token: 0x040002AC RID: 684
			PrimaryDeleted,
			// Token: 0x040002AD RID: 685
			OverrodeCompletionVerfication,
			// Token: 0x040002AE RID: 686
			AppointmentUpdated,
			// Token: 0x040002AF RID: 687
			VerificationOverride,
			// Token: 0x040002B0 RID: 688
			LocateExamined,
			// Token: 0x040002B1 RID: 689
			MarkedAsCompleted,
			// Token: 0x040002B2 RID: 690
			LocateDownloaded,
			// Token: 0x040002B3 RID: 691
			LocateUploaded,
			// Token: 0x040002B4 RID: 692
			LocatePrinted,
			// Token: 0x040002B5 RID: 693
			AutoFaxCompleted,
			// Token: 0x040002B6 RID: 694
			AutoFaxFailed,
			// Token: 0x040002B7 RID: 695
			AutoFaxFailedNoPDFs,
			// Token: 0x040002B8 RID: 696
			ManuallyFaxed,
			// Token: 0x040002B9 RID: 697
			FaxAbandonedbyUser,
			// Token: 0x040002BA RID: 698
			AutoEmailCompleted,
			// Token: 0x040002BB RID: 699
			AutoEmailFailed,
			// Token: 0x040002BC RID: 700
			AutoEmailFailedNoPDFs,
			// Token: 0x040002BD RID: 701
			ManuallyEmailed,
			// Token: 0x040002BE RID: 702
			EmailAbandonedbyUser,
			// Token: 0x040002BF RID: 703
			EmailedFromU2byUser,
			// Token: 0x040002C0 RID: 704
			FaxedFromU2byUser,
			// Token: 0x040002C1 RID: 705
			UploadedHazard,
			// Token: 0x040002C2 RID: 706
			HazardEmailed,
			// Token: 0x040002C3 RID: 707
			HazardEmailFailed
		}

		// Token: 0x02000038 RID: 56
		public class cbItem
		{
			// Token: 0x06000446 RID: 1094 RVA: 0x000ABD68 File Offset: 0x000AAD68
			[DebuggerNonUserCode]
			public cbItem()
			{
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x000ABD70 File Offset: 0x000AAD70
			public override string ToString()
			{
				return this.name;
			}

			// Token: 0x040002C4 RID: 708
			public string ID;

			// Token: 0x040002C5 RID: 709
			public string name;
		}
	}
}
